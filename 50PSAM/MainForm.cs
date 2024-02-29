using _50P.Software.GetApplications;
using System;
using System.Threading;
using System.Windows.Forms;

namespace _50PSAM
{
    public partial class MainForm : Form
    {
        private GetApps ga;
        private Settings settings = new Settings();
        public bool HiddenOnStart { get; set; }
        private bool hideOnClose;
        private bool notifyOnClosing = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "50PSAM";
            ga = new GetApps();
            listBoxApps.Items.AddRange(ga.GetAppsArray());
            ga.ApplicationChanges += Ga_ApplicationChanges;

            timer1.Interval = settings.RefreshTimerInterval;
            timer2.Interval = settings.RefreshTimer2Interval * 1000;
            timer1.Enabled = true;
            timer2.Enabled = settings.AutoRefresh;
            tlSpustit.Enabled = false;
            tlUninstall.Enabled = false;
            tlUninstallAll.Enabled = (ga.AppsCount == 0) ? false : true;
            hideOnClose = settings.HideOnClosing;
            tlRefresh.Enabled = !settings.AutoRefresh;

            for (int index = 0; index < ga.AppsCount; index++)
            {
                ToolStripItem item = new ToolStripMenuItem();
                item.Name = $"item{ga.Apps(index)}";
                item.Text = $"Spustit {ga.Apps(index)}";
                item.Click += Item_Click;
                contextMenuStrip1.Items.Add(item);
            }
        }

        private bool changed = false;

        private void Ga_ApplicationChanges(object sender, GetAppsEventArgs e)
        {
            if (settings.ShowNotifications)
            {
                switch (e.Action)
                {
                    case ApplicationAction.Added:
                        notifyIcon1.ShowBalloonTip(1000, "Proběhla změna", "Byly přidány aplikace!", ToolTipIcon.Info);
                        break;

                    case ApplicationAction.Deleted:
                        notifyIcon1.ShowBalloonTip(1000, "Proběhla změna", "Byly odebrány aplikace!", ToolTipIcon.Info);
                        break;
                }
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ga.AppsCount; i++)
            {
                if (ga.Apps(i) == sender.ToString().Substring("Spustit ".Length))
                    ga.StartApp(i);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ga.Refresh();
            Status.Text = (ga.RunningApps > 0 && ga.RunningApps < 5) ? ga.RunningApps.ToString() + " aplikace běží." : ga.RunningApps.ToString() + " aplikací běží.";
            tlUninstallAll.Enabled = (ga.AppsCount == 0) ? false : true;
        }

        private void Status_Click(object sender, EventArgs e)
        {
            ga.Refresh();
            if (ga.AppsCount != 0)
            {
                string zpráva = null;
                for (int i = 0; i < ga.AppsCount; i++)
                {
                    if (ga.IsRunning(i))
                    {
                        zpráva += "Aplikace " + ga.Apps(i) + " běží " + ga.Times(i) + "x\n";
                    }
                    else
                    {
                        zpráva += "Aplikace " + ga.Apps(i) + " neběží.\n";
                    }
                }
                MessageBox.Show(zpráva, "Aplikace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!hideOnClose)
            {
                e.Cancel = false;
                if (ga.RunningApps > 0)
                {
                    DialogResult ans = MessageBox.Show("Chcete zavřít všechny spuštěné procesy?\nPočet spuštěných procesů: " + ga.RunningApps, "Před ukončením", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ans == DialogResult.Yes)
                    {
                        ga.KillAllProcesses();
                    }
                }
            }
            else if (hideOnClose)
            {
                e.Cancel = true;
                if (notifyOnClosing)
                {
                    notifyIcon1.ShowBalloonTip(500, "Informace", "Stále běžím!", ToolTipIcon.Info);
                    notifyOnClosing = false;
                }
                Hide();
            }
        }

        private void tlSpustit_Click(object sender, EventArgs e)
        {
            ga.StartApp(listBoxApps.SelectedIndex);
            listBoxApps.ClearSelected();
        }

        private void tlUninstall_Click(object sender, EventArgs e)
        {
            ga.Uninstall(listBoxApps.SelectedIndex);
            listBoxApps.ClearSelected();
        }

        private void tlUninstallAll_Click(object sender, EventArgs e)
        {
            ga.UninstallAll();
            tlUninstallAll.Enabled = false;
        }

        private void tlRefresh_Click(object sender, EventArgs e)
        {
            RefreshApplication();
        }

        private void listBoxApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxApps.SelectedIndex < 0)
            {
                tlSpustit.Enabled = false;
                tlUninstall.Enabled = false;
            }
            else
            {
                tlSpustit.Enabled = true;
                tlUninstall.Enabled = true;
            }
        }

        private void tlNastavení_Click(object sender, EventArgs e)
        {
            SettingsDialog nastavení = new SettingsDialog();
            DialogResult result = nastavení.ShowDialog();
            if (result == DialogResult.OK)
            {
                settings.Reload();
                timer1.Interval = settings.RefreshTimerInterval;
                hideOnClose = settings.HideOnClosing;
                timer2.Interval = settings.RefreshTimer2Interval * 1000;
                timer2.Enabled = settings.AutoRefresh;
                tlRefresh.Enabled = !settings.AutoRefresh;
                notifyOnClosing = nastavení.NotifyOnClosing;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void ukončit50PSAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideOnClose = false;
            Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (HiddenOnStart)
            {
                Hide();
                Opacity = 100;
            }
        }

        private void RefreshApplication()
        {
            if (changed)
            {
                tlSpustit.Enabled = false;
                tlUninstall.Enabled = false;

                listBoxApps.Items.Clear();
                string[] apps = ga.GetAppsArray();
                listBoxApps.Items.AddRange(apps);
                for (int index = 0; index < contextMenuStrip1.Items.Count; index++)
                {
                    if (contextMenuStrip1.Items[index].Name.StartsWith("item"))
                    {
                        contextMenuStrip1.Items.RemoveAt(index);
                        index = 0;
                    }
                }

                if (ga.AppsCount != 0)
                {
                    for (int index = 0; index < ga.AppsCount; index++)
                    {
                        ToolStripItem item = new ToolStripMenuItem();
                        item.Name = $"item{ga.Apps(index)}";
                        item.Text = $"Spustit {ga.Apps(index)}";
                        item.Click += Item_Click;
                        contextMenuStrip1.Items.Add(item);
                    }
                }
                changed = false;
            }
            else
            {
                changed = ga.ApplicationChanged();
                Console.ForegroundColor = (changed) ? ConsoleColor.Green : ConsoleColor.Red;
                Console.WriteLine($"Changed: {changed}");
                Console.ResetColor();
            }
            //timer2.Enabled = (settings.AutoRefresh) ? true : false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            RefreshApplication();
            if (changed)
            {
                timer2.Enabled = false;
                Thread.Sleep(timer2.Interval);
                timer2.Enabled = true;
            }
        }
    }
}
