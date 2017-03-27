﻿namespace PoEWhisperNotifier
{
	partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNotifyMinimizedOnly = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogPartyMessages = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogGuildMessages = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogTradeMessages = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEnableTrayNotifications = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEnableSound = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEnableSMTPNotifications = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEnablePushBullet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMinimizeToTray = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStartMinimized = new System.Windows.Forms.ToolStripMenuItem();
            this.configureSMTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurePushBulletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTrimLogFile = new System.Windows.Forms.ToolStripMenuItem();
            this.testNotificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotificationIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.textBoxTrade = new System.Windows.Forms.TextBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbHistory = new System.Windows.Forms.RichTextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.tsmLogGlobalMessages = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGlobal = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(863, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNotifyMinimizedOnly,
            this.tsmLogPartyMessages,
            this.tsmLogGuildMessages,
            this.tsmLogTradeMessages,
            this.tsmLogGlobalMessages,
            this.tsmEnableTrayNotifications,
            this.tsmEnableSound,
            this.tsmEnableSMTPNotifications,
            this.tsmEnablePushBullet,
            this.tsmMinimizeToTray,
            this.tsmStartMinimized,
            this.configureSMTPToolStripMenuItem,
            this.configurePushBulletToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.editToolStripMenuItem.Text = "&Settings";
            // 
            // tsmNotifyMinimizedOnly
            // 
            this.tsmNotifyMinimizedOnly.Name = "tsmNotifyMinimizedOnly";
            this.tsmNotifyMinimizedOnly.Size = new System.Drawing.Size(239, 22);
            this.tsmNotifyMinimizedOnly.Text = "Notify Only When &Minimized";
            this.tsmNotifyMinimizedOnly.Click += new System.EventHandler(this.notifyOnlyWhenMinimizedToolStripMenuItem_Click);
            // 
            // tsmLogPartyMessages
            // 
            this.tsmLogPartyMessages.Name = "tsmLogPartyMessages";
            this.tsmLogPartyMessages.Size = new System.Drawing.Size(239, 22);
            this.tsmLogPartyMessages.Text = "Include Part&y Messages";
            this.tsmLogPartyMessages.Click += new System.EventHandler(this.tsmLogPartyMessages_Click);
            // 
            // tsmLogGuildMessages
            // 
            this.tsmLogGuildMessages.Name = "tsmLogGuildMessages";
            this.tsmLogGuildMessages.Size = new System.Drawing.Size(239, 22);
            this.tsmLogGuildMessages.Text = "Include Guil&d Messages";
            this.tsmLogGuildMessages.Click += new System.EventHandler(this.tsmLogGuildMessages_Click);
            // 
            // tsmLogTradeMessages
            // 
            this.tsmLogTradeMessages.Name = "tsmLogTradeMessages";
            this.tsmLogTradeMessages.Size = new System.Drawing.Size(239, 22);
            this.tsmLogTradeMessages.Text = "Include Trad&e Messages";
            this.tsmLogTradeMessages.Click += new System.EventHandler(this.tsmLogTradeMessages_Click);
            // 
            // tsmEnableTrayNotifications
            // 
            this.tsmEnableTrayNotifications.Name = "tsmEnableTrayNotifications";
            this.tsmEnableTrayNotifications.Size = new System.Drawing.Size(239, 22);
            this.tsmEnableTrayNotifications.Text = "Enable &Tray Notifications";
            this.tsmEnableTrayNotifications.Click += new System.EventHandler(this.tsmEnableTrayNotifications_Click);
            // 
            // tsmEnableSound
            // 
            this.tsmEnableSound.Name = "tsmEnableSound";
            this.tsmEnableSound.Size = new System.Drawing.Size(239, 22);
            this.tsmEnableSound.Text = "Enable S&ound";
            this.tsmEnableSound.Click += new System.EventHandler(this.tsmEnableSound_Click);
            // 
            // tsmEnableSMTPNotifications
            // 
            this.tsmEnableSMTPNotifications.Name = "tsmEnableSMTPNotifications";
            this.tsmEnableSMTPNotifications.Size = new System.Drawing.Size(239, 22);
            this.tsmEnableSMTPNotifications.Text = "Enable &SMTP Notifications";
            this.tsmEnableSMTPNotifications.Click += new System.EventHandler(this.tsmEnableSMTPNotifications_Click);
            // 
            // tsmEnablePushBullet
            // 
            this.tsmEnablePushBullet.Name = "tsmEnablePushBullet";
            this.tsmEnablePushBullet.Size = new System.Drawing.Size(239, 22);
            this.tsmEnablePushBullet.Text = "Enable &PushBullet Notifications";
            this.tsmEnablePushBullet.Click += new System.EventHandler(this.tsmEnablePushbullet_Click);
            // 
            // tsmMinimizeToTray
            // 
            this.tsmMinimizeToTray.Name = "tsmMinimizeToTray";
            this.tsmMinimizeToTray.Size = new System.Drawing.Size(239, 22);
            this.tsmMinimizeToTray.Text = "M&inimize to System Tray";
            this.tsmMinimizeToTray.Click += new System.EventHandler(this.tsmMinimizeToTray_Click);
            // 
            // tsmStartMinimized
            // 
            this.tsmStartMinimized.Name = "tsmStartMinimized";
            this.tsmStartMinimized.Size = new System.Drawing.Size(239, 22);
            this.tsmStartMinimized.Text = "Start Minimiz&ed";
            this.tsmStartMinimized.Click += new System.EventHandler(this.tsmStartMinimized_Click);
            // 
            // configureSMTPToolStripMenuItem
            // 
            this.configureSMTPToolStripMenuItem.Name = "configureSMTPToolStripMenuItem";
            this.configureSMTPToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.configureSMTPToolStripMenuItem.Text = "Configure SMTP";
            this.configureSMTPToolStripMenuItem.Click += new System.EventHandler(this.configureSMTPToolStripMenuItem_Click);
            // 
            // configurePushBulletToolStripMenuItem
            // 
            this.configurePushBulletToolStripMenuItem.Name = "configurePushBulletToolStripMenuItem";
            this.configurePushBulletToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.configurePushBulletToolStripMenuItem.Text = "Configure PushBullet";
            this.configurePushBulletToolStripMenuItem.Click += new System.EventHandler(this.configurePushBulletToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTrimLogFile,
            this.testNotificationToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // tsmTrimLogFile
            // 
            this.tsmTrimLogFile.Name = "tsmTrimLogFile";
            this.tsmTrimLogFile.Size = new System.Drawing.Size(162, 22);
            this.tsmTrimLogFile.Text = "Trim Client.txt";
            this.tsmTrimLogFile.Click += new System.EventHandler(this.trimClienttxtToolStripMenuItem_Click);
            // 
            // testNotificationToolStripMenuItem
            // 
            this.testNotificationToolStripMenuItem.Name = "testNotificationToolStripMenuItem";
            this.testNotificationToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.testNotificationToolStripMenuItem.Text = "Test &Notification";
            this.testNotificationToolStripMenuItem.Click += new System.EventHandler(this.testNotificationToolStripMenuItem_Click);
            // 
            // NotificationIcon
            // 
            this.NotificationIcon.Text = "PoE Whisper Notifier";
            this.NotificationIcon.Visible = true;
            // 
            // textBoxTrade
            // 
            this.textBoxTrade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTrade.Location = new System.Drawing.Point(165, 51);
            this.textBoxTrade.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTrade.Name = "textBoxTrade";
            this.textBoxTrade.Size = new System.Drawing.Size(604, 23);
            this.textBoxTrade.TabIndex = 5;
            // 
            // cmdStart
            // 
            this.cmdStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdStart.Location = new System.Drawing.Point(0, 582);
            this.cmdStart.Margin = new System.Windows.Forms.Padding(2);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(863, 29);
            this.cmdStart.TabIndex = 3;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdStop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdStop.Enabled = false;
            this.cmdStop.Location = new System.Drawing.Point(0, 611);
            this.cmdStop.Margin = new System.Windows.Forms.Padding(2);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(863, 29);
            this.cmdStop.TabIndex = 2;
            this.cmdStop.Text = "Stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // txtLogPath
            // 
            this.txtLogPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogPath.Location = new System.Drawing.Point(84, 24);
            this.txtLogPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.Size = new System.Drawing.Size(768, 23);
            this.txtLogPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Find Trade Messages:";
            // 
            // rtbHistory
            // 
            this.rtbHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbHistory.BackColor = System.Drawing.Color.White;
            this.rtbHistory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHistory.HideSelection = false;
            this.rtbHistory.Location = new System.Drawing.Point(9, 115);
            this.rtbHistory.Margin = new System.Windows.Forms.Padding(2);
            this.rtbHistory.Name = "rtbHistory";
            this.rtbHistory.ReadOnly = true;
            this.rtbHistory.Size = new System.Drawing.Size(841, 463);
            this.rtbHistory.TabIndex = 4;
            this.rtbHistory.Text = "";
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Location = new System.Drawing.Point(775, 51);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 48);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Reload";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // tsmLogGlobalMessages
            // 
            this.tsmLogGlobalMessages.Name = "tsmLogGlobalMessages";
            this.tsmLogGlobalMessages.Size = new System.Drawing.Size(239, 22);
            this.tsmLogGlobalMessages.Text = "Include Global Messages";
            this.tsmLogGlobalMessages.Click += new System.EventHandler(this.tsmLogGlobalMessages_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Find Global Messages:";
            // 
            // textBoxGlobal
            // 
            this.textBoxGlobal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGlobal.Location = new System.Drawing.Point(165, 79);
            this.textBoxGlobal.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGlobal.Name = "textBoxGlobal";
            this.textBoxGlobal.Size = new System.Drawing.Size(604, 23);
            this.textBoxGlobal.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(863, 640);
            this.Controls.Add(this.textBoxGlobal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.txtLogPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTrade);
            this.Controls.Add(this.rtbHistory);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "PoE Whisper Notifier";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmNotifyMinimizedOnly;
		private System.Windows.Forms.ToolStripMenuItem tsmEnableTrayNotifications;
		private System.Windows.Forms.NotifyIcon NotificationIcon;
		private System.Windows.Forms.ToolStripMenuItem tsmEnableSMTPNotifications;
		private System.Windows.Forms.ToolStripMenuItem configureSMTPToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmEnablePushBullet;
		private System.Windows.Forms.ToolStripMenuItem configurePushBulletToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmEnableSound;
		private System.Windows.Forms.ToolStripMenuItem tsmMinimizeToTray;
		private System.Windows.Forms.ToolStripMenuItem tsmLogPartyMessages;
        private System.Windows.Forms.ToolStripMenuItem tsmLogGuildMessages;
        private System.Windows.Forms.ToolStripMenuItem tsmLogTradeMessages;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmTrimLogFile;
		private System.Windows.Forms.ToolStripMenuItem testNotificationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmStartMinimized;
        private System.Windows.Forms.TextBox textBoxTrade;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.TextBox txtLogPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbHistory;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ToolStripMenuItem tsmLogGlobalMessages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGlobal;
    }
}

