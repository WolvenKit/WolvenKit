
using Catel.Services;
using WolvenKit.App.ViewModels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using Catel.MVVM;
using WolvenKit.App.Commands;
using Catel;
using Catel.IoC;
using Catel.Threading;
using ControlzEx.Standard;
using Orc.ProjectManagement;
using WolvenKit.App.Model;
using WolvenKit.Common.Services;
using WolvenKit.CR2W;
using NativeMethods = WolvenKit.App.NativeWin.NativeMethods;

namespace WolvenKit.App.ViewModels
{
    /// <summary>
	/// The WorkSpaceViewModel implements AvalonDock demo specific properties, events and methods.
	/// </summary>
	public class WorkSpaceViewModel : ViewModelBase, IWorkSpaceViewModel
	{
		#region fields
		private readonly ObservableCollection<DocumentViewModel> _files = new ObservableCollection<DocumentViewModel>();
		private ToolViewModel[] _tools = null;

		private ICommand _openCommand = null;
		private ICommand _newCommand = null;


		private DocumentViewModel _activeDocument = null;

		private int _newDocumentCounter = 0;

        private readonly IMessageService _messageService;
        private readonly ILoggerService _loggerService;
        private readonly IProjectManager _projectManager;

        private delegate void DocumentViewModelDelegate(DocumentViewModel value);

        private readonly DocumentViewModelDelegate addfiledel;
        #endregion fields

        #region constructors
        /// <summary>
        /// Class constructor
        /// </summary>
        public WorkSpaceViewModel(
            IProjectManager projectManager,
			ILoggerService loggerService,
			IMessageService messageService, 
            ICommandManager commandManager
            )
		{
            #region dependency injection

            Argument.IsNotNull(() => projectManager);
            Argument.IsNotNull(() => messageService);
            Argument.IsNotNull(() => commandManager);
            Argument.IsNotNull(() => loggerService);

            _projectManager = projectManager;
            _loggerService = loggerService;
            _messageService = messageService;

            #endregion

            #region commands

            ShowLogCommand = new RelayCommand(ExecuteShowLog, CanShowLog);
            ShowProjectExplorerCommand = new RelayCommand(ExecuteShowProjectExplorer, CanShowProjectExplorer);
            ShowImportUtilityCommand = new RelayCommand(ExecuteShowImportUtility, CanShowImportUtility);
            ShowPropertiesCommand = new RelayCommand(ExecuteShowProperties, CanShowProperties);

            OpenFileCommand = new DelegateCommand<FileSystemInfoModel>(
                async (p ) => await ExecuteOpenFile(p), 
                (p) =>  CanOpenFile(p));
            NewFileCommand = new RelayCommand(ExecuteNewFile, CanNewFile);

            PackModCommand = new RelayCommand(ExecutePackMod, CanPackMod);
            BackupModCommand = new RelayCommand(ExecuteBackupMod, CanBackupMod);


            addfiledel = vm => _files.Add(vm);


            // register as application-wide commands
            RegisterCommands(commandManager);

            #endregion

			#region events

			

            #endregion

		}
		#endregion constructors

		#region init

        private void RegisterCommands(ICommandManager commandManager)
        {
            // View Tab
            commandManager.RegisterCommand(AppCommands.Application.ShowLog, ShowLogCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowProjectExplorer, ShowProjectExplorerCommand,
                this);
            commandManager.RegisterCommand(AppCommands.Application.ShowImportUtility, ShowImportUtilityCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.ShowProperties, ShowPropertiesCommand, this);

            // Home Tab
            commandManager.RegisterCommand(AppCommands.Application.OpenFile, OpenFileCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.NewFile, NewFileCommand, this);

            commandManager.RegisterCommand(AppCommands.Application.PackMod, PackModCommand, this);
            commandManager.RegisterCommand(AppCommands.Application.BackupMod, BackupModCommand, this);

			
		}


		private void OnProjectExplorerOnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            // executes a global command that can be subscribed to from any viewmodel
            // passes the currently active viewmodel
            if (args.PropertyName == "IsActive" && sender is PaneViewModel panevm)
                ServiceLocator.Default.ResolveType<ICommandManager>()
                    .GetCommand(AppCommands.Application.ViewSelected)
                    .SafeExecute(new Tuple<PaneViewModel, bool>(panevm, panevm.IsActive));
        }

		protected override async Task InitializeAsync()
		{
            _projectManager.ProjectActivationAsync += OnProjectActivationAsync;

			await base.InitializeAsync();
        }

