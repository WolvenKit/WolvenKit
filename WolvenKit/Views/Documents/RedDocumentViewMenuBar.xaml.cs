using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using ReactiveUI;
using Splat;
using WolvenKit.App;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Scripting;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevel;
using WolvenKit.Common.Extensions;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Dialogs.Windows;

namespace WolvenKit.Views.Documents
{
    public partial class RedDocumentViewMenuBar : ReactiveUserControl<RedDocumentViewToolbarModel>
    {
        private readonly AppScriptService _scriptService;
        private readonly ISettingsManager _settingsManager;
        private readonly IProjectManager _projectManager;
        private readonly ILoggerService _loggerService;
        private readonly WatcherService _projectWatcher;
        private readonly IAppArchiveManager _archiveManager;


        public RedDocumentViewMenuBar()
        {
            _scriptService = Locator.Current.GetService<AppScriptService>();
            _settingsManager = Locator.Current.GetService<ISettingsManager>();
            _projectManager = Locator.Current.GetService<IProjectManager>();
            _loggerService = Locator.Current.GetService<ILoggerService>();
            _projectWatcher = (WatcherService)Locator.Current.GetService<IWatcherService>();
            _archiveManager = Locator.Current.GetService<IAppArchiveManager>();
            InitializeComponent();
            
            RegisterFileValidationScript();

            DataContext = new RedDocumentViewToolbarModel { CurrentTab = _currentTab };
            ViewModel = DataContext as RedDocumentViewToolbarModel;

            this.WhenActivated(_ =>
            {
                if (DataContext is not RedDocumentViewToolbarModel vm)
                {
                    return;
                }

                vm.RefreshMenuVisibility(true);
            });
        }


        private RedDocumentTabViewModel _currentTab;

        private ScriptFileViewModel _fileValidationScript;

        private void RegisterFileValidationScript()
        {
            _fileValidationScript = _scriptService.GetScripts(ISettingsManager.GetWScriptDir()).ToList()
                .Where(s => s.Name == "run_FileValidation_on_active_tab")
                .Select(s => new ScriptFileViewModel(_settingsManager, ScriptSource.User, s))
                .FirstOrDefault();

            _fileValidationScript ??= _scriptService.GetScripts(@"Resources\Scripts").ToList()
                .Where(s => s.Name == "run_FileValidation_on_active_tab")
                .Select(s => new ScriptFileViewModel(_settingsManager, ScriptSource.System, s))
                .FirstOrDefault();

            if (_fileValidationScript is null && ViewModel is not null)
            {
                ViewModel.IsFileValidationMenuVisible = false;
            }
        }

        public RedDocumentTabViewModel CurrentTab
        {
            get => _currentTab;
            set
            {
                _currentTab = value;
                ViewModel?.SetCurrentTab(value);
                ViewModel?.RefreshMenuVisibility();
            }
        }

        private bool _isRunning;

        private async Task RunFileValidation()
        {
            if (_fileValidationScript is null || !File.Exists(_fileValidationScript.Path))
            {
                throw new WolvenKitException(0x5002, "File validation script not found! Please contact the devs!");
            }

            if (_isRunning)
            {
                return;
            }

            _isRunning = true;
            try
            {
                var code = await File.ReadAllTextAsync(_fileValidationScript.Path);

                await _scriptService.ExecuteAsync(code);
                _loggerService.Success("File validation complete!");
            }
            catch
            {
                // error will be a WolvenkitException
            }
            finally
            {
                _isRunning = false;
            }
            
        }

        private void OnFileValidationClick(object sender, RoutedEventArgs e)
        {
            _loggerService.Info("Running file validation, please wait. The UI will be unresponsive.");
            
            // This needs to be inside the DispatcherHelper, or the UI button will make everything explode
            DispatcherHelper.RunOnMainThread(() => Task.Run(async () => await RunFileValidation()).GetAwaiter().GetResult());
        }

        private void OnConvertLocalMaterialsClick(object sender, RoutedEventArgs e) =>
            ViewModel?.RootChunk?.ConvertPreloadMaterialsCommand.Execute(null);

