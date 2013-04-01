using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnvDTE;
using EnvDTE80;
using SVControls;

namespace TestGuiApp
{
    public partial class AddTest : Form
    {
        private MWin MWin_;
        MWinProc MWinProc_ = new MWinProc();
        
        public AddTest(MWin MWin_)
        {
            InitializeComponent();
            this.MWin_ = MWin_;
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Test name is empty!");
                return;
            }

            //add new test to file
            StringBuilder builder = new StringBuilder();
            string fileNamePath = MWin.FileNamePath_;
            string suiteName = MWin.SuiteName_;
            string testName = textBox1.Text;

             
            NewTest ds = new NewTest();
            
            if (suiteName == "")
            {
                ds.CreateTestEmpty(builder, testName, fileNamePath);
            }

            if (suiteName != "")
            {
                ds.CreateTest(suiteName, testName, fileNamePath);
            }

            //get TreeNodeCollection
            ExtendedTree ExtendedTree_ = MWin_.ExtTree();
            TreeNodeCollection TreeNodeCollection_ = ExtendedTree_.svNodes;
            //TreeNode TreeNode_ = ExtendedTree_.svSelectedNode;

            //remember extendedTree before refresh
            MWinProc_.RememberExtendedTree(TreeNodeCollection_);
            List<String> ddd = MWinProc_.RememberExtendedTree(TreeNodeCollection_);

            //refresh tree
            ProjectPropertiesExtractor prj = new ProjectPropertiesExtractor();
            DTE2 dte2_ = prj.GetActiveIDE();

            const string RootNode = "All Tests";
            ExtendedTree_.RemoveAt(RootNode);
            TestProc TestProc_ = new TestProc(dte2_, ExtendedTree_);


            //restore the tree
            ddd = ddd.FindAll(delegate(string s) { return !s.EndsWith("\\"); });
            foreach (var ss in ddd)
            {
                ExtendedTree_.svSelectedNode = MWinProc_.FindNode(ExtendedTree_.svNodes, ss);
            }

            //select new test
            TreeNode[] dfg = ExtendedTree_.svNodes.Find(testName, true);
            foreach (var gg in dfg)
            {
                ExtendedTree_.svSelectedNode = gg;
            }
            

            //get solution directory
            EnvDTE80.DTE2 dte = (EnvDTE80.DTE2)System.Runtime.InteropServices.Marshal.GetActiveObject("VisualStudio.DTE");
            string solutionDir = System.IO.Path.GetDirectoryName(dte.Solution.FullName);

            //????
            //ExtendedTree_ = MWin_.ExtTree();
            //TreeNode_ = ExtendedTree_.svSelectedNode;
            //TreeNodeCollection_ = ExtendedTree_.svNodes;
            //ExtendedTree_.CheckedNames(TreeNodeCollection_);

            //get selected node
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


            TreeNodeCollection nodes = ExtendedTree_.svNodes;
            foreach (TreeNode n in nodes)
            {
                ExtendedTree_.rem(n);

            }

            
            this.Close();
            
        }


        

    }
}