        protected override Task OnClosingAsync()
        {
            _projectManager.ProjectActivationAsync -= OnProjectActivationAsync;
			RaisePropertyChanged(nameof(SaveLayout));

			return base.OnClosingAsync();
        }

        protected override Task CloseAsync()
		{
			// TODO: Unsubscribe from events
            

			return base.CloseAsync();
		}
		#endregion

		#region commands
		/// <summary>
		/// Displays the LogView.
		/// </summary>
        public ICommand ShowLogCommand { get; private set; }
		private bool CanShowLog() => true;
        private void ExecuteShowLog() => Log.IsVisible = !Log.IsVisible;

		/// <summary>
		/// Displays the Project Explorer View.
		/// </summary>
        public ICommand ShowProjectExplorerCommand { get; private set; }
        private bool CanShowProjectExplorer() => true;
        private void ExecuteShowProjectExplorer() => ProjectExplorer.IsVisible = !ProjectExplorer.IsVisible;

		/// <summary>
		/// Displays the Import Utility View
		/// </summary>
		public ICommand ShowImportUtilityCommand { get; private set; }
        private bool CanShowImportUtility() => true;
        private async void ExecuteShowImportUtility() => ImportViewModel.IsVisible = !ImportViewModel.IsVisible;

        /// <summary>
        /// Displays the Properties View
        /// </summary>
        public ICommand ShowPropertiesCommand { get; private set; }
        private bool CanShowProperties() => true;
        private async void ExecuteShowProperties() => PropertiesViewModel.IsVisible = !PropertiesViewModel.IsVisible;

		/// <summary>
		/// Opens a physical file in WolvenKit.
		/// </summary>
		public ICommand OpenFileCommand { get; private set; }
        private bool CanOpenFile(FileSystemInfoModel model) => true;
        private async Task ExecuteOpenFile(FileSystemInfoModel model)
        {
            if (model == null)
            {
                var dlg = new OpenFileDialog();
                if (dlg.ShowDialog().GetValueOrDefault())
                {
					model = new FileSystemInfoModel(new FileInfo(dlg.FileName), null);
                    ActiveDocument = await OpenAsync(model);
                }
            }
            else
            {
                if (model.IsDirectory)
                    model.IsExpanded = !model.IsExpanded;
                else if (model.IsFile)
                {
                    // TODO: make this a background task
                    await RequestFileOpen(model);
                    //await Task.Run(() => RequestFileOpen(model));
                }
            }
			
		}

        

        /// <summary>
        /// Creates a new cr2w file in WolvenKit.
        /// </summary>
        public ICommand NewFileCommand { get; private set; }
        private bool CanNewFile() => true;
        private void ExecuteNewFile()
        {
            //TODO
		}

		/// <summary>
		/// Packs the current mod project.
		/// </summary>
		public ICommand PackModCommand { get; private set; }
        private bool CanPackMod() => _projectManager.ActiveProject is EditorProject proj;
        private async void ExecutePackMod()
        {
            //TODO
		}

		/// <summary>
		/// Git-backup current mod project
		/// </summary>
		public ICommand BackupModCommand { get; private set; }
        private bool CanBackupMod() => _projectManager.ActiveProject is EditorProject;
        private async void ExecuteBackupMod()
        {
            //TODO
		}

		


		#endregion

		#region properties

		/// <summary>
		/// Event is raised when AvalonDock (or the user) selects a new document.
		/// </summary>
		public event EventHandler ActiveDocumentChanged;

        public EditorProject EditorProject { get; set; }

		public bool SaveLayout { get; set; }

		/// <summary>
		/// Gets/Sets the currently active document.
		/// </summary>
		public DocumentViewModel ActiveDocument
		{
			get => _activeDocument;
			set             // This can also be set by the user via the view
			{
				if (_activeDocument != value)
				{
					_activeDocument = value;
					RaisePropertyChanged(nameof(ActiveDocument));

                    ActiveDocumentChanged?.Invoke(this, EventArgs.Empty);
                }
			}
		}

		/// <summary>
		/// Gets a collection of all currently available document viewmodels
		/// </summary>
		public IEnumerable<DocumentViewModel> Files => _files;

		/// <summary>
		/// Gets an enumeration of all currently available tool window viewmodels.
		/// </summary>
		public IEnumerable<ToolViewModel> Tools => _tools ??= new ToolViewModel[]
        {
            Log, 
            ProjectExplorer, 
            PropertiesViewModel, 
            ImportViewModel
        };

