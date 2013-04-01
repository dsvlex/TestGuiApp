using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SVControls
{
    public partial class ExtendedTree : UserControl
    {
        public ExtendedTree()
        {
            InitializeComponent();
        }



        [Description("TreeView associated with the control"), Category("Behavior")]
        public TreeView TreeView
        {
            get { return this.treeView1; }
        }

        [Description("Columns associated with the control"), Category("Behavior")]
        public ListView.ColumnHeaderCollection Columns
        {
            get { return this.listView1.Columns; }
        }


        public void Insert(ExtendedTreeNode etn)
        {
            this.treeView1.Nodes.Add(etn);
        }

        public void Insert(ExtendedTreeNode etn, string[] path)
        {
            FindNodeCollection(this.treeView1.Nodes, path.GetEnumerator()).Add(etn);
        }

        public void Insert(TreeNodeCollection where, ExtendedTreeNode etn, string[] path)
        {
            FindNodeCollection(where, path.GetEnumerator()).Add(etn);
        }

        public void RemoveAt(string what)
        {
            this.treeView1.Nodes.RemoveByKey(what);
        }

        private TreeNodeCollection FindNodeCollection(TreeNodeCollection where,
                                                      System.Collections.IEnumerator enumerator)
        {
            if (!enumerator.MoveNext())
                return where;

            TreeNode[] nodes = where.Find((string) enumerator.Current, false);
            if (nodes == null || nodes.Length == 0)
                return where;

            foreach (TreeNode node in nodes)
                return FindNodeCollection(node.Nodes, enumerator);

            return where;
        }

        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            e.DrawDefault = true;

            Rectangle rect = e.Bounds;

            if ((e.State & TreeNodeStates.Selected) != 0)
            {
                if ((e.State & TreeNodeStates.Focused) != 0)
                    e.Graphics.FillRectangle(SystemBrushes.Highlight, rect);
                else
                    e.Graphics.FillRectangle(SystemBrushes.Control, rect);
            }
            else
                e.Graphics.FillRectangle(Brushes.White, rect);

            //e.Graphics.DrawRectangle(SystemPens.Control, rect);

            for (int intColumn = 1; intColumn < this.listView1.Columns.Count; intColumn++)
            {
                rect.Offset(this.listView1.Columns[intColumn - 1].Width, 0);
                rect.Width = this.listView1.Columns[intColumn].Width;

                //e.Graphics.DrawRectangle(SystemPens.Control, rect);

                string strColumnText;
                string[] list = e.Node.Tag as string[];
                if (list == null)
                    strColumnText = "";
                else
                    strColumnText = list[intColumn - 1]; // dummy

                TextFormatFlags flags = TextFormatFlags.EndEllipsis;
                switch (this.listView1.Columns[intColumn].TextAlign)
                {
                    case HorizontalAlignment.Center:
                        flags |= TextFormatFlags.HorizontalCenter;
                        break;
                    case HorizontalAlignment.Left:
                        flags |= TextFormatFlags.Left;
                        break;
                    case HorizontalAlignment.Right:
                        flags |= TextFormatFlags.Right;
                        break;
                    default:
                        break;
                }

                rect.Y++;
                if ((e.State & TreeNodeStates.Selected) != 0 &&
                    (e.State & TreeNodeStates.Focused) != 0)
                    TextRenderer.DrawText(e.Graphics, strColumnText, e.Node.NodeFont, rect, SystemColors.HighlightText,
                                          flags);
                else
                    TextRenderer.DrawText(e.Graphics, strColumnText, e.Node.NodeFont, rect, e.Node.ForeColor,
                                          e.Node.BackColor, flags);
                rect.Y--;
            }
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            Point p = this.treeView1.PointToClient(Control.MousePosition);
            TreeNode tn = this.treeView1.GetNodeAt(p);
            if (tn != null)
                this.treeView1.SelectedNode = tn;
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.treeView1.Focus();
        }

        private void listView1_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            this.treeView1.Focus();
            this.treeView1.Invalidate();
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            this.treeView1.Focus();
            this.treeView1.Invalidate();
        }



        public List<String> CheckedNames(TreeNodeCollection theNodes)
        {
            List<String> aResult = new List<String>();
            if (theNodes != null)
            {
                foreach (System.Windows.Forms.TreeNode aNode in theNodes)
                {
                    if (aNode.Checked)
                    {
                        aResult.Add(aNode.Text);
                    }
                    aResult.AddRange(CheckedNames(aNode.Nodes));
                }
            }
            return aResult;
        }


        private TreeNodeCollection svNodes_;

        public TreeNodeCollection svNodes
        {
            get { return svNodes_; }
            set { svNodes_ = this.treeView1.Nodes; }
        }

        public TreeNode svSelectedNode
        {
            get { return this.treeView1.SelectedNode; }
            set { this.treeView1.SelectedNode = value; }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UncheckAllNodes(this.treeView1.Nodes);
            if (e.Node.GetNodeCount(true) == 0)
            {
                e.Node.Checked = true;
            }

        }

        private void UncheckAllNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.Checked = false;
                CheckChildren(node, false);
            }
        }

        private void CheckChildren(TreeNode rootNode, bool isChecked)
        {
            foreach (TreeNode node in rootNode.Nodes)
            {
                CheckChildren(node, isChecked);
                node.Checked = isChecked;
            }
        }


        public event EventHandler treeView1NodeMouseDoubleClick;

        protected void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //bubble the event up to the parent
            if (this.treeView1NodeMouseDoubleClick != null)
                this.treeView1NodeMouseDoubleClick(this, e);

        }


        public void FillTreeView()
        {
            ////  Load the images in an ImageList. 
            //ImageList imageList1 = new ImageList();
            //imageList1.Images.Add(Image.FromFile(@"c:\_Copy of 1363879920_onebit_39_test.png"));
            //imageList1.Images.Add(Image.FromFile(@"c:\_1363879899_onebit_13_proj.png"));
            //imageList1.Images.Add(Image.FromFile(@"c:\_1363879924_talk_chat_suite.png"));
            //imageList1.Images.Add(Image.FromFile(@"c:\_1363879920_onebit_39_test.png"));
            ////ImageList.Images.Add(Image.FromFile(@"c:\1361438965_refresh.png"));
            ////  Assign the ImageList to the TreeView.
            treeView1.ImageList = imageList1;
        }


        //public void Rem(TreeNodeCollection theNodes)
        //{
        //    //List<String> aResult = new List<String>();
        //    //if (theNodes != null)
        //    //{

        //    //FillTreeView();  

        //    //FillTreeView();   
        //     if (theNodes != null)
        //     {

        //    foreach (TreeNode aNode in theNodes)
        //    {

               

        //            if (aNode.Level == 0)
        //            {
        //                aNode.ImageIndex = 0;
        //                aNode.SelectedImageIndex = 0;
        //                //aResult.Add(aNode.FullPath);
        //            }


        //            //if (aNode.Level == 1)
        //            //{
        //            //    aNode.ImageIndex = 1;
        //            //    aNode.SelectedImageIndex = 1;
        //            //    //return;
        //            //    //aResult.Add(aNode.FullPath);
        //            //}


        //            //if (aNode.Level == 2)
        //            //{
        //            //    aNode.ImageIndex = 2;
        //            //    aNode.SelectedImageIndex = 2;

        //            //}


        //            //if (aNode.Level == 3)
        //            //{
        //            //    aNode.ImageIndex = 3;
        //            //    aNode.SelectedImageIndex = 3;

        //            //}

        //            Rem(theNodes);

        //        }
        //    }





        //}


        public void rem (TreeNode treeNode)
        {
            if (treeNode.Level == 0)
            {
                treeNode.ImageIndex = 0;
                treeNode.SelectedImageIndex = 0;
            }

            if (treeNode.Level == 1)
            {
                treeNode.ImageIndex = 1;
                treeNode.SelectedImageIndex = 1;
            }

            if (treeNode.Level == 2)
            {
                treeNode.ImageIndex = 2;
                treeNode.SelectedImageIndex = 2;
            }

            if (treeNode.Level == 3)
            {
                treeNode.ImageIndex = 3;
                treeNode.SelectedImageIndex = 3;
            }

            foreach (TreeNode tn in treeNode.Nodes)
            {
                rem(tn);
            }

        }


       
    }
}
