using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SVControls
{
    public partial class ListBuilder : UserControl
    {
        public ListBuilder()
        {
            InitializeComponent();
            ChangeSize();
        }

        public void Init(List<string> list)
        {
            listBoxLeft.Items.Clear();
            listBoxLeft.Items.AddRange(list.ToArray());
        }

        public void Init(List<string> list, List<string> setted)
        {
            listBoxLeft.Items.Clear();
            List<string> rest = new List<string>();
            foreach (string s in list)
                if (!setted.Contains(s))
                    rest.Add(s);
            listBoxLeft.Items.AddRange(rest.ToArray());
            listBoxRight.Items.AddRange(setted.ToArray());
        }

        public List<string> GetResult()
        {
            List<string> list = new List<string>();
            //TODO:
            foreach (string str in listBoxRight.Items)
            {
                list.Add(str);
            }

            //list.AddRange(listBoxRight.Items.Select(item => ((ListItem)item).Value));
            //list.AddRange(listBoxRight.Items.);
            return list;
            //return listBoxRight.Items.Cast<String>().ToList();
            //return listBoxRight.Items.OfType<string>().ToList();
        }

        private void MoveItemBetween(ref ListBox first, ref ListBox second)
        {
            if (first.SelectedItem == null)
                return;
            second.Items.Add(first.SelectedItem.ToString());
            int selectiedIndex = first.SelectedIndex;
            first.Items.Remove(first.SelectedItem);
            if (first.Items.Count == 0)
                return;
            if (first.Items.Count == selectiedIndex)
                first.SetSelected(selectiedIndex - 1, true);
            else
                first.SetSelected(selectiedIndex, true);
        }

        private void MoveOneLeft()
        {
            MoveItemBetween(ref listBoxRight, ref listBoxLeft);
        }

        private void MoveOneRight()
        {
            MoveItemBetween(ref listBoxLeft, ref listBoxRight);
        }

        private void MoveUp()
        {
            if (listBoxRight.SelectedItem == null)
                return;
            int selectedIndex = listBoxRight.SelectedIndex;
            if (selectedIndex == 0)
                return;
            listBoxRight.Items.Insert(selectedIndex - 1, listBoxRight.SelectedItem.ToString());
            listBoxRight.Items.RemoveAt(selectedIndex + 1);
            listBoxRight.SetSelected(selectedIndex - 1, true);
        }

        private void MoveDown()
        {
            if (listBoxRight.SelectedItem == null)
                return;
            int selectedIndex = listBoxRight.SelectedIndex;
            if (selectedIndex + 1 == listBoxRight.Items.Count)
                return;
            listBoxRight.Items.Insert(selectedIndex + 2, listBoxRight.SelectedItem.ToString());
            listBoxRight.Items.RemoveAt(selectedIndex);
            listBoxRight.SetSelected(selectedIndex + 1, true);
        }

        private void ChangeSize()
        {
            int panelWidth = (this.Size.Width - this.panel1.Size.Width) / 2 - this.listBoxLeft.Location.X;
            int panelHeight = this.Size.Height - this.listBoxLeft.Location.Y * 2;
            this.SuspendLayout();
            this.listBoxLeft.Size = new Size(panelWidth, panelHeight);
            this.panel1.Location = new Point(this.listBoxLeft.Location.X + panelWidth, this.listBoxLeft.Location.Y);
            this.panel1.Size = new Size(panel1.Size.Width, panelHeight);
            this.listBoxRight.Location = new Point(this.panel1.Location.X + this.panel1.Size.Width, this.listBoxLeft.Location.Y);
            this.listBoxRight.Size = new Size(panelWidth, panelHeight);
            this.ResumeLayout();
        }

        private void buttonAddOne_Click(object sender, EventArgs e)
        {
            MoveOneRight();
        }

        private void OnRightBoxMouseDoubleClick(object sender, MouseEventArgs e)
        {
            MoveOneLeft();
        }

        private void buttonAddAll_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            MoveUp();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {
            ChangeSize();
        }

        private void OnLeftBoxMouseDoubleClick(object sender, MouseEventArgs e)
        {
            MoveOneRight();
        }

        private void buttonRemoveOne_Click(object sender, EventArgs e)
        {
            MoveOneLeft();
        }

        private void listBoxLeft_MouseMove(object sender, MouseEventArgs e)
        {
            //// See what item is under the mouse.
            //int index = listBoxLeft.IndexFromPoint(e.Location);

            //// Just use the item's value for the tooltip.
            //string tip = listBoxLeft.Items[index].ToString();

            //// Display the item's value as a tooltip.
            //if (toolTip1.GetToolTip(listBoxLeft) != tip)
            //    toolTip1.SetToolTip(listBoxLeft, tip);



            ListBox lb = (ListBox)sender;
            int index = lb.IndexFromPoint(e.Location);

            if (index >= 0 && index < lb.Items.Count)
            {
                string toolTipString = lb.Items[index].ToString();

                // check if tooltip text coincides with the current one,
                // if so, do nothing
                if (toolTip1.GetToolTip(lb) != toolTipString)
                    toolTip1.SetToolTip(lb, toolTipString);
            }
            else
                toolTip1.Hide(lb);


        }

        private void listBoxRight_MouseMove(object sender, MouseEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            int index = lb.IndexFromPoint(e.Location);

            if (index >= 0 && index < lb.Items.Count)
            {
                string toolTipString = lb.Items[index].ToString();

                // check if tooltip text coincides with the current one,
                // if so, do nothing
                if (toolTip1.GetToolTip(lb) != toolTipString)
                    toolTip1.SetToolTip(lb, toolTipString);
            }
            else
                toolTip1.Hide(lb);
        }

    }
}
