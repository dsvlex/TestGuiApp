using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnvDTE;
using EnvDTE80;

using System.Windows.Forms;
using Microsoft.VisualStudio.VCProjectEngine;
using Microsoft.VisualStudio.VCProject;


namespace TestGuiApp
{

    public class ProjectPropertiesExtractor
    {

        private DTE2 IDTE2_;
        public ProjectPropertiesExtractor()
        {
            //IDTE2_ = dte;
            IDTE2_ = (DTE2)System.Runtime.InteropServices.Marshal.GetActiveObject("VisualStudio.DTE");
        }

        public DTE2 GetActiveIDE()
        {
            //DTE2 dte2;
            //dte2 = (DTE2)System.Runtime.InteropServices.Marshal.GetActiveObject("VisualStudio.DTE");
            return IDTE2_;
        }
              
        
        public NewProjectProperties GetProps()
        {
            IList<String> defines = StringBreake(GetPreprocessorDefinitions());
            IList<String> includes = StringBreakeIncludes(GetIncludes());
            IList<String> libpath = StringBreakeLibpath(GetLibpath());
            //includes 
            NewProjectProperties prop = new NewProjectProperties(defines, includes, libpath);
            //prop.FilePath = 
            return prop;
        }


        public string GetPreprocessorDefinitions()
        {
            string list = null;

            StringBuilder builder = new StringBuilder();

            EnvDTE80.DTE2 prj = GetActiveIDE();

            foreach (Project proj in prj.Solution.Projects)
            {
                // Only Interested in VC++ projects
                if (proj.Kind != vcContextGuids.vcContextGuidVCProject) continue;

                VCProject vcProj = (VCProject)proj.Object;
                IVCCollection configs = (IVCCollection)vcProj.Configurations;

                foreach (object conf in configs)
                {
                    VCConfiguration cfg = configs.Item(conf) as VCConfiguration;
                    if (cfg == null) break;

                    IVCCollection tools = cfg.Tools as IVCCollection;
                    if (tools == null) break;

                    VCCLCompilerTool compilerTool = tools.Item("VCCLCompilerTool") as VCCLCompilerTool;
                    if (compilerTool == null) break;

                    if (compilerTool.PreprocessorDefinitions != null)
                    {
                        list = Convert.ToString(builder.Append(compilerTool.PreprocessorDefinitions.ToString()).Append(";"));

                    }
                }
            }

            return list;
        }



        public string GetIncludes()
        {
            string list = null;

            StringBuilder builder = new StringBuilder();

            EnvDTE80.DTE2 prj = GetActiveIDE();

            foreach (Project proj in prj.Solution.Projects)
            {
                // Only Interested in VC++ projects
                if (proj.Kind != vcContextGuids.vcContextGuidVCProject) continue;

                VCProject vcProj = (VCProject)proj.Object;
                IVCCollection configs = (IVCCollection)vcProj.Configurations;

                foreach (object conf in configs)
                {
                    VCConfiguration cfg = configs.Item(conf) as VCConfiguration;
                    if (cfg == null) break;

                    IVCCollection tools = cfg.Tools as IVCCollection;
                    if (tools == null) break;

                    VCCLCompilerTool compilerTool = tools.Item("VCCLCompilerTool") as VCCLCompilerTool;
                    if (compilerTool == null) break;

                    if (compilerTool.AdditionalIncludeDirectories != null)
                    {
                        list = Convert.ToString(builder.Append(compilerTool.AdditionalIncludeDirectories.ToString()).Append(";"));

                    }
                }
            }

            return list;
        }


        public string GetLibpath()
        {
            string list = null;

            StringBuilder builder = new StringBuilder();

            EnvDTE80.DTE2 prj = GetActiveIDE();

            foreach (Project proj in prj.Solution.Projects)
            {
                // Only Interested in VC++ projects
                if (proj.Kind != vcContextGuids.vcContextGuidVCProject) continue;

                VCProject vcProj = (VCProject)proj.Object;
                IVCCollection configs = (IVCCollection)vcProj.Configurations;

                foreach (object conf in configs)
                {
                    VCConfiguration cfg = configs.Item(conf) as VCConfiguration;
                    if (cfg == null) break;

                    IVCCollection tools = cfg.Tools as IVCCollection;
                    if (tools == null) break;

                    VCLinkerTool compilerTool = tools.Item("VCLinkerTool") as VCLinkerTool;
                    if (compilerTool == null) break;

                    if (compilerTool.AdditionalLibraryDirectories != null)
                    {
                        list = Convert.ToString(builder.Append(compilerTool.AdditionalLibraryDirectories.ToString()).Append(";"));

                    }
                }
            }

            return list;
        }


                
        public IList<String> StringBreake(string str)
        {
            List<String> list = new List<String>();

            string strtr = GetPreprocessorDefinitions();

            string[] split = str.Split(';');
            foreach (string s in split)
            {
                if (s != "") list.Add(s);
            }

            List<string> distinct = list.Distinct().ToList();
            return distinct;
        }

        public IList<String> StringBreakeIncludes(string str)
        {
            List<String> list = new List<String>();

            string strtr = GetIncludes();

            string[] split = str.Split(';');
            foreach (string s in split)
            {
                if (s != "") list.Add(s);
            }

            List<string> distinct = list.Distinct().ToList();
            return distinct;
        }

        public IList<String> StringBreakeLibpath(string str)
        {
            List<String> list = new List<String>();

            string strtr = GetLibpath();

            string[] split = str.Split(';');
            foreach (string s in split)
            {
                if (s != "") list.Add(s);
            }

            List<string> distinct = list.Distinct().ToList();
            return distinct;
        }
         


    }
}
