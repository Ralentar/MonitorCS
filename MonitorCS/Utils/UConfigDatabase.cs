using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MonitorCS.Utils
{
    class UConfigDatabase
    {
        private Dictionary<string, string> _properties;
        private string _host;
        private string _port;
        private string _sid;
        private string _user;
        private string _password;

        public UConfigDatabase()
        {
            _properties = new Dictionary<string, string>();
        }

        public bool TryReadConfig(string configPath)
        {
            try
            {
                string[] lines = File.ReadAllLines(configPath);

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line) || !line.Contains(":"))
                        continue;

                    string[] parts = line.Split(new char[] { ':' }, 2);

                    if (parts.Length != 2)
                        continue;

                    string key = parts[0].Trim();
                    string value = parts[1].Trim();
                    _properties.Add(key, value);
                }

                return true;
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Ошибка при чтении файла конфигурации {configPath} : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public bool IsExistConfig()
        {
            string labelHost = "host";
            string labelPort = "port";
            string labelSid = "sid";
            string labelUser = "user";
            string labelPassword = "password";

            if (!_properties.ContainsKey(labelHost) ||
                !_properties.ContainsKey(labelPort) ||
                !_properties.ContainsKey(labelSid) ||
                !_properties.ContainsKey(labelUser) ||
                !_properties.ContainsKey(labelPassword))
                return false;

            _host = _properties[labelHost];
            _port = _properties[labelPort];
            _sid = _properties[labelSid];
            _user = _properties[labelUser];
            _password = _properties[labelPassword];

            return true;
        }

        public string GetHost() => _host;
        public string GetPort() => _port;
        public string GetSid() => _sid;
        public string GetUser() => _user;
        public string GetPassword() => _password;
    }
}