using SVControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for ExtendedTreeTest and is intended
    ///to contain all ExtendedTreeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ExtendedTreeTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for CheckedNames
        ///</summary>
        [TestMethod()]
        public void CheckedNamesTest()
        {
            ExtendedTree TreeViewExpected = new ExtendedTree();
            TreeViewExpected.svNodes = null;
            TreeNode treeNodeExpected1 = new TreeNode("T1");
            TreeNode treeNodeExpected2 = new TreeNode("T2");
            TreeViewExpected.svNodes.Add(treeNodeExpected1);
            TreeViewExpected.svNodes[0].Nodes.Add(treeNodeExpected2);
            treeNodeExpected2.Checked = true;

            TreeNodeCollection TreeNodeCollection_ = TreeViewExpected.svNodes;
            ExtendedTree target = new ExtendedTree();

            int nodesCountExpected = target.CheckedNames(TreeNodeCollection_).Count;
            int nodesCountActual = 1;

            Assert.AreEqual(nodesCountExpected, nodesCountActual);


        }
    }
}