        private LogViewModel _logViewModel = null;
        /// <summary>
		/// Gets an instance of the LogViewModel.
		/// </summary>
		public LogViewModel Log => _logViewModel ??= new LogViewModel();

        private ProjectExplorerViewModel _projectExplorerViewModel = null;
		/// <summary>
		/// Gets an instance of the LogViewModel.
		/// </summary>
		public ProjectExplorerViewModel ProjectExplorer
        {
            get
            {
                _projectExplorerViewModel ??= ServiceLocator.Default.RegisterTypeAndInstantiate<ProjectExplorerViewModel>();
                _projectExplorerViewModel.PropertyChanged += OnProjectExplorerOnPropertyChanged;
				return _projectExplorerViewModel;
			}
        }

        private ImportViewModel _importViewModel = null;
		/// <summary>
		/// Gets an instance of the LogViewModel.
		/// </summary>
		public ImportViewModel ImportViewModel
        {
            get
            {
                _importViewModel ??= ServiceLocator.Default.RegisterTypeAndInstantiate<ImportViewModel>();
                return _importViewModel;
            }
        }

        private PropertiesViewModel _propertiesViewModel = null;
		/// <summary>
		/// Gets an instance of the LogViewModel.
		/// </summary>
		public PropertiesViewModel PropertiesViewModel
		{
            get
            {
                _propertiesViewModel ??= ServiceLocator.Default.RegisterTypeAndInstantiate<PropertiesViewModel>();
                return _propertiesViewModel;
            }
        }

        #endregion Properties

        #region methods

