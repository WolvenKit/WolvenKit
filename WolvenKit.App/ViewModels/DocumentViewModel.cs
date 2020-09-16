using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Input;
using WolvenKit.App.Commands;
using WolvenKit.App.Model;
using WolvenKit.Common.Model;using WolvenKit.Common.Services;
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

            _openEmbedded =new Dictionary<string,DocumentViewModel>();
        }

        #region Fields
        public event EventHandler<FileSavedEventArgs> OnFileSaved;

        #endregion

        #region Properties
        public object SaveTarget { get; set; }
        #region File
        private IWolvenkitFile _file;
        public IWolvenkitFile File
        {
            get => _file;
            private set
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
        public virtual string Cr2wFileName => File.Cr2wFileName;
        #endregion
        #region OpenEmbedded
        private Dictionary<string,DocumentViewModel> _openEmbedded;
        public Dictionary<string,DocumentViewModel> OpenEmbedded
        {
            get => _openEmbedded;
            set
            {
                if (_openEmbedded != value)
                {
                    _openEmbedded = value;
                    OnPropertyChanged();
                }
            }
        }

        public void RemoveEmbedded(object sender, EventArgs e, DocumentViewModel embVM)
        {
            string embkey = embVM.Cr2wFileName;
            if (!OpenEmbedded.ContainsKey(embkey))
                throw new NullReferenceException();
            OpenEmbedded.Remove(embkey);
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
            // save all open embedded files
            foreach (DocumentViewModel model in OpenEmbedded.Values)
            {
                var editvar = model.SaveTarget as CR2WEmbeddedWrapper;

                // get bytes from model
                editvar?.SetRawEmbeddedData(model.GetRawBytes());
            }

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
            MainController.LogString(Cr2wFileName + " saved!\n", Logtype.Success);
            MainController.Get().ProjectStatus = "Saved";
        }

        private byte[] GetRawBytes()
        {
            using (var mem = new MemoryStream())
            using (var writer = new BinaryWriter(mem))
            {
                File.Write(writer);
                return mem.ToArray();
            }
        }

        private void saveToMemoryStream()
        {
            using (var mem = new MemoryStream())
            using (var writer = new BinaryWriter(mem))
            {
                File.Write(writer);

                OnFileSaved?.Invoke(this, new FileSavedEventArgs { FileName = Cr2wFileName, Stream = mem, File = File });
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

                using (var fs = new FileStream(Cr2wFileName, FileMode.Create, FileAccess.Write))
                {
                    mem.WriteTo(fs);

                    OnFileSaved?.Invoke(this, new FileSavedEventArgs { FileName = Cr2wFileName, Stream = fs, File = File });
                    fs.Close();
                }
            }
            //}
            //catch (Exception e)
            //{
            //    MainController.Get().QueueLog("Failed to save the file(s)! They are probably in use.\n" + e.ToString());
            //}
        }


        public EFileReadErrorCodes LoadFile(string filename, IVariableEditor variableEditor, LoggerService logger, Stream stream = null)
        {

            if (stream != null)
            {
                return loadFile(stream, filename, variableEditor, logger);
            }
            else
            {
                using (var fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    return loadFile(fs, filename, variableEditor, logger);
                }
            }
            
        }

        private EFileReadErrorCodes loadFile(Stream stream, string filename, IVariableEditor variableEditor, LoggerService logger)
        {
            EFileReadErrorCodes errorcode;

            using (var reader = new BinaryReader(stream))
            {
                // switch between cr2wfiles and others (e.g. srt)
                if (Path.GetExtension(filename) == ".srt")
                {
                    File = new Srtfile()
                    {
                        Cr2wFileName = filename
                    };
                    errorcode = File.Read(reader);
                    OnPropertyChanged(nameof(File));
                }
                else
                {
                    File = new CR2WFile(logger)
                    {
                        Cr2wFileName = filename,

                        EditorController = variableEditor/*UIController.Get()*/,

                        LocalizedStringSource = MainController.Get()
                    };
                    errorcode = File.Read(reader);
                    OnPropertyChanged(nameof(File));
                }
            }

            return errorcode;
        }
        #endregion

    }
}
