using System.IO;
using System.Text;
using WolvenKit.Common.Services;
using WolvenKit.CR2W;
using WolvenKit.Functionality.Controllers;

namespace WolvenKit.MVVM.ViewModels.Shell.Editor.Documents
{
    public class ScriptDocumentViewModel : CloseableViewModel, Old_IDocumentViewModel
    {
        #region Constructors

        public ScriptDocumentViewModel(IWindowFactory windowFactory) : base(windowFactory)
        {
        }

        #endregion Constructors

        #region Properties

        public string FileName => Path.GetFileName(FilePath);
        public string FilePath { get; set; }
        public bool IsUnsaved { get; private set; }
        public object SaveTarget { get; set; }
        public override string Title => FileName;

        #region Text

        private string _text;

        public string Text
        {
            get => _text;
            set
            {
                if (_text != value)
                {
                    var oldValue = _text;
                    _text = value;
                    RaisePropertyChanged(() => Text, oldValue, value);

                    // notify unsaved
                    IsUnsaved = true;
                    FormTitle = $"{FileName}*";
                }
            }
        }

        #endregion Text

        #region FormTitle

        private string _formTitle;

        public string FormTitle
        {
            get => _formTitle;
            set
            {
                if (_formTitle != value)
                {
                    var oldValue = _formTitle;
                    _formTitle = value;
                    RaisePropertyChanged(() => FormTitle, oldValue, value);
                }
            }
        }

        #endregion FormTitle

        #endregion Properties

        #region Methods

        public void SaveFile()
        {
            MainController.Get().ProjectStatus = EProjectStatus.Busy;
            // encode in UTF-16LE
            var enc = Encoding.Unicode;

            File.WriteAllText(FilePath, Text, enc);

            MainController.LogString(FilePath + " saved!", Logtype.Normal);

            // register all new classes
            CR2WManager.ReloadAssembly(MainController.Get().Logger);

            IsUnsaved = false;
            FormTitle = Path.GetFileName(FilePath);

            // Logging
            MainController.LogString(FileName + " saved!\n", Logtype.Success);
            MainController.Get().ProjectStatus = EProjectStatus.Ready;
        }

        #endregion Methods
    }
}
