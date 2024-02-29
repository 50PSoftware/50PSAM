namespace _50PSAM
{
    partial class SettingsDialog
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
            this.checkBoxRunOnStartup = new System.Windows.Forms.CheckBox();
            this.tlOK = new System.Windows.Forms.Button();
            this.tlClose = new System.Windows.Forms.Button();
            this.tlInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshTimerInterval1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonHidden = new System.Windows.Forms.RadioButton();
            this.radioButtonMinimized = new System.Windows.Forms.RadioButton();
            this.groupBoxRunOnStartup1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAutoRefresh = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.refreshTimerInterval2 = new System.Windows.Forms.NumericUpDown();
            this.checkBoxHideOnClosing1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxNotifyOnClosing1 = new System.Windows.Forms.CheckBox();
            this.checkBoxShowNotifs = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.refreshTimerInterval1)).BeginInit();
            this.groupBoxRunOnStartup1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshTimerInterval2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxRunOnStartup
            // 
            this.checkBoxRunOnStartup.AutoSize = true;
            this.checkBoxRunOnStartup.Location = new System.Drawing.Point(6, 19);
            this.checkBoxRunOnStartup.Name = "checkBoxRunOnStartup";
            this.checkBoxRunOnStartup.Size = new System.Drawing.Size(151, 17);
            this.checkBoxRunOnStartup.TabIndex = 0;
            this.checkBoxRunOnStartup.Text = "Spustit při startu počítače:";
            this.checkBoxRunOnStartup.UseVisualStyleBackColor = true;
            this.checkBoxRunOnStartup.CheckedChanged += new System.EventHandler(this.checkBoxRunOnStartup_CheckedChanged);
            // 
            // tlOK
            // 
            this.tlOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tlOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.tlOK.Location = new System.Drawing.Point(12, 299);
            this.tlOK.Name = "tlOK";
            this.tlOK.Size = new System.Drawing.Size(75, 23);
            this.tlOK.TabIndex = 1;
            this.tlOK.Text = "Potvrdit";
            this.tlOK.UseVisualStyleBackColor = true;
            this.tlOK.Click += new System.EventHandler(this.tlOK_Click);
            // 
            // tlClose
            // 
            this.tlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tlClose.Location = new System.Drawing.Point(258, 299);
            this.tlClose.Name = "tlClose";
            this.tlClose.Size = new System.Drawing.Size(75, 23);
            this.tlClose.TabIndex = 2;
            this.tlClose.Text = "Zavřít";
            this.tlClose.UseVisualStyleBackColor = true;
            this.tlClose.Click += new System.EventHandler(this.tlClose_Click);
            // 
            // tlInfo
            // 
            this.tlInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlInfo.Location = new System.Drawing.Point(258, 270);
            this.tlInfo.Name = "tlInfo";
            this.tlInfo.Size = new System.Drawing.Size(75, 23);
            this.tlInfo.TabIndex = 3;
            this.tlInfo.Text = "Informace";
            this.tlInfo.UseVisualStyleBackColor = true;
            this.tlInfo.Click += new System.EventHandler(this.tlInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Obnovení stavu běžících aplikací:";
            // 
            // refreshTimerInterval1
            // 
            this.refreshTimerInterval1.Location = new System.Drawing.Point(185, 14);
            this.refreshTimerInterval1.Maximum = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            this.refreshTimerInterval1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.refreshTimerInterval1.Name = "refreshTimerInterval1";
            this.refreshTimerInterval1.Size = new System.Drawing.Size(79, 20);
            this.refreshTimerInterval1.TabIndex = 5;
            this.refreshTimerInterval1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ms";
            // 
            // radioButtonHidden
            // 
            this.radioButtonHidden.AutoSize = true;
            this.radioButtonHidden.Location = new System.Drawing.Point(163, 42);
            this.radioButtonHidden.Name = "radioButtonHidden";
            this.radioButtonHidden.Size = new System.Drawing.Size(53, 17);
            this.radioButtonHidden.TabIndex = 8;
            this.radioButtonHidden.TabStop = true;
            this.radioButtonHidden.Text = "skryté";
            this.radioButtonHidden.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinimized
            // 
            this.radioButtonMinimized.AutoSize = true;
            this.radioButtonMinimized.Location = new System.Drawing.Point(163, 19);
            this.radioButtonMinimized.Name = "radioButtonMinimized";
            this.radioButtonMinimized.Size = new System.Drawing.Size(96, 17);
            this.radioButtonMinimized.TabIndex = 9;
            this.radioButtonMinimized.TabStop = true;
            this.radioButtonMinimized.Text = "minimalizované";
            this.radioButtonMinimized.UseVisualStyleBackColor = true;
            // 
            // groupBoxRunOnStartup1
            // 
            this.groupBoxRunOnStartup1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRunOnStartup1.Controls.Add(this.radioButtonHidden);
            this.groupBoxRunOnStartup1.Controls.Add(this.radioButtonMinimized);
            this.groupBoxRunOnStartup1.Controls.Add(this.checkBoxRunOnStartup);
            this.groupBoxRunOnStartup1.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRunOnStartup1.Name = "groupBoxRunOnStartup1";
            this.groupBoxRunOnStartup1.Size = new System.Drawing.Size(321, 72);
            this.groupBoxRunOnStartup1.TabIndex = 10;
            this.groupBoxRunOnStartup1.TabStop = false;
            this.groupBoxRunOnStartup1.Text = "Chování při zapnutí počítače";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBoxAutoRefresh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.refreshTimerInterval2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.refreshTimerInterval1);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 72);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intervaly časovačů";
            // 
            // checkBoxAutoRefresh
            // 
            this.checkBoxAutoRefresh.AutoSize = true;
            this.checkBoxAutoRefresh.Location = new System.Drawing.Point(6, 41);
            this.checkBoxAutoRefresh.Name = "checkBoxAutoRefresh";
            this.checkBoxAutoRefresh.Size = new System.Drawing.Size(219, 17);
            this.checkBoxAutoRefresh.TabIndex = 11;
            this.checkBoxAutoRefresh.Text = "Automatická aktualizace výpisu aplikací:";
            this.checkBoxAutoRefresh.UseVisualStyleBackColor = true;
            this.checkBoxAutoRefresh.CheckedChanged += new System.EventHandler(this.checkBoxAutoRefresh_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "s";
            // 
            // refreshTimerInterval2
            // 
            this.refreshTimerInterval2.Location = new System.Drawing.Point(227, 40);
            this.refreshTimerInterval2.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.refreshTimerInterval2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.refreshTimerInterval2.Name = "refreshTimerInterval2";
            this.refreshTimerInterval2.Size = new System.Drawing.Size(37, 20);
            this.refreshTimerInterval2.TabIndex = 9;
            this.refreshTimerInterval2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxHideOnClosing1
            // 
            this.checkBoxHideOnClosing1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxHideOnClosing1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxHideOnClosing1.AutoSize = true;
            this.checkBoxHideOnClosing1.Location = new System.Drawing.Point(6, 51);
            this.checkBoxHideOnClosing1.Name = "checkBoxHideOnClosing1";
            this.checkBoxHideOnClosing1.Size = new System.Drawing.Size(232, 23);
            this.checkBoxHideOnClosing1.TabIndex = 7;
            this.checkBoxHideOnClosing1.Text = "Při zavření okna skrýt do oznamovací oblasti";
            this.checkBoxHideOnClosing1.UseVisualStyleBackColor = true;
            this.checkBoxHideOnClosing1.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBoxNotifyOnClosing1);
            this.groupBox2.Controls.Add(this.checkBoxShowNotifs);
            this.groupBox2.Controls.Add(this.checkBoxHideOnClosing1);
            this.groupBox2.Location = new System.Drawing.Point(12, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 80);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ostatní";
            // 
            // checkBoxNotifyOnClosing1
            // 
            this.checkBoxNotifyOnClosing1.AutoSize = true;
            this.checkBoxNotifyOnClosing1.Location = new System.Drawing.Point(244, 55);
            this.checkBoxNotifyOnClosing1.Name = "checkBoxNotifyOnClosing1";
            this.checkBoxNotifyOnClosing1.Size = new System.Drawing.Size(64, 17);
            this.checkBoxNotifyOnClosing1.TabIndex = 9;
            this.checkBoxNotifyOnClosing1.Text = "Oznámit";
            this.checkBoxNotifyOnClosing1.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowNotifs
            // 
            this.checkBoxShowNotifs.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxShowNotifs.AutoSize = true;
            this.checkBoxShowNotifs.Location = new System.Drawing.Point(6, 19);
            this.checkBoxShowNotifs.Name = "checkBoxShowNotifs";
            this.checkBoxShowNotifs.Size = new System.Drawing.Size(121, 23);
            this.checkBoxShowNotifs.TabIndex = 8;
            this.checkBoxShowNotifs.Text = "Zobrazovat oznámení";
            this.checkBoxShowNotifs.UseVisualStyleBackColor = true;
            this.checkBoxShowNotifs.CheckedChanged += new System.EventHandler(this.checkBoxes_CheckedChanged);
            // 
            // Nastavení
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 334);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tlInfo);
            this.Controls.Add(this.tlClose);
            this.Controls.Add(this.tlOK);
            this.Controls.Add(this.groupBoxRunOnStartup1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Nastavení";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nastavení";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Nastavení_FormClosing);
            this.Load += new System.EventHandler(this.Nastavení_Load);
            ((System.ComponentModel.ISupportInitialize)(this.refreshTimerInterval1)).EndInit();
            this.groupBoxRunOnStartup1.ResumeLayout(false);
            this.groupBoxRunOnStartup1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshTimerInterval2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxRunOnStartup;
        private System.Windows.Forms.Button tlOK;
        private System.Windows.Forms.Button tlClose;
        private System.Windows.Forms.Button tlInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown refreshTimerInterval1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonHidden;
        private System.Windows.Forms.RadioButton radioButtonMinimized;
        private System.Windows.Forms.GroupBox groupBoxRunOnStartup1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxHideOnClosing1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown refreshTimerInterval2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxAutoRefresh;
        private System.Windows.Forms.CheckBox checkBoxShowNotifs;
        private System.Windows.Forms.CheckBox checkBoxNotifyOnClosing1;
    }
}