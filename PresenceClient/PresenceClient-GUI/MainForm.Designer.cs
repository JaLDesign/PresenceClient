﻿namespace PresenceClient_GUI
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
            this.connectButton = new System.Windows.Forms.Button();
            this.clientBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkTime = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.smallKeyBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bigKeyBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bigTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkTray = new System.Windows.Forms.CheckBox();
            this.checkMainMenu = new System.Windows.Forms.CheckBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.UseMacDefault = new System.Windows.Forms.CheckBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(81, 232);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 13;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // clientBox
            // 
            this.clientBox.Location = new System.Drawing.Point(120, 59);
            this.clientBox.MaxLength = 18;
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(100, 20);
            this.clientBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.MinimumSize = new System.Drawing.Size(100, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP or MAC Address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(123, 43);
            this.linkLabel1.MinimumSize = new System.Drawing.Size(100, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Client ID";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked_1);
            // 
            // checkTime
            // 
            this.checkTime.AutoSize = true;
            this.checkTime.Checked = true;
            this.checkTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkTime.Location = new System.Drawing.Point(17, 163);
            this.checkTime.Name = "checkTime";
            this.checkTime.Size = new System.Drawing.Size(117, 17);
            this.checkTime.TabIndex = 14;
            this.checkTime.Text = "Show Time Lapsed";
            this.checkTime.UseVisualStyleBackColor = true;
            this.checkTime.CheckedChanged += new System.EventHandler(this.CheckTime_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 121);
            this.label2.MinimumSize = new System.Drawing.Size(100, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "State Text";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stateBox
            // 
            this.stateBox.Location = new System.Drawing.Point(120, 137);
            this.stateBox.MaxLength = 128;
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(100, 20);
            this.stateBox.TabIndex = 11;
            this.stateBox.TextChanged += new System.EventHandler(this.StateBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 121);
            this.label3.MinimumSize = new System.Drawing.Size(100, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Small Image Key";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // smallKeyBox
            // 
            this.smallKeyBox.Location = new System.Drawing.Point(17, 137);
            this.smallKeyBox.MaxLength = 32;
            this.smallKeyBox.Name = "smallKeyBox";
            this.smallKeyBox.Size = new System.Drawing.Size(100, 20);
            this.smallKeyBox.TabIndex = 9;
            this.smallKeyBox.TextChanged += new System.EventHandler(this.SKeyBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 82);
            this.label4.MinimumSize = new System.Drawing.Size(100, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Large Image Key";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bigKeyBox
            // 
            this.bigKeyBox.Location = new System.Drawing.Point(17, 98);
            this.bigKeyBox.MaxLength = 32;
            this.bigKeyBox.Name = "bigKeyBox";
            this.bigKeyBox.Size = new System.Drawing.Size(100, 20);
            this.bigKeyBox.TabIndex = 5;
            this.bigKeyBox.TextChanged += new System.EventHandler(this.BigKeyBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 82);
            this.label5.MinimumSize = new System.Drawing.Size(100, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Large Image Text";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bigTextBox
            // 
            this.bigTextBox.Location = new System.Drawing.Point(120, 98);
            this.bigTextBox.MaxLength = 128;
            this.bigTextBox.Name = "bigTextBox";
            this.bigTextBox.Size = new System.Drawing.Size(100, 20);
            this.bigTextBox.TabIndex = 7;
            this.bigTextBox.TextChanged += new System.EventHandler(this.BigTextBox_TextChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(0, 22);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(236, 17);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayContextMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "PresenceClient (Disconnected)";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.trayExitMenuItem});
            this.trayContextMenu.Name = "trayContextMenu";
            this.trayContextMenu.Size = new System.Drawing.Size(120, 48);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // trayExitMenuItem
            // 
            this.trayExitMenuItem.Name = "trayExitMenuItem";
            this.trayExitMenuItem.Size = new System.Drawing.Size(119, 22);
            this.trayExitMenuItem.Text = "Exit";
            this.trayExitMenuItem.Click += new System.EventHandler(this.TrayExitMenuItem_Click);
            // 
            // checkTray
            // 
            this.checkTray.AutoSize = true;
            this.checkTray.Location = new System.Drawing.Point(1, 266);
            this.checkTray.Name = "checkTray";
            this.checkTray.Size = new System.Drawing.Size(102, 17);
            this.checkTray.TabIndex = 15;
            this.checkTray.Text = "Minimize to Tray";
            this.checkTray.UseVisualStyleBackColor = true;
            // 
            // checkMainMenu
            // 
            this.checkMainMenu.AutoSize = true;
            this.checkMainMenu.Checked = true;
            this.checkMainMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMainMenu.Location = new System.Drawing.Point(17, 186);
            this.checkMainMenu.Name = "checkMainMenu";
            this.checkMainMenu.Size = new System.Drawing.Size(175, 17);
            this.checkMainMenu.TabIndex = 18;
            this.checkMainMenu.Text = "Display Home Menu as a status";
            this.checkMainMenu.UseVisualStyleBackColor = true;
            this.checkMainMenu.CheckedChanged += new System.EventHandler(this.CheckMainMenu_CheckedChanged);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(17, 59);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(100, 20);
            this.addressBox.TabIndex = 1;
            // 
            // UseMacDefault
            // 
            this.UseMacDefault.AutoSize = true;
            this.UseMacDefault.Location = new System.Drawing.Point(17, 209);
            this.UseMacDefault.Name = "UseMacDefault";
            this.UseMacDefault.Size = new System.Drawing.Size(178, 17);
            this.UseMacDefault.TabIndex = 19;
            this.UseMacDefault.Text = "Automatically convert IP to MAC";
            this.UseMacDefault.UseVisualStyleBackColor = true;
            this.UseMacDefault.CheckedChanged += new System.EventHandler(this.UseMacDefault_CheckedChanged);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel2.Location = new System.Drawing.Point(133, 265);
            this.linkLabel2.MinimumSize = new System.Drawing.Size(100, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(100, 13);
            this.linkLabel2.TabIndex = 20;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "About";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(98, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 281);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UseMacDefault);
            this.Controls.Add(this.checkMainMenu);
            this.Controls.Add(this.checkTray);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bigTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bigKeyBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.smallKeyBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.checkTime);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.linkLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Presence Client | 1.0.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.trayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox clientBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox smallKeyBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bigKeyBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bigTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem trayExitMenuItem;
        private System.Windows.Forms.CheckBox checkTray;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkMainMenu;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.CheckBox UseMacDefault;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

