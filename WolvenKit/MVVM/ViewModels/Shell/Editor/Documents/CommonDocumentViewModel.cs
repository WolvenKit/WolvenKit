using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.CR2W;
using WolvenKit.CR2W.SRT;
using WolvenKit.Functionality.Controllers;

namespace WolvenKit.MVVM.ViewModels.Shell.Editor.Documents
{
    public class CommonDocumentViewModel : CloseableViewModel, Old_IDocumentViewModel
    {
        #region Constructors

        public CommonDocumentViewModel(IWindowFactory windowFactory) : base(windowFactory)
        {
        }

        #endregion Constructors



        #region Fields

        public event EventHandler<FileSavedEventArgs> OnFileSaved;

        #endregion Fields

        #region Properties

        public object SaveTarget { get; set; }
        public override string Title => Path.GetFileName(FileName);

        #region File

        private IWolvenkitFile _file;

        public IWolvenkitFile File
        {
            get => _file;
            private set
            {
                if (_file != value)
                {
                    var oldValue = _file;
                    _file = value;
                    RaisePropertyChanged(() => File, oldValue, value);
                }
            }
        }

        #endregion File

        #region FileName

        public string FileName => File.FileName;

        #endregion FileName

        #endregion Properties

        // Propagate changed event from cr2wfile
        private void File_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (File is CR2WFile cr2w)
            {
                if (e.PropertyName == nameof(cr2w.Chunks))
                {
                    RaisePropertyChanged(nameof(File));
                }
            }
        }

        #region Methods

        public void CreateNewChunk()
        {
        }

        public async Task<Common.EFileReadErrorCodes> LoadFile(string filename, IVariableEditor variableEditor, LoggerService logger, Stream stream = null)
        {
            if (stream != null)
            {
                return await loadFile(stream, filename, variableEditor, logger);
            }
            else
            {
                using var fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                return await loadFile(fs, filename, variableEditor, logger);
            }
        }

        public virtual void SaveFile()
        {
            MainController.Get().ProjectStatus = EProjectStatus.Busy;

            // save File
            if (SaveTarget == null)
            {
                saveToFileName();
            }
            else
            {
                saveToMemoryStream();
            }

            // Logging
            MainController.LogString(FileName + " saved!\n", Logtype.Success);
            MainController.Get().ProjectStatus = EProjectStatus.Ready;
        }

        protected byte[] GetRawBytes()
        {
            using var mem = new MemoryStream();
            using var writer = new BinaryWriter(mem);
            File.Write(writer);
            return mem.ToArray();
        }

        private async Task<Common.EFileReadErrorCodes> loadFile(Stream stream, string filename, IVariableEditor variableEditor, LoggerService logger)
        {
            Common.EFileReadErrorCodes errorcode;

            using (var reader = new BinaryReader(stream))
            {
                // switch between cr2wfiles and others (e.g. srt)
                if (Path.GetExtension(filename) == ".srt")
                {
                    File = new Srtfile()
                    {
                        FileName = filename
                    };
                    errorcode = await File.Read(reader);
                    RaisePropertyChanged(nameof(File));
                }
                else
                {
                    File = new CR2WFile()
                    {
                        FileName = filename,

                        EditorController = variableEditor/*UIController.Get()*/,

                        LocalizedStringSource = MainController.Get()
                    };
                    errorcode = await File.Read(reader);
                    RaisePropertyChanged(nameof(File));

                    File.PropertyChanged += File_PropertyChanged;
                }
            }

            return errorcode;
        }

        private void saveToFileName()
        {
            //try
            //{
            using var mem = new MemoryStream();
            using var writer = new BinaryWriter(mem);
            File.Write(writer);
            mem.Seek(0, SeekOrigin.Begin);

            using var fs = new FileStream(FileName, FileMode.Create, FileAccess.Write);
            mem.WriteTo(fs);

            OnFileSaved?.Invoke(this, new FileSavedEventArgs { FileName = FileName, Stream = fs, File = File });
            fs.Close();
            //}
            //catch (Exception e)
            //{
            //    MainController.Get().QueueLog("Failed to save the file(s)! They are probably in use.\n" + e.ToString());
            //}
        }

        private void saveToMemoryStream()
        {
            using var mem = new MemoryStream();
            using var writer = new BinaryWriter(mem);
            File.Write(writer);

            OnFileSaved?.Invoke(this, new FileSavedEventArgs { FileName = FileName, Stream = mem, File = File });
        }

        #endregion Methods
    }
}
