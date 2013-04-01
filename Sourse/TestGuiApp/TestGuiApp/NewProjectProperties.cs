using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EnvDTE80;
using EnvDTE;

using System.Windows.Forms;

//using System.Runtime.InteropServices;
//using Microsoft.VisualStudio.VCProjectEngine;
//using Microsoft.VisualStudio.VCProject;

namespace TestGuiApp
{
    public class NewProjectProperties
    {
        public NewProjectProperties(IList<String> definitions, IList<String> includes, IList<String> libpath) 
        {
            UseLast_ = false;
            SetAsStartUp_ = true;
            OpenFile_ = true;

            Name_ = "NewTest";
            Suit_ = "Suit";
            Test_ = "Test";

            //ProjectPropertiesForm PropertiesForm_ = new ProjectPropertiesForm();
            ProjectPropertiesExtractor prj = new ProjectPropertiesExtractor();
            string NewPath_ = System.IO.Path.GetDirectoryName(prj.GetActiveIDE().Solution.FullName); //"";// PropertiesForm_.textBoxProjSourcesPath.Text;

            MainSourcesPath_ = NewPath_;

            ProjectTemplate_ = "";
            ProjectPath_ = NewPath_;

            FileTemplates_ = new List<string>();
            FileTemplates_.Add("");
            FilePath_ = NewPath_;

            InclPath_ = new Dictionary<string, bool>();

//             InclPath_.Add("Incl0", true);
//             InclPath_.Add("Incl1", true);
//             InclPath_.Add("Incl2", true);

            foreach (string str2 in includes)
            {
                InclPath_.Add(str2, true);
            }


            Defines_ = new Dictionary<string, bool>();


            //заполняем listBuilderMacroses
            //EnvDTE80.DTE2 prj = (EnvDTE80.DTE2)System.Runtime.InteropServices.Marshal.GetActiveObject("VisualStudio.DTE");
            //ProjectPropertiesExtractor ert_ = new ProjectPropertiesExtractor(prj);

            foreach (string str in definitions) 
            {
                Defines_.Add(str, true);
            }

            //          Defines_.Add("Def0", true);
            //          Defines_.Add("Def1", true);
            //          Defines_.Add("Def2", true);

            LibPath_ = new Dictionary<string, bool>();
            //             LibPath_.Add("LibPath0", true);
            //             LibPath_.Add("LibPath1", true);
            //             LibPath_.Add("LibPath2", true);
            
            Libs_ = new Dictionary<string, bool>();

            foreach (string str3 in libpath)
            {
                LibPath_.Add(str3, true);
            }
            //Libs_.Add("lib0", true);
            //Libs_.Add("lib1", true);
            //Libs_.Add("lib2", true);
        }

        public NewProjectProperties()
        {
            FileTemplates_ = new List<string>();
            InclPath_ = new Dictionary<string, bool>();
            Defines_ = new Dictionary<string, bool>();
            LibPath_ = new Dictionary<string, bool>();
            Libs_ = new Dictionary<string, bool>();
        }

        public void Save()
        { 
            //TODO
        }

        private Dictionary<string, bool> InclPath_;
        public Dictionary<string, bool> InclPath
        {
            get { return InclPath_; }
            set { InclPath_ = value; }
        }
        public string InclPathStr()
        {
            return DictToStr(InclPath_, ";");
        }
        private Dictionary<string, bool> Defines_;
        public Dictionary<string, bool> Defines
        {
            get { return Defines_; }
            set { Defines_ = value; }
        }
        public string DefinesStr()
        {
            return DictToStr(Defines_, ";");
        }
        private Dictionary<string, bool> LibPath_;
        public Dictionary<string, bool> LibPath
        {
            get { return LibPath_; }
            set { LibPath_ = value; }
        }
        public string LibPathStr()
        {
            return DictToStr(LibPath_, ";");
        }
        private Dictionary<string, bool> Libs_;
        public Dictionary<string, bool> Libs
        {
            get { return Libs_; }
            set { Libs_ = value; }
        }
        public string LibsStr()
        {
            return DictToStr(Libs_, " ");
        }
        private string ProjectTemplate_;
        public string ProjectTemplate
        {
            get { return ProjectTemplate_; }
            set { ProjectTemplate_ = value; }
        }
        private string ProjectPath_;
        public string ProjectPath
        {
            get { return ProjectPath_; }
            set { ProjectPath_ = value; }
        }
        private string Name_;
        public string Name
        {
            get { return Name_; }
            set { Name_ = value; }
        }

 
        private string Suit_;
        public string Suit
        {
            get { return Suit_; }
            set { Suit_ = value; }
        }
        private string Test_;
        public string Test
        {
            get { return Test_; }
            set { Test_ = value; }
        }
        private List<string> FileTemplates_;
        public List<string> FileTemplates
        {
            get { return FileTemplates_; }
            set { FileTemplates_ = value; }
        }
        private string FilePath_;
        public string FilePath
        {
            get { return FilePath_; }
            set { FilePath_ = value; }
        }

        private string MainSourcesPath_;
        public string MainSourcesPath
        {
            get { return MainSourcesPath_; }
            set { MainSourcesPath_ = value; }
        }

        private bool UseLast_;
        public bool UseLast
        {
            get { return UseLast_; }
            set { UseLast_ = value; }
        }

        private bool SetAsStartUp_;
        public bool SetAsStartUp
        {
            get { return SetAsStartUp_; }
            set { SetAsStartUp_ = value; }
        }

        private bool OpenFile_;
        public bool OpenFile
        {
            get { return OpenFile_; }
            set { OpenFile_ = value; }
        }
        private string DictToStr(Dictionary<string, bool> dict, string delim)
        {
            string line = "";
            foreach (KeyValuePair<string, bool> pair in dict)
                line += pair.Key + delim;
            return line;
        }

        public List<string> DictToList(Dictionary<string, bool> dict)
        {
            List<string> list = new List<string>();
            foreach (KeyValuePair<string, bool> pair in dict)
                list.Add(pair.Key);
            return list;
        }

        public Dictionary<string, bool> DictFromList(List<string> list)
        {
            Dictionary<string, bool> dict = new Dictionary<string, bool>();
            foreach (string s in list)
                dict.Add(s, true);
            return dict;
        }

    }
}
