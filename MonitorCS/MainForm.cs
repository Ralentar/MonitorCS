using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Timers;
using MonitorCS.Utils;

namespace MonitorCS
{
    public partial class MainForm : Form
    {
        private bool _isWorking = false;

        private int _interval = 1;
        private int _condition = 1;

        private string _soundPath;
        private string _configPath;
        private string _queryPath1;
        private string _queryPath2;

        private string _query1;
        private string _query2;

        private Scaner _scaner;
        private UConfigDatabase _configDB;
        private static System.Timers.Timer _timer;

        public MainForm()
        {
            InitializeComponent();
            _scaner = new Scaner();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _soundPath = Properties.Settings.Default.SoundPath.ToString();
            _configPath = Properties.Settings.Default.ConfigPath.ToString();
            _queryPath1 = Properties.Settings.Default.QueryPath1.ToString();
            _queryPath2 = Properties.Settings.Default.QueryPath2.ToString();

            if (_soundPath is null)
                _soundPath = "C:\\";

            if (_configPath is null)
                _configPath = "C:\\";

            if (_queryPath1 is null)
                _queryPath1 = "C:\\";

            if (_queryPath2 is null)
                _queryPath2 = "C:\\";

            txtSoundPath.Text = _soundPath;
            txtConfigPath.Text = _configPath;
            txtQueryPath1.Text = _queryPath1;
            txtQueryPath2.Text = _queryPath2;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBoxInterval.Text, out _interval) ||
                !int.TryParse(txtBoxTrigger.Text, out _condition) ||
                _condition <= 0)
                return;

            _query1 = ReadFile(_queryPath1);
            _query2 = ReadFile(_queryPath2);

            if (_query1 is null || _query2 is null)
                return;

            if (!ExistRequestBody(_query1, _queryPath1))
                return;

            if (!ExistRequestBody(_query2, _queryPath2))
                return;

            _configDB = new UConfigDatabase();

            if (!_configDB.TryReadConfig(_configPath))
                return;

            if (!_configDB.IsExistConfig())
                return;

            _scaner.SetParametrs(txtTime, txtQueryResult1, txtQueryResult2, lblException, _query1, _query2, _condition, _soundPath);

            SwitchButtons();

            _scaner.Run(_configDB, _isWorking, checkBoxSound.Checked);

            PerformScanning();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            SwitchButtons();

            txtQueryResult1.BackColor = SystemColors.Control;
            txtQueryResult2.BackColor = SystemColors.Control;

            _timer.Stop();
            _timer.Dispose();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            string path = Browse();

            if (path is null)
                return;

            _soundPath = path;
            txtSoundPath.Text = path;
            Properties.Settings.Default.SoundPath = path;
            Properties.Settings.Default.Save();
        }

        private void btnBase_Click(object sender, EventArgs e)
        {
            string path = Browse();

            if (path is null)
                return;

            _configPath = path;
            txtConfigPath.Text = path;
            Properties.Settings.Default.ConfigPath = path;
            Properties.Settings.Default.Save();
        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            string path = Browse();

            if (path is null)
                return;

            _queryPath1 = path;
            txtQueryPath1.Text = path;
            Properties.Settings.Default.QueryPath1 = path;
            Properties.Settings.Default.Save();
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            string path = Browse();

            if (path is null)
                return;

            _queryPath2 = path;
            txtQueryPath2.Text = path;
            Properties.Settings.Default.QueryPath2 = path;
            Properties.Settings.Default.Save();
        }

        private string Browse()
        {
            OpenFileDialog selectFilePath;

            using (selectFilePath = new OpenFileDialog())
            {
                if (selectFilePath.ShowDialog() == DialogResult.OK)
                    return selectFilePath.FileName;

                return null;
            }
        }

        private string ReadFile(string path)
        {
            string fileContent = null;

            try
            {
                fileContent = File.ReadAllText(path);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"Не найден файл {path}!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Произошла ошибка при чтении файла {path}: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return fileContent;
        }

        private bool ExistRequestBody(string request, string message)
        {
            if (request.Length != 0)
                return true;

            MessageBox.Show($"Не задан текст запроса {message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void SwitchButtons()
        {
            btnStart.Enabled = !btnStart.Enabled;
            btnStop.Enabled = !btnStop.Enabled;
            _isWorking = !_isWorking;

            txtBoxInterval.ReadOnly = _isWorking;
            txtBoxTrigger.ReadOnly = _isWorking;
        }

        private void PerformScanning()
        {
            _timer = new System.Timers.Timer(_interval * 1000);
            _timer.Elapsed += OnTimedEvent;
            _timer.AutoReset = true;
            _timer.Enabled = true;

            if (_isWorking)
                return;

            _timer.Stop();
            _timer.Dispose();
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if (!_isWorking)
                return;

            _scaner.Run(_configDB, _isWorking, checkBoxSound.Checked);
        }
    }
}