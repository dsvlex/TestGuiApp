using System.Drawing;
using System.Windows.Forms;
using TestGuiApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SVControls;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for MWinTest and is intended
    ///to contain all MWinTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MWinTest
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
        ///A test for FindRootNode
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TestGuiApp.dll")]
        public void FindRootNodeTest()
        {
            ExtendedTree TreeViewActual1 = new ExtendedTree();
            TreeViewActual1.svNodes = null;
            TreeNode treeNodeActualAllTests1 = new TreeNode("All Tests");
            TreeNode treeNodeActual1 = new TreeNode("T1");
            TreeNode treeNodeActual2 = new TreeNode("T2");
            TreeNode treeNodeActual3 = new TreeNode("T3");
            TreeViewActual1.svNodes.Add(treeNodeActualAllTests1);
            TreeViewActual1.svNodes[0].Nodes.Add(treeNodeActual1);
            TreeViewActual1.svNodes[0].Nodes[0].Nodes.Add(treeNodeActual2);
            TreeViewActual1.svNodes[0].Nodes[0].Nodes[0].Nodes.Add(treeNodeActual3);

            MWinProc target = new MWinProc();
            TreeNode treeNodeExpected = target.FindRootNode(treeNodeActual3);
            Assert.AreEqual(treeNodeExpected.Text, treeNodeActual1.Text);

        }
    }
}