        private async Task RequestFileOpen(FileSystemInfoModel model)
        {
            var fullpath = model.FullName;

            var ext = Path.GetExtension(fullpath).ToUpper();

            #region inspect on single click

            //// click
            //if (e.Inspect)
            //{
            //    switch (ext)
            //    {
            //        case ".CSV":
            //        case ".XML":
            //        case ".TXT":
            //        case ".BAT":
            //        case ".WS":
            //        case ".YML":
            //        case ".LOG":
            //        case ".INI":
            //            {
            //                var existing = TryOpenExisting(fullpath);
            //                if (existing == null)
            //                {
            //                    MockKernel.Get().ShowScriptPreview().LoadFile(fullpath);
            //                }
            //                break;
            //            }
            //        case ".PNG":
            //        case ".JPG":
            //        case ".TGA":
            //        case ".BMP":
            //        case ".JPEG":
            //        case ".DDS":
            //            {
            //                //TODO: unused
            //                //if (OpenImages.Any(_ => _.Text == Path.GetFileName(fullpath)))
            //                //{
            //                //    OpenImages.First(_ => _.Text == Path.GetFileName(fullpath)).Activate();
            //                //}
            //                //else
            //                {
            //                    MockKernel.Get().ShowImagePreview().SetImage(fullpath);
            //                }
            //                break;
            //            }
            //        default:
            //            break;
            //    }
            //    return;
            //}

            #endregion

            // double click
            switch (ext)
            {
                // images
                case ".PNG":
                case ".JPG":
                case ".TGA":
                case ".BMP":
                case ".JPEG":
                case ".DDS":
                //text
                case ".CSV":
                case ".XML":
                case ".TXT":
                case ".WS":
                // other
                case ".FBX":
                case ".XCF":
                case ".PSD":
                case ".APB":
                case ".APX":
                case ".CTW":
                case ".BLEND":
                case ".ZIP":
                case ".RAR":
                case ".BAT":
                case ".YML":
                case ".LOG":
                case ".INI":
                    ShellExecute(fullpath);
                    break;
                case ".BNK":
                case ".WEM":
                    {
                        // TODO: port winforms
                        //using (var sp = new frmAudioPlayer(fullpath))
                        //{
                        //    sp.ShowDialog();
                        //}
                        break;
                    }
                case ".SUBS":
                    PolymorphExecute(fullpath, ".txt");
                    break;
                case ".USM":
                    {
                        // TODO: port winforms
                        //if (!File.Exists(fullpath) || Path.GetExtension(fullpath) != ".usm")
                        //    return;
                        //var usmplayer = new frmUsmPlayer(fullpath);
                        //usmplayer.Show(dockPanel, DockState.Document);
                        break;
                    }

                default:
                    ActiveDocument = await OpenAsync(model);
                    break;
            }

            void ShellExecute(string path)
            {
                try
                {
                    var proc = new ProcessStartInfo(path) { UseShellExecute = true };
                    Process.Start(proc);
                }
                catch (Win32Exception winex)
                {
                    // eat this: no default app set for filetype
                    _loggerService.LogString($"No default prgram set in Windows to open file extension {Path.GetExtension(path)}", Common.Services.Logtype.Error);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            void PolymorphExecute(string path, string extension)
            {
                File.WriteAllBytes(Path.GetTempPath() + "asd." + extension, new byte[] { 0x01 });
                var programname = new StringBuilder();
                NativeMethods.FindExecutable("asd." + extension, Path.GetTempPath(), programname);
                if (programname.ToString().ToUpper().Contains(".EXE"))
                {
                    Process.Start(programname.ToString(), path);
                }
                else
                {
                    throw new InvalidFileTypeException("Invalid file type");
                }
            }
        }

        private async Task OnProjectActivationAsync(object sender, ProjectUpdatingCancelEventArgs e)
        {
            var newProject = (EditorProject)e.NewProject;
            if (newProject is null)
                return;

            EditorProject = newProject;
        }

        //
        // https://github.com/Dirkster99/AvalonDock/blob/5032524bae6e342dbb648a4c1d3fc3264f449db9/source/MLibTest/MLibTest/Demos/ViewModels/WorkSpaceViewModel.cs
        // 


        /// <summary>Closing all documents without user interaction to support reload of layout via menu.</summary>
        public void CloseAllDocuments()
        {
            ActiveDocument = null;
            _files.Clear();
        }

		/// <summary>
		/// Checks if a document can be closed and asks the user whether
		/// to save before closing if the document appears to be dirty.
		/// </summary>
		/// <param name="fileToClose"></param>
		public void Close(DocumentViewModel fileToClose)
		{
			if (fileToClose.IsDirty)
			{
				var res = MessageBox.Show($"Save changes for file '{fileToClose.FileName}'?", "AvalonDock Test App", MessageBoxButton.YesNoCancel);
				if (res == MessageBoxResult.Cancel)
					return;

				if (res == MessageBoxResult.Yes)
				{
					Save(fileToClose);
				}
			}

			_files.Remove(fileToClose);
		}

		/// <summary>
		/// Add a new document viewmodel into the collection of files.
		/// </summary>
		/// <param name="fileToAdd"></param>
		public void AddFile(DocumentViewModel fileToAdd)
		{
			if (fileToAdd == null) return;

			// Don't add this twice
			if (_files.Any(f => f.ContentId == fileToAdd.ContentId))
				return;

			_files.Add(fileToAdd);
		}

		/// <summary>
		/// Saves a document and resets the dirty flag.
		/// </summary>
		/// <param name="fileToSave"></param>
		/// <param name="saveAsFlag"></param>
		public void Save(DocumentViewModel fileToSave, bool saveAsFlag = false)
		{
			if (fileToSave.FilePath == null || saveAsFlag)
			{
				var dlg = new SaveFileDialog();
				if (dlg.ShowDialog().GetValueOrDefault())
					fileToSave.FilePath = dlg.SafeFileName;
			}

			// TODO

			

			ActiveDocument.IsDirty = false;
		}

        

        /// <summary>
		/// Open a file and return its content in a viewmodel.
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		public async Task<DocumentViewModel> OpenAsync(FileSystemInfoModel model)
		{
			// Check if we have already loaded this file and return it if so
			var fileViewModel = _files.FirstOrDefault(fm => fm.ContentId == model.FullName);
			if (fileViewModel != null)
				return fileViewModel;

            // open file
			fileViewModel = new DocumentViewModel(this as IWorkSpaceViewModel, model, true);
			bool result = await fileViewModel.OpenFileAsync(model.FullName);

			if (result)
			{
                // TODO: this is not threadsafe
                _files.Add(fileViewModel);

                //Dispatcher.CurrentDispatcher.Invoke(new Action(() =>
                //{
                //    addfiledel(fileViewModel);
                //}), DispatcherPriority.ContextIdle);

                return fileViewModel;
			}

			return null;
		}

		#region NewCommand
		/// <summary>
		/// Determines if application can currently create a new document or not.
		/// </summary>
		/// <param name="parameter"></param>
		/// <returns></returns>
		private bool CanNew(object parameter) => true;

        private void OnNew(object parameter)
		{
			//TODO
			//string path = string.Format("Untitled{0}.txt", _newDocumentCounter++);

			//var newFile = new DocumentViewModel(this as IWorkSpaceViewModel, path, false);
			//_files.Add(newFile);
			//ActiveDocument = newFile;
		}

		#endregion
		#endregion methods
	}
}