        private void OnDeleteUnusedMaterialsClick(object sender, RoutedEventArgs e) =>
            ViewModel?.RootChunk?.DeleteUnusedMaterialsCommand.Execute(null);

        private void OnClearAllMaterialsClick(object sender, RoutedEventArgs e) =>
            ViewModel?.RootChunk?.ClearMaterialsCommand.Execute(null);

        private void OnDeleteEmptySubmeshesClick(object sender, RoutedEventArgs e) =>
            ViewModel?.RootChunk?.DeleteEmptySubmeshesCommand.Execute(null);

        private void OnDeleteDuplicateEntriesClick(object sender, RoutedEventArgs e) =>
            ViewModel?.RootChunk?.DeleteDuplicateEntriesCommand.Execute(null);

        private void OnRegenerateControllersClick(object sender, RoutedEventArgs e) =>
            ViewModel?.SelectedChunk?.RegenerateAppearanceVisualControllerCommand.Execute(null);

        private void OnGenerateNewCruidClick(object sender, RoutedEventArgs e) =>
            ViewModel?.SelectedChunk?.GenerateCRUIDCommand.Execute(null);

        private void OnGenerateMissingMaterialsClick(object sender, RoutedEventArgs e)
        {
            var dialog = new CreateMaterialsDialog();
            if (ViewModel?.RootChunk is not ChunkViewModel cvm || dialog.ShowDialog() != true)
            {
                return;
            }

            var baseMaterial = dialog.ViewModel?.BaseMaterial ?? "";
            var isLocal = dialog.ViewModel?.IsLocalMaterial ?? true;
            var resolveSubstitutions = dialog.ViewModel?.ResolveSubstitutions ?? false;

            cvm.GenerateMissingMaterials(baseMaterial, isLocal, resolveSubstitutions);

            cvm.Tab?.Parent.SetIsDirty(true);
        }

        public event EventHandler<EditorDifficultyLevel> EditorDifficultChanged;

        private void OnEditorModeClick(EditorDifficultyLevel level)
        {
            if (ViewModel is null)
            {
                return;
            }

            ViewModel?.SetEditorLevel(level);
            EditorDifficultChanged?.Invoke(this, level);
        }

        private void OnEditorModeClick_Easy(object sender, RoutedEventArgs e) => OnEditorModeClick(EditorDifficultyLevel.Easy);

        private void OnEditorModeClick_Default(object sender, RoutedEventArgs e) => OnEditorModeClick(EditorDifficultyLevel.Default);

        private void OnEditorModeClick_Advanced(object sender, RoutedEventArgs e) => OnEditorModeClick(EditorDifficultyLevel.Advanced);

        private void OnScrollToMaterialClick(object sender, RoutedEventArgs e) =>
            ViewModel?.SelectedChunk?.ScrollToMaterialCommand.Execute(null);

        private string GetTextureDirForDependencies(bool useTextureSubfolder)
        {
            if (_projectManager.ActiveProject?.ModDirectory is string modDir
                && ViewModel?.FilePath?.RelativePath(new DirectoryInfo(modDir)) is string activeFilePath
                && Path.GetDirectoryName(activeFilePath) is string dirName && !string.IsNullOrEmpty(dirName))
            {
                if (useTextureSubfolder)
                {
                    return Path.Combine(dirName, "textures");
                }

                return dirName;
            }

            var destFolder = Interactions.AskForTextInput("Target folder for dependencies");

            if (destFolder is not null)
            {
                return destFolder;
            }

            var projectName = _projectManager.ActiveProject?.Name ?? "yourProject";
            var subfolder = _settingsManager.ModderName ?? "YourName";
            return Path.Join(subfolder, projectName, "dependencies");
        }

        private async Task AddDependenciesToMesh(ChunkViewModel cvm)
        {
            cvm.DeleteUnusedMaterialsCommand.Execute(null);
            await LoadModArchives();

            var materialDependencies = await cvm.GetMaterialDependenciesOutsideOfProject();

            var destFolder = GetTextureDirForDependencies(true);
            // Use search and replace to fix file paths
            var pathReplacements = await ProjectResourceHelper.AddDependenciesToProjectPathAsync(
                destFolder, materialDependencies
            );

            await SearchAndReplaceInChildNodes(cvm, pathReplacements, "localMaterialBuffers.materials", "externalMaterials");

        }
        
