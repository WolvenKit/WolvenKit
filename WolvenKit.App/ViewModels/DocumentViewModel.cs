using System;
using System.IO;
using System.Windows.Input;
using WolvenKit.App.Commands;
using WolvenKit.App.Model;
using WolvenKit.CR2W;
using WolvenKit.Radish.Model;

namespace WolvenKit.App.ViewModels
{
    public class DocumentViewModel : CloseableViewModel
    {

        public DocumentViewModel()
        {
            cmd1 = new RelayCommand(cm1, canrm1);

        }

        #region Fields
        public event EventHandler<FileSavedEventArgs> OnFileSaved;

        #endregion

        #region Properties
        public object SaveTarget { get; set; }
        #region File
        private CR2WFile _file;
        public CR2WFile File
        {
            get => _file;
            set
            {
                if (_file != value)
                {
                    _file = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        #region FileName
        public virtual string FileName => File.FileName;
        #endregion
        #region FormText
        private string _formText;
        public string FormText
        {
            get => _formText;
            set
            {
                if (_formText != value)
                {
                    _formText = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        public string Title => Path.GetFileName(FileName);

        #endregion

        #region Commands
        public ICommand cmd1 { get; }

        #endregion

        #region Commands Implementation
        protected bool canrm1() => RadishController.Get().IsHealthy();
        protected void cm1() { }


        #endregion

        #region Methods
        public void SaveFile()
        {
            if (SaveTarget == null)
            {
                saveToFileName();
            }
            else
            {
                saveToMemoryStream();
            }
        }
        private void saveToMemoryStream()
        {
            using (var mem = new MemoryStream())
            {
                using (var writer = new BinaryWriter(mem))
                {
                    File.Write(writer);

                    if (OnFileSaved != null)
                    {
                        OnFileSaved(this, new FileSavedEventArgs { FileName = FileName, Stream = mem, File = File });
                    }
                }
            }
        }

        private void saveToFileName()
        {
            //try
            //{
            using (var mem = new MemoryStream())
            using (var writer = new BinaryWriter(mem))
            {
                File.Write(writer);
                mem.Seek(0, SeekOrigin.Begin);

                using (var fs = new FileStream(FileName, FileMode.Create, FileAccess.Write))
                {
                    mem.WriteTo(fs);

                    OnFileSaved?.Invoke(this, new FileSavedEventArgs { FileName = FileName, Stream = fs, File = File });
                    fs.Close();
                }
            }
            //}
            //catch (Exception e)
            //{
            //    MainController.Get().QueueLog("Failed to save the file(s)! They are probably in use.\n" + e.ToString());
            //}
        }
        public void LoadFile(string filename, IVariableEditor variableEditor)
        {
            using (var fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                loadFile(fs, filename, variableEditor);

                fs.Close();
            }
        }

        public void LoadFile(string filename, Stream stream, IVariableEditor variableEditor)
        {
            loadFile(stream, filename, variableEditor);
        }

        private void loadFile(Stream stream, string filename, IVariableEditor variableEditor)
        {
            FormText = Path.GetFileName(filename) + " [" + filename + "]";

            using (var reader = new BinaryReader(stream))
            {
                File = new CR2WFile(reader, MainController.Get().Logger)
                {
                    FileName = filename,
                    EditorController = variableEditor/*UIController.Get()*/,
                    LocalizedStringSource = MainController.Get()
                };
            }
        }
        #endregion

    }
}
