using System;
using System.IO;
using System.Windows.Input;
using WolvenKit.App.Commands;
using WolvenKit.App.Model;
using WolvenKit.Common.Model;
using WolvenKit.CR2W;
using WolvenKit.CR2W.SRT;
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
        private IWolvenkitFile _cr2wfile;
        public IWolvenkitFile Cr2wFile
        {
            get => _cr2wfile;
            set
            {
                if (_cr2wfile != value)
                {
                    _cr2wfile = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        #region FileName
        public virtual string Cr2wFileName => Cr2wFile.Cr2wFileName;
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
        public string Title => Path.GetFileName(Cr2wFileName);

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
                    Cr2wFile.Write(writer);

                    if (OnFileSaved != null)
                    {
                        OnFileSaved(this, new FileSavedEventArgs { FileName = Cr2wFileName, Stream = mem, File = Cr2wFile });
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
                Cr2wFile.Write(writer);
                mem.Seek(0, SeekOrigin.Begin);

                using (var fs = new FileStream(Cr2wFileName, FileMode.Create, FileAccess.Write))
                {
                    mem.WriteTo(fs);

                    OnFileSaved?.Invoke(this, new FileSavedEventArgs { FileName = Cr2wFileName, Stream = fs, File = Cr2wFile });
                    fs.Close();
                }
            }
            //}
            //catch (Exception e)
            //{
            //    MainController.Get().QueueLog("Failed to save the file(s)! They are probably in use.\n" + e.ToString());
            //}
        }
        public EFileReadErrorCodes LoadFile(string filename, IVariableEditor variableEditor, Stream stream = null)
        {

            if (stream != null)
            {
                return loadFile(stream, filename, variableEditor);
            }
            else
            {
                using (var fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    return loadFile(fs, filename, variableEditor);
                }
            }
            
        }

        private EFileReadErrorCodes loadFile(Stream stream, string filename, IVariableEditor variableEditor)
        {
            FormText = Path.GetFileName(filename) + " [" + filename + "]";

            using (var reader = new BinaryReader(stream))
            {
                // switch between cr2wfiles and others (e.g. srt)
                if (Path.GetExtension(filename) == ".srt")
                {
                    Cr2wFile = new Srtfile()
                    {
                        Cr2wFileName = filename
                    };
                    return Cr2wFile.Read(reader);
                }
                else
                {
                    Cr2wFile = new CR2WFile(MainController.Get().Logger)
                    {
                        Cr2wFileName = filename,

                        EditorController = variableEditor/*UIController.Get()*/,

                        LocalizedStringSource = MainController.Get()
                    };
                    return Cr2wFile.Read(reader);
                }
            }
        }
        #endregion

    }
}
