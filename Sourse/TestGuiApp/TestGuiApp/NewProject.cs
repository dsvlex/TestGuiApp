using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnvDTE;
using EnvDTE80;

using System.Drawing;


using Microsoft.VisualStudio.VCProjectEngine;
using Microsoft.VisualStudio.VCProject;
using SVControls;

namespace TestGuiApp
{
    public class NewProject
    {
        private DTE2 IDTE2_;
        private ProjectPropertiesForm Props_;
        private ProjectPropertiesExtractor PropertiesExtractor_;


        public NewProject(DTE2 a) 
        {
            IDTE2_ = a;
            Last_ = null;
            PropertiesExtractor_ = new ProjectPropertiesExtractor();
        }

        public List<string> Create() 
        {
            if (Props_ == null)
                Props_ = new ProjectPropertiesForm();
            NewProjectProperties extracted = PropertiesExtractor_.GetProps();
            Props_.InitForm(extracted, Last_);
            if (Props_.ShowDialog() == DialogResult.OK)
            {
                NewProjectProperties created = Props_.GetProjectProperties();
                System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(PropertiesExtractor_.GetActiveIDE().Solution.FullName) + @"\" + created.Name);

                //System.Threading.Thread.Sleep(10000);

                //wewe(MWin.Tr);

                SaveLastProjProp(created);
                return AddTestProject(created);
            }
            return null;
        }





        delegate void StringListParameterDelegate(ExtendedTree ExtendedTree_);


        public void wewe(ExtendedTree Extr)
        {
            //List<string> added = NewProject_.Create();
            //if (added == null)
            //    return;

            //ExtendedTree ExtendedTree_ = MWin.Tr;
            if (Extr.InvokeRequired)
            {
                // We're not in the UI thread, so we need to call BeginInvoke
                Extr.BeginInvoke(new StringListParameterDelegate(gggg), new object[] { Extr });
                return;
                //StringListParameterDelegate update = new StringListParameterDelegate(gggg);
                //ExtendedTree_.BeginInvoke(update, ExtendedTree_);
            }
            else
                gggg(Extr);
        }


       ///////
        /// 
       public void gggg(ExtendedTree Extr)
        {
            ExtendedTree ExtendedTree_ = Extr;

            MWinProc MWinProc_ = new MWinProc();


            TreeNodeCollection TreeNodeCollection_ = ExtendedTree_.svNodes;

            //get selected node
            TreeNode aNode = ExtendedTree_.svSelectedNode;

            //remember extendedTree before refresh
            MWinProc_.RememberExtendedTree(TreeNodeCollection_);
            List<String> ddd = MWinProc_.RememberExtendedTree(TreeNodeCollection_);

            if (Extr.svSelectedNode == null) return;

            string sdsd = Extr.svSelectedNode.FullPath;

            //refresh
            ProjectPropertiesExtractor prj = new ProjectPropertiesExtractor();

            DTE2 dte2_ = prj.GetActiveIDE();
            if (dte2_ == null) return;

            const string RootNode = "All Tests";
            Extr.RemoveAt(RootNode);
            TestProc TestProc_ = new TestProc(dte2_, Extr);

            //restore the tree
            ddd = ddd.FindAll(delegate(string s) { return !s.EndsWith("\\"); });

            foreach (var ss in ddd)
            {
                Extr.svSelectedNode = MWinProc_.FindNode(Extr.svNodes, ss);
            }

            //select
            //if (ExtendedTree_.svNodes.Count <= 1) return;
            //TreeNode[] dfg = ExtendedTree_.svNodes.Find(aNode.Name, true);
            //foreach (var gg in dfg)
            //{
            //    ExtendedTree_.svSelectedNode = gg;
            //}
            MWinProc MMWinProc_ = new MWinProc();
            MMWinProc_.SelectNode(Extr, TreeNodeCollection_, sdsd);


            //ExtendedTree_ = extendedTree1;
            //ExtendedTree_.FillTreeView();
            //Rem(treeView1.Nodes);

            TreeNodeCollection nodes = ExtendedTree_.svNodes;
            foreach (TreeNode n in nodes)
            {
                ExtendedTree_.rem(n);

            }


           

            //select new test
            NewProjectProperties created = Props_.GetProjectProperties();
            TreeNode[] dfg = ExtendedTree_.svNodes.Find(created.Name, true);
            foreach (var gg in dfg)
            {
                ExtendedTree_.svSelectedNode = gg;
            }

            ////get project name
            //string strName = created.Name;

            ////get solution directory
            //EnvDTE80.DTE2 dte = (EnvDTE80.DTE2)System.Runtime.InteropServices.Marshal.GetActiveObject("VisualStudio.DTE");
            //string solutionDir = System.IO.Path.GetDirectoryName(dte.Solution.FullName);

            ////get project file with test
            //string sddf = solutionDir + @"\" + strName + @"\" + strName + ".cpp";

            ////get line number
            //int df = MWinProc_.FindLineNumber(aNode.Name, sddf);

            ////open file and scroll to the test place
            //MWinProc_.OpenFileAndScroll(dte, sddf, df);



        }


        private List<string> AddTestProject(NewProjectProperties props)
        {
            Project project = AddProject(props);
            ProjectItem file = AddFile(props, project);
            if (props.OpenFile)
                ActivateFile(file);
            List<string> list = new List<string>();
            list.Add(props.Name);
            list.Add(props.Suit);
            list.Add(props.Test);

            InsertPreprocessorDefinitions();
            InsertIncludes();
            InsertLibPath();

            //build project
            ProjectPropertiesExtractor prj = new ProjectPropertiesExtractor();
            DTE2 dte2_ = prj.GetActiveIDE();
            dte2_.Solution.SolutionBuild.BuildProject("Debug", project.FullName, false);
           
            wewe(MWin.Tr);
            

            //BuildDependencies dependencies = dte2_.Solution.SolutionBuild.BuildDependencies;
            //MessageBox.Show(dependencies.Count.ToString());
            //foreach (BuildDependency dependency in dependencies)
            //    MessageBox.Show(dependency.Project.Name);

            
            return list;
        }


        public void InsertPreprocessorDefinitions()
        {
            StringBuilder builder = new StringBuilder();

            object sd = PropertiesExtractor_.GetActiveIDE().Solution.Projects.Count;

            Project activeProject = PropertiesExtractor_.GetActiveIDE().Solution.Projects.Item(Convert.ToInt16(sd));
            Configuration cfg = activeProject.ConfigurationManager.ActiveConfiguration;
            VCProject vcproj = (VCProject)activeProject.Object;

            VCConfiguration vcconfig = (VCConfiguration)((IVCCollection)vcproj.Configurations).Item(cfg.ConfigurationName);
            IVCCollection tools = (IVCCollection)vcconfig.Tools;

            VCCLCompilerTool tool2 = (VCCLCompilerTool)tools.Item("VCCLCompilerTool");
            string _linker = tool2.PreprocessorDefinitions;

            foreach (object item in Props_.GetMacroses())
            {
                tool2.PreprocessorDefinitions = Convert.ToString(builder.Append(item.ToString()).Append(";"));

            }

        }

        public void InsertIncludes()
        {
            StringBuilder builder = new StringBuilder();

            object sd = PropertiesExtractor_.GetActiveIDE().Solution.Projects.Count;

            Project activeProject = PropertiesExtractor_.GetActiveIDE().Solution.Projects.Item(Convert.ToInt16(sd));
            Configuration cfg = activeProject.ConfigurationManager.ActiveConfiguration;
            VCProject vcproj = (VCProject)activeProject.Object;

            VCConfiguration vcconfig = (VCConfiguration)((IVCCollection)vcproj.Configurations).Item(cfg.ConfigurationName);
            IVCCollection tools = (IVCCollection)vcconfig.Tools;

            VCCLCompilerTool tool2 = (VCCLCompilerTool)tools.Item("VCCLCompilerTool");
            string _linker = tool2.AdditionalIncludeDirectories;

            foreach (object item in Props_.GetIncludes())
            {
                tool2.AdditionalIncludeDirectories = Convert.ToString(builder.Append(item.ToString()).Append(";"));

            }

        }


        public void InsertLibPath()
        {
            StringBuilder builder = new StringBuilder();

            object sd = PropertiesExtractor_.GetActiveIDE().Solution.Projects.Count;

            Project activeProject = PropertiesExtractor_.GetActiveIDE().Solution.Projects.Item(Convert.ToInt16(sd));
            Configuration cfg = activeProject.ConfigurationManager.ActiveConfiguration;
            VCProject vcproj = (VCProject)activeProject.Object;

            VCConfiguration vcconfig = (VCConfiguration)((IVCCollection)vcproj.Configurations).Item(cfg.ConfigurationName);
            IVCCollection tools = (IVCCollection)vcconfig.Tools;

            VCLinkerTool tool2 = (VCLinkerTool)tools.Item("VCLinkerTool");
            string _linker = tool2.AdditionalLibraryDirectories;

            foreach (object item in Props_.GetLibPath())
            {
                tool2.AdditionalLibraryDirectories = Convert.ToString(builder.Append(item.ToString()).Append(";"));

            }

        }

        private Project AddProject(NewProjectProperties props)
        {
            Dictionary<string, string> projDict = GetProjectDict(props);
            string projPathName = props.ProjectPath + "//" + props.Name + ".vcxproj";
            PushProjectData(props.ProjectTemplate, projPathName, projDict);
            Project project = SetProject(projPathName, props.SetAsStartUp);
            return project;
        }

        private ProjectItem AddFile(NewProjectProperties props, Project project)
        {
            Dictionary<string, string> fileDict = GetFileDict(props);
            string filePathName = props.FilePath + "//" + props.Name + ".cpp";
            PushFileData(props.FileTemplates[0], filePathName, fileDict);
            return project.ProjectItems.AddFromFile(filePathName);
        }


        //public static string ReplaceVars22(string varText, Dictionary<string, string> dict)
        //{
        //    //"NAME"->"MyName", "INCLUDE"->"include"
        //    // "$NAME NAME asdqwe $(NAME) oiu "$INCLUDE" " - > "MyName NAME asdqwe MyName oiu "include" "
        //    if (string.IsNullOrEmpty(varText)) return string.Empty;
        //    return dict.Aggregate(varText, (current, value) => current
        //                                                           .Replace("$(" + value.Key + ")", value.Value)
        //                                                           .Replace("$" + value.Key, '"' + value.Value + '"'));
        //}


        private Dictionary<string, string> GetProjectDict(NewProjectProperties props)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Name", props.Name);
            dict.Add("ClCompile Include", props.Name + ".cpp");
           
            dict.Add("ProjectGUID", "{" + Guid.NewGuid().ToString() + "}");
            dict.Add("PreprocessorDefinitions", props.DefinesStr());
            dict.Add("AdditionalIncludeDirectories", props.InclPathStr());
            dict.Add("AdditionalLibraryDirectories", props.LibPathStr());
            dict.Add("AdditionalDependencies", props.LibsStr());
            return dict;
        }

        private Dictionary<string, string> GetFileDict(NewProjectProperties props)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("{UNIT_NAME}", props.Name);
            dict.Add("{UNIT_SUIT}", props.Suit);
            dict.Add("{UNIT_TEST}", props.Test);
            return dict;
        }

        private void PushProjectData(string src, string dst, Dictionary<string, string> dict)
        {
            using (StreamReader srcStream = new StreamReader(src))
            {
                using (StreamWriter dstStream = new StreamWriter(dst))
                {
                    string line;
                    bool nameFound = false;
                    bool guidFound = false;
                    bool cicompileFound = false;
                    bool opened = false;
                    while ((line = srcStream.ReadLine()) != null)
                    {
                        if (!IsSkip(line, ref opened))
                            dstStream.WriteLine(AddProjectVars(line, dict, ref nameFound, ref guidFound, ref cicompileFound));
                    }
                }
            }
        }

        private bool IsSkip(string line, ref bool opened)
        {
            bool openFound = line.Contains("<File") && !line.Contains("<Files");
            bool closeFound = line.Contains("/File>");

            if (openFound)
            {
                opened = !closeFound;
                return true;
            }
            if (closeFound)
            {
                opened = false;
                return true;
            }
            return opened;
        }

        private void PushFileData(string src, string dst, Dictionary<string, string> dict)
        {
            using (StreamReader srcStream = new StreamReader(src))
            {
                using (StreamWriter dstStream = new StreamWriter(dst))
                {
                    string line;
                    while ((line = srcStream.ReadLine()) != null)
                        dstStream.WriteLine(AddVarToFile(line, dict));
                }
            }
        }

        private string AddProjectVars(string line, Dictionary<string, string> dict, ref bool nameFound, ref bool guidFound, ref bool cicompileFound)
        {
            if (TryReplaceRootNamespace("Name", dict, ref line, ref nameFound))
                return line;

            if (TryReplaceClCompile("ClCompile Include", dict, ref line, ref cicompileFound))
                return line;

            if (TryReplaceRootNamespace("ProjectGUID", dict, ref line, ref guidFound))
                return line;
            return TryAppendVarToProj(line, dict);
        }

        private string AddVarToFile(string line, Dictionary<string, string> dict)
        {
            foreach (KeyValuePair<string, string> pair in dict)
            {
                line = line.Replace(pair.Key, pair.Value);
            }
            return line;
        }

        private string TryAppendVarToProj(string str, Dictionary<string, string> dict)
        {
            string[] words = str.Split('=');
            if (words.Count() < 2)
                return str;
            if (dict.ContainsKey(words[0]) && dict[words[0]].Length > 0)
            {
                str = words[0] + "=\"" + dict[words[0]] + "\"" + words[1];
                str = str.Replace("\"\"", "\"");
            }
            return str;
        }

        private bool TryReplaceRootNamespace(string token, Dictionary<string, string> dict, ref string str, ref bool found)
        {
            if (!found)
            {
                if (str.Contains(token))
                {
                    found = true;
                    str = "<RootNamespace>" + dict[token] + "</RootNamespace>";
                    return true;
                }
            }
            return false;
        }

        private bool TryReplaceClCompile(string token, Dictionary<string, string> dict, ref string str, ref bool found)
        {
            if (!found)
            {
                if (str.Contains(token))
                {
                    found = true;
                    str = "<" + token + "=\"" + dict[token] + "\"" + "/>";
                    return true;
                }
            }
            return false;
        }

        private Project SetProject(string projectPath, bool setAsStartUp)
        {
            if (IDTE2_.Solution == null)
                return null;

            Solution2 solution = (Solution2)IDTE2_.Solution;
            Project project = solution.AddFromFile(projectPath, false);

            if (setAsStartUp)
            {
                Properties props = solution.Properties;
                props.Item("StartupProject").Value = project;
            }

            return project;
        }

        private void ActivateFile(ProjectItem fileItem)
        {
            Window w = fileItem.Open(Constants.vsViewKindCode);
            w.Visible = true;
            w.Activate();

            // get the function element and show it
            //CodeElement function = CodeElementSearcher.GetFunction(requestedItem, myFunctionName);

            // get the text of the document
            //TextSelection textSelection = w.Document.Selection as TextSelection;

            // now set the cursor to the beginning of the function
            //textSelection.MoveToPoint(20);

            //Cursor.Position = new Point(Cursor.Position.X - 150, Cursor.Position.Y - 150); 
            string eyeye = w.Document.FullName;

            EnvDTE80.DTE2 dte = (EnvDTE80.DTE2)System.Runtime.InteropServices.Marshal.GetActiveObject("VisualStudio.DTE");

            MWinProc MWinProc_  = new MWinProc();
            //get line number
            int df = MWinProc_.FindLineNumber("BOOST_AUTO_TEST_CASE", eyeye);
            MWinProc_.OpenFileAndScroll(dte, eyeye, df);



        }

        

        private void SaveLastProjProp(NewProjectProperties pp)
        {
            Last_ = pp;
        }

        NewProjectProperties Last_;
    }
}
