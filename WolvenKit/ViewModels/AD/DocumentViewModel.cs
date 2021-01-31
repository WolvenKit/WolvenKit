using System;
using System.Collections.Generic;
using System.Linq;
using Catel.MVVM;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using Catel.IoC;
using WolvenKit.Common;
using WolvenKit.Common.Services;

namespace WolvenKit.ViewModels
{
	using Model;
	using Common.Model;
	using CR2W;
	using CR2W.SRT;
	using Commands;

    public class DocumentViewModel : PaneViewModel, IDocumentViewModel
	{
		#region fields
		private static ImageSourceConverter ISC = new ImageSourceConverter();
		private IWorkSpaceViewModel _workSpaceViewModel = null;

		private string _textContent = string.Empty;
		private string _filePath = null;
		private bool _isDirty = false;

		ICommand _closeCommand = null;
		ICommand _saveAsCommand = null;
		ICommand _saveCommand = null;

		private string _initialPath;
		private bool _isInitialized;
		private bool _IsExistingInFileSystem;

        private FileSystemInfoModel fileinfo;
		#endregion fields

		#region ctors
		/// <summary>
		/// class constructor
		/// </summary>
		/// <param name="workSpaceViewModel"></param>
		/// <param name="initialPath"></param>
		/// <param name="isExistingInFileSystem"></param>
		public DocumentViewModel(IWorkSpaceViewModel workSpaceViewModel,
								FileSystemInfoModel model,
								bool isExistingInFileSystem)
			: this(workSpaceViewModel)
        {
            fileinfo = model;
			_initialPath = fileinfo.FullName;

			try
			{
				Title = System.IO.Path.GetFileName(fileinfo.FullName);
			}
			catch { }

			ContentId = fileinfo.FullName;
			_IsExistingInFileSystem = isExistingInFileSystem;
		}

		/// <summary>
		/// class constructor
		/// </summary>
		/// <param name="workSpaceViewModel"></param>
		public DocumentViewModel(IWorkSpaceViewModel workSpaceViewModel)
			: this()
		{
			_workSpaceViewModel = workSpaceViewModel;
		}

		/// <summary>
		/// class constructor
		/// </summary>
		public DocumentViewModel()
		{
			IsDirty = false;
        }
		#endregion ctors

		#region Properties

        

		/// <summary>
		/// 
		/// </summary>
        [Model]
        private IWolvenkitFile File { get; set; }

		/// <summary>
		/// Bound to the View
		/// </summary>
        public List<ChunkViewModel> Chunks => (File as CR2WFile)?.Chunks.Select(_ => new ChunkViewModel(_)).ToList();

        /// <summary>
        /// Bound to the View via TreeViewBehavior.cs
        /// </summary>
        //public ChunkViewModel SelectedChunk { get; set; }

        private ChunkViewModel _selectedChunk;
        public ChunkViewModel SelectedChunk
        {
            get => _selectedChunk;
            set
            {
                if (_selectedChunk != value)
                {
                    var oldValue = _selectedChunk;
                    _selectedChunk = value;
                    RaisePropertyChanged(() => SelectedChunk, oldValue, value);

                    SelectEditableVariables = _selectedChunk.Data.ChildrEditableVariables;

                }
            }
        }

        public List<IEditableVariable> _selectEditableVariables;
		public List<IEditableVariable> SelectEditableVariables
        {
            get => _selectEditableVariables;
            set
            {
                if (_selectEditableVariables != value)
                {
                    var oldValue = _selectEditableVariables;
                    _selectEditableVariables = value;
                    RaisePropertyChanged(() => SelectEditableVariables, oldValue, value);
                }
            }
        }

		/// <summary>
		/// Gets the current path of the file being managed in this document viewmodel.
		/// </summary>
		public string FilePath
		{
			get => _filePath;
			set
			{
				if (_filePath != value)
				{
					var oldValue = _filePath;
					_filePath = value;
					RaisePropertyChanged(nameof(FilePath));
					RaisePropertyChanged(nameof(FileName));
					RaisePropertyChanged(nameof(Title));
				}
			}
		}

		/// <summary>Gets the current filename of the file being managed in this document viewmodel.</summary>
		public string FileName
		{
			get
			{
				if (FilePath == null)
					return "Noname" + (IsDirty ? "*" : "");

				return System.IO.Path.GetFileName(FilePath) + (IsDirty ? "*" : "");
			}
		}

		/// <summary>Gets/sets whether the documents content has been changed without saving into file system or not.</summary>
		public new bool IsDirty
		{
			get => _isDirty;
			set
			{
				if (_isDirty != value)
				{
					_isDirty = value;
					RaisePropertyChanged(nameof(IsDirty));
					RaisePropertyChanged(nameof(FileName));
				}
			}
		}

		/// <summary>Gets/sets whether the documents content has been changed without saving into file system or not.</summary>
		public bool IsExistingInFileSystem
		{
			get => _IsExistingInFileSystem;
			set
			{
				if (_IsExistingInFileSystem != value)
				{
					_IsExistingInFileSystem = value;
					RaisePropertyChanged(nameof(IsExistingInFileSystem));
				}
			}
		}

