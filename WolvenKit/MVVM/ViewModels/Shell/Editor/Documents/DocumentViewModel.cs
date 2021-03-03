using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Catel.MVVM;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using Catel.IoC;
using HandyControl.Controls;
using Orc.ProjectManagement;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.CR2W.SRT;
using WolvenKit.Functionality.Extensions;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.MVVM.Model;

namespace WolvenKit.MVVM.ViewModels.Shell.Editor.Documents
{
    public class EditorViewModel
    {
        public EditorViewModel()
        {
            
        }

        public string Name { get; } = "TBA";
    }

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

		public DocumentViewModel(IWorkSpaceViewModel workSpaceViewModel)
			: this()
		{
			_workSpaceViewModel = workSpaceViewModel;
		}

		public DocumentViewModel()
		{
			IsDirty = false;

            OpenEditorCommand = new RelayCommand(ExecuteOpenEditor, CanOpenEditor);
            OpenBufferCommand = new RelayCommand(ExecuteOpenBuffer, CanOpenBuffer);
            OpenImportCommand = new RelayCommand(ExecuteOpenImport, CanOpenImport);
        }
        #endregion ctors

        #region commands

        public ICommand OpenImportCommand { get; private set; }
        private bool CanOpenImport() => true;
        private void ExecuteOpenImport()
        {
            // TODO: Handle command logic here
        }

        public ICommand OpenBufferCommand { get; private set; }
        private bool CanOpenBuffer()
        {
            return true;
        }
        private void ExecuteOpenBuffer()
        {
            // TODO: Handle command logic here
        }

        public ICommand OpenEditorCommand { get; private set; }
        private bool CanOpenEditor()
        {
            return true;
        }
        private void ExecuteOpenEditor()
        {
            // TODO: Handle command logic here
        }

        


        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        [Model]
        private IWolvenkitFile File { get; set; }

		/// <summary>
		/// Bound to the View
		/// </summary>
        public List<ChunkViewModel> Chunks => File.Chunks
            .Where(_ => _.VirtualParentChunk == null)
            .Select(_ => new ChunkViewModel(_)).ToList();

        /// <summary>
        /// Bound to the View
        /// </summary>
        public List<ICR2WImport> Imports => File.Imports;

        /// <summary>
        /// Bound to the View
        /// </summary>
        public List<ICR2WBuffer> Buffers => File.Buffers;

        /// <summary>
        /// Bound to the View
        /// </summary>
        public List<EditorViewModel> Editors => GetEditorsForFile(File);

        private List<EditorViewModel> GetEditorsForFile(IWolvenkitFile file)
        {
            return new();
        }

        private ChunkViewModel _selectedChunk;
        /// <summary>
        /// Bound to the View via TreeViewBehavior.cs
        /// </summary>
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

                    //SelectEditableVariables = _selectedChunk?.ChildrenProperties;

                }
            }
        }

  //      public List<ChunkPropertyViewModel> _selectEditableVariables;
		//public List<ChunkPropertyViewModel> SelectEditableVariables
  //      {
  //          get => _selectEditableVariables;
  //          set
  //          {
  //              if (_selectEditableVariables != value)
  //              {
  //                  var oldValue = _selectEditableVariables;
  //                  _selectEditableVariables = value;
  //                  RaisePropertyChanged(() => SelectEditableVariables, oldValue, value);
  //              }
  //          }
  //      }

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
            _isInitialized = false;

			try
			{
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
                    using var reader = new BinaryReader(stream);
                    
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
                        // check game
                        var pm = ServiceLocator.Default.ResolveType<IProjectManager>();
                        //var fileService = ServiceLocator.Default.ResolveType<IWolvenkitFileService>();
                        switch (pm.ActiveProject)
                        {
                            case Cp77Project cp77proj:
                                var cr2w = CP77.CR2W.ModTools.TryReadCr2WFile(reader);
                                if (cr2w == null)
                                {
                                    logger.LogString($"Failed to read cr2w file {path}", Logtype.Error);
                                    return false;
                                }
                                cr2w.FileName = path;

                                File = cr2w;

                                break;
                            case Tw3Project tw3proj:
                                throw new NotImplementedException();

                            default:
                                _isInitialized = false;
                                return false;
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


        public PropertyGridDemoModel DemoModel { get; set; } = new PropertyGridDemoModel
        {
            String = "TestString",
            Enum = Gender.Female,
            Boolean = true,
            Integer = 98,
        };

}




    public class PropertyGridDemoModel
    {

        public PropertyGridDemoModel()
        {
            List = new List<string>() {"aaa", "bbb"};
        }



        [Category("Category1")]
        [Editor(typeof(IListPropertyEditor), typeof(PropertyEditorBase))]
        public List<string> List { get; set; }
        [Category("Category1")]
        public string String { get; set; }
        [Category("Category2")]
        public int Integer { get; set; }
        [Category("Category2")]
        public bool Boolean { get; set; }
        [Category("Category1")]
        public Gender Enum { get; set; }
        public ImageSource ImageSource { get; set; }
    }
    public enum Gender
    {
        Male,
        Female
    }
    
}
