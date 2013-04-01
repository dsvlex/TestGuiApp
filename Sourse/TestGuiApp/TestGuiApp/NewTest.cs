using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EnvDTE80;

namespace TestGuiApp
{
    class NewTest
    {
        
        public void CreateTest(string testSuit, string test, string fileName)
        {
            string titleMatch;
            string text;

            
            //find text inside suite
            try
            {
                using (StreamReader streamReader = new StreamReader(fileName))
                {
                    text = streamReader.ReadToEnd();
                    titleMatch =
                        new Regex("BOOST_AUTO_TEST_SUITE[(]" + testSuit + "[)]" + "(.*?)BOOST_AUTO_TEST_SUITE_END",
                                  RegexOptions.IgnoreCase | RegexOptions.Singleline).Match(text).Groups[1].Value;

                }


                //text inside suite in string
                StringBuilder ss = new StringBuilder(titleMatch);

                //text from file in string
                StringBuilder builder22 = new StringBuilder(text);


                //message
                if (titleMatch == "")
                {
                    MessageBox.Show("Replace space's in suite name");
                    return;
                }

                //add new test by replacement
                builder22.Replace(titleMatch,
                                  ss.Append("BOOST_AUTO_TEST_CASE (" + test +
                                            ")\r\n{\r\n\tBOOST_CHECK(1 == 3);\r\n}\r\n").ToString());


                //write back new string with test to file
                string y = builder22.ToString();

                File.WriteAllText(fileName, string.Empty);
                StreamWriter file2 = new StreamWriter(fileName, true);
                file2.WriteLine(y);
                file2.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("File is busy");
                return;
            }


            //file project path
            string jdkkjfkd = Path.GetDirectoryName(MWin.FileNamePath_) +"\\"+ Path.GetFileNameWithoutExtension(MWin.FileNamePath_) + ".vcxproj";
            
            //build project

            try
            {
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



        public void CreateTestEmpty(StringBuilder builder, string test, string fileName)
        {
            //add new test to the end of the file
            try
            {
                using (StreamWriter stream = new StreamWriter(fileName, true))
                {
                    int qw = 0;
                    builder.Append("BOOST_AUTO_TEST_CASE (" + test + ")\r\n{\r\n\tBOOST_CHECK(1 == 3);\r\n}\r\n");


                    Debug.WriteLine(builder);
                    stream.WriteLine(builder);

                }
            }

            catch (Exception)
            {
                MessageBox.Show("File is busy");
                return;
            }


            //file project path
            string jdkkjfkd = Path.GetDirectoryName(MWin.FileNamePath_) + "\\" + Path.GetFileNameWithoutExtension(MWin.FileNamePath_) + ".vcxproj";
            
            //build project

            try
            {
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
