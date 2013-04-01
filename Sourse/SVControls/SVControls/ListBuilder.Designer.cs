namespace SVControls
{
    partial class ListBuilder
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxLeft = new System.Windows.Forms.ListBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.listBoxRight = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.buttonAddAll = new System.Windows.Forms.Button();
            this.buttonRemoveOne = new System.Windows.Forms.Button();
            this.buttonAddOne = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxLeft
            // 
            this.listBoxLeft.FormattingEnabled = true;
            this.listBoxLeft.Items.AddRange(new object[] {
            "asd",
            "qwe",
            "zxc"});
            this.listBoxLeft.Location = new System.Drawing.Point(3, 3);
            this.listBoxLeft.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLeft.Name = "listBoxLeft";
            this.listBoxLeft.Size = new System.Drawing.Size(160, 264);
            this.listBoxLeft.TabIndex = 0;
            this.listBoxLeft.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnLeftBoxMouseDoubleClick);
            this.listBoxLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxLeft_MouseMove);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(2, 2);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(27, 20);
            this.buttonUp.TabIndex = 5;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(2, 27);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(27, 20);
            this.buttonDown.TabIndex = 6;
            this.buttonDown.Text = "Dw";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // listBoxRight
            // 
            this.listBoxRight.FormattingEnabled = true;
            this.listBoxRight.Location = new System.Drawing.Point(202, 2);
            this.listBoxRight.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxRight.Name = "listBoxRight";
            this.listBoxRight.Size = new System.Drawing.Size(191, 264);
            this.listBoxRight.TabIndex = 7;
            this.listBoxRight.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnRightBoxMouseDoubleClick);
            this.listBoxRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxRight_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(166, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 263);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonRemoveAll);
            this.panel3.Controls.Add(this.buttonAddAll);
            this.panel3.Controls.Add(this.buttonRemoveOne);
            this.panel3.Controls.Add(this.buttonAddOne);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(32, 98);
            this.panel3.TabIndex = 13;
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Location = new System.Drawing.Point(2, 76);
            this.buttonRemoveAll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(27, 20);
            this.buttonRemoveAll.TabIndex = 11;
            this.buttonRemoveAll.Text = "<<";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // buttonAddAll
            // 
            this.buttonAddAll.Location = new System.Drawing.Point(2, 2);
            this.buttonAddAll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddAll.Name = "buttonAddAll";
            this.buttonAddAll.Size = new System.Drawing.Size(27, 20);
            this.buttonAddAll.TabIndex = 10;
            this.buttonAddAll.Text = ">>";
            this.buttonAddAll.UseVisualStyleBackColor = true;
            this.buttonAddAll.Click += new System.EventHandler(this.buttonAddAll_Click);
            // 
            // buttonRemoveOne
            // 
            this.buttonRemoveOne.Location = new System.Drawing.Point(2, 51);
            this.buttonRemoveOne.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoveOne.Name = "buttonRemoveOne";
            this.buttonRemoveOne.Size = new System.Drawing.Size(27, 20);
            this.buttonRemoveOne.TabIndex = 12;
            this.buttonRemoveOne.Text = "<";
            this.buttonRemoveOne.UseVisualStyleBackColor = true;
            this.buttonRemoveOne.Click += new System.EventHandler(this.buttonRemoveOne_Click);
            // 
            // buttonAddOne
            // 
            this.buttonAddOne.Location = new System.Drawing.Point(2, 27);
            this.buttonAddOne.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddOne.Name = "buttonAddOne";
            this.buttonAddOne.Size = new System.Drawing.Size(27, 20);
            this.buttonAddOne.TabIndex = 9;
            this.buttonAddOne.Text = ">";
            this.buttonAddOne.UseVisualStyleBackColor = true;
            this.buttonAddOne.Click += new System.EventHandler(this.buttonAddOne_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonDown);
            this.panel2.Controls.Add(this.buttonUp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 214);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 49);
            this.panel2.TabIndex = 0;
            // 
            // ListBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxRight);
            this.Controls.Add(this.listBoxLeft);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(240, 146);
            this.Name = "ListBuilder";
            this.Size = new System.Drawing.Size(480, 275);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLeft;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.ListBox listBoxRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddAll;
        private System.Windows.Forms.Button buttonAddOne;
        private System.Windows.Forms.Button buttonRemoveOne;
        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}