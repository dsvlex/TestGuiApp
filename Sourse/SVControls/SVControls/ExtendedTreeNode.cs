using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace SVControls
{
    public class ExtendedTreeNode : TreeNode
    {
        public ExtendedTreeNode(ExtendedTreeInfo info)
        {
            this.Name = info.Name;
            this.Text = info.Name;
            info_ = new ExtendedTreeInfo(info);
        }

        public ExtendedTreeNode(string name, bool check)
        {
            info_ = new ExtendedTreeInfo(name);
            this.Name = name;
            this.Text = name;
            if (check)
                SetChecked();
            else
                SetUnchecked();
        }

        private ExtendedTreeInfo info_;
        public ExtendedTreeInfo Info
        {
            get { return info_; }
            set { info_ = value; }
        }
        
        public void SetChecked()
        {
            this.SelectedImageIndex = 2;
        }

        public void SetUnchecked()
        {
            this.SelectedImageIndex = 0;
        }

    }

    public class ExtendedTreeInfo
    {
        public ExtendedTreeInfo(string name)
        {
            Name = name;
            Status = ShowedStatus.Checked;
            Total = 0;
            Passed = 0;
            Warnings = 0;
            Errors = 0;
        }

        public ExtendedTreeInfo(ExtendedTreeInfo info)
        {
            Name = info.Name;
            Status = info.Status;
            Total = info.Total;
            Passed = info.Passed;
            Warnings = info.Warnings;
            Errors = info.Errors;
        }

        private string name_;
        public string Name
        {
            get { return name_; }
            set { name_ = value; }
        }
        
        private ShowedStatus status_;
        public ShowedStatus Status
        {
            get { return status_; }
            set { status_ = value; }
        }

        int total_;
        public int Total
        {
            get { return total_; }
            set { total_ = value; }
        }
        int passed_;
        public int Passed
        {
            get { return passed_; }
            set { passed_ = value; }
        }
        int warnings_;
        public int Warnings
        {
            get { return warnings_; }
            set { warnings_ = value; }
        }
        int errors_;
        public int Errors
        {
            get { return errors_; }
            set { errors_ = value; }
        }
    }


    public enum ShowedStatus
    {
        Unknown = 0,
        Checked,
        OK,
        Info,
        Warning,
        Serious,
        Checkpoint,
        Error,
        Fatal
    }

}


