namespace TestGuiApp
{
    partial class MWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MWin));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCreateTestProject = new System.Windows.Forms.ToolStripButton();
            this.AddTestSuiteButton = new System.Windows.Forms.ToolStripButton();
            this.AddTestButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRunCurrent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CleanTestsResultsButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.extendedTree1 = new SVControls.ExtendedTree();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshButton,
            this.toolStripSeparator3,
            this.toolStripButtonCreateTestProject,
            this.AddTestSuiteButton,
            this.AddTestButton,
            this.toolStripSeparator1,
            this.toolStripButtonRunCurrent,
            this.toolStripSeparator2,
            this.CleanTestsResultsButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(614, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(23, 22);
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonCreateTestProject
            // 
            this.toolStripButtonCreateTestProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCreateTestProject.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCreateTestProject.Image")));
            this.toolStripButtonCreateTestProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCreateTestProject.Name = "toolStripButtonCreateTestProject";
            this.toolStripButtonCreateTestProject.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCreateTestProject.Text = "Create test project";
            this.toolStripButtonCreateTestProject.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // AddTestSuiteButton
            // 
            this.AddTestSuiteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddTestSuiteButton.Image = ((System.Drawing.Image)(resources.GetObject("AddTestSuiteButton.Image")));
            this.AddTestSuiteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddTestSuiteButton.Name = "AddTestSuiteButton";
            this.AddTestSuiteButton.Size = new System.Drawing.Size(23, 22);
            this.AddTestSuiteButton.Text = "Add suite with tests";
            this.AddTestSuiteButton.Click += new System.EventHandler(this.AddTestSuiteButton_Click);
            // 
            // AddTestButton
            // 
            this.AddTestButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddTestButton.Image = ((System.Drawing.Image)(resources.GetObject("AddTestButton.Image")));
            this.AddTestButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddTestButton.Name = "AddTestButton";
            this.AddTestButton.Size = new System.Drawing.Size(23, 22);
            this.AddTestButton.Text = "Add test";
            this.AddTestButton.Click += new System.EventHandler(this.AddTestButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonRunCurrent
            // 
            this.toolStripButtonRunCurrent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRunCurrent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRunCurrent.Image")));
            this.toolStripButtonRunCurrent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRunCurrent.Name = "toolStripButtonRunCurrent";
            this.toolStripButtonRunCurrent.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRunCurrent.Text = "Run test";
            this.toolStripButtonRunCurrent.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // CleanTestsResultsButton
            // 
            this.CleanTestsResultsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CleanTestsResultsButton.Image = ((System.Drawing.Image)(resources.GetObject("CleanTestsResultsButton.Image")));
            this.CleanTestsResultsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CleanTestsResultsButton.Name = "CleanTestsResultsButton";
            this.CleanTestsResultsButton.Size = new System.Drawing.Size(23, 22);
            this.CleanTestsResultsButton.Text = "Erase all results";
            this.CleanTestsResultsButton.Click += new System.EventHandler(this.CleanTestsResultsButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.extendedTree1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 356);
            this.panel1.TabIndex = 2;
            // 
            // extendedTree1
            // 
            this.extendedTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extendedTree1.Location = new System.Drawing.Point(0, 0);
            this.extendedTree1.Name = "extendedTree1";
            this.extendedTree1.Size = new System.Drawing.Size(614, 356);
            this.extendedTree1.svNodes = null;
            this.extendedTree1.svSelectedNode = null;
            this.extendedTree1.TabIndex = 1;
            this.extendedTree1.treeView1NodeMouseDoubleClick += new System.EventHandler(this.extendedTree1_treeView1NodeMouseDoubleClick);
            // 
            // MWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MWin";
            this.Text = "MWin";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private SVControls.ExtendedTree extendedTree1;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonCreateTestProject;
        private System.Windows.Forms.ToolStripButton AddTestSuiteButton;
        private System.Windows.Forms.ToolStripButton AddTestButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRunCurrent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton CleanTestsResultsButton;

    }
}