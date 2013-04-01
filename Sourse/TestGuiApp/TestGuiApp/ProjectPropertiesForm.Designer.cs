namespace TestGuiApp
{
    partial class ProjectPropertiesForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.checkBoxUseLast = new System.Windows.Forms.CheckBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.openFileDialogOpenProjectTemplate = new System.Windows.Forms.OpenFileDialog();
            this.tabPageTemplate = new System.Windows.Forms.TabPage();
            this.checkBoxOpenFile = new System.Windows.Forms.CheckBox();
            this.checkBoxSetAsStartUp = new System.Windows.Forms.CheckBox();
            this.labelLastUsed0 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxUnitCaseName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUnitSuitName = new System.Windows.Forms.TextBox();
            this.textBoxProjSourcesPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonOpenProjSourcesPath = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUnitFileName = new System.Windows.Forms.TextBox();
            this.buttonOpenUnitFileLocation = new System.Windows.Forms.Button();
            this.textBoxUnitFileLocation = new System.Windows.Forms.TextBox();
            this.textBoxUnitFileTemplate = new System.Windows.Forms.TextBox();
            this.textBoxProjectLocation = new System.Windows.Forms.TextBox();
            this.textBoxProjectTemplate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOpenUnitFileTemplate = new System.Windows.Forms.Button();
            this.buttonOpenProjectLocation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpenProjectTemplate = new System.Windows.Forms.Button();
            this.tabPageLibs = new System.Windows.Forms.TabPage();
            this.labelLastUsed3 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBuilderLibPath = new SVControls.ListBuilder();
            this.listBuilderLibs = new SVControls.ListBuilder();
            this.tabPageMacroses = new System.Windows.Forms.TabPage();
            this.labelLastUsed2 = new System.Windows.Forms.Label();
            this.listBuilderMacroses = new SVControls.ListBuilder();
            this.tabPageIncludePath = new System.Windows.Forms.TabPage();
            this.labelLastUsed1 = new System.Windows.Forms.Label();
            this.listBuilderInclPath = new SVControls.ListBuilder();
            this.tabControlProjProp = new System.Windows.Forms.TabControl();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialogOpenFileTemplate = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.tabPageTemplate.SuspendLayout();
            this.tabPageLibs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPageMacroses.SuspendLayout();
            this.tabPageIncludePath.SuspendLayout();
            this.tabControlProjProp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Controls.Add(this.buttonOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 364);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 32);
            this.panel2.TabIndex = 8;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(3, 2);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 24);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(493, 2);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(90, 24);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseLast
            // 
            this.checkBoxUseLast.AutoSize = true;
            this.checkBoxUseLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUseLast.Location = new System.Drawing.Point(376, 16);
            this.checkBoxUseLast.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxUseLast.Name = "checkBoxUseLast";
            this.checkBoxUseLast.Size = new System.Drawing.Size(168, 17);
            this.checkBoxUseLast.TabIndex = 3;
            this.checkBoxUseLast.Text = "Use settings of the last project";
            this.checkBoxUseLast.UseVisualStyleBackColor = true;
            this.checkBoxUseLast.CheckedChanged += new System.EventHandler(this.checkBoxUseLast_CheckedChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 143);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 24);
            this.button7.TabIndex = 4;
            this.button7.Text = ">>";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 233);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 24);
            this.button8.TabIndex = 5;
            this.button8.Text = "<<";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 173);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(36, 24);
            this.button9.TabIndex = 1;
            this.button9.Text = ">";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 203);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(36, 24);
            this.button10.TabIndex = 2;
            this.button10.Text = "<";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // openFileDialogOpenProjectTemplate
            // 
            this.openFileDialogOpenProjectTemplate.DefaultExt = "*.vcxproj";
            this.openFileDialogOpenProjectTemplate.Filter = "VC Project files|*.vcxproj";
            // 
            // tabPageTemplate
            // 
            this.tabPageTemplate.Controls.Add(this.checkBoxOpenFile);
            this.tabPageTemplate.Controls.Add(this.checkBoxSetAsStartUp);
            this.tabPageTemplate.Controls.Add(this.checkBoxUseLast);
            this.tabPageTemplate.Controls.Add(this.labelLastUsed0);
            this.tabPageTemplate.Controls.Add(this.label8);
            this.tabPageTemplate.Controls.Add(this.textBoxUnitCaseName);
            this.tabPageTemplate.Controls.Add(this.label7);
            this.tabPageTemplate.Controls.Add(this.textBoxUnitSuitName);
            this.tabPageTemplate.Controls.Add(this.textBoxProjSourcesPath);
            this.tabPageTemplate.Controls.Add(this.label6);
            this.tabPageTemplate.Controls.Add(this.buttonOpenProjSourcesPath);
            this.tabPageTemplate.Controls.Add(this.label5);
            this.tabPageTemplate.Controls.Add(this.textBoxUnitFileName);
            this.tabPageTemplate.Controls.Add(this.buttonOpenUnitFileLocation);
            this.tabPageTemplate.Controls.Add(this.textBoxUnitFileLocation);
            this.tabPageTemplate.Controls.Add(this.textBoxUnitFileTemplate);
            this.tabPageTemplate.Controls.Add(this.textBoxProjectLocation);
            this.tabPageTemplate.Controls.Add(this.textBoxProjectTemplate);
            this.tabPageTemplate.Controls.Add(this.label2);
            this.tabPageTemplate.Controls.Add(this.label4);
            this.tabPageTemplate.Controls.Add(this.buttonOpenUnitFileTemplate);
            this.tabPageTemplate.Controls.Add(this.buttonOpenProjectLocation);
            this.tabPageTemplate.Controls.Add(this.label3);
            this.tabPageTemplate.Controls.Add(this.label1);
            this.tabPageTemplate.Controls.Add(this.buttonOpenProjectTemplate);
            this.tabPageTemplate.Location = new System.Drawing.Point(4, 22);
            this.tabPageTemplate.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageTemplate.Name = "tabPageTemplate";
            this.tabPageTemplate.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageTemplate.Size = new System.Drawing.Size(578, 338);
            this.tabPageTemplate.TabIndex = 3;
            this.tabPageTemplate.Text = "ProjectTemplate";
            this.tabPageTemplate.UseVisualStyleBackColor = true;
            // 
            // checkBoxOpenFile
            // 
            this.checkBoxOpenFile.AutoSize = true;
            this.checkBoxOpenFile.Checked = true;
            this.checkBoxOpenFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOpenFile.Location = new System.Drawing.Point(376, 73);
            this.checkBoxOpenFile.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOpenFile.Name = "checkBoxOpenFile";
            this.checkBoxOpenFile.Size = new System.Drawing.Size(133, 17);
            this.checkBoxOpenFile.TabIndex = 35;
            this.checkBoxOpenFile.Text = "Open file after creation";
            this.checkBoxOpenFile.UseVisualStyleBackColor = true;
            // 
            // checkBoxSetAsStartUp
            // 
            this.checkBoxSetAsStartUp.AutoSize = true;
            this.checkBoxSetAsStartUp.Checked = true;
            this.checkBoxSetAsStartUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSetAsStartUp.Location = new System.Drawing.Point(376, 45);
            this.checkBoxSetAsStartUp.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxSetAsStartUp.Name = "checkBoxSetAsStartUp";
            this.checkBoxSetAsStartUp.Size = new System.Drawing.Size(129, 17);
            this.checkBoxSetAsStartUp.TabIndex = 34;
            this.checkBoxSetAsStartUp.Text = "Set as start up project";
            this.checkBoxSetAsStartUp.UseVisualStyleBackColor = true;
            // 
            // labelLastUsed0
            // 
            this.labelLastUsed0.AutoSize = true;
            this.labelLastUsed0.Location = new System.Drawing.Point(16, 112);
            this.labelLastUsed0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastUsed0.Name = "labelLastUsed0";
            this.labelLastUsed0.Size = new System.Drawing.Size(145, 13);
            this.labelLastUsed0.TabIndex = 33;
            this.labelLastUsed0.Text = "The last project settings used";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(17, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Case name";
            this.label8.Visible = false;
            // 
            // textBoxUnitCaseName
            // 
            this.textBoxUnitCaseName.AutoCompleteCustomSource.AddRange(new string[] {
            "Test",
            "test",
            "Unit",
            "unit"});
            this.textBoxUnitCaseName.Location = new System.Drawing.Point(103, 74);
            this.textBoxUnitCaseName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUnitCaseName.Name = "textBoxUnitCaseName";
            this.textBoxUnitCaseName.Size = new System.Drawing.Size(166, 20);
            this.textBoxUnitCaseName.TabIndex = 31;
            this.textBoxUnitCaseName.Visible = false;
            this.textBoxUnitCaseName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxUnitCaseName_MouseMove);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(17, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Suit name";
            this.label7.Visible = false;
            // 
            // textBoxUnitSuitName
            // 
            this.textBoxUnitSuitName.AutoCompleteCustomSource.AddRange(new string[] {
            "Test",
            "test",
            "Unit",
            "unit"});
            this.textBoxUnitSuitName.Location = new System.Drawing.Point(103, 46);
            this.textBoxUnitSuitName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUnitSuitName.Name = "textBoxUnitSuitName";
            this.textBoxUnitSuitName.Size = new System.Drawing.Size(166, 20);
            this.textBoxUnitSuitName.TabIndex = 29;
            this.textBoxUnitSuitName.Visible = false;
            this.textBoxUnitSuitName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxUnitSuitName_MouseMove);
            // 
            // textBoxProjSourcesPath
            // 
            this.textBoxProjSourcesPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProjSourcesPath.Location = new System.Drawing.Point(19, 128);
            this.textBoxProjSourcesPath.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProjSourcesPath.Name = "textBoxProjSourcesPath";
            this.textBoxProjSourcesPath.Size = new System.Drawing.Size(518, 20);
            this.textBoxProjSourcesPath.TabIndex = 26;
            this.textBoxProjSourcesPath.TabStop = false;
            this.textBoxProjSourcesPath.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxProjSourcesPath_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Main project sources path";
            // 
            // buttonOpenProjSourcesPath
            // 
            this.buttonOpenProjSourcesPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenProjSourcesPath.Location = new System.Drawing.Point(541, 128);
            this.buttonOpenProjSourcesPath.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenProjSourcesPath.Name = "buttonOpenProjSourcesPath";
            this.buttonOpenProjSourcesPath.Size = new System.Drawing.Size(25, 19);
            this.buttonOpenProjSourcesPath.TabIndex = 27;
            this.buttonOpenProjSourcesPath.Text = "...";
            this.buttonOpenProjSourcesPath.UseVisualStyleBackColor = true;
            this.buttonOpenProjSourcesPath.Click += new System.EventHandler(this.buttonOpenProjSourcesPath_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Unit file name";
            // 
            // textBoxUnitFileName
            // 
            this.textBoxUnitFileName.AutoCompleteCustomSource.AddRange(new string[] {
            "Test",
            "test",
            "Unit",
            "unit"});
            this.textBoxUnitFileName.Location = new System.Drawing.Point(103, 17);
            this.textBoxUnitFileName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUnitFileName.Name = "textBoxUnitFileName";
            this.textBoxUnitFileName.Size = new System.Drawing.Size(166, 20);
            this.textBoxUnitFileName.TabIndex = 0;
            this.textBoxUnitFileName.TextChanged += new System.EventHandler(this.textBoxUnitFileName_TextChanged);
            this.textBoxUnitFileName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUnitName_KeyDown);
            this.textBoxUnitFileName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxUnitFileName_MouseMove);
            // 
            // buttonOpenUnitFileLocation
            // 
            this.buttonOpenUnitFileLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenUnitFileLocation.Location = new System.Drawing.Point(542, 301);
            this.buttonOpenUnitFileLocation.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenUnitFileLocation.Name = "buttonOpenUnitFileLocation";
            this.buttonOpenUnitFileLocation.Size = new System.Drawing.Size(25, 19);
            this.buttonOpenUnitFileLocation.TabIndex = 6;
            this.buttonOpenUnitFileLocation.Text = "...";
            this.buttonOpenUnitFileLocation.UseVisualStyleBackColor = true;
            this.buttonOpenUnitFileLocation.Click += new System.EventHandler(this.buttonOpenUnitFileLocation_Click);
            // 
            // textBoxUnitFileLocation
            // 
            this.textBoxUnitFileLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUnitFileLocation.Location = new System.Drawing.Point(20, 301);
            this.textBoxUnitFileLocation.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUnitFileLocation.Name = "textBoxUnitFileLocation";
            this.textBoxUnitFileLocation.Size = new System.Drawing.Size(518, 20);
            this.textBoxUnitFileLocation.TabIndex = 14;
            this.textBoxUnitFileLocation.TabStop = false;
            this.textBoxUnitFileLocation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxUnitFileLocation_MouseMove);
            // 
            // textBoxUnitFileTemplate
            // 
            this.textBoxUnitFileTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUnitFileTemplate.Location = new System.Drawing.Point(20, 264);
            this.textBoxUnitFileTemplate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUnitFileTemplate.Name = "textBoxUnitFileTemplate";
            this.textBoxUnitFileTemplate.Size = new System.Drawing.Size(518, 20);
            this.textBoxUnitFileTemplate.TabIndex = 10;
            this.textBoxUnitFileTemplate.TabStop = false;
            this.textBoxUnitFileTemplate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxUnitFileTemplate_MouseMove);
            // 
            // textBoxProjectLocation
            // 
            this.textBoxProjectLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProjectLocation.Location = new System.Drawing.Point(20, 216);
            this.textBoxProjectLocation.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProjectLocation.Name = "textBoxProjectLocation";
            this.textBoxProjectLocation.Size = new System.Drawing.Size(518, 20);
            this.textBoxProjectLocation.TabIndex = 8;
            this.textBoxProjectLocation.TabStop = false;
            this.textBoxProjectLocation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxProjectLocation_MouseMove);
            // 
            // textBoxProjectTemplate
            // 
            this.textBoxProjectTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProjectTemplate.Location = new System.Drawing.Point(20, 179);
            this.textBoxProjectTemplate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProjectTemplate.Name = "textBoxProjectTemplate";
            this.textBoxProjectTemplate.Size = new System.Drawing.Size(518, 20);
            this.textBoxProjectTemplate.TabIndex = 0;
            this.textBoxProjectTemplate.TabStop = false;
            this.textBoxProjectTemplate.TextChanged += new System.EventHandler(this.textBoxProjectTemplate_TextChanged);
            this.textBoxProjectTemplate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBoxProjectTemplate_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 285);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Unit file location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Unit file template";
            // 
            // buttonOpenUnitFileTemplate
            // 
            this.buttonOpenUnitFileTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenUnitFileTemplate.Location = new System.Drawing.Point(542, 263);
            this.buttonOpenUnitFileTemplate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenUnitFileTemplate.Name = "buttonOpenUnitFileTemplate";
            this.buttonOpenUnitFileTemplate.Size = new System.Drawing.Size(25, 19);
            this.buttonOpenUnitFileTemplate.TabIndex = 5;
            this.buttonOpenUnitFileTemplate.Text = "...";
            this.buttonOpenUnitFileTemplate.UseVisualStyleBackColor = true;
            this.buttonOpenUnitFileTemplate.Click += new System.EventHandler(this.buttonOpenUnitFileTemplate_Click);
            // 
            // buttonOpenProjectLocation
            // 
            this.buttonOpenProjectLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenProjectLocation.Location = new System.Drawing.Point(542, 215);
            this.buttonOpenProjectLocation.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenProjectLocation.Name = "buttonOpenProjectLocation";
            this.buttonOpenProjectLocation.Size = new System.Drawing.Size(25, 19);
            this.buttonOpenProjectLocation.TabIndex = 4;
            this.buttonOpenProjectLocation.Text = "...";
            this.buttonOpenProjectLocation.UseVisualStyleBackColor = true;
            this.buttonOpenProjectLocation.Click += new System.EventHandler(this.buttonOpenProjectLocation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Project location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Project template";
            // 
            // buttonOpenProjectTemplate
            // 
            this.buttonOpenProjectTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenProjectTemplate.Location = new System.Drawing.Point(542, 178);
            this.buttonOpenProjectTemplate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenProjectTemplate.Name = "buttonOpenProjectTemplate";
            this.buttonOpenProjectTemplate.Size = new System.Drawing.Size(25, 19);
            this.buttonOpenProjectTemplate.TabIndex = 3;
            this.buttonOpenProjectTemplate.Text = "...";
            this.buttonOpenProjectTemplate.UseVisualStyleBackColor = true;
            this.buttonOpenProjectTemplate.Click += new System.EventHandler(this.buttonOpenProjectTemplate_Click);
            // 
            // tabPageLibs
            // 
            this.tabPageLibs.Controls.Add(this.labelLastUsed3);
            this.tabPageLibs.Controls.Add(this.splitContainer1);
            this.tabPageLibs.Location = new System.Drawing.Point(4, 22);
            this.tabPageLibs.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageLibs.Name = "tabPageLibs";
            this.tabPageLibs.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageLibs.Size = new System.Drawing.Size(578, 338);
            this.tabPageLibs.TabIndex = 2;
            this.tabPageLibs.Text = "Library";
            this.tabPageLibs.UseVisualStyleBackColor = true;
            // 
            // labelLastUsed3
            // 
            this.labelLastUsed3.AutoSize = true;
            this.labelLastUsed3.Location = new System.Drawing.Point(24, 26);
            this.labelLastUsed3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastUsed3.Name = "labelLastUsed3";
            this.labelLastUsed3.Size = new System.Drawing.Size(145, 13);
            this.labelLastUsed3.TabIndex = 34;
            this.labelLastUsed3.Text = "The last project settings used";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBuilderLibPath);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBuilderLibs);
            this.splitContainer1.Size = new System.Drawing.Size(574, 334);
            this.splitContainer1.SplitterDistance = 164;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBuilderLibPath
            // 
            this.listBuilderLibPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBuilderLibPath.Location = new System.Drawing.Point(0, 0);
            this.listBuilderLibPath.Margin = new System.Windows.Forms.Padding(2);
            this.listBuilderLibPath.MinimumSize = new System.Drawing.Size(240, 146);
            this.listBuilderLibPath.Name = "listBuilderLibPath";
            this.listBuilderLibPath.Size = new System.Drawing.Size(574, 164);
            this.listBuilderLibPath.TabIndex = 0;
            // 
            // listBuilderLibs
            // 
            this.listBuilderLibs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBuilderLibs.Location = new System.Drawing.Point(0, 0);
            this.listBuilderLibs.Margin = new System.Windows.Forms.Padding(2);
            this.listBuilderLibs.MinimumSize = new System.Drawing.Size(240, 146);
            this.listBuilderLibs.Name = "listBuilderLibs";
            this.listBuilderLibs.Size = new System.Drawing.Size(574, 167);
            this.listBuilderLibs.TabIndex = 0;
            this.listBuilderLibs.Visible = false;
            // 
            // tabPageMacroses
            // 
            this.tabPageMacroses.Controls.Add(this.labelLastUsed2);
            this.tabPageMacroses.Controls.Add(this.listBuilderMacroses);
            this.tabPageMacroses.Location = new System.Drawing.Point(4, 22);
            this.tabPageMacroses.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageMacroses.Name = "tabPageMacroses";
            this.tabPageMacroses.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageMacroses.Size = new System.Drawing.Size(578, 338);
            this.tabPageMacroses.TabIndex = 1;
            this.tabPageMacroses.Text = "Macros Definitions";
            this.tabPageMacroses.UseVisualStyleBackColor = true;
            // 
            // labelLastUsed2
            // 
            this.labelLastUsed2.AutoSize = true;
            this.labelLastUsed2.Location = new System.Drawing.Point(24, 26);
            this.labelLastUsed2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastUsed2.Name = "labelLastUsed2";
            this.labelLastUsed2.Size = new System.Drawing.Size(145, 13);
            this.labelLastUsed2.TabIndex = 34;
            this.labelLastUsed2.Text = "The last project settings used";
            // 
            // listBuilderMacroses
            // 
            this.listBuilderMacroses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBuilderMacroses.Location = new System.Drawing.Point(2, 2);
            this.listBuilderMacroses.Margin = new System.Windows.Forms.Padding(2);
            this.listBuilderMacroses.MinimumSize = new System.Drawing.Size(240, 195);
            this.listBuilderMacroses.Name = "listBuilderMacroses";
            this.listBuilderMacroses.Size = new System.Drawing.Size(574, 334);
            this.listBuilderMacroses.TabIndex = 0;
            // 
            // tabPageIncludePath
            // 
            this.tabPageIncludePath.Controls.Add(this.labelLastUsed1);
            this.tabPageIncludePath.Controls.Add(this.listBuilderInclPath);
            this.tabPageIncludePath.Location = new System.Drawing.Point(4, 22);
            this.tabPageIncludePath.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageIncludePath.Name = "tabPageIncludePath";
            this.tabPageIncludePath.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageIncludePath.Size = new System.Drawing.Size(578, 338);
            this.tabPageIncludePath.TabIndex = 0;
            this.tabPageIncludePath.Text = "Additional Include Paths";
            this.tabPageIncludePath.UseVisualStyleBackColor = true;
            // 
            // labelLastUsed1
            // 
            this.labelLastUsed1.AutoSize = true;
            this.labelLastUsed1.Location = new System.Drawing.Point(24, 26);
            this.labelLastUsed1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastUsed1.Name = "labelLastUsed1";
            this.labelLastUsed1.Size = new System.Drawing.Size(145, 13);
            this.labelLastUsed1.TabIndex = 34;
            this.labelLastUsed1.Text = "The last project settings used";
            // 
            // listBuilderInclPath
            // 
            this.listBuilderInclPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBuilderInclPath.Location = new System.Drawing.Point(2, 2);
            this.listBuilderInclPath.Margin = new System.Windows.Forms.Padding(2);
            this.listBuilderInclPath.MinimumSize = new System.Drawing.Size(240, 195);
            this.listBuilderInclPath.Name = "listBuilderInclPath";
            this.listBuilderInclPath.Size = new System.Drawing.Size(574, 334);
            this.listBuilderInclPath.TabIndex = 0;
            // 
            // tabControlProjProp
            // 
            this.tabControlProjProp.Controls.Add(this.tabPageTemplate);
            this.tabControlProjProp.Controls.Add(this.tabPageIncludePath);
            this.tabControlProjProp.Controls.Add(this.tabPageMacroses);
            this.tabControlProjProp.Controls.Add(this.tabPageLibs);
            this.tabControlProjProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlProjProp.Location = new System.Drawing.Point(0, 0);
            this.tabControlProjProp.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlProjProp.Name = "tabControlProjProp";
            this.tabControlProjProp.SelectedIndex = 0;
            this.tabControlProjProp.Size = new System.Drawing.Size(586, 364);
            this.tabControlProjProp.TabIndex = 9;
            // 
            // openFileDialogOpenFileTemplate
            // 
            this.openFileDialogOpenFileTemplate.DefaultExt = "*.cpp";
            this.openFileDialogOpenFileTemplate.Filter = "C++ source files|*.cpp";
            // 
            // ProjectPropertiesForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(586, 396);
            this.Controls.Add(this.tabControlProjProp);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectPropertiesForm";
            this.ShowIcon = false;
            this.Text = "Project Properties Form";
            this.panel2.ResumeLayout(false);
            this.tabPageTemplate.ResumeLayout(false);
            this.tabPageTemplate.PerformLayout();
            this.tabPageLibs.ResumeLayout(false);
            this.tabPageLibs.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPageMacroses.ResumeLayout(false);
            this.tabPageMacroses.PerformLayout();
            this.tabPageIncludePath.ResumeLayout(false);
            this.tabPageIncludePath.PerformLayout();
            this.tabControlProjProp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.OpenFileDialog openFileDialogOpenProjectTemplate;
        private System.Windows.Forms.TabPage tabPageTemplate;
        private System.Windows.Forms.Button buttonOpenUnitFileLocation;
        private System.Windows.Forms.TextBox textBoxUnitFileLocation;
        private System.Windows.Forms.TextBox textBoxUnitFileTemplate;
        private System.Windows.Forms.TextBox textBoxProjectLocation;
        private System.Windows.Forms.TextBox textBoxProjectTemplate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOpenUnitFileTemplate;
        private System.Windows.Forms.Button buttonOpenProjectLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOpenProjectTemplate;
        private System.Windows.Forms.TabPage tabPageLibs;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private SVControls.ListBuilder listBuilderLibPath;
        private SVControls.ListBuilder listBuilderLibs;
        private System.Windows.Forms.TabPage tabPageMacroses;
        private SVControls.ListBuilder listBuilderMacroses;
        private System.Windows.Forms.TabPage tabPageIncludePath;
        private SVControls.ListBuilder listBuilderInclPath;
        private System.Windows.Forms.TabControl tabControlProjProp;
        private System.Windows.Forms.TextBox textBoxUnitFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxProjSourcesPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonOpenProjSourcesPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxUnitCaseName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUnitSuitName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox checkBoxUseLast;
        private System.Windows.Forms.Label labelLastUsed0;
        private System.Windows.Forms.OpenFileDialog openFileDialogOpenFileTemplate;
        private System.Windows.Forms.CheckBox checkBoxSetAsStartUp;
        private System.Windows.Forms.CheckBox checkBoxOpenFile;
        private System.Windows.Forms.Label labelLastUsed3;
        private System.Windows.Forms.Label labelLastUsed2;
        private System.Windows.Forms.Label labelLastUsed1;
    }
}