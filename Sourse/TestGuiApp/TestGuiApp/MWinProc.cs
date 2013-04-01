using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnvDTE;
using EnvDTE80;
using SVControls;

namespace TestGuiApp
{
    public class MWinProc
    {
        
        ExtendedTree ExtendedTree_;
      
       
        public void FileNamePathSuite(ExtendedTree xt)
        {
            MWin.FileNamePath_ = "";
            MWin.SuiteNameForSuiteCreate_ = "";

            ExtendedTree_ = xt;
            TreeNode aNode = ExtendedTree_.svSelectedNode;
            
            if(aNode == null) return;
            if (aNode.Level != 1) return;
         
            ProjectPropertiesExtractor prj = new ProjectPropertiesExtractor();
            string NewPath_ = System.IO.Path.GetDirectoryName(prj.GetActiveIDE().Solution.FullName);

            string StrFileNamePath = null;
            
            StrFileNamePath = NewPath_ + @"\" + aNode.Name + @"\" + aNode.Name + ".cpp";
          
            MWin.FileNamePath_ = StrFileNamePath;
            MWin.SuiteNameForSuiteCreate_ = aNode.Name;


        }

        
        public void FileNamePathTest(ExtendedTree xt)
        {

            MWin.SuiteName_ = "";

            ExtendedTree_ = xt;
            
            TreeNode aNode = ExtendedTree_.svSelectedNode;

            if (aNode == null) return;

            if (aNode.Level != 1 && aNode.Level != 2) return;
        
            ProjectPropertiesExtractor prj = new ProjectPropertiesExtractor();
            string NewPath_ = System.IO.Path.GetDirectoryName(prj.GetActiveIDE().Solution.FullName);

            string StrFileNamePath = null;

            if (aNode.Level == 1) StrFileNamePath = NewPath_ + @"\" + aNode.Name + @"\" + aNode.Name + ".cpp";
            if (aNode.Level == 2) StrFileNamePath = NewPath_ + @"\" + aNode.Parent.Name + @"\" + aNode.Parent.Name + ".cpp";

            MWin.FileNamePath_ = StrFileNamePath;

            if (aNode.Level == 2) MWin.SuiteName_ = aNode.Name;

            
        }


        public void SelectNode(ExtendedTree ExtTree, TreeNodeCollection Nodes, String str)
        {
            foreach (TreeNode tree in Nodes)
            {
                if (tree.FullPath == str)
                {
                    ExtTree.svSelectedNode = tree;
                    return;
                }
                SelectNode(ExtTree, tree.Nodes, str);
            }
        }


        public TreeNode FindRootNode(TreeNode treeNode)
        {
            if (treeNode!=null && treeNode.Text != "All Tests")
            {
                while (treeNode.Parent != null && treeNode.Parent.Text != "All Tests")
                {
                    treeNode = treeNode.Parent;
                }
            }
            return treeNode;
        }



        public List<String> RememberExtendedTree(TreeNodeCollection theNodes)
        {
            List<String> aResult = new List<String>();
            if (theNodes != null)
            {
                foreach (System.Windows.Forms.TreeNode aNode in theNodes)
                {
                    if (aNode.IsExpanded)
                    {
                        aResult.Add(aNode.FullPath);
                    }
                    aResult.AddRange(RememberExtendedTree(aNode.Nodes));
                }
            }
            return aResult;
        }



        public void DeleteTags(TreeNode treeNode)
        {
            treeNode.Tag = new string[] { "", "" };
            foreach (TreeNode tn in treeNode.Nodes)
            {
                DeleteTags(tn);
            }
        }


        public TreeNode FindNode(TreeNodeCollection tncoll, String strText)
        {
            TreeNode tnFound;
            foreach (TreeNode tnCurr in tncoll)
            {
                if (tnCurr.FullPath == strText)
                {
                    tnCurr.Expand();
                    return tnCurr;
                }
                tnFound = FindNode(tnCurr.Nodes, strText);
                if (tnFound != null)
                {
                    return tnFound;
                }
            }
            return null;
        }


        public int TotalLines(string filePath)
        {
            using (StreamReader r = new StreamReader(filePath))
            {
                int i = 0;
                while (r.ReadLine() != null) { i++; }
                return i;
            }
        }



        public int FindLineNumber(string NodeName, string FilePath)
        {
            int hhh = TotalLines(FilePath);
            int LineNumber = 0;
            using (var reader = new System.IO.StreamReader(FilePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    line = line.Replace(@" ", @"");

                    string fff = "BOOST_AUTO_TEST_CASE(" + NodeName + ")";
                    string fff2 = "BOOST_AUTO_TEST_SUITE(" + NodeName + ")";

                    if (line.StartsWith(fff) || line.StartsWith(fff2)) break;
                    if (LineNumber != hhh) LineNumber++;
                }

                reader.Close();
            }
            return LineNumber;
        }



        public void OpenFileAndScroll(DTE2 dte, string FileFullPath, int LineNumber)
        {
            ProjectItem projItem = null;
            try
            {
                projItem = dte.Solution.FindProjectItem(FileFullPath);
            }
            catch
            {
            }
            if (projItem != null)
            {
                bool wasOpen = projItem.get_IsOpen(EnvDTE.Constants.vsViewKindCode);
                Window win = null;
                if (!wasOpen)
                {
                    win = projItem.Open(EnvDTE.Constants.vsViewKindCode);
                    win.Visible = true;
                    win.SetFocus();
                }
                else
                {
                    projItem.Document.Activate();
                }
                ((TextSelection)projItem.Document.Selection).GotoLine(LineNumber + 1);
                //((TextSelection)projItem.Document.Selection).GotoLine(LineNumber + 1, true);
            }
        }





    }
}
