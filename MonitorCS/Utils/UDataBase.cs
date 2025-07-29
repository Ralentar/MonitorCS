using Oracle.DataAccess.Client;

namespace MonitorCS.Utils
{
    class UDataBase
    {
        public static OracleConnection Connect(UConfigDatabase configDatabase)
        {
            string host = configDatabase.GetHost();
            string port = configDatabase.GetPort();
            string sid = configDatabase.GetSid();
            string user = configDatabase.GetUser();
            string password = configDatabase.GetPassword();

            return UOracle.GetConnection(host, port, sid, user, password);
        }
    }
}