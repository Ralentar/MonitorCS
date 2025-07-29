using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
using MonitorCS.Utils;
using Oracle.DataAccess.Client;

namespace MonitorCS
{
    class Scaner
    {
        private TextBox _boxTime;
        private TextBox _boxErrors;
        private TextBox _boxRequests;
        private Label _lblException;
        private string _soundPath;
        private string _sqlQuery1;
        private string _sqlQuery2;
        private string _errors;
        private string _requests;
        private int _condition;

        public void SetParametrs(TextBox boxTime, TextBox boxErrors, TextBox boxRequests, Label lblException, string sqlQuery1, string sqlQuery2, int condition, string soundPath = "")
        {
            _boxTime = boxTime;
            _boxErrors = boxErrors;
            _boxRequests = boxRequests;
            _lblException = lblException;
            _sqlQuery1 = sqlQuery1;
            _sqlQuery2 = sqlQuery2;
            _condition = condition;
            _soundPath = soundPath;
        }

        public async void Run(UConfigDatabase configDatabase, bool isWorking, bool isVoicePlay)
        {
            _lblException.Text = "";

            if (!isWorking)
                return;

            using (OracleConnection connection = UDataBase.Connect(configDatabase))
            {
                try
                {
                    using (OracleCommand command = new OracleCommand())
                    {
                        object result;
                        command.Connection = connection;

                        await command.Connection.OpenAsync();

                        command.CommandText = _sqlQuery1;
                        result = await command.ExecuteScalarAsync();
                        _errors = result.ToString();

                        command.CommandText = _sqlQuery2;
                        result = await command.ExecuteScalarAsync();
                        _requests = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    OutFile(ex.Message);
                }
            }

            _boxErrors.Text = _errors;
            _boxRequests.Text = _requests;

            Color color = Color.LightGreen;

            int errors = int.Parse(_errors);
            int requests = int.Parse(_requests);
            bool isAlert = false;

            // если знаменатель = 0, то операция деления на 0 упадет в исключение
            // чтобы не было исключения, в форму выведен 0, а в расчетах будет деление на 1
            // если оба значения = 0, то это может быть поломкой или холостая работа ночью
            // TODO
            if (requests == 0)
                requests++;

            if (errors * 100 / requests >= _condition)
                isAlert = true;

            if (isAlert)
                color = Color.LightCoral;

            _boxErrors.BackColor = color;
            _boxRequests.BackColor = color;

            if (isAlert && isWorking)
                OutFile($"Фиксация события :: {_errors} :: {_requests}");

            if (isAlert && isWorking && isVoicePlay)
                PlaySound();

            _boxTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void PlaySound()
        {
            using (SoundPlayer player = new SoundPlayer(_soundPath))
            {
                try
                {
                    player.Load();
                    player.PlaySync();
                }
                catch (Exception ex)
                {
                    OutFile(ex.Message);
                }
            }
        }

        private void OutFile(string message = "Текст ошибки")
        {
            DateTime now = DateTime.Now;
            string folderPath = "logs";
            string fileDate = now.ToString("yyyy-MM-dd");
            string filePath = Path.Combine(folderPath, $"monitor-{fileDate}.log");
            string currentTime = now.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{currentTime} {message}");
                }
            }
            catch (Exception ex)
            {
                _lblException.Text = "Недоступна запись в файл лога";
            }
        }
    }
}