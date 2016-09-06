namespace NetStudio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLanguage = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assemblyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.BuildExeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildDllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.NewtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OpentoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SavetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RuntoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.StoptoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panelRight = new System.Windows.Forms.Panel();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.splitterLeftRight = new System.Windows.Forms.Splitter();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.splitterTopBottom = new System.Windows.Forms.Splitter();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.tabControlStatus = new System.Windows.Forms.TabControl();
            this.tabPageCompilerErrors = new System.Windows.Forms.TabPage();
            this.listViewCompilerErrors = new System.Windows.Forms.ListView();
            this.IndexCompilerErrorsColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MessageCompilerErrorsColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageRunTimeErrors = new System.Windows.Forms.TabPage();
            this.listViewRuntimeErrors = new System.Windows.Forms.ListView();
            this.indexRuntimeErrorsColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.messageRuntimeErrorsColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stackRuntimeErrorsColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.tabControlStatus.SuspendLayout();
            this.tabPageCompilerErrors.SuspendLayout();
            this.tabPageRunTimeErrors.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLanguage});
            this.statusStrip.Location = new System.Drawing.Point(0, 705);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1295, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelLanguage
            // 
            this.toolStripStatusLabelLanguage.Name = "toolStripStatusLabelLanguage";
            this.toolStripStatusLabelLanguage.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.assemblyToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1295, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripMenuItem1,
            this.openToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.ToolTipText = "Создать новый документ...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewOperation_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.ToolTipText = "Открыть документ...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenOperation_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(118, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.ToolTipText = "Сохранить документ";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveOperation_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.ToolTipText = "Сохранить документ как...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsOperation_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(118, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Выход из программы";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // assemblyToolStripMenuItem
            // 
            this.assemblyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripMenuItem5,
            this.BuildExeToolStripMenuItem,
            this.BuildDllToolStripMenuItem});
            this.assemblyToolStripMenuItem.Name = "assemblyToolStripMenuItem";
            this.assemblyToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.assemblyToolStripMenuItem.Text = "Build";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Enabled = false;
            this.runToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("runToolStripMenuItem.Image")));
            this.runToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.runToolStripMenuItem.Text = "Run...";
            this.runToolStripMenuItem.ToolTipText = "Выполнить программу...";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.RunOperation_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stopToolStripMenuItem.Image")));
            this.stopToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.ToolTipText = "Остановить выполнение программы";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.StopOperation_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(133, 6);
            // 
            // BuildExeToolStripMenuItem
            // 
            this.BuildExeToolStripMenuItem.Name = "BuildExeToolStripMenuItem";
            this.BuildExeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.BuildExeToolStripMenuItem.Text = "Create *.exe";
            this.BuildExeToolStripMenuItem.Click += new System.EventHandler(this.BuildExeToolStripMenuItem_Click);
            // 
            // BuildDllToolStripMenuItem
            // 
            this.BuildDllToolStripMenuItem.Name = "BuildDllToolStripMenuItem";
            this.BuildDllToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.BuildDllToolStripMenuItem.Text = "Create *.dll";
            this.BuildDllToolStripMenuItem.Click += new System.EventHandler(this.BuildDllToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.ToolTipText = "О проекте Coding Craft Studio";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewtoolStripButton,
            this.OpentoolStripButton,
            this.SavetoolStripButton,
            this.toolStripSeparator1,
            this.RefreshtoolStripButton,
            this.toolStripSeparator2,
            this.RuntoolStripButton,
            this.StoptoolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1295, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // NewtoolStripButton
            // 
            this.NewtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewtoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NewtoolStripButton.Image")));
            this.NewtoolStripButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.NewtoolStripButton.Name = "NewtoolStripButton";
            this.NewtoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.NewtoolStripButton.Text = "New File";
            this.NewtoolStripButton.Click += new System.EventHandler(this.NewOperation_Click);
            // 
            // OpentoolStripButton
            // 
            this.OpentoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpentoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OpentoolStripButton.Image")));
            this.OpentoolStripButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.OpentoolStripButton.Name = "OpentoolStripButton";
            this.OpentoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.OpentoolStripButton.Text = "Open...";
            this.OpentoolStripButton.Click += new System.EventHandler(this.OpenOperation_Click);
            // 
            // SavetoolStripButton
            // 
            this.SavetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SavetoolStripButton.Enabled = false;
            this.SavetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SavetoolStripButton.Image")));
            this.SavetoolStripButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.SavetoolStripButton.Name = "SavetoolStripButton";
            this.SavetoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SavetoolStripButton.Text = "Save...";
            this.SavetoolStripButton.Click += new System.EventHandler(this.saveOperation_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // RefreshtoolStripButton
            // 
            this.RefreshtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshtoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshtoolStripButton.Image")));
            this.RefreshtoolStripButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.RefreshtoolStripButton.Name = "RefreshtoolStripButton";
            this.RefreshtoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.RefreshtoolStripButton.Text = "Refresh Build";
            this.RefreshtoolStripButton.Click += new System.EventHandler(this.RefreshtoolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // RuntoolStripButton
            // 
            this.RuntoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RuntoolStripButton.Enabled = false;
            this.RuntoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RuntoolStripButton.Image")));
            this.RuntoolStripButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.RuntoolStripButton.Name = "RuntoolStripButton";
            this.RuntoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.RuntoolStripButton.Text = "Run...";
            this.RuntoolStripButton.Click += new System.EventHandler(this.RunOperation_Click);
            // 
            // StoptoolStripButton
            // 
            this.StoptoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StoptoolStripButton.Enabled = false;
            this.StoptoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("StoptoolStripButton.Image")));
            this.StoptoolStripButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.StoptoolStripButton.Name = "StoptoolStripButton";
            this.StoptoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.StoptoolStripButton.Text = "Stop";
            this.StoptoolStripButton.Click += new System.EventHandler(this.StopOperation_Click);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.propertyGrid);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1015, 49);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(280, 656);
            this.panelRight.TabIndex = 3;
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(280, 656);
            this.propertyGrid.TabIndex = 0;
            // 
            // splitterLeftRight
            // 
            this.splitterLeftRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterLeftRight.Location = new System.Drawing.Point(1010, 49);
            this.splitterLeftRight.Name = "splitterLeftRight";
            this.splitterLeftRight.Size = new System.Drawing.Size(5, 656);
            this.splitterLeftRight.TabIndex = 4;
            this.splitterLeftRight.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.panelMain);
            this.panelLeft.Controls.Add(this.splitterTopBottom);
            this.panelLeft.Controls.Add(this.panelBottom);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 49);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(1010, 656);
            this.panelLeft.TabIndex = 5;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.textBoxCode);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1010, 500);
            this.panelMain.TabIndex = 2;
            // 
            // textBoxCode
            // 
            this.textBoxCode.AcceptsReturn = true;
            this.textBoxCode.AcceptsTab = true;
            this.textBoxCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCode.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCode.Location = new System.Drawing.Point(0, 0);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCode.Size = new System.Drawing.Size(1010, 500);
            this.textBoxCode.TabIndex = 0;
            this.textBoxCode.TextChanged += new System.EventHandler(this.textBoxCode_TextChanged);
            // 
            // splitterTopBottom
            // 
            this.splitterTopBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterTopBottom.Location = new System.Drawing.Point(0, 500);
            this.splitterTopBottom.Name = "splitterTopBottom";
            this.splitterTopBottom.Size = new System.Drawing.Size(1010, 5);
            this.splitterTopBottom.TabIndex = 1;
            this.splitterTopBottom.TabStop = false;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.tabControlStatus);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 505);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1010, 151);
            this.panelBottom.TabIndex = 0;
            // 
            // tabControlStatus
            // 
            this.tabControlStatus.Controls.Add(this.tabPageCompilerErrors);
            this.tabControlStatus.Controls.Add(this.tabPageRunTimeErrors);
            this.tabControlStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStatus.Location = new System.Drawing.Point(0, 0);
            this.tabControlStatus.Name = "tabControlStatus";
            this.tabControlStatus.SelectedIndex = 0;
            this.tabControlStatus.Size = new System.Drawing.Size(1010, 151);
            this.tabControlStatus.TabIndex = 0;
            // 
            // tabPageCompilerErrors
            // 
            this.tabPageCompilerErrors.Controls.Add(this.listViewCompilerErrors);
            this.tabPageCompilerErrors.Location = new System.Drawing.Point(4, 22);
            this.tabPageCompilerErrors.Name = "tabPageCompilerErrors";
            this.tabPageCompilerErrors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompilerErrors.Size = new System.Drawing.Size(1002, 125);
            this.tabPageCompilerErrors.TabIndex = 0;
            this.tabPageCompilerErrors.Text = "Compile errors";
            this.tabPageCompilerErrors.UseVisualStyleBackColor = true;
            // 
            // listViewCompilerErrors
            // 
            this.listViewCompilerErrors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IndexCompilerErrorsColumnHeader,
            this.MessageCompilerErrorsColumnHeader});
            this.listViewCompilerErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCompilerErrors.FullRowSelect = true;
            this.listViewCompilerErrors.GridLines = true;
            this.listViewCompilerErrors.HideSelection = false;
            this.listViewCompilerErrors.Location = new System.Drawing.Point(3, 3);
            this.listViewCompilerErrors.Name = "listViewCompilerErrors";
            this.listViewCompilerErrors.Size = new System.Drawing.Size(996, 119);
            this.listViewCompilerErrors.TabIndex = 0;
            this.listViewCompilerErrors.UseCompatibleStateImageBehavior = false;
            this.listViewCompilerErrors.View = System.Windows.Forms.View.Details;
            this.listViewCompilerErrors.SelectedIndexChanged += new System.EventHandler(this.listViewCompilerErrors_SelectedIndexChanged);
            this.listViewCompilerErrors.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listViewCompilerErrors_MouseUp);
            // 
            // IndexCompilerErrorsColumnHeader
            // 
            this.IndexCompilerErrorsColumnHeader.Text = "";
            // 
            // MessageCompilerErrorsColumnHeader
            // 
            this.MessageCompilerErrorsColumnHeader.Text = "Description";
            this.MessageCompilerErrorsColumnHeader.Width = 500;
            // 
            // tabPageRunTimeErrors
            // 
            this.tabPageRunTimeErrors.Controls.Add(this.listViewRuntimeErrors);
            this.tabPageRunTimeErrors.Location = new System.Drawing.Point(4, 22);
            this.tabPageRunTimeErrors.Name = "tabPageRunTimeErrors";
            this.tabPageRunTimeErrors.Size = new System.Drawing.Size(1002, 125);
            this.tabPageRunTimeErrors.TabIndex = 1;
            this.tabPageRunTimeErrors.Text = "Run errors";
            this.tabPageRunTimeErrors.UseVisualStyleBackColor = true;
            // 
            // listViewRuntimeErrors
            // 
            this.listViewRuntimeErrors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.indexRuntimeErrorsColumnHeader,
            this.messageRuntimeErrorsColumnHeader,
            this.stackRuntimeErrorsColumnHeader});
            this.listViewRuntimeErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRuntimeErrors.FullRowSelect = true;
            this.listViewRuntimeErrors.GridLines = true;
            this.listViewRuntimeErrors.HideSelection = false;
            this.listViewRuntimeErrors.Location = new System.Drawing.Point(0, 0);
            this.listViewRuntimeErrors.Name = "listViewRuntimeErrors";
            this.listViewRuntimeErrors.Size = new System.Drawing.Size(1002, 125);
            this.listViewRuntimeErrors.TabIndex = 1;
            this.listViewRuntimeErrors.UseCompatibleStateImageBehavior = false;
            this.listViewRuntimeErrors.View = System.Windows.Forms.View.Details;
            // 
            // indexRuntimeErrorsColumnHeader
            // 
            this.indexRuntimeErrorsColumnHeader.Text = "";
            // 
            // messageRuntimeErrorsColumnHeader
            // 
            this.messageRuntimeErrorsColumnHeader.Text = "Description";
            this.messageRuntimeErrorsColumnHeader.Width = 500;
            // 
            // stackRuntimeErrorsColumnHeader
            // 
            this.stackRuntimeErrorsColumnHeader.Text = "Stack";
            this.stackRuntimeErrorsColumnHeader.Width = 250;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 727);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.splitterLeftRight);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Net Studio";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.tabControlStatus.ResumeLayout(false);
            this.tabPageCompilerErrors.ResumeLayout(false);
            this.tabPageRunTimeErrors.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Splitter splitterLeftRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Splitter splitterTopBottom;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TabControl tabControlStatus;
        private System.Windows.Forms.TabPage tabPageCompilerErrors;
        private System.Windows.Forms.ListView listViewCompilerErrors;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton NewtoolStripButton;
        private System.Windows.Forms.ToolStripButton OpentoolStripButton;
        private System.Windows.Forms.ToolStripButton SavetoolStripButton;
        private System.Windows.Forms.ToolStripMenuItem assemblyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RuntoolStripButton;
        private System.Windows.Forms.ColumnHeader IndexCompilerErrorsColumnHeader;
        private System.Windows.Forms.ColumnHeader MessageCompilerErrorsColumnHeader;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton StoptoolStripButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLanguage;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.TabPage tabPageRunTimeErrors;
        private System.Windows.Forms.ListView listViewRuntimeErrors;
        private System.Windows.Forms.ColumnHeader indexRuntimeErrorsColumnHeader;
        private System.Windows.Forms.ColumnHeader messageRuntimeErrorsColumnHeader;
        private System.Windows.Forms.ColumnHeader stackRuntimeErrorsColumnHeader;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem BuildExeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuildDllToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton RefreshtoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

