namespace SmartAppStarter
{
    partial class Form1
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
            this.btnLoadProjPath = new System.Windows.Forms.Button();
            this.txtProjectPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnStartCoreDiskloader = new System.Windows.Forms.Button();
            this.gbxDiskloader = new System.Windows.Forms.GroupBox();
            this.btnLoadCore = new System.Windows.Forms.Button();
            this.btnSaveCore = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtDi = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblDi = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblStatusPath = new System.Windows.Forms.Label();
            this.grpLoadProject = new System.Windows.Forms.GroupBox();
            this.btnSwitchToQuickView = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadGui = new System.Windows.Forms.Button();
            this.btnSaveGui = new System.Windows.Forms.Button();
            this.btnStartGui = new System.Windows.Forms.Button();
            this.txtGuiPort = new System.Windows.Forms.TextBox();
            this.txtGuiIp = new System.Windows.Forms.TextBox();
            this.lblGuiPort = new System.Windows.Forms.Label();
            this.lblGUIIP = new System.Windows.Forms.Label();
            this.grpQuickView = new System.Windows.Forms.GroupBox();
            this.txtMakepyCMD = new System.Windows.Forms.TextBox();
            this.txtComponent = new System.Windows.Forms.TextBox();
            this.btnCompile = new System.Windows.Forms.Button();
            this.btnPathToBin = new System.Windows.Forms.Button();
            this.btnOpenProj = new System.Windows.Forms.Button();
            this.btnQuickSwitch = new System.Windows.Forms.Button();
            this.btnQuickStartGUI = new System.Windows.Forms.Button();
            this.btnQuickStartCore = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbxDiskloader.SuspendLayout();
            this.grpLoadProject.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpQuickView.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadProjPath
            // 
            this.btnLoadProjPath.Location = new System.Drawing.Point(6, 19);
            this.btnLoadProjPath.Name = "btnLoadProjPath";
            this.btnLoadProjPath.Size = new System.Drawing.Size(188, 23);
            this.btnLoadProjPath.TabIndex = 0;
            this.btnLoadProjPath.Text = "LoadProjectPath";
            this.btnLoadProjPath.UseVisualStyleBackColor = true;
            this.btnLoadProjPath.Click += new System.EventHandler(this.btnLoadProjPath_Click);
            // 
            // txtProjectPath
            // 
            this.txtProjectPath.Location = new System.Drawing.Point(4, 48);
            this.txtProjectPath.Name = "txtProjectPath";
            this.txtProjectPath.ReadOnly = true;
            this.txtProjectPath.Size = new System.Drawing.Size(190, 20);
            this.txtProjectPath.TabIndex = 1;
            // 
            // btnStartCoreDiskloader
            // 
            this.btnStartCoreDiskloader.Location = new System.Drawing.Point(6, 114);
            this.btnStartCoreDiskloader.Name = "btnStartCoreDiskloader";
            this.btnStartCoreDiskloader.Size = new System.Drawing.Size(94, 23);
            this.btnStartCoreDiskloader.TabIndex = 2;
            this.btnStartCoreDiskloader.Text = "Start Core";
            this.btnStartCoreDiskloader.UseVisualStyleBackColor = true;
            this.btnStartCoreDiskloader.Click += new System.EventHandler(this.btnStartCoreDiskloader_Click);
            // 
            // gbxDiskloader
            // 
            this.gbxDiskloader.Controls.Add(this.btnLoadCore);
            this.gbxDiskloader.Controls.Add(this.btnSaveCore);
            this.gbxDiskloader.Controls.Add(this.txtIP);
            this.gbxDiskloader.Controls.Add(this.txtDi);
            this.gbxDiskloader.Controls.Add(this.txtD);
            this.gbxDiskloader.Controls.Add(this.lblIp);
            this.gbxDiskloader.Controls.Add(this.lblDi);
            this.gbxDiskloader.Controls.Add(this.lblD);
            this.gbxDiskloader.Controls.Add(this.btnStartCoreDiskloader);
            this.gbxDiskloader.Location = new System.Drawing.Point(224, 51);
            this.gbxDiskloader.Name = "gbxDiskloader";
            this.gbxDiskloader.Size = new System.Drawing.Size(206, 143);
            this.gbxDiskloader.TabIndex = 3;
            this.gbxDiskloader.TabStop = false;
            this.gbxDiskloader.Text = "Core";
            // 
            // btnLoadCore
            // 
            this.btnLoadCore.Location = new System.Drawing.Point(154, 113);
            this.btnLoadCore.Name = "btnLoadCore";
            this.btnLoadCore.Size = new System.Drawing.Size(42, 23);
            this.btnLoadCore.TabIndex = 10;
            this.btnLoadCore.Text = "Load";
            this.btnLoadCore.UseVisualStyleBackColor = true;
            this.btnLoadCore.Click += new System.EventHandler(this.btnLoadCore_Click);
            // 
            // btnSaveCore
            // 
            this.btnSaveCore.Location = new System.Drawing.Point(106, 113);
            this.btnSaveCore.Name = "btnSaveCore";
            this.btnSaveCore.Size = new System.Drawing.Size(42, 23);
            this.btnSaveCore.TabIndex = 9;
            this.btnSaveCore.Text = "Save";
            this.btnSaveCore.UseVisualStyleBackColor = true;
            this.btnSaveCore.Click += new System.EventHandler(this.btnSaveCore_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(58, 77);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(129, 20);
            this.txtIP.TabIndex = 8;
            // 
            // txtDi
            // 
            this.txtDi.Location = new System.Drawing.Point(58, 50);
            this.txtDi.Name = "txtDi";
            this.txtDi.Size = new System.Drawing.Size(129, 20);
            this.txtDi.TabIndex = 7;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(58, 26);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(129, 20);
            this.txtD.TabIndex = 6;
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(17, 80);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(17, 13);
            this.lblIp.TabIndex = 5;
            this.lblIp.Text = "IP";
            // 
            // lblDi
            // 
            this.lblDi.AutoSize = true;
            this.lblDi.Location = new System.Drawing.Point(17, 53);
            this.lblDi.Name = "lblDi";
            this.lblDi.Size = new System.Drawing.Size(18, 13);
            this.lblDi.TabIndex = 4;
            this.lblDi.Text = "-di";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(17, 26);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(16, 13);
            this.lblD.TabIndex = 3;
            this.lblD.Text = "-d";
            // 
            // lblStatusPath
            // 
            this.lblStatusPath.AutoSize = true;
            this.lblStatusPath.ForeColor = System.Drawing.Color.Red;
            this.lblStatusPath.Location = new System.Drawing.Point(79, 71);
            this.lblStatusPath.Name = "lblStatusPath";
            this.lblStatusPath.Size = new System.Drawing.Size(48, 13);
            this.lblStatusPath.TabIndex = 4;
            this.lblStatusPath.Text = "NOT OK";
            this.lblStatusPath.Visible = false;
            // 
            // grpLoadProject
            // 
            this.grpLoadProject.Controls.Add(this.btnSwitchToQuickView);
            this.grpLoadProject.Controls.Add(this.btnLoadProjPath);
            this.grpLoadProject.Controls.Add(this.lblStatusPath);
            this.grpLoadProject.Controls.Add(this.txtProjectPath);
            this.grpLoadProject.Location = new System.Drawing.Point(9, 51);
            this.grpLoadProject.Name = "grpLoadProject";
            this.grpLoadProject.Size = new System.Drawing.Size(206, 143);
            this.grpLoadProject.TabIndex = 5;
            this.grpLoadProject.TabStop = false;
            this.grpLoadProject.Text = "LoadProject";
            // 
            // btnSwitchToQuickView
            // 
            this.btnSwitchToQuickView.Location = new System.Drawing.Point(12, 98);
            this.btnSwitchToQuickView.Name = "btnSwitchToQuickView";
            this.btnSwitchToQuickView.Size = new System.Drawing.Size(182, 23);
            this.btnSwitchToQuickView.TabIndex = 3;
            this.btnSwitchToQuickView.Text = "Switch To Quick View";
            this.btnSwitchToQuickView.UseVisualStyleBackColor = true;
            this.btnSwitchToQuickView.Click += new System.EventHandler(this.btnSwitchToQuickView_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadGui);
            this.groupBox1.Controls.Add(this.btnSaveGui);
            this.groupBox1.Controls.Add(this.btnStartGui);
            this.groupBox1.Controls.Add(this.txtGuiPort);
            this.groupBox1.Controls.Add(this.txtGuiIp);
            this.groupBox1.Controls.Add(this.lblGuiPort);
            this.groupBox1.Controls.Add(this.lblGUIIP);
            this.groupBox1.Location = new System.Drawing.Point(436, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 143);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GUI";
            // 
            // btnLoadGui
            // 
            this.btnLoadGui.Location = new System.Drawing.Point(144, 113);
            this.btnLoadGui.Name = "btnLoadGui";
            this.btnLoadGui.Size = new System.Drawing.Size(42, 23);
            this.btnLoadGui.TabIndex = 11;
            this.btnLoadGui.Text = "Load";
            this.btnLoadGui.UseVisualStyleBackColor = true;
            this.btnLoadGui.Click += new System.EventHandler(this.btnLoadGui_Click);
            // 
            // btnSaveGui
            // 
            this.btnSaveGui.Location = new System.Drawing.Point(96, 113);
            this.btnSaveGui.Name = "btnSaveGui";
            this.btnSaveGui.Size = new System.Drawing.Size(42, 23);
            this.btnSaveGui.TabIndex = 11;
            this.btnSaveGui.Text = "Save";
            this.btnSaveGui.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSaveGui.UseVisualStyleBackColor = true;
            this.btnSaveGui.Click += new System.EventHandler(this.btnSaveGui_Click);
            // 
            // btnStartGui
            // 
            this.btnStartGui.Location = new System.Drawing.Point(12, 114);
            this.btnStartGui.Name = "btnStartGui";
            this.btnStartGui.Size = new System.Drawing.Size(78, 23);
            this.btnStartGui.TabIndex = 9;
            this.btnStartGui.Text = "Start GUI";
            this.btnStartGui.UseVisualStyleBackColor = true;
            this.btnStartGui.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGuiPort
            // 
            this.txtGuiPort.Location = new System.Drawing.Point(58, 52);
            this.txtGuiPort.Name = "txtGuiPort";
            this.txtGuiPort.Size = new System.Drawing.Size(129, 20);
            this.txtGuiPort.TabIndex = 10;
            // 
            // txtGuiIp
            // 
            this.txtGuiIp.Location = new System.Drawing.Point(58, 26);
            this.txtGuiIp.Name = "txtGuiIp";
            this.txtGuiIp.Size = new System.Drawing.Size(129, 20);
            this.txtGuiIp.TabIndex = 9;
            // 
            // lblGuiPort
            // 
            this.lblGuiPort.AutoSize = true;
            this.lblGuiPort.Location = new System.Drawing.Point(10, 56);
            this.lblGuiPort.Name = "lblGuiPort";
            this.lblGuiPort.Size = new System.Drawing.Size(48, 13);
            this.lblGuiPort.TabIndex = 1;
            this.lblGuiPort.Text = "GUI Port";
            // 
            // lblGUIIP
            // 
            this.lblGUIIP.AutoSize = true;
            this.lblGUIIP.Location = new System.Drawing.Point(11, 28);
            this.lblGUIIP.Name = "lblGUIIP";
            this.lblGUIIP.Size = new System.Drawing.Size(39, 13);
            this.lblGUIIP.TabIndex = 0;
            this.lblGUIIP.Text = "GUI IP";
            // 
            // grpQuickView
            // 
            this.grpQuickView.Controls.Add(this.txtMakepyCMD);
            this.grpQuickView.Controls.Add(this.txtComponent);
            this.grpQuickView.Controls.Add(this.btnCompile);
            this.grpQuickView.Controls.Add(this.btnPathToBin);
            this.grpQuickView.Controls.Add(this.btnOpenProj);
            this.grpQuickView.Controls.Add(this.btnQuickSwitch);
            this.grpQuickView.Controls.Add(this.btnQuickStartGUI);
            this.grpQuickView.Controls.Add(this.btnQuickStartCore);
            this.grpQuickView.Location = new System.Drawing.Point(7, -1);
            this.grpQuickView.Name = "grpQuickView";
            this.grpQuickView.Size = new System.Drawing.Size(300, 40);
            this.grpQuickView.TabIndex = 7;
            this.grpQuickView.TabStop = false;
            this.grpQuickView.Text = "Quick View";
            // 
            // txtMakepyCMD
            // 
            this.txtMakepyCMD.Location = new System.Drawing.Point(180, 13);
            this.txtMakepyCMD.Name = "txtMakepyCMD";
            this.txtMakepyCMD.Size = new System.Drawing.Size(48, 20);
            this.txtMakepyCMD.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtMakepyCMD, "Make.py command that you want to execute");
            // 
            // txtComponent
            // 
            this.txtComponent.Location = new System.Drawing.Point(233, 13);
            this.txtComponent.Name = "txtComponent";
            this.txtComponent.Size = new System.Drawing.Size(63, 20);
            this.txtComponent.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtComponent, "Component that You want to use");
            // 
            // btnCompile
            // 
            this.btnCompile.Location = new System.Drawing.Point(143, 12);
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Size = new System.Drawing.Size(31, 23);
            this.btnCompile.TabIndex = 9;
            this.btnCompile.Text = "PY";
            this.toolTip1.SetToolTip(this.btnCompile, "Run Make.py + specified CMD + Specified Component");
            this.btnCompile.UseVisualStyleBackColor = true;
            this.btnCompile.Click += new System.EventHandler(this.btnCompile_Click);
            // 
            // btnPathToBin
            // 
            this.btnPathToBin.Location = new System.Drawing.Point(106, 12);
            this.btnPathToBin.Name = "btnPathToBin";
            this.btnPathToBin.Size = new System.Drawing.Size(32, 23);
            this.btnPathToBin.TabIndex = 4;
            this.btnPathToBin.Text = "PB";
            this.toolTip1.SetToolTip(this.btnPathToBin, "Open Project Bin Path");
            this.btnPathToBin.UseVisualStyleBackColor = true;
            this.btnPathToBin.Click += new System.EventHandler(this.btnPathToBin_Click);
            // 
            // btnOpenProj
            // 
            this.btnOpenProj.Location = new System.Drawing.Point(71, 12);
            this.btnOpenProj.Name = "btnOpenProj";
            this.btnOpenProj.Size = new System.Drawing.Size(30, 23);
            this.btnOpenProj.TabIndex = 3;
            this.btnOpenProj.Text = "PP";
            this.toolTip1.SetToolTip(this.btnOpenProj, "Open Project Path");
            this.btnOpenProj.UseVisualStyleBackColor = true;
            this.btnOpenProj.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnQuickSwitch
            // 
            this.btnQuickSwitch.Location = new System.Drawing.Point(49, 12);
            this.btnQuickSwitch.Name = "btnQuickSwitch";
            this.btnQuickSwitch.Size = new System.Drawing.Size(17, 23);
            this.btnQuickSwitch.TabIndex = 2;
            this.btnQuickSwitch.Text = "S";
            this.toolTip1.SetToolTip(this.btnQuickSwitch, "Switch View");
            this.btnQuickSwitch.UseVisualStyleBackColor = true;
            this.btnQuickSwitch.Click += new System.EventHandler(this.btnQuickSwitch_Click);
            // 
            // btnQuickStartGUI
            // 
            this.btnQuickStartGUI.Location = new System.Drawing.Point(28, 12);
            this.btnQuickStartGUI.Name = "btnQuickStartGUI";
            this.btnQuickStartGUI.Size = new System.Drawing.Size(18, 23);
            this.btnQuickStartGUI.TabIndex = 1;
            this.btnQuickStartGUI.Text = "G";
            this.toolTip1.SetToolTip(this.btnQuickStartGUI, "Start GUI");
            this.btnQuickStartGUI.UseVisualStyleBackColor = true;
            this.btnQuickStartGUI.Click += new System.EventHandler(this.btnQuickStartGUI_Click);
            // 
            // btnQuickStartCore
            // 
            this.btnQuickStartCore.Location = new System.Drawing.Point(6, 12);
            this.btnQuickStartCore.Name = "btnQuickStartCore";
            this.btnQuickStartCore.Size = new System.Drawing.Size(18, 23);
            this.btnQuickStartCore.TabIndex = 0;
            this.btnQuickStartCore.Text = "C";
            this.toolTip1.SetToolTip(this.btnQuickStartCore, "Start Core");
            this.btnQuickStartCore.UseVisualStyleBackColor = true;
            this.btnQuickStartCore.Click += new System.EventHandler(this.btnQuickStartCore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 205);
            this.Controls.Add(this.grpQuickView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpLoadProject);
            this.Controls.Add(this.gbxDiskloader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SmartAppStarter";
            this.gbxDiskloader.ResumeLayout(false);
            this.gbxDiskloader.PerformLayout();
            this.grpLoadProject.ResumeLayout(false);
            this.grpLoadProject.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpQuickView.ResumeLayout(false);
            this.grpQuickView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadProjPath;
        private System.Windows.Forms.TextBox txtProjectPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnStartCoreDiskloader;
        private System.Windows.Forms.GroupBox gbxDiskloader;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtDi;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblDi;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblStatusPath;
        private System.Windows.Forms.GroupBox grpLoadProject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStartGui;
        private System.Windows.Forms.TextBox txtGuiPort;
        private System.Windows.Forms.TextBox txtGuiIp;
        private System.Windows.Forms.Label lblGuiPort;
        private System.Windows.Forms.Label lblGUIIP;
        private System.Windows.Forms.Button btnLoadCore;
        private System.Windows.Forms.Button btnSaveCore;
        private System.Windows.Forms.Button btnLoadGui;
        private System.Windows.Forms.Button btnSaveGui;
        private System.Windows.Forms.GroupBox grpQuickView;
        private System.Windows.Forms.Button btnQuickSwitch;
        private System.Windows.Forms.Button btnQuickStartGUI;
        private System.Windows.Forms.Button btnQuickStartCore;
        private System.Windows.Forms.Button btnSwitchToQuickView;
        private System.Windows.Forms.Button btnPathToBin;
        private System.Windows.Forms.Button btnOpenProj;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtComponent;
        private System.Windows.Forms.Button btnCompile;
        private System.Windows.Forms.TextBox txtMakepyCMD;
    }
}

