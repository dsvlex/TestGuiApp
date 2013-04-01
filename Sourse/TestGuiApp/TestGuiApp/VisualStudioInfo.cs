using System;
using EnvDTE;
using EnvDTE80;
using System.Collections.Generic;
using System.Text;

namespace TestGuiApp
{
    class VisualStudioInfo
    {
        public VisualStudioInfo(DTE2 dte)
        {
            string rgRoot = dte.RegistryRoot;
            if (rgRoot.Contains("10."))
            {
                _vsVersion = 100;
            }
            else if (rgRoot.Contains("9."))
            {
                _vsVersion = 90;
            }
            else if (rgRoot.Contains("8."))
            {
                _vsVersion = 80;
            }
            else
                throw new AppException(AppExceptionLevel.InitError, "Unsupported VIsual Studio version");
        }

        public string GetGUIDStr()
        {
            switch (_vsVersion)
            {
                case 80:
                    return "{081313A3-41BD-4068-8998-2585868B361F}";
                case 90:
                    return "{E3657D38-2B24-4c64-A6BB-134F086FD6A9}";
                case 100:
                    return "{9D977C07-C0E4-40ca-87B3-18F52D9909CE}";
                default:
                    return "{2149DED6-5A1A-4e0f-B84F-7F1D70C4FA6C}";
            }
        }

        private int _vsVersion;

        public int VsVersion
        {
            get { return _vsVersion; }
            set { _vsVersion = value; }
        }
    }
}
