using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnvDTE80;
using SVControls;

namespace TestGuiApp
{
    class NewSuiteTest
    {


        public void CreateTest(StringBuilder builder, string testSuit, List<string> cases, string fileName)
        {

            try
            {
                using (StreamWriter stream = new StreamWriter(fileName, true))
                {
                    int qw = 0;
                    builder.Append("BOOST_AUTO_TEST_SUITE(" + testSuit + ")\r\n")
                           .Append(
                               (String.Concat(
                                   Enumerable.Repeat("", cases.Count)
                                             .Select(
                                                 t =>
                                                 "\r\nBOOST_AUTO_TEST_CASE(" + cases[qw++] +
                                                 ")\r\n{\r\n\tBOOST_CHECK(1 == 3);\r\n}\r\n"))))
                           .Append("\r\nBOOST_AUTO_TEST_SUITE_END()");


                    //builder.Append("dcd"); //для проверки теста
                    Debug.WriteLine(builder);
                    stream.WriteLine(builder);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("File is busy");
                return;
            }


            try
            {
                string jdkkjfkd = Path.GetDirectoryName(MWin.FileNamePath_) + "\\" +
                                  Path.GetFileNameWithoutExtension(MWin.FileNamePath_) + ".vcxproj";
                //build project
                ProjectPropertiesExtractor prj = new ProjectPropertiesExtractor();
                DTE2 dte2_ = prj.GetActiveIDE();
                dte2_.Solution.SolutionBuild.BuildProject("Debug", jdkkjfkd, true);


            }

            catch (Exception)
            {
                MessageBox.Show("\"Build process\" is running. Tests will be added");
                return;
            }


        }

    }
}
