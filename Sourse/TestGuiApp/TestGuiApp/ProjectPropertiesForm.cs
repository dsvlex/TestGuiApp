using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestGuiApp
{
    public partial class ProjectPropertiesForm : Form
    {
        string NewFolderPath_;

        public ProjectPropertiesForm()
        {
            InitializeComponent();
            this.textBoxUnitFileName.Select();
            this.CenterToScreen();

          
        }

        public void InitForm(NewProjectProperties prop, NewProjectProperties last)
        {
            if (last == null)
            {
                this.checkBoxUseLast.Checked = false;
                this.checkBoxUseLast.Enabled = false;
                this.checkBoxUseLast.Visible = false;
                this.labelLastUsed0.Visible = false;
                this.labelLastUsed1.Visible = false;
                this.labelLastUsed2.Visible = false;
                this.labelLastUsed3.Visible = false;
                NewFolderPath_ = prop.ProjectPath;
            }
            else
            {
                UseLast(last.UseLast);
            }

            this.textBoxUnitFileName.Text = prop.Name;
            this.textBoxUnitSuitName.Text = prop.Suit;
            this.textBoxUnitCaseName.Text = prop.Test;



            if (last != null)
            {
                this.checkBoxSetAsStartUp.Checked = last.SetAsStartUp;
                this.checkBoxOpenFile.Checked = last.OpenFile;
                this.textBoxProjSourcesPath.Text = last.MainSourcesPath;
                this.textBoxProjectTemplate.Text = last.ProjectTemplate;
                this.textBoxProjectLocation.Text = last.ProjectPath;
                this.textBoxUnitFileTemplate.Text = last.FileTemplates[0];
                this.textBoxUnitFileLocation.Text = last.FilePath;

                //закомментировал, чтобы при повторном открытии записи не задваивались
                //this.listBuilderInclPath.Init(prop.DictToList(prop.InclPath), last.DictToList(last.InclPath));
                //закомментировал, чтобы при повторном открытии записи не задваивались
                //this.listBuilderMacroses.Init(prop.DictToList(prop.Defines), last.DictToList(last.Defines));
                //закомментировал, чтобы при повторном открытии записи не задваивались
                //this.listBuilderLibPath.Init(prop.DictToList(prop.LibPath), last.DictToList(last.LibPath));
                this.listBuilderLibs.Init(prop.DictToList(prop.Libs), last.DictToList(last.Libs));
            }
            else
            {
                this.checkBoxSetAsStartUp.Checked = prop.SetAsStartUp;
                this.checkBoxOpenFile.Checked = prop.OpenFile;
                this.textBoxProjSourcesPath.Text = prop.MainSourcesPath;
                this.textBoxProjectTemplate.Text = prop.ProjectTemplate;
                this.textBoxProjectLocation.Text = prop.ProjectPath;
                this.textBoxUnitFileTemplate.Text = prop.FileTemplates[0];
                this.textBoxUnitFileLocation.Text = prop.FilePath;

                this.listBuilderInclPath.Init(prop.DictToList(prop.InclPath));
                this.listBuilderMacroses.Init(prop.DictToList(prop.Defines));
                this.listBuilderLibPath.Init(prop.DictToList(prop.LibPath));
                this.listBuilderLibs.Init(prop.DictToList(prop.Libs));
            }


            if (last == null)
            {
                this.textBoxProjectTemplate.Text = @"c:\Program Files\TGA\ProjectTemplate.vcxproj";
                this.textBoxUnitFileTemplate.Text = @"c:\Program Files\TGA\UnitFileTemplate.cpp";
            }

        }

        public List<String> GetMacroses()
        {
            return this.listBuilderMacroses.GetResult();
        }

        public List<String> GetIncludes()
        {
            return this.listBuilderInclPath.GetResult();
        }

        public List<String> GetLibPath()
        {
            return this.listBuilderLibPath.GetResult();
        }

        public NewProjectProperties GetProjectProperties()
        {
            NewProjectProperties prop = new NewProjectProperties();
            prop.UseLast = this.checkBoxUseLast.Checked;

            if (this.textBoxUnitFileName.Text != string.Empty)
                prop.Name = this.textBoxUnitFileName.Text;

            if (this.textBoxUnitSuitName.Text != string.Empty)
                prop.Suit = this.textBoxUnitSuitName.Text;

            if (this.textBoxUnitCaseName.Text != string.Empty)
                prop.Test = this.textBoxUnitCaseName.Text;


            if (this.textBoxProjSourcesPath.Text != string.Empty)
                prop.MainSourcesPath = this.textBoxProjSourcesPath.Text;

            if (this.textBoxProjectTemplate.Text != string.Empty)
                prop.ProjectTemplate = this.textBoxProjectTemplate.Text;

            if (this.textBoxProjectLocation.Text != string.Empty)
                prop.ProjectPath = this.textBoxProjectLocation.Text;

            if (this.textBoxUnitFileTemplate.Text != string.Empty)
                prop.FileTemplates.Add(this.textBoxUnitFileTemplate.Text);
            else
                prop.FileTemplates.Add("");

            if (this.textBoxUnitFileLocation.Text != string.Empty)
                prop.FilePath = this.textBoxUnitFileLocation.Text;

            prop.SetAsStartUp = this.checkBoxSetAsStartUp.Checked;
            prop.OpenFile = this.checkBoxOpenFile.Checked;

            prop.InclPath = prop.DictFromList(this.listBuilderInclPath.GetResult());
            prop.Defines = prop.DictFromList(this.listBuilderMacroses.GetResult());
            prop.LibPath = prop.DictFromList(this.listBuilderLibPath.GetResult());
            prop.Libs = prop.DictFromList(this.listBuilderLibs.GetResult());

            return prop;
        }

        private void textBoxUnitName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void UseLast(bool useLast)
        {
            this.checkBoxUseLast.Checked = useLast;
            this.checkBoxUseLast.Enabled = true;
            this.checkBoxUseLast.Visible = true;

            this.labelLastUsed0.Visible = useLast;
            this.labelLastUsed1.Visible = useLast;
            this.labelLastUsed2.Visible = useLast;
            this.labelLastUsed3.Visible = useLast;

            this.label1.Visible = !useLast;
            this.label2.Visible = !useLast;
            this.label3.Visible = !useLast;
            this.label4.Visible = !useLast;
            this.label6.Visible = !useLast;

            this.textBoxProjSourcesPath.Visible = !useLast;
            this.textBoxProjectTemplate.Visible = !useLast;
            this.textBoxProjectLocation.Visible = !useLast;
            this.textBoxUnitFileTemplate.Visible = !useLast;
            this.textBoxUnitFileLocation.Visible = !useLast;


            this.buttonOpenProjSourcesPath.Visible = !useLast;
            this.buttonOpenProjectTemplate.Visible = !useLast;
            this.buttonOpenProjectLocation.Visible = !useLast;
            this.buttonOpenUnitFileTemplate.Visible = !useLast;
            this.buttonOpenUnitFileLocation.Visible = !useLast;

            this.listBuilderInclPath.Visible = !useLast;
            this.listBuilderMacroses.Visible = !useLast;
            this.listBuilderLibPath.Visible = !useLast;
            this.listBuilderLibs.Visible = !useLast;
        }

        private void checkBoxUseLast_CheckedChanged(object sender, EventArgs e)
        {
            UseLast(this.checkBoxUseLast.Checked);
        }

        private void buttonOpenProjSourcesPath_Click(object sender, EventArgs e)
        {
            DoSetDir(this.textBoxProjSourcesPath);
        }

        private void DoSetDir(TextBox tb)
        {
            if (this.folderBrowserDialog == null)
                this.folderBrowserDialog = new FolderBrowserDialog();
            this.folderBrowserDialog.SelectedPath = tb.Text;
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tb.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        private void DoSetFile(OpenFileDialog dlg, TextBox tb)
        {
            if (dlg == null)
                dlg = new OpenFileDialog();
            dlg.FileName = tb.Text;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tb.Text = dlg.FileName;
            }
        }

        private void buttonOpenProjectLocation_Click(object sender, EventArgs e)
        {
            DoSetDir(this.textBoxProjectLocation);
        }

        private void buttonOpenUnitFileLocation_Click(object sender, EventArgs e)
        {
            DoSetDir(this.textBoxUnitFileLocation);
        }

        private void buttonOpenProjectTemplate_Click(object sender, EventArgs e)
        {
            DoSetFile(this.openFileDialogOpenProjectTemplate, this.textBoxProjectTemplate);
        }

        private void buttonOpenUnitFileTemplate_Click(object sender, EventArgs e)
        {
            DoSetFile(this.openFileDialogOpenFileTemplate, this.textBoxUnitFileTemplate);
        }

        private void textBoxUnitFileName_TextChanged(object sender, EventArgs e)
        {
            this.textBoxProjSourcesPath.Text = NewFolderPath_ + @"\" + textBoxUnitFileName.Text;
            this.textBoxProjectLocation.Text = NewFolderPath_ + @"\" + textBoxUnitFileName.Text;
            this.textBoxUnitFileLocation.Text = NewFolderPath_ + @"\" + textBoxUnitFileName.Text;
        }

        private void textBoxProjSourcesPath_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBoxProjSourcesPath, textBoxProjSourcesPath.Text);
        }

        private void textBoxUnitFileName_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBoxUnitFileName, textBoxUnitFileName.Text);
        }

        private void textBoxUnitSuitName_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBoxUnitSuitName, textBoxUnitSuitName.Text);
        }

        private void textBoxUnitCaseName_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBoxUnitCaseName, textBoxUnitCaseName.Text);
        }

        private void textBoxProjectTemplate_TextChanged(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBoxProjectTemplate, textBoxProjectTemplate.Text);
        }

        private void textBoxProjectTemplate_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBoxProjectTemplate, textBoxProjectTemplate.Text);
        }

        private void textBoxProjectLocation_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBoxProjectLocation, textBoxProjectLocation.Text);
        }

        private void textBoxUnitFileTemplate_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBoxUnitFileTemplate, textBoxUnitFileTemplate.Text);
        }

        private void textBoxUnitFileLocation_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBoxUnitFileLocation, textBoxUnitFileLocation.Text);
        }

       



    }
}
