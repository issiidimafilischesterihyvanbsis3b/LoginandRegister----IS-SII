using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace LoginRegisterApp
{
    public class UserInfo
    {
        public string FullName;
        public string UserName;
        public string Email;
    }

    public static class Database
    {
        // Stored in a local folder (NOT OneDrive):  %LocalAppData%\LoginRegisterApp
        private static readonly string DbFolder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LoginRegisterApp");

        public static string DbPath { get; private set; }
        private static string _connStr;
        private static string ConnStr { get { return _connStr; } }

        public static void Init()
        {
            Directory.CreateDirectory(DbFolder);

            // Try each database engine until one works.
            var engines = new List<string[]>
            {
                new[] { "Microsoft.ACE.OLEDB.16.0", ".accdb" },
                new[] { "Microsoft.ACE.OLEDB.12.0", ".accdb" }
            };
            if (!Environment.Is64BitProcess)   // Jet only exists as 32-bit, built into Windows
                engines.Add(new[] { "Microsoft.Jet.OLEDB.4.0", ".mdb" });

            var errors = new StringBuilder();

            foreach (string[] eng in engines)
            {
                string path = Path.Combine(DbFolder, "UsersDB" + eng[1]);
                string cs = "Provider=" + eng[0] + ";Data Source=" + path + ";";
                bool created = false;
                try
                {
                    if (!File.Exists(path))
                    {
                        object cat = Activator.CreateInstance(Type.GetTypeFromProgID("ADOX.Catalog"));
                        try
                        {
                            ((dynamic)cat).Create(cs);
                            created = true;
                        }
                        finally
                        {
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(cat);
                        }
                    }

                    File.SetAttributes(path, FileAttributes.Normal);   // never read-only

                    using (var con = new OleDbConnection(cs))
                    {
                        con.Open();
                        EnsureTable(con);
                    }

                    _connStr = cs;
                    DbPath = path;
                    return;
                }
                catch (Exception ex)
                {
                    errors.AppendLine("- " + eng[0] + ": " + ex.Message);
                    if (created)
                    {
                        try { File.Delete(path); } catch { }
                    }
                }
            }

            throw new Exception(
                "No Access database engine worked (" + (Environment.Is64BitProcess ? "64-bit" : "32-bit") + " app).\n\n" +
                errors + "\nFolder: " + DbFolder);
        }

        private static void EnsureTable(OleDbConnection con)
        {
            try
            {
                using (var cmd = new OleDbCommand("SELECT TOP 1 ID FROM Users", con))
                    cmd.ExecuteScalar();
            }
            catch (OleDbException)
            {
                string sql = "CREATE TABLE Users (" +
                             "ID COUNTER PRIMARY KEY, " +
                             "FullName VARCHAR(100), " +
                             "UserName VARCHAR(50), " +
                             "Email VARCHAR(100), " +
                             "PasswordHash VARCHAR(64), " +
                             "CreatedAt DATETIME)";
                using (var cmd = new OleDbCommand(sql, con)) cmd.ExecuteNonQuery();
            }
        }

        public static string Hash(string text)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(text));
                var sb = new StringBuilder();
                foreach (byte b in bytes) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        public static bool UserExists(string userName)
        {
            using (var con = new OleDbConnection(ConnStr))
            using (var cmd = new OleDbCommand("SELECT COUNT(*) FROM Users WHERE UserName = ?", con))
            {
                cmd.Parameters.AddWithValue("?", userName);
                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public static void Register(string fullName, string userName, string email, string password)
        {
            using (var con = new OleDbConnection(ConnStr))
            using (var cmd = new OleDbCommand(
                "INSERT INTO Users (FullName, UserName, Email, PasswordHash, CreatedAt) VALUES (?, ?, ?, ?, ?)", con))
            {
                cmd.Parameters.AddWithValue("?", fullName);
                cmd.Parameters.AddWithValue("?", userName);
                cmd.Parameters.AddWithValue("?", email);
                cmd.Parameters.AddWithValue("?", Hash(password));
                cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static UserInfo Login(string userName, string password)
        {
            using (var con = new OleDbConnection(ConnStr))
            using (var cmd = new OleDbCommand(
                "SELECT FullName, UserName, Email FROM Users WHERE UserName = ? AND PasswordHash = ?", con))
            {
                cmd.Parameters.AddWithValue("?", userName);
                cmd.Parameters.AddWithValue("?", Hash(password));
                con.Open();
                using (var r = cmd.ExecuteReader())
                {
                    if (!r.Read()) return null;
                    return new UserInfo
                    {
                        FullName = r["FullName"].ToString(),
                        UserName = r["UserName"].ToString(),
                        Email = r["Email"].ToString()
                    };
                }
            }
        }
    }
}
