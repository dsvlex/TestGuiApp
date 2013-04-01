using System;
using System.Collections.Generic;
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

    public delegate void ICommandDelegate();

    
    public class TestProc
    {



        GUIController GUIController_;
        NewProject NewProject_;
        ExtendedTree ExtendedTree_;

        
        const string RootNode = "All Tests";

        public TestProc(DTE2 a, ExtendedTree etree)
        {
            GUIController_ = new GUIController();
            NewProject_ = new NewProject(a);
            ExtendedTree_ = etree;
            ExtendedTree_.Insert(new ExtendedTreeNode(RootNode, false));

            
            /////////////////////

            //находим каталог солюшина и получаем все файлы с расширением ".cpp"
            //
            EnvDTE80.DTE2 dte = (EnvDTE80.DTE2)System.Runtime.InteropServices.Marshal.GetActiveObject("VisualStudio.DTE");
            if (string.IsNullOrEmpty(dte.Solution.FullName)) return;
            string solutionDir = System.IO.Path.GetDirectoryName(dte.Solution.FullName);
            string[] strSource = Directory.GetFiles(solutionDir, "*.cpp", SearchOption.AllDirectories);

            //список для заполнения словаря тестов
            //
            List<string[]> testList = new List<string[]>();

            //содержание файла .cpp для поиска названия SUITE
            //
            List<string> textStringsList = new List<string>();

            foreach (string cppFileName in strSource)
            {
                StreamReader str = new StreamReader(cppFileName, Encoding.Default);
                while (!str.EndOfStream)
                {
                    string testName = str.ReadLine();

                    textStringsList.Add(testName); //параллельно заполняем для поиска названия Suite

                    if (testName.StartsWith("BOOST_AUTO_TEST_CASE"))
                    {
                        string suiteName = null;

                        foreach (string textString in textStringsList.Reverse<string>())
                        {
                            if (textString.StartsWith("BOOST_AUTO_TEST_SUITE_END")) break;
                            if (textString.StartsWith("BOOST_AUTO_TEST_SUITE") && !textString.StartsWith("BOOST_AUTO_TEST_SUITE_END"))
                            {
                                suiteName = textString.ToString();
                                break;
                            }
                            else
                            {
                                suiteName = "";
                            }
                        }

                        testList.Add(new string[] { cppFileName, suiteName, testName });
                    }
                }
            }

            //создаем и заполняем словарь
            //
            Dictionary<string, Dictionary<string, List<string>>> slovar = new Dictionary<string, Dictionary<string, List<string>>>();

            foreach (string[] strgArray in testList)
            {
                if (!slovar.ContainsKey(strgArray[0]))
                    slovar.Add(strgArray[0], new Dictionary<string, List<string>> { { strgArray[1], new List<string> { strgArray[2] } } });
                else
                    if (!slovar[strgArray[0]].ContainsKey(strgArray[1]))
                        slovar[strgArray[0]].Add(strgArray[1], new List<string> { strgArray[2] });
                    else
                        slovar[strgArray[0]][strgArray[1]].Add(strgArray[2]);
            }

            //заполняем дерево тестов
            //
            const string RootNode1 = "All Tests";

            foreach (var node0 in slovar)
            {
                ///Формируем заголовок списка
                ///
                ExtendedTreeNode projNode = new ExtendedTreeNode(RemovePunctuationSymbols(Path.GetFileName(node0.Key)), true);
                string[] rootPath = { RootNode1 };
                ExtendedTree_.Insert(projNode, rootPath);

                foreach (var node1 in node0.Value)
                {
                    ///Формируем подзаголовок второго уровня
                    ///
                    ExtendedTreeNode projNode1 = new ExtendedTreeNode(RemovePunctuationSymbols(node1.Key.ToString()), true);
                    projNode.Nodes.Add(projNode1);

                    foreach (var node2 in node1.Value)
                    {
                        ///Выводим элементы
                        ///
                        ExtendedTreeNode projNode2 = new ExtendedTreeNode(RemovePunctuationSymbols(node2.ToString()), true);
                        projNode1.Nodes.Add(projNode2);

                    }
                }
            }


        }


        public static string RemovePunctuationSymbols(string str)
        {
            str = Regex.Replace(str, "[ ()]", "");
            str = Regex.Replace(str, ".cpp", "");
            str = Regex.Replace(str, "BOOST_AUTO_TEST_CASE", "");
            str = Regex.Replace(str, "BOOST_AUTO_TEST_SUITE", "");

            return str.Trim();
        }


        public static IList<Project> Projects()
        {
            ProjectPropertiesExtractor prj = new ProjectPropertiesExtractor();

            Projects projects = prj.GetActiveIDE().Solution.Projects;
            List<Project> list = new List<Project>();
            var item = projects.GetEnumerator();
            while (item.MoveNext())
            {
                var project = item.Current as Project;
                if (project == null)
                {
                    continue;
                }

                if (project.Kind == ProjectKinds.vsProjectKindSolutionFolder)
                {
                    list.AddRange(GetSolutionFolderProjects(project));
                }
                else
                {
                    list.Add(project);
                }
            }

            return list;
        }

        private static IEnumerable<Project> GetSolutionFolderProjects(Project solutionFolder)
        {
            List<Project> list = new List<Project>();
            for (var i = 1; i <= solutionFolder.ProjectItems.Count; i++)
            {
                var subProject = solutionFolder.ProjectItems.Item(i).SubProject;
                if (subProject == null)
                {
                    continue;
                }

                // If this is another solution folder, do a recursive call, otherwise add
                if (subProject.Kind == ProjectKinds.vsProjectKindSolutionFolder)
                {
                    list.AddRange(GetSolutionFolderProjects(subProject));
                }
                else
                {
                    list.Add(subProject);
                }
            }

            return list;
        }


        
        public void CreateTestProject()
        {
            GUIController_.AddCommand(new ICommandDelegate(OnCreateTestProjectCommand));
        }
         
        /*
        public void AddTestSuit()
        {
            GUIController_.AddCommand(new ICommandDelegate(OnAddTestSuitCommand));
        }

        public void AddTestSuitFixture()
        {
            GUIController_.AddCommand(new ICommandDelegate(OnAddTestSuitFixtureCommand));
        }

        public void AddTestCase()
        {
            GUIController_.AddCommand(new ICommandDelegate(OnAddTestCaseCommand));
        }

        public void AddTestCaseFixture()
        {
            GUIController_.AddCommand(new ICommandDelegate(OnAddTestCaseFixtureCommand));
        }
          
        */  

        delegate void StringListParameterDelegate(List<string> added);
        
        
        public void OnCreateTestProjectCommand()
        {
            List<string> added = NewProject_.Create();
            if (added == null)
                return;

            if (ExtendedTree_.InvokeRequired)
            {
                // We're not in the UI thread, so we need to call BeginInvoke
                ExtendedTree_.BeginInvoke(new StringListParameterDelegate(NewTestProject), new object[] { added });
                return;
            }
            else
                NewTestProject(added);
        }
         

        
        private void NewTestProject(List<string> path)
        {
            if (path.Count == 0 || path[0].Trim() == string.Empty)
                return;

            ExtendedTreeNode projNode = new ExtendedTreeNode(path[0], true);
            if (path.Count > 1)
            {
                ExtendedTreeNode suitNode = new ExtendedTreeNode(path[1], true);
                if (path.Count > 2)
                {
                    ExtendedTreeNode caseNode = new ExtendedTreeNode(path[2], true);
                    suitNode.Nodes.Add(caseNode);
                }
                projNode.Nodes.Add(suitNode);
            }

            //!!!insert new project (wrong)
            //string[] rootPath = { RootNode };
            //ExtendedTree_.Insert(projNode, rootPath);
        }
        

        public void OnAddTestSuitCommand()
        {

        }

        public void OnAddTestSuitFixtureCommand()
        {

        }

        public void OnAddTestCaseCommand()
        {

        }

        public void OnAddTestCaseFixtureCommand()
        {

        }





    }
}
