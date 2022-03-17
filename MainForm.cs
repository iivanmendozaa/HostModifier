using HostModifier.Settings;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HostModifier
{
    public partial class MainForm : Form
    {
        static AppSettings appSettings = new AppSettings();

        public MainForm()
        {
            InitializeComponent();
            LoadSettings(ref appSettings);
        }

        private void btLocal_Click(object sender, EventArgs e)
        {

            ModifyHostsToAddLocalDomain(appSettings.HostsBasePath, appSettings.LineToAdd);

        }

        private void btRemoto_Click(object sender, EventArgs e)
        {

            RestoreHostsFile(appSettings.HostsBasePath);

        }

        /// <summary>
        /// Restore Hosts file backup.
        /// </summary>
        /// <param name="filepath">Filepath were backup is located.</param>
        public void RestoreHostsFile(string filepath)
        {       
            var lines = File.ReadAllLines(filepath);
            File.WriteAllLines(@"C:\\Windows\\System32\\drivers\\etc\\hosts", lines.Take(lines.Length).ToArray());
        }

        /// <summary>
        /// Load settings from JSON file into variables.
        /// </summary>
        public void LoadSettings(ref AppSettings appSettings)
        {
            try
            {
                SettingsControl.Load(ref appSettings);
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR[01] - Missing XML Settings file or some parameters are not present or does not have a correct input value.");
                MessageBox.Show("Additional Details: " + e.ToString());
                throw;
            }
        }
        
        /// <summary>
        /// Add line to host file according to Settings file property.
        /// </summary>
        public void ModifyHostsToAddLocalDomain(string filepath, string lineToAdd) {

            var lines = File.ReadAllLines(filepath);
            File.WriteAllLines(@"C:\\Windows\\System32\\drivers\\etc\\hosts", lines.Take(lines.Length).ToArray());
            FileStream fw = new FileStream(@"C:\\Windows\\System32\\drivers\\etc\\hosts", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fw);

            string sMessage = lineToAdd;
            writer.WriteLine(sMessage);
            writer.Close();

        }

        /// <summary>
        /// Exit application in proper way.
        /// </summary>
        public void ExitProcess()
        {

            Application.ExitThread();
            Environment.Exit(0);
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExitProcess();
        }
    }
}
