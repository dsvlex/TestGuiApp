using System.Collections.Generic;

namespace TestGuiApp
{
    public enum AppExceptionLevel { InitError, ImportError, CreateError, UnknownError }
 
    public class AppException : System.ApplicationException
    {

        private AppExceptionLevel _el;
        public AppExceptionLevel ExceptionLevel 
        { 
            get { return _el; }
            set { _el = value; }
        }

        public string LevelDescription;
        public List<string> Messages;

        public AppException(AppExceptionLevel level, string message)
            : base(message)
        {
            SetLevel(level);

        }

        public AppException(AppExceptionLevel level, string message, List<string> others)
            : base(message)
        {
            SetLevel(level);
            Messages = others;
        }

        private void SetLevel(AppExceptionLevel level)
        {
            ExceptionLevel = level;

            switch (level)
            {
                case AppExceptionLevel.InitError:
                    LevelDescription = "Initialization error";
                    break;
                case AppExceptionLevel.ImportError:
                    LevelDescription = "Import Error";
                    break;
                case AppExceptionLevel.CreateError:
                    LevelDescription = "Creation Error";
                    break;
                default:
                    LevelDescription = "Error";
                    break;
            }
        }
    }
}