		/// <summary>Gets a command to save this document's content into the file system.</summary>
		public ICommand SaveCommand
		{
			get
			{
				if (_saveCommand == null)
				{
					_saveCommand = new DelegateCommand<object>((p) => OnSave(p), (p) => CanSave(p));
				}

				return _saveCommand;
			}
		}

		/// <summary>Gets a command to save this document's content into another file in the file system.</summary>
		public ICommand SaveAsCommand
		{
			get
			{
				if (_saveAsCommand == null)
					_saveAsCommand = new DelegateCommand<object>((p) => OnSaveAs(p), (p) => CanSaveAs(p));

				return _saveAsCommand;
			}
		}

		/// <summary>Gets a command to close this document.</summary>
		public ICommand CloseCommand
		{
			get
			{
				if (_closeCommand == null)
					_closeCommand = new DelegateCommand<object>((p) => OnClose(), (p) => CanClose());

				return _closeCommand;
			}
		}
		#endregion Properties

		#region methods
		/// <summary>
		/// Attempts to read the contents of a text file defined via initialPath
		/// and assigns it to text content of this viewmodel.
		/// </summary>
		/// <returns>True if file read was successful, otherwise false</returns>
		public async Task<bool> OpenFileWithInitialPathAsync()
		{
			if (string.IsNullOrEmpty(_initialPath) && _isInitialized == false)
				return false;

			if (_isInitialized || _IsExistingInFileSystem == false)
				return true;

			bool result = await OpenFileAsync(_initialPath);

			if (result == true)
				_initialPath = null;

			return result;
		}

		/// <summary>
		/// Attempts to read the contents of a text file and assigns it to
		/// text content of this viewmodel.
		/// </summary>
		/// <param name="path"></param>
		/// <returns>True if file read was successful, otherwise false</returns>
		public async Task<bool> OpenFileAsync(string path)
		{
			try
			{
				string textContent = string.Empty;

				// This is the same default buffer size as
				// <see cref="StreamReader"/> and <see cref="FileStream"/>.
				// int DefaultBufferSize = 4096;

				// Indicates that
				// 1. The file is to be used for asynchronous reading.
				// 2. The file is to be accessed sequentially from beginning to end.
				// FileOptions DefaultOptions = FileOptions.Asynchronous | FileOptions.SequentialScan;

                var logger = ServiceLocator.Default.ResolveType<ILoggerService>();
                logger.LogString("Opening file: " + path + "...");

				//TODO
                await using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
					EFileReadErrorCodes errorcode;
                    using (var reader = new BinaryReader(stream))
                    {
						// switch between cr2wfiles and others (e.g. srt)
                        

						if (Path.GetExtension(path) == ".srt")
                        {
                            File = new Srtfile()
                            {
                                FileName = path
							};
                            errorcode = await File.Read(reader);
                        }
                        else
                        {
                            File = new CR2WFile()
                            {
                                FileName = path,

								//TODO: ???
                                //EditorController = variableEditor/*UIController.Get()*/,

                                LocalizedStringSource = MainController.Get()
                            };
                            errorcode = await File.Read(reader);

                            //File.PropertyChanged += File_PropertyChanged;
                        }
                    }

				}


				ContentId = path;
				FilePath = path;
				IsDirty = false;
				Title = FileName;
				_isInitialized = true;

				return true;
			}
			catch (Exception)
			{
				// Not processing this catch in any other way than rejecting to initialize this
				_isInitialized = false;
			}

			return false;
		}

		/// <summary>
		/// Gets the encoding of a file from its first 4 bytes.
		/// </summary>
		/// <param name="bom">BOM to be translated into an <see cref="Encoding"/>.
		/// This should be at least 4 bytes long.</param>
		/// <returns>Recommended <see cref="Encoding"/> to be used to read text from this file.</returns>
		public Encoding GetEncoding(byte[] bom)
		{
			// Analyze the BOM
			if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76)
				return Encoding.UTF7;

			if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf)
				return Encoding.UTF8;

			if (bom[0] == 0xff && bom[1] == 0xfe)
				return Encoding.Unicode; //UTF-16LE

			if (bom[0] == 0xfe && bom[1] == 0xff)
				return Encoding.BigEndianUnicode; //UTF-16BE

			if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff)
				return Encoding.UTF32;

			return Encoding.Default;
		}

		private bool CanClose()
		{
			return true;
		}

		private void OnClose()
		{
			_workSpaceViewModel.Close(this);
		}

		private bool CanSave(object parameter)
		{
			return IsDirty;
		}

		private void OnSave(object parameter)
		{
			_workSpaceViewModel.Save(this, false);
		}

		private bool CanSaveAs(object parameter)
		{
			return IsDirty;
		}

		private void OnSaveAs(object parameter)
		{
			_workSpaceViewModel.Save(this, true);
		}
		#endregion methods
	}
}
