#nullable enable

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
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
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
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
        private readonly IModifierViewStateService _modifierStateService;

        public RedDocumentViewMenuBar()
        {
            _scriptService = Locator.Current.GetService<AppScriptService>()!;
            _settingsManager = Locator.Current.GetService<ISettingsManager>()!;
            _projectManager = Locator.Current.GetService<IProjectManager>()!;
            _loggerService = Locator.Current.GetService<ILoggerService>()!;
            _projectWatcher = (WatcherService)Locator.Current.GetService<IWatcherService>()!;
            _archiveManager = Locator.Current.GetService<IAppArchiveManager>()!;
            _modifierStateService = Locator.Current.GetService<IModifierViewStateService>()!;
            
            InitializeComponent();
            
            RegisterFileValidationScript();

            DataContext = new RedDocumentViewToolbarModel { CurrentTab = _currentTab };
            ViewModel = DataContext as RedDocumentViewToolbarModel;

            _modifierStateService.ModifierStateChanged += OnModifierStateChanged;

            this.WhenActivated(_ =>
            {
                if (DataContext is not RedDocumentViewToolbarModel vm)
                {
                    return;
                }

                vm.RefreshMenuVisibility(true);
                vm.OnAddDependencies += OnAddDependencies;
            });
        }

        private void OnModifierStateChanged() => RefreshChildMenuItems();

        private RedDocumentTabViewModel? _currentTab;

        private ScriptFileViewModel? _fileValidationScript;

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
        }

        public RedDocumentTabViewModel? CurrentTab
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


        private ChunkViewModel? SelectedChunk => ViewModel?.SelectedChunk;

        private ChunkViewModel? RootChunk => ViewModel?.RootChunk;

        private void OnFileValidationClick(object _, RoutedEventArgs e)
        {
            // in .app or root entity: warn with >5 appearances, because this can take a while 
            if (ViewModel?.RootChunk is ChunkViewModel cvm
                && ((cvm.ResolvedData is appearanceAppearanceResource app && app.Appearances.Count > 5) ||
                    (cvm.ResolvedData is entEntityTemplate ent && ent.Appearances.Count > 5)))
            {
                var result = Interactions.ShowConfirmation((
                    "Run file validation now? (Wolvenkit will be unresponsive)",
                    "Wolvenkit may be unresponsive",
                    WMessageBoxImage.Question,
                    WMessageBoxButtons.YesNo));
                if (result != WMessageBoxResult.Yes)
                {
                    return;
                }
            }
           
            
            // This needs to be inside the DispatcherHelper, or the UI button will make everything explode
            DispatcherHelper.RunOnMainThread(
                () => _loggerService.Info("Running file validation, please wait. The UI will be unresponsive."));
            DispatcherHelper.RunOnMainThread(() => Task.Run(async () => await RunFileValidation()).GetAwaiter().GetResult());
        }

        private void OnConvertLocalMaterialsClick(object _, RoutedEventArgs e) => RootChunk?.ConvertPreloadMaterialsCommand.Execute(null);

        private void OnGenerateMissingMaterialsClick(object _, RoutedEventArgs e)
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

        public event EventHandler<EditorDifficultyLevel>? EditorDifficultChanged;

        private void OnEditorModeClick(EditorDifficultyLevel level)
        {
            if (ViewModel is null)
            {
                return;
            }

            ViewModel?.SetEditorLevel(level);
            EditorDifficultChanged?.Invoke(this, level);
        }

        private void OnEditorModeClick_Easy(object _, RoutedEventArgs e) => OnEditorModeClick(EditorDifficultyLevel.Easy);

        private void OnEditorModeClick_Default(object _, RoutedEventArgs e) => OnEditorModeClick(EditorDifficultyLevel.Default);

        private void OnEditorModeClick_Advanced(object _, RoutedEventArgs e) => OnEditorModeClick(EditorDifficultyLevel.Advanced);

        private string GetTextureDirForDependencies(bool useTextureSubfolder)
        {
            if (_projectManager.ActiveProject?.ModDirectory is string modDir
                && ViewModel?.FilePath?.RelativePath(new DirectoryInfo(modDir)) is string activeFilePath
                && Path.GetDirectoryName(activeFilePath) is string dirName && !string.IsNullOrEmpty(dirName))
            {
                // we're in a .mi file
                if (!useTextureSubfolder)
                {
                    return dirName;
                }

                if (_currentTab?.FilePath is not string filePath || Directory.GetFiles(Path.Combine(filePath, ".."), "*.mesh").Length <= 1)
                {
                    return Path.Combine(dirName, "textures");
                }

                // if the folder contains more than one .mesh file, add a subdirectory inside "textures"
                var fileName = Path.GetFileName(_currentTab.FilePath.Split('.').FirstOrDefault() ?? "").Replace(' ', '_').ToLower();
                return Path.Combine(dirName, "textures", fileName);

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

        private async Task AddDependenciesToMesh(ChunkViewModel _)
        {
            if (RootChunk is not { ResolvedData: CMesh } rootChunk)
            {
                return;
            }

            rootChunk.DeleteUnusedMaterialsCommand.Execute(null);
            await LoadModArchives();

            var materialDependencies = await rootChunk.GetMaterialDependenciesOutsideOfProject();
            var isShiftKeyDown = ModifierViewStateService.IsShiftBeingHeld;

            // Filter files: Ignore base game files unless shift key is pressed
            materialDependencies = materialDependencies
                .Where(refPathHash =>
                    {
                        var hasBasegameFile = _archiveManager.Lookup(refPathHash, ArchiveManagerScope.Basegame) is { HasValue: true };
                        var hasModFile = _archiveManager.Lookup(refPathHash, ArchiveManagerScope.Mods) is { HasValue: true };
                        // Only files from mods. Filter out anything that overwrites basegame files.
                        if (!isShiftKeyDown)
                        {
                            return hasModFile && !hasBasegameFile;
                        }

                        return hasModFile || hasBasegameFile;
                    }
                )
                .ToHashSet();
            

            var destFolder = GetTextureDirForDependencies(true);
            // Use search and replace to fix file paths
            var pathReplacements = await ProjectResourceHelper.AddDependenciesToProjectPathAsync(
                destFolder, materialDependencies
            );

            await SearchAndReplaceInChildNodes(rootChunk, pathReplacements,
                ChunkViewModel.LocalMaterialBufferPath,
                ChunkViewModel.ExternalMaterialPath);

        }

        private async Task AddDependenciesToMiOrMlSetup(ChunkViewModel cvm)
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
                if (cvm.GetPropertyFromPath(propertyPath) is ChunkViewModel child)
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
                    var ignoredArchives = _settingsManager.ArchiveNamesExcludeFromScan.Split(",").Select(m => m.Replace(".archive", ""))
                        .ToArray();
                    _archiveManager.LoadModArchives(new FileInfo(_settingsManager.CP77ExecutablePath), true, ignoredArchives);
                    
                    if (_settingsManager.ExtraModDirPath is string extraModDir && !string.IsNullOrEmpty(extraModDir))
                    {
                        _archiveManager.LoadAdditionalModArchives(extraModDir, true, ignoredArchives);
                    }
                });

                _loggerService.Info("... Done!");
            }
        }

        private async void OnAddDependencies(object? _, EventArgs eventArgs)
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
                case Multilayer_Setup:
                    await AddDependenciesToMiOrMlSetup(cvm);
                    break;
                default:
                    break;
            }

            _projectWatcher.Refresh();
            _projectWatcher.Resume();
        }

        private void OnChangeChunkMasksClick(object _, RoutedEventArgs e)
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

        private MenuItem? _openMenu;

        private void RefreshChildMenuItems()
        {
            if (_openMenu is null)
            {
                return;
            }

            ViewModel?.RefreshMenuVisibility();
            
            foreach (var item in _openMenu.Items.OfType<MenuItem>())
            {
                // Force the submenu items to re-evaluate their bindings
                var bindingExpression = item.GetBindingExpression(VisibilityProperty);
                bindingExpression?.UpdateTarget();
            }
            
        }

        private void OnMenuClosed(object sender, RoutedEventArgs e) => _openMenu = null;

        // Refresh nested menu visibility bindings
        private void OnMenuOpened(object sender, RoutedEventArgs e)
        {
            if (sender is MenuItem parentMenuItem)
            {
                _openMenu = parentMenuItem;
            }

            _modifierStateService.RefreshModifierStates();
            RefreshChildMenuItems();
        }

        // do not fire duplicate events... is this necessary? Somewhere we have a performance hog :/
        private void OnMainKeystateChanged(object sender, KeyEventArgs e)
        {
            if (_openMenu is null)
            {
                _modifierStateService.OnKeystateChanged(e);
            }
        }

        private void OnKeystateChanged(object sender, KeyEventArgs e)
        {
            if (_openMenu is not null)
            {
                _modifierStateService.OnKeystateChanged(e);
            }
        }

        private void SearchBox_OnKeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.Key);
            switch (e.Key)
            {
                case Key.Enter:
                    SearchBox_OnSubmit(this, e);
                    return;
                case Key.Escape:
                case Key.Back when ModifierViewStateService.IsShiftBeingHeld:
                case Key.Delete when ModifierViewStateService.IsShiftBeingHeld:
                    SearchBox_OnClear(this, e);
                    return;
                default:
                    return;
            }
        }

        private void SearchBox_OnSubmit(object sender, RoutedEventArgs e) => ViewModel?.OnSearchChanged(SearchBox?.Text ?? "");

        private void SearchBox_OnClear(object sender, RoutedEventArgs e)
        {
            SearchBox?.Clear();
            SearchBox_OnSubmit(this, e);
        }

        private void SearchBox_OnClick(object sender, MouseButtonEventArgs e)
        {
            if (ModifierViewStateService.IsShiftBeingHeld)
            {
                SearchBox?.SelectAll();
            }
            else if (ModifierViewStateService.IsCtrlBeingHeld)
            {
                SearchBox_OnClear(this, e);
            }
        }
    }
}