using Oracle.DataAccess.Client;

namespace MonitorCS.Utils
{
    class UOracle
    {
        public static OracleConnection GetConnection(string host, string port, string sid, string user, string password)
        {
            string connectionString = $"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={host})(PORT={port}))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={sid})));User ID={user};Password={password}";

            OracleConnection dbConnect = new OracleConnection
            {
                ConnectionString = connectionString
            };

            return dbConnect;
        }
    }
}