namespace MassSSH
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
            this.mnuTop = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileLatest = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScript = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScriptAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScriptEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScriptDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScriptRun = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScriptMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScriptMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHost = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHostAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHostEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHostDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHostMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHostMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpUse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ssBottom = new System.Windows.Forms.StatusStrip();
            this.tssBottom = new System.Windows.Forms.ToolStripStatusLabel();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.scContent = new System.Windows.Forms.SplitContainer();
            this.grpbxCommands = new System.Windows.Forms.GroupBox();
            this.txtCommands = new System.Windows.Forms.TextBox();
            this.grpbxOutput = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cmsOutput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsOutputClear = new System.Windows.Forms.ToolStripMenuItem();
            this.scLeft = new System.Windows.Forms.SplitContainer();
            this.grpbxScripts = new System.Windows.Forms.GroupBox();
            this.lstbxScripts = new System.Windows.Forms.ListBox();
            this.cmsScripts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsScriptAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsScriptEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsScriptDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsScriptRun = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsScriptMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsScriptMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.grpbxHosts = new System.Windows.Forms.GroupBox();
            this.lstbxHosts = new System.Windows.Forms.ListBox();
            this.cmsHost = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsHostAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsHostEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsHostDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsHostMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsHostMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdSaveAs = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.mnuTop.SuspendLayout();
            this.ssBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).BeginInit();
            this.scContent.Panel1.SuspendLayout();
            this.scContent.Panel2.SuspendLayout();
            this.scContent.SuspendLayout();
            this.grpbxCommands.SuspendLayout();
            this.grpbxOutput.SuspendLayout();
            this.cmsOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scLeft)).BeginInit();
            this.scLeft.Panel1.SuspendLayout();
            this.scLeft.Panel2.SuspendLayout();
            this.scLeft.SuspendLayout();
            this.grpbxScripts.SuspendLayout();
            this.cmsScripts.SuspendLayout();
            this.grpbxHosts.SuspendLayout();
            this.cmsHost.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuTop
            // 
            this.mnuTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuScript,
            this.mnuHost,
            this.mnuHelp});
            this.mnuTop.Location = new System.Drawing.Point(0, 0);
            this.mnuTop.Name = "mnuTop";
            this.mnuTop.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuTop.Size = new System.Drawing.Size(895, 28);
            this.mnuTop.TabIndex = 0;
            this.mnuTop.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.mnuFileLatest,
            this.mnuFileSeperator1,
            this.mnuFileClose});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(49, 24);
            this.mnuFile.Text = "Filer";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFileNew.Size = new System.Drawing.Size(246, 26);
            this.mnuFileNew.Text = "Ny";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFileOpen.Size = new System.Drawing.Size(246, 26);
            this.mnuFileOpen.Text = "Åbn...";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFileSave.Size = new System.Drawing.Size(246, 26);
            this.mnuFileSave.Text = "Gem";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mnuFileSaveAs.Size = new System.Drawing.Size(246, 26);
            this.mnuFileSaveAs.Text = "Gem som...";
            this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
            // 
            // mnuFileLatest
            // 
            this.mnuFileLatest.Name = "mnuFileLatest";
            this.mnuFileLatest.Size = new System.Drawing.Size(246, 26);
            this.mnuFileLatest.Text = "Seneste";
            this.mnuFileLatest.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuFileLatest_DropDownItemClicked);
            // 
            // mnuFileSeperator1
            // 
            this.mnuFileSeperator1.Name = "mnuFileSeperator1";
            this.mnuFileSeperator1.Size = new System.Drawing.Size(243, 6);
            // 
            // mnuFileClose
            // 
            this.mnuFileClose.Name = "mnuFileClose";
            this.mnuFileClose.Size = new System.Drawing.Size(246, 26);
            this.mnuFileClose.Text = "Afslut";
            this.mnuFileClose.Click += new System.EventHandler(this.mnuFileClose_Click);
            // 
            // mnuScript
            // 
            this.mnuScript.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuScriptAdd,
            this.mnuScriptEdit,
            this.mnuScriptDelete,
            this.mnuScriptRun,
            this.mnuScriptMoveUp,
            this.mnuScriptMoveDown});
            this.mnuScript.Name = "mnuScript";
            this.mnuScript.Size = new System.Drawing.Size(59, 24);
            this.mnuScript.Text = "Script";
            this.mnuScript.DropDownOpening += new System.EventHandler(this.mnuScript_DropDownOpening);
            // 
            // mnuScriptAdd
            // 
            this.mnuScriptAdd.Name = "mnuScriptAdd";
            this.mnuScriptAdd.Size = new System.Drawing.Size(147, 26);
            this.mnuScriptAdd.Text = "Nyt script";
            this.mnuScriptAdd.Click += new System.EventHandler(this.ScriptAdd);
            // 
            // mnuScriptEdit
            // 
            this.mnuScriptEdit.Name = "mnuScriptEdit";
            this.mnuScriptEdit.Size = new System.Drawing.Size(147, 26);
            this.mnuScriptEdit.Text = "Rediger";
            this.mnuScriptEdit.Click += new System.EventHandler(this.ScriptEdit);
            // 
            // mnuScriptDelete
            // 
            this.mnuScriptDelete.Name = "mnuScriptDelete";
            this.mnuScriptDelete.Size = new System.Drawing.Size(147, 26);
            this.mnuScriptDelete.Text = "Slet";
            this.mnuScriptDelete.Click += new System.EventHandler(this.ScriptDelete);
            // 
            // mnuScriptRun
            // 
            this.mnuScriptRun.Name = "mnuScriptRun";
            this.mnuScriptRun.Size = new System.Drawing.Size(147, 26);
            this.mnuScriptRun.Text = "Kør";
            this.mnuScriptRun.Click += new System.EventHandler(this.ScriptRun);
            // 
            // mnuScriptMoveUp
            // 
            this.mnuScriptMoveUp.Name = "mnuScriptMoveUp";
            this.mnuScriptMoveUp.Size = new System.Drawing.Size(147, 26);
            this.mnuScriptMoveUp.Text = "Flyt op";
            this.mnuScriptMoveUp.Click += new System.EventHandler(this.ScriptMoveUp);
            // 
            // mnuScriptMoveDown
            // 
            this.mnuScriptMoveDown.Name = "mnuScriptMoveDown";
            this.mnuScriptMoveDown.Size = new System.Drawing.Size(147, 26);
            this.mnuScriptMoveDown.Text = "Flyt ned";
            this.mnuScriptMoveDown.Click += new System.EventHandler(this.ScriptMoveDown);
            // 
            // mnuHost
            // 
            this.mnuHost.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHostAdd,
            this.mnuHostEdit,
            this.mnuHostDelete,
            this.mnuHostMoveUp,
            this.mnuHostMoveDown});
            this.mnuHost.Name = "mnuHost";
            this.mnuHost.Size = new System.Drawing.Size(52, 24);
            this.mnuHost.Text = "Host";
            this.mnuHost.DropDownOpening += new System.EventHandler(this.mnuHost_DropDownOpening);
            // 
            // mnuHostAdd
            // 
            this.mnuHostAdd.Name = "mnuHostAdd";
            this.mnuHostAdd.Size = new System.Drawing.Size(136, 26);
            this.mnuHostAdd.Text = "Ny host";
            this.mnuHostAdd.Click += new System.EventHandler(this.HostAdd);
            // 
            // mnuHostEdit
            // 
            this.mnuHostEdit.Name = "mnuHostEdit";
            this.mnuHostEdit.Size = new System.Drawing.Size(136, 26);
            this.mnuHostEdit.Text = "Rediger";
            this.mnuHostEdit.Click += new System.EventHandler(this.HostEdit);
            // 
            // mnuHostDelete
            // 
            this.mnuHostDelete.Name = "mnuHostDelete";
            this.mnuHostDelete.Size = new System.Drawing.Size(136, 26);
            this.mnuHostDelete.Text = "Slet";
            this.mnuHostDelete.Click += new System.EventHandler(this.HostDelete);
            // 
            // mnuHostMoveUp
            // 
            this.mnuHostMoveUp.Name = "mnuHostMoveUp";
            this.mnuHostMoveUp.Size = new System.Drawing.Size(136, 26);
            this.mnuHostMoveUp.Text = "Flyt op";
            this.mnuHostMoveUp.Click += new System.EventHandler(this.HostMoveUp);
            // 
            // mnuHostMoveDown
            // 
            this.mnuHostMoveDown.Name = "mnuHostMoveDown";
            this.mnuHostMoveDown.Size = new System.Drawing.Size(136, 26);
            this.mnuHostMoveDown.Text = "Flyt ned";
            this.mnuHostMoveDown.Click += new System.EventHandler(this.HostMoveDown);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpUse,
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(61, 24);
            this.mnuHelp.Text = "Hjælp";
            // 
            // mnuHelpUse
            // 
            this.mnuHelpUse.Name = "mnuHelpUse";
            this.mnuHelpUse.Size = new System.Drawing.Size(196, 26);
            this.mnuHelpUse.Text = "Brug af MassSSH";
            this.mnuHelpUse.Click += new System.EventHandler(this.mnuHelpUse_Click);
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(196, 26);
            this.mnuHelpAbout.Text = "Om...";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // ssBottom
            // 
            this.ssBottom.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssBottom});
            this.ssBottom.Location = new System.Drawing.Point(0, 588);
            this.ssBottom.Name = "ssBottom";
            this.ssBottom.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.ssBottom.Size = new System.Drawing.Size(895, 25);
            this.ssBottom.SizingGrip = false;
            this.ssBottom.TabIndex = 1;
            this.ssBottom.Text = "statusStrip1";
            // 
            // tssBottom
            // 
            this.tssBottom.Name = "tssBottom";
            this.tssBottom.Size = new System.Drawing.Size(76, 20);
            this.tssBottom.Text = "tssBottom";
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.IsSplitterFixed = true;
            this.scMain.Location = new System.Drawing.Point(0, 28);
            this.scMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.btnStop);
            this.scMain.Panel1.Controls.Add(this.lblPassword);
            this.scMain.Panel1.Controls.Add(this.txtPassword);
            this.scMain.Panel1.Controls.Add(this.lblUsername);
            this.scMain.Panel1.Controls.Add(this.txtUsername);
            this.scMain.Panel1.Controls.Add(this.btnRun);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scContent);
            this.scMain.Panel2.Controls.Add(this.scLeft);
            this.scMain.Size = new System.Drawing.Size(895, 560);
            this.scMain.SplitterDistance = 57;
            this.scMain.TabIndex = 2;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(377, 7);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(147, 42);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(117, 7);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(117, 28);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 10;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 7);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(82, 17);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Brugernavn";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 28);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 9;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(224, 7);
            this.btnRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(147, 42);
            this.btnRun.TabIndex = 11;
            this.btnRun.Text = "Kør";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // scContent
            // 
            this.scContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContent.Location = new System.Drawing.Point(149, 0);
            this.scContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scContent.Name = "scContent";
            // 
            // scContent.Panel1
            // 
            this.scContent.Panel1.Controls.Add(this.grpbxCommands);
            this.scContent.Panel1MinSize = 150;
            // 
            // scContent.Panel2
            // 
            this.scContent.Panel2.Controls.Add(this.grpbxOutput);
            this.scContent.Panel2MinSize = 150;
            this.scContent.Size = new System.Drawing.Size(746, 499);
            this.scContent.SplitterDistance = 343;
            this.scContent.TabIndex = 16;
            // 
            // grpbxCommands
            // 
            this.grpbxCommands.Controls.Add(this.txtCommands);
            this.grpbxCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbxCommands.Location = new System.Drawing.Point(0, 0);
            this.grpbxCommands.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxCommands.Name = "grpbxCommands";
            this.grpbxCommands.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxCommands.Size = new System.Drawing.Size(343, 499);
            this.grpbxCommands.TabIndex = 14;
            this.grpbxCommands.TabStop = false;
            this.grpbxCommands.Text = "Kommandoer";
            // 
            // txtCommands
            // 
            this.txtCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCommands.Enabled = false;
            this.txtCommands.Location = new System.Drawing.Point(3, 17);
            this.txtCommands.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCommands.Multiline = true;
            this.txtCommands.Name = "txtCommands";
            this.txtCommands.Size = new System.Drawing.Size(337, 480);
            this.txtCommands.TabIndex = 11;
            this.txtCommands.TextChanged += new System.EventHandler(this.txtCommands_TextChanged);
            // 
            // grpbxOutput
            // 
            this.grpbxOutput.Controls.Add(this.txtOutput);
            this.grpbxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbxOutput.Location = new System.Drawing.Point(0, 0);
            this.grpbxOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxOutput.Name = "grpbxOutput";
            this.grpbxOutput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxOutput.Size = new System.Drawing.Size(399, 499);
            this.grpbxOutput.TabIndex = 13;
            this.grpbxOutput.TabStop = false;
            this.grpbxOutput.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.ContextMenuStrip = this.cmsOutput;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(3, 17);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(393, 480);
            this.txtOutput.TabIndex = 5;
            // 
            // cmsOutput
            // 
            this.cmsOutput.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOutput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsOutputClear});
            this.cmsOutput.Name = "cmsOutput";
            this.cmsOutput.Size = new System.Drawing.Size(131, 30);
            // 
            // cmsOutputClear
            // 
            this.cmsOutputClear.Name = "cmsOutputClear";
            this.cmsOutputClear.Size = new System.Drawing.Size(130, 26);
            this.cmsOutputClear.Text = "Slet alt";
            this.cmsOutputClear.Click += new System.EventHandler(this.cmsOutputClear_Click);
            // 
            // scLeft
            // 
            this.scLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.scLeft.Location = new System.Drawing.Point(0, 0);
            this.scLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scLeft.Name = "scLeft";
            this.scLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scLeft.Panel1
            // 
            this.scLeft.Panel1.Controls.Add(this.grpbxScripts);
            this.scLeft.Panel1MinSize = 50;
            // 
            // scLeft.Panel2
            // 
            this.scLeft.Panel2.Controls.Add(this.grpbxHosts);
            this.scLeft.Panel2MinSize = 50;
            this.scLeft.Size = new System.Drawing.Size(149, 499);
            this.scLeft.SplitterDistance = 302;
            this.scLeft.TabIndex = 15;
            // 
            // grpbxScripts
            // 
            this.grpbxScripts.Controls.Add(this.lstbxScripts);
            this.grpbxScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbxScripts.Location = new System.Drawing.Point(0, 0);
            this.grpbxScripts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxScripts.Name = "grpbxScripts";
            this.grpbxScripts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxScripts.Size = new System.Drawing.Size(149, 302);
            this.grpbxScripts.TabIndex = 12;
            this.grpbxScripts.TabStop = false;
            this.grpbxScripts.Text = "Scripts";
            // 
            // lstbxScripts
            // 
            this.lstbxScripts.ContextMenuStrip = this.cmsScripts;
            this.lstbxScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbxScripts.FormattingEnabled = true;
            this.lstbxScripts.ItemHeight = 16;
            this.lstbxScripts.Location = new System.Drawing.Point(3, 17);
            this.lstbxScripts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbxScripts.Name = "lstbxScripts";
            this.lstbxScripts.Size = new System.Drawing.Size(143, 283);
            this.lstbxScripts.TabIndex = 10;
            this.lstbxScripts.SelectedIndexChanged += new System.EventHandler(this.lstbxScripts_SelectedIndexChanged);
            this.lstbxScripts.DoubleClick += new System.EventHandler(this.ScriptEdit);
            this.lstbxScripts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstbxScripts_MouseDown);
            // 
            // cmsScripts
            // 
            this.cmsScripts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsScripts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsScriptAdd,
            this.cmsScriptEdit,
            this.cmsScriptDelete,
            this.cmsScriptRun,
            this.cmsScriptMoveUp,
            this.cmsScriptMoveDown});
            this.cmsScripts.Name = "cmsScripts";
            this.cmsScripts.Size = new System.Drawing.Size(187, 160);
            this.cmsScripts.Opening += new System.ComponentModel.CancelEventHandler(this.cmsScripts_Opening);
            // 
            // cmsScriptAdd
            // 
            this.cmsScriptAdd.Name = "cmsScriptAdd";
            this.cmsScriptAdd.Size = new System.Drawing.Size(186, 26);
            this.cmsScriptAdd.Text = "Nyt script";
            this.cmsScriptAdd.Click += new System.EventHandler(this.ScriptAdd);
            // 
            // cmsScriptEdit
            // 
            this.cmsScriptEdit.Name = "cmsScriptEdit";
            this.cmsScriptEdit.Size = new System.Drawing.Size(186, 26);
            this.cmsScriptEdit.Text = "Rediger";
            this.cmsScriptEdit.Click += new System.EventHandler(this.ScriptEdit);
            // 
            // cmsScriptDelete
            // 
            this.cmsScriptDelete.Name = "cmsScriptDelete";
            this.cmsScriptDelete.Size = new System.Drawing.Size(186, 26);
            this.cmsScriptDelete.Text = "Slet";
            this.cmsScriptDelete.Click += new System.EventHandler(this.ScriptDelete);
            // 
            // cmsScriptRun
            // 
            this.cmsScriptRun.Name = "cmsScriptRun";
            this.cmsScriptRun.Size = new System.Drawing.Size(186, 26);
            this.cmsScriptRun.Text = "Kør dette script";
            this.cmsScriptRun.Click += new System.EventHandler(this.ScriptRun);
            // 
            // cmsScriptMoveUp
            // 
            this.cmsScriptMoveUp.Name = "cmsScriptMoveUp";
            this.cmsScriptMoveUp.Size = new System.Drawing.Size(186, 26);
            this.cmsScriptMoveUp.Text = "Flyt op";
            this.cmsScriptMoveUp.Click += new System.EventHandler(this.ScriptMoveUp);
            // 
            // cmsScriptMoveDown
            // 
            this.cmsScriptMoveDown.Name = "cmsScriptMoveDown";
            this.cmsScriptMoveDown.Size = new System.Drawing.Size(186, 26);
            this.cmsScriptMoveDown.Text = "Flyt ned";
            this.cmsScriptMoveDown.Click += new System.EventHandler(this.ScriptMoveDown);
            // 
            // grpbxHosts
            // 
            this.grpbxHosts.Controls.Add(this.lstbxHosts);
            this.grpbxHosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbxHosts.Location = new System.Drawing.Point(0, 0);
            this.grpbxHosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxHosts.Name = "grpbxHosts";
            this.grpbxHosts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxHosts.Size = new System.Drawing.Size(149, 193);
            this.grpbxHosts.TabIndex = 13;
            this.grpbxHosts.TabStop = false;
            this.grpbxHosts.Text = "Hosts";
            // 
            // lstbxHosts
            // 
            this.lstbxHosts.ContextMenuStrip = this.cmsHost;
            this.lstbxHosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbxHosts.FormattingEnabled = true;
            this.lstbxHosts.ItemHeight = 16;
            this.lstbxHosts.Location = new System.Drawing.Point(3, 17);
            this.lstbxHosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbxHosts.Name = "lstbxHosts";
            this.lstbxHosts.Size = new System.Drawing.Size(143, 174);
            this.lstbxHosts.TabIndex = 10;
            this.lstbxHosts.DoubleClick += new System.EventHandler(this.HostEdit);
            this.lstbxHosts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstbxHosts_MouseDown);
            // 
            // cmsHost
            // 
            this.cmsHost.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsHost.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsHostAdd,
            this.cmsHostEdit,
            this.cmsHostDelete,
            this.cmsHostMoveUp,
            this.cmsHostMoveDown});
            this.cmsHost.Name = "cmsHost";
            this.cmsHost.Size = new System.Drawing.Size(137, 134);
            this.cmsHost.Opening += new System.ComponentModel.CancelEventHandler(this.cmsHost_Opening);
            // 
            // cmsHostAdd
            // 
            this.cmsHostAdd.Name = "cmsHostAdd";
            this.cmsHostAdd.Size = new System.Drawing.Size(136, 26);
            this.cmsHostAdd.Text = "Ny host";
            this.cmsHostAdd.Click += new System.EventHandler(this.HostAdd);
            // 
            // cmsHostEdit
            // 
            this.cmsHostEdit.Name = "cmsHostEdit";
            this.cmsHostEdit.Size = new System.Drawing.Size(136, 26);
            this.cmsHostEdit.Text = "Rediger";
            this.cmsHostEdit.Click += new System.EventHandler(this.HostEdit);
            // 
            // cmsHostDelete
            // 
            this.cmsHostDelete.Name = "cmsHostDelete";
            this.cmsHostDelete.Size = new System.Drawing.Size(136, 26);
            this.cmsHostDelete.Text = "Slet";
            this.cmsHostDelete.Click += new System.EventHandler(this.HostDelete);
            // 
            // cmsHostMoveUp
            // 
            this.cmsHostMoveUp.Name = "cmsHostMoveUp";
            this.cmsHostMoveUp.Size = new System.Drawing.Size(136, 26);
            this.cmsHostMoveUp.Text = "Flyt op";
            this.cmsHostMoveUp.Click += new System.EventHandler(this.HostMoveUp);
            // 
            // cmsHostMoveDown
            // 
            this.cmsHostMoveDown.Name = "cmsHostMoveDown";
            this.cmsHostMoveDown.Size = new System.Drawing.Size(136, 26);
            this.cmsHostMoveDown.Text = "Flyt ned";
            this.cmsHostMoveDown.Click += new System.EventHandler(this.HostMoveDown);
            // 
            // sfdSaveAs
            // 
            this.sfdSaveAs.FileName = "*.msh";
            // 
            // ofdOpen
            // 
            this.ofdOpen.FileName = "Script.msh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 613);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.ssBottom);
            this.Controls.Add(this.mnuTop);
            this.MainMenuStrip = this.mnuTop;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(599, 298);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "MassSSH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            this.mnuTop.ResumeLayout(false);
            this.mnuTop.PerformLayout();
            this.ssBottom.ResumeLayout(false);
            this.ssBottom.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scContent.Panel1.ResumeLayout(false);
            this.scContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).EndInit();
            this.scContent.ResumeLayout(false);
            this.grpbxCommands.ResumeLayout(false);
            this.grpbxCommands.PerformLayout();
            this.grpbxOutput.ResumeLayout(false);
            this.grpbxOutput.PerformLayout();
            this.cmsOutput.ResumeLayout(false);
            this.scLeft.Panel1.ResumeLayout(false);
            this.scLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scLeft)).EndInit();
            this.scLeft.ResumeLayout(false);
            this.grpbxScripts.ResumeLayout(false);
            this.cmsScripts.ResumeLayout(false);
            this.grpbxHosts.ResumeLayout(false);
            this.cmsHost.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuTop;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.StatusStrip ssBottom;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ListBox lstbxScripts;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.SaveFileDialog sfdSaveAs;
        private System.Windows.Forms.ToolStripStatusLabel tssBottom;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.TextBox txtCommands;
        private System.Windows.Forms.GroupBox grpbxScripts;
        private System.Windows.Forms.GroupBox grpbxOutput;
        private System.Windows.Forms.GroupBox grpbxCommands;
        private System.Windows.Forms.GroupBox grpbxHosts;
        private System.Windows.Forms.ListBox lstbxHosts;
        private System.Windows.Forms.SplitContainer scLeft;
        private System.Windows.Forms.SplitContainer scContent;
        private System.Windows.Forms.ToolStripMenuItem mnuScript;
        private System.Windows.Forms.ContextMenuStrip cmsHost;
        private System.Windows.Forms.ToolStripMenuItem mnuHost;
        private System.Windows.Forms.ToolStripMenuItem mnuHostEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuHostDelete;
        private System.Windows.Forms.ContextMenuStrip cmsScripts;
        private System.Windows.Forms.ToolStripMenuItem cmsScriptEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsScriptDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuHostAdd;
        private System.Windows.Forms.ToolStripMenuItem cmsHostDelete;
        private System.Windows.Forms.ToolStripMenuItem cmsHostEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuScriptAdd;
        private System.Windows.Forms.ContextMenuStrip cmsOutput;
        private System.Windows.Forms.ToolStripMenuItem cmsOutputClear;
        private System.Windows.Forms.ToolStripMenuItem cmsScriptAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuScriptEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuScriptDelete;
        private System.Windows.Forms.ToolStripMenuItem cmsHostAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileLatest;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClose;
        private System.Windows.Forms.ToolStripSeparator mnuFileSeperator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ToolStripMenuItem cmsScriptRun;
        private System.Windows.Forms.ToolStripMenuItem mnuScriptRun;
        private System.Windows.Forms.ToolStripMenuItem cmsScriptMoveUp;
        private System.Windows.Forms.ToolStripMenuItem cmsScriptMoveDown;
        private System.Windows.Forms.ToolStripMenuItem mnuScriptMoveUp;
        private System.Windows.Forms.ToolStripMenuItem mnuScriptMoveDown;
        private System.Windows.Forms.ToolStripMenuItem cmsHostMoveUp;
        private System.Windows.Forms.ToolStripMenuItem cmsHostMoveDown;
        private System.Windows.Forms.ToolStripMenuItem mnuHostMoveUp;
        private System.Windows.Forms.ToolStripMenuItem mnuHostMoveDown;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpUse;
    }
}