        private async Task AddDependenciesToMi(ChunkViewModel cvm)
        {
            await LoadModArchives();

            var materialDependencies = await cvm.GetMaterialDependenciesOutsideOfProject();

            var destFolder = GetTextureDirForDependencies(false);

            // Use search and replace to fix file paths
            var pathReplacements = await ProjectResourceHelper.AddDependenciesToProjectPathAsync(destFolder, materialDependencies);

            await SearchAndReplaceInChildNodes(cvm, pathReplacements, "values");
        }

        private static async Task SearchAndReplaceInChildNodes(ChunkViewModel cvm, Dictionary<string, string> pathReplacements,
            params string[] propertyPaths)
        {
            if (pathReplacements.Count == 0)
            {
                return;
            }
            var isDirty = false;
            var childNodes = new List<ChunkViewModel>();
            var dirtyNodes = new HashSet<ChunkViewModel>();

            foreach (var propertyPath in propertyPaths)
            {
                if (cvm.GetModelFromPath(propertyPath) is ChunkViewModel child)
                {
                    childNodes.AddRange(child.TVProperties);
                }
            }

            foreach (var childNode in childNodes)
            {
                foreach (var (oldPath, newPath) in pathReplacements)
                {
                    if (!await childNode.SearchAndReplaceAsync(oldPath, newPath))
                    {
                        continue;
                    }

                    dirtyNodes.Add(childNode);
                    isDirty = true;
                }
            }

            foreach (var node in dirtyNodes)
            {
                await node.Refresh();
            }

            if (isDirty && cvm.Tab?.Parent is not null)
            {
                cvm.Tab.Parent.SetIsDirty(true);
            }
        }

        private async Task LoadModArchives()
        {
            if (!_archiveManager.GetModArchives().Any())
            {
                if (_settingsManager.CP77ExecutablePath is null)
                {
                    throw new WolvenKitException(0x5001, "No game executable set");
                }

                _loggerService.Info("Loading mod archives, this may take a moment...");
                await Task.Run(() =>
                {
                    _archiveManager.LoadModsArchives(new FileInfo(_settingsManager.CP77ExecutablePath), true);
                    if (_settingsManager.ExtraModDirPath is string extraModDir && !string.IsNullOrEmpty(extraModDir))
                    {
                        _archiveManager.LoadAdditionalModArchives(extraModDir, true);
                    }
                });

                _loggerService.Info("... Done!");
            }
        }

        private void OnToggleLocalInstanceClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel?.SelectedChunks is null)
            {
                return;
            }

            foreach (var chunk in ViewModel.SelectedChunks)
            {
                chunk.ToggleMaterialDefinitionIsExternalCommand.Execute(null);
            }

            ViewModel.SelectedChunks.LastOrDefault()?.Parent?.RecalculateProperties();
        }
        
        private async void OnAddDependenciesClick(object sender, RoutedEventArgs e)
        {
            if (_projectManager.ActiveProject is null || ViewModel?.RootChunk is not ChunkViewModel cvm)
            {
                return;
            }

            _projectWatcher.Suspend();

            switch (cvm.ResolvedData)
            {
                case CMesh:
                    await AddDependenciesToMesh(cvm);
                    break;
                case CMaterialInstance:
                    await AddDependenciesToMi(cvm);
                    break;
                default:
                    break;
            }

            _projectWatcher.Refresh();
            _projectWatcher.Resume();
        }

        private void OnChangeChunkMasksClick(object sender, RoutedEventArgs e)
        {
            var dialog = new ChangeComponentChunkMaskDialog();
            if (ViewModel?.RootChunk is not ChunkViewModel cvm || dialog.ShowDialog() != true)
            {
                return;
            }

            if (dialog.ViewModel is null || string.IsNullOrEmpty(dialog.ViewModel.ComponentName))
            {
                return;
            }

            var chunkMask = (CUInt64)dialog.ViewModel.ChunkMask;

            cvm.ReplaceComponentChunkMasks(dialog.ViewModel.ComponentName!, chunkMask);
        }
    }
}