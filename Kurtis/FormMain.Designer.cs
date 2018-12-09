namespace Kurtis
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMinute = new System.Windows.Forms.ComboBox();
            this.cbSystemMessage = new System.Windows.Forms.CheckBox();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.cbLockDisable = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbMinuteInput = new System.Windows.Forms.ComboBox();
            this.cbInput = new System.Windows.Forms.CheckBox();
            this.groupBoxMouse = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDeactive = new System.Windows.Forms.ToolStripMenuItem();
            this.cmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.groupBoxMouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmOpen,
            this.cmDeactive,
            this.cmSettings,
            this.toolStripSeparator1,
            this.cmExit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 120);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.cbMinute);
            this.groupBox.Enabled = false;
            this.groupBox.Location = new System.Drawing.Point(146, 48);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(253, 39);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "dakika öncesinde uyarı ver";
            // 
            // cbMinute
            // 
            this.cbMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinute.FormattingEnabled = true;
            this.cbMinute.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cbMinute.Location = new System.Drawing.Point(15, 11);
            this.cbMinute.Name = "cbMinute";
            this.cbMinute.Size = new System.Drawing.Size(39, 21);
            this.cbMinute.TabIndex = 0;
            this.cbMinute.SelectedIndexChanged += new System.EventHandler(this.cbMinute_SelectedIndexChanged);
            // 
            // cbSystemMessage
            // 
            this.cbSystemMessage.AutoSize = true;
            this.cbSystemMessage.Location = new System.Drawing.Point(149, 35);
            this.cbSystemMessage.Name = "cbSystemMessage";
            this.cbSystemMessage.Size = new System.Drawing.Size(140, 17);
            this.cbSystemMessage.TabIndex = 1;
            this.cbSystemMessage.Text = "Sistem mesajlarını göster";
            this.cbSystemMessage.UseVisualStyleBackColor = true;
            this.cbSystemMessage.CheckedChanged += new System.EventHandler(this.cbSystemMessage_CheckedChanged);
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(330, 155);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 23);
            this.btnLock.TabIndex = 4;
            this.btnLock.Text = "Kilitle";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(330, 184);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 5;
            this.btnHide.Text = "Gizle";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(238, 184);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(88, 23);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // cbLockDisable
            // 
            this.cbLockDisable.AutoSize = true;
            this.cbLockDisable.Location = new System.Drawing.Point(149, 12);
            this.cbLockDisable.Name = "cbLockDisable";
            this.cbLockDisable.Size = new System.Drawing.Size(102, 17);
            this.cbLockDisable.TabIndex = 0;
            this.cbLockDisable.Text = "Devre Dışı Bırak";
            this.toolTip.SetToolTip(this.cbLockDisable, "Uygulamanın Windows\' u otomatik olarak kilitlemesini engeller. Seçim kaldırıldığı" +
        "nda tekrar çalışmaya devam eder.");
            this.cbLockDisable.UseVisualStyleBackColor = true;
            this.cbLockDisable.CheckedChanged += new System.EventHandler(this.cbLockDisable_CheckedChanged);
            // 
            // cbMinuteInput
            // 
            this.cbMinuteInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinuteInput.FormattingEnabled = true;
            this.cbMinuteInput.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "60"});
            this.cbMinuteInput.Location = new System.Drawing.Point(15, 11);
            this.cbMinuteInput.Name = "cbMinuteInput";
            this.cbMinuteInput.Size = new System.Drawing.Size(39, 21);
            this.cbMinuteInput.TabIndex = 0;
            this.cbMinuteInput.SelectedIndexChanged += new System.EventHandler(this.cbMinuteInput_SelectedIndexChanged);
            // 
            // cbInput
            // 
            this.cbInput.AutoSize = true;
            this.cbInput.Location = new System.Drawing.Point(149, 93);
            this.cbInput.Name = "cbInput";
            this.cbInput.Size = new System.Drawing.Size(213, 17);
            this.cbInput.TabIndex = 2;
            this.cbInput.Text = "Mouse ve klavyeden giriş olmazsa kilitle";
            this.cbInput.UseVisualStyleBackColor = true;
            this.cbInput.CheckedChanged += new System.EventHandler(this.cbInput_CheckedChanged);
            // 
            // groupBoxMouse
            // 
            this.groupBoxMouse.Controls.Add(this.label3);
            this.groupBoxMouse.Controls.Add(this.cbMinuteInput);
            this.groupBoxMouse.Enabled = false;
            this.groupBoxMouse.Location = new System.Drawing.Point(146, 106);
            this.groupBoxMouse.Name = "groupBoxMouse";
            this.groupBoxMouse.Size = new System.Drawing.Size(253, 39);
            this.groupBoxMouse.TabIndex = 7;
            this.groupBoxMouse.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "dakika sonra kilitle";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // cmSettings
            // 
            this.cmSettings.Image = global::Kurtis.Properties.Resources.settings;
            this.cmSettings.Name = "cmSettings";
            this.cmSettings.Size = new System.Drawing.Size(180, 22);
            this.cmSettings.Text = "Ayarlar";
            this.cmSettings.Click += new System.EventHandler(this.cmSettings_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 41);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kurtis.Properties.Resources.run;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 126);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmOpen
            // 
            this.cmOpen.Image = global::Kurtis.Properties.Resources.timer_cm;
            this.cmOpen.Name = "cmOpen";
            this.cmOpen.Size = new System.Drawing.Size(180, 22);
            this.cmOpen.Text = "Aç";
            this.cmOpen.Click += new System.EventHandler(this.cmOpen_Click);
            // 
            // cmDeactive
            // 
            this.cmDeactive.Image = global::Kurtis.Properties.Resources.stop;
            this.cmDeactive.Name = "cmDeactive";
            this.cmDeactive.Size = new System.Drawing.Size(180, 22);
            this.cmDeactive.Text = "Devre Dışı Bırak";
            this.cmDeactive.Click += new System.EventHandler(this.cmDeactive_Click);
            // 
            // cmExit
            // 
            this.cmExit.Image = ((System.Drawing.Image)(resources.GetObject("cmExit.Image")));
            this.cmExit.Name = "cmExit";
            this.cmExit.Size = new System.Drawing.Size(180, 22);
            this.cmExit.Text = "Çıkış";
            this.cmExit.Click += new System.EventHandler(this.cmExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(411, 212);
            this.Controls.Add(this.cbInput);
            this.Controls.Add(this.groupBoxMouse);
            this.Controls.Add(this.cbLockDisable);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.cbSystemMessage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.contextMenuStrip.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBoxMouse.ResumeLayout(false);
            this.groupBoxMouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMinute;
        private System.Windows.Forms.CheckBox cbSystemMessage;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox cbLockDisable;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ComboBox cbMinuteInput;
        private System.Windows.Forms.CheckBox cbInput;
        private System.Windows.Forms.GroupBox groupBoxMouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cmDeactive;
        private System.Windows.Forms.ToolStripMenuItem cmExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmOpen;
        private System.Windows.Forms.ToolStripMenuItem cmSettings;
    }
}