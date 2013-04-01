using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EnvDTE;
using EnvDTE80;
using SVControls;



namespace TestGuiApp
{
    public partial class MWin : Form
    {

        TestProc TestProc_;
        ExtendedTree ExtendedTree_;
        TreeNode TreeNode_;
        TreeNodeCollection TreeNodeCollection_;


        public MWin MWin_;

        MWinProc MWinProc_ = new MWinProc();


        public static string FileNamePath_;
        public static string SuiteNameForSuiteCreate_;


        
        public MWin()
        {
            InitializeComponent();
          

        }

        public static ExtendedTree Tr;
        public void ext()
        {
            Tr = this.extendedTree1;
        }


        public void InitWin(DTE2 a)
        {
            const string RootNode = "All Tests";
            this.extendedTree1.RemoveAt(RootNode);
            TestProc_ = new TestProc(a, this.extendedTree1);



            ExtendedTree_ = extendedTree1;
            ExtendedTree_.FillTreeView();
            //Rem(treeView1.Nodes);

            TreeNodeCollection nodes = ExtendedTree_.svNodes;
            foreach (TreeNode n in nodes)
            {
                ExtendedTree_.rem(n);

            }
    

        }


        public ExtendedTree ExtTree()
        {
            return this.extendedTree1;
        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ext();
            //if (this.extendedTree1.svNodes.Count <= 1) return;
            TestProc_.CreateTestProject();
        }
        
       
        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            //if (this.extendedTree1.svNodes.Count <= 1) return;

            EnvDTE80.DTE2 dte = (EnvDTE80.DTE2)System.Runtime.InteropServices.Marshal.GetActiveObject("VisualStudio.DTE");
            if(string.IsNullOrEmpty(dte.Solution.FullName)) return;
            string solutionDir = System.IO.Path.GetDirectoryName(dte.Solution.FullName);

            if (File.Exists(solutionDir + @"\Debug\LogFiles\LogFile.xml"))
            {
                File.Delete(solutionDir + @"\Debug\LogFiles\LogFile.xml");
            }
            
            ExtendedTree_ = this.extendedTree1;
            TreeNode_ = ExtendedTree_.svSelectedNode;
            TreeNodeCollection_ = ExtendedTree_.svNodes;
            ExtendedTree_.CheckedNames(TreeNodeCollection_);
            
            System.Windows.Forms.TreeNode aNode = ExtendedTree_.svSelectedNode;
            if (aNode == null || aNode.Text=="All Tests") return;

            var rootNode = MWinProc_.FindRootNode(aNode);
            if (aNode.Checked == false) return;
           
            System.Diagnostics.Process p = new System.Diagnostics.Process();

            if (File.Exists(solutionDir + @"\Debug\" + rootNode.Name + ".exe"))
            {
                p.StartInfo.FileName = solutionDir + @"\Debug\" + rootNode.Name + ".exe";
            }
            else
            {
                MessageBox.Show("Wait. Exe-file is not created yet");
                return;
            }
            
            if (rootNode.GetNodeCount(false) == 1) p.StartInfo.Arguments = "--run_test=" + aNode.Name;
            if (rootNode.GetNodeCount(false) > 1) p.StartInfo.Arguments = "--run_test=" + aNode.Parent.Name + "/" + aNode.Name;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.BeginOutputReadLine();
            p.WaitForExit();

            string xmlContent = System.IO.File.ReadAllText(solutionDir + @"\Debug\LogFiles\LogFile.xml");
            if (xmlContent == "<TestLog></TestLog>") xmlContent = "Successful";
            aNode.Tag = new string[] { xmlContent, "col2" };

            ExtendedTree_.Refresh();

        }


        

        
   
        

        private void RefreshButton_Click(object sender, EventArgs e)
        {

            //get TreeNodeCollection
            ExtendedTree_ = this.extendedTree1;
            
            TreeNodeCollection TreeNodeCollection_ = ExtendedTree_.svNodes;

            //get selected node
            TreeNode aNode = ExtendedTree_.svSelectedNode;
            
            //remember extendedTree before refresh
            MWinProc_.RememberExtendedTree(TreeNodeCollection_);
            List<String> ddd = MWinProc_.RememberExtendedTree(TreeNodeCollection_);

            if(extendedTree1.svSelectedNode == null) return;

            string sdsd = extendedTree1.svSelectedNode.FullPath;
            
            //refresh
            ProjectPropertiesExtractor prj = new ProjectPropertiesExtractor();
            
            DTE2 dte2_ = prj.GetActiveIDE();
            if(dte2_ == null) return;

            const string RootNode = "All Tests";
            this.extendedTree1.RemoveAt(RootNode);
            TestProc_ = new TestProc(dte2_, this.extendedTree1);

            //restore the tree
            ddd = ddd.FindAll(delegate(string s) { return !s.EndsWith("\\"); });

            foreach (var ss in ddd)
            {
                extendedTree1.svSelectedNode = MWinProc_.FindNode(extendedTree1.svNodes, ss);
            }

            //select
            //if (ExtendedTree_.svNodes.Count <= 1) return;
            //TreeNode[] dfg = ExtendedTree_.svNodes.Find(aNode.Name, true);
            //foreach (var gg in dfg)
            //{
            //    ExtendedTree_.svSelectedNode = gg;
            //}
            MWinProc MMWinProc_ = new MWinProc();
            MMWinProc_.SelectNode(extendedTree1, TreeNodeCollection_, sdsd);


            //ExtendedTree_ = extendedTree1;
            //ExtendedTree_.FillTreeView();
            //Rem(treeView1.Nodes);

            TreeNodeCollection nodes = ExtendedTree_.svNodes;
            foreach (TreeNode n in nodes)
            {
                ExtendedTree_.rem(n);

            }



        }


       



        private void AddTestSuiteButton_Click(object sender, EventArgs e)
        {
            //if (this.extendedTree1.svNodes.Count <= 1) return;
            FileNamePath_ = "";

            MWinProc_ = new MWinProc();
            MWinProc_.FileNamePathSuite(this.extendedTree1);

            if (FileNamePath_!="")
            {
                AddSuiteTest AddTest_ = new AddSuiteTest(this);
                AddTest_.Show();
            }
            

        }



        public static string SuiteName_ = "";
        private void AddTestButton_Click(object sender, EventArgs e)
        {
            //if (this.extendedTree1.svNodes.Count <= 1) return;

            FileNamePath_ = "";

            MWinProc_ = new MWinProc();
            MWinProc_.FileNamePathTest(this.extendedTree1);

            if (FileNamePath_ != "")
            {
                AddTest fff = new AddTest(this);

                fff.Show();
            }
        }

        
        

        private void extendedTree1_treeView1NodeMouseDoubleClick(object sender, EventArgs e)
        {
            //get solution directory
            EnvDTE80.DTE2 dte = (EnvDTE80.DTE2)System.Runtime.InteropServices.Marshal.GetActiveObject("VisualStudio.DTE");
            string solutionDir = System.IO.Path.GetDirectoryName(dte.Solution.FullName);

            //get selected node
            ExtendedTree_ = this.extendedTree1;
            TreeNode aNode = ExtendedTree_.svSelectedNode;

            //get project name
            string strName = null;
            if (aNode.Level == 0) return;
            if (aNode.Level == 1) strName = aNode.Name;
            if (aNode.Level == 2) strName = aNode.Parent.Name;
            if (aNode.Level == 3) strName = aNode.Parent.Parent.Name;

            
            //get project file with test
            string sddf = solutionDir + @"\" + strName + @"\" + strName + ".cpp";

            //get line number
            int df = MWinProc_.FindLineNumber(aNode.Name, sddf);

            //open file and scroll to the test place
            MWinProc_.OpenFileAndScroll(dte, sddf, df);


        }

        private void CleanTestsResultsButton_Click(object sender, EventArgs e)
        {
            //if (this.extendedTree1.svNodes.Count <= 1) return;
            ExtendedTree_ = this.extendedTree1;
            TreeNodeCollection_ = ExtendedTree_.svNodes;
            foreach (TreeNode dd in TreeNodeCollection_)
            {
                MWinProc_.DeleteTags(dd);
            }

            ExtendedTree_.Refresh();
        }

       

       




        

       


        



    }
}
