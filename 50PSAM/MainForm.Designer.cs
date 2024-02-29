namespace _50PSAM
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBoxApps = new System.Windows.Forms.ListBox();
            this.popisekAplikace1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlSpustit = new System.Windows.Forms.Button();
            this.tlUninstall = new System.Windows.Forms.Button();
            this.tlUninstallAll = new System.Windows.Forms.Button();
            this.tlNastavení = new System.Windows.Forms.Button();
            this.tlRefresh = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ukončit50PSAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxApps
            // 
            this.listBoxApps.FormattingEnabled = true;
            this.listBoxApps.Location = new System.Drawing.Point(12, 37);
            this.listBoxApps.Name = "listBoxApps";
            this.listBoxApps.Size = new System.Drawing.Size(120, 134);
            this.listBoxApps.TabIndex = 0;
            this.listBoxApps.SelectedIndexChanged += new System.EventHandler(this.listBoxApps_SelectedIndexChanged);
            // 
            // popisekAplikace1
            // 
            this.popisekAplikace1.AutoSize = true;
            this.popisekAplikace1.Location = new System.Drawing.Point(13, 13);
            this.popisekAplikace1.Name = "popisekAplikace1";
            this.popisekAplikace1.Size = new System.Drawing.Size(51, 13);
            this.popisekAplikace1.TabIndex = 1;
            this.popisekAplikace1.Text = "Aplikace:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 184);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(291, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(118, 17);
            this.Status.Text = "toolStripStatusLabel1";
            this.Status.ToolTipText = "Klikněte pro podrobnější informace";
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // tlSpustit
            // 
            this.tlSpustit.Location = new System.Drawing.Point(138, 37);
            this.tlSpustit.Name = "tlSpustit";
            this.tlSpustit.Size = new System.Drawing.Size(107, 23);
            this.tlSpustit.TabIndex = 5;
            this.tlSpustit.Text = "Spustit";
            this.tlSpustit.UseVisualStyleBackColor = true;
            this.tlSpustit.Click += new System.EventHandler(this.tlSpustit_Click);
            // 
            // tlUninstall
            // 
            this.tlUninstall.Location = new System.Drawing.Point(138, 66);
            this.tlUninstall.Name = "tlUninstall";
            this.tlUninstall.Size = new System.Drawing.Size(107, 23);
            this.tlUninstall.TabIndex = 6;
            this.tlUninstall.Text = "Odinstalovat";
            this.tlUninstall.UseVisualStyleBackColor = true;
            this.tlUninstall.Click += new System.EventHandler(this.tlUninstall_Click);
            // 
            // tlUninstallAll
            // 
            this.tlUninstallAll.Location = new System.Drawing.Point(138, 95);
            this.tlUninstallAll.Name = "tlUninstallAll";
            this.tlUninstallAll.Size = new System.Drawing.Size(107, 23);
            this.tlUninstallAll.TabIndex = 7;
            this.tlUninstallAll.Text = "Odinstalovat vše";
            this.tlUninstallAll.UseVisualStyleBackColor = true;
            this.tlUninstallAll.Click += new System.EventHandler(this.tlUninstallAll_Click);
            // 
            // tlNastavení
            // 
            this.tlNastavení.Location = new System.Drawing.Point(138, 153);
            this.tlNastavení.Name = "tlNastavení";
            this.tlNastavení.Size = new System.Drawing.Size(107, 23);
            this.tlNastavení.TabIndex = 8;
            this.tlNastavení.Text = "Nastavení";
            this.tlNastavení.UseVisualStyleBackColor = true;
            this.tlNastavení.Click += new System.EventHandler(this.tlNastavení_Click);
            // 
            // tlRefresh
            // 
            this.tlRefresh.Location = new System.Drawing.Point(138, 124);
            this.tlRefresh.Name = "tlRefresh";
            this.tlRefresh.Size = new System.Drawing.Size(107, 23);
            this.tlRefresh.TabIndex = 9;
            this.tlRefresh.Text = "Obnovit";
            this.tlRefresh.UseVisualStyleBackColor = true;
            this.tlRefresh.Click += new System.EventHandler(this.tlRefresh_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Dvojitým poklepáním zobrazíte okno";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ukončit50PSAMToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 26);
            // 
            // ukončit50PSAMToolStripMenuItem
            // 
            this.ukončit50PSAMToolStripMenuItem.Name = "ukončit50PSAMToolStripMenuItem";
            this.ukončit50PSAMToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ukončit50PSAMToolStripMenuItem.Text = "Ukončit 50PSAM";
            this.ukončit50PSAMToolStripMenuItem.Click += new System.EventHandler(this.ukončit50PSAMToolStripMenuItem_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 206);
            this.Controls.Add(this.tlRefresh);
            this.Controls.Add(this.tlNastavení);
            this.Controls.Add(this.tlUninstallAll);
            this.Controls.Add(this.tlUninstall);
            this.Controls.Add(this.tlSpustit);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.popisekAplikace1);
            this.Controls.Add(this.listBoxApps);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(307, 245);
            this.MinimumSize = new System.Drawing.Size(307, 245);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxApps;
        private System.Windows.Forms.Label popisekAplikace1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.Button tlSpustit;
        private System.Windows.Forms.Button tlUninstall;
        private System.Windows.Forms.Button tlUninstallAll;
        private System.Windows.Forms.Button tlNastavení;
        private System.Windows.Forms.Button tlRefresh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ukončit50PSAMToolStripMenuItem;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer2;
    }
}

