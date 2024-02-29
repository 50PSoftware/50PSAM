using System;
using System.Windows.Forms;

namespace _50PSAM
{
    public partial class SettingsDialog : Form
    {
        public bool NotifyOnClosing { get; private set; }
        private Settings settings = new Settings();
        public SettingsDialog()
        {
            InitializeComponent();
            NotifyOnClosing = false;
        }

        private void tlClose_Click(object sender, EventArgs e)
        {
            settings.Reload();
        }

        private void tlOK_Click(object sender, EventArgs e)
        {
            RegistryManager.SetOnStartup(checkBoxRunOnStartup.Checked, radioButtonMinimized.Checked, radioButtonHidden.Checked);
            settings.RunOnStartup = checkBoxRunOnStartup.Checked;
            settings.RefreshTimerInterval = (int)refreshTimerInterval1.Value;
            settings.RefreshTimer2Interval = (int)refreshTimerInterval2.Value;
            settings.RunMinimized = radioButtonMinimized.Checked;
            settings.RunHidden = radioButtonHidden.Checked;
            settings.HideOnClosing = checkBoxHideOnClosing1.Checked;
            settings.AutoRefresh = checkBoxAutoRefresh.Checked;
            settings.ShowNotifications = checkBoxShowNotifs.Checked;

            NotifyOnClosing = checkBoxNotifyOnClosing1.Checked;
        }

        private void Nastavení_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.Save();
        }

        private void tlInfo_Click(object sender, EventArgs e)
        {
            AboutMe about = new AboutMe();
            about.ShowDialog();
        }

        private void Nastavení_Load(object sender, EventArgs e)
        {
            checkBoxRunOnStartup.Checked = settings.RunOnStartup;
            refreshTimerInterval1.Value = settings.RefreshTimerInterval;
            refreshTimerInterval2.Value = settings.RefreshTimer2Interval;
            radioButtonMinimized.Checked = settings.RunMinimized;
            radioButtonMinimized.Enabled = settings.RunOnStartup;
            radioButtonHidden.Checked = settings.RunHidden;
            radioButtonHidden.Enabled = settings.RunOnStartup;
            checkBoxHideOnClosing1.Checked = settings.HideOnClosing;
            checkBoxAutoRefresh.Checked = settings.AutoRefresh;
            refreshTimerInterval2.Enabled = settings.AutoRefresh;
            checkBoxShowNotifs.Checked = settings.ShowNotifications;
            checkBoxNotifyOnClosing1.Enabled = settings.ShowNotifications;

            NotifyOnClosing = false;
        }

        private void checkBoxRunOnStartup_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonMinimized.Enabled = radioButtonHidden.Enabled = (checkBoxRunOnStartup.Checked) ? true : false;
            if (!checkBoxRunOnStartup.Checked)
            {
                radioButtonMinimized.Checked = false;
                radioButtonHidden.Checked = false;
            }
        }

        private void checkBoxAutoRefresh_CheckedChanged(object sender, EventArgs e)
        {
            refreshTimerInterval2.Enabled = checkBoxAutoRefresh.Checked;
        }

        private void checkBoxes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowNotifs.Checked && checkBoxHideOnClosing1.Checked)
            {
                checkBoxNotifyOnClosing1.Enabled = true;
            }
            else
            {
                checkBoxNotifyOnClosing1.Checked = false;
                checkBoxNotifyOnClosing1.Enabled = false;
            }
        }
    }
}
