using Dapper;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Reflection;

namespace Flow.Launcher.Plugin.Engineering.XNoteFinder
{
    internal class MySQLHelper
    {
        private static string connectionString = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location).AppSettings.Settings["MySQLConnection"].Value;

        public static IEnumerable<Record> RetrieveAllRecords()
        {
            using MySqlConnection conn = new MySqlConnection(connectionString);
            IEnumerable<Record> records = conn.Query<Record>("SELECT Id, Content, Code, Clause, Catalog, ImageFlag FROM xnote");
            conn.Close();

            return records;
        }

        public static byte[] ViewImage(int id)
        {
            byte[] buffer;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string sql = $"SELECT image FROM xnote WHERE id={id}";
                buffer = conn.QueryFirst<byte[]>(sql);
                conn.Close();
            }

            return buffer;
        }
    }
}
