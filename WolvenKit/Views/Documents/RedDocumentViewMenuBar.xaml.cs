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
using WolvenKit.App.ViewModels.Dialogs;
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
        private readonly AppViewModel _appViewModel;
        private readonly IProgressService<double> _progressService;
        
        public RedDocumentViewMenuBar()
        {
            _scriptService = Locator.Current.GetService<AppScriptService>()!;
            _settingsManager = Locator.Current.GetService<ISettingsManager>()!;
            _projectManager = Locator.Current.GetService<IProjectManager>()!;
            _loggerService = Locator.Current.GetService<ILoggerService>()!;
            _projectWatcher = (WatcherService)Locator.Current.GetService<IWatcherService>()!;
            _archiveManager = Locator.Current.GetService<IAppArchiveManager>()!;
            _modifierStateService = Locator.Current.GetService<IModifierViewStateService>()!;
            _appViewModel = Locator.Current.GetService<AppViewModel>()!;
            _progressService = Locator.Current.GetService<IProgressService<double>>()!;
            
            InitializeComponent();

            InitializeInstanceObjects();

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

        private void InitializeInstanceObjects()
        {
            _fileValidationScript = _scriptService.GetScripts(ISettingsManager.GetWScriptDir()).ToList()
                .Where(s => s.Name == "run_FileValidation_on_active_tab")
                .Select(s => new ScriptFileViewModel(_settingsManager, ScriptSource.User, s))
                .FirstOrDefault();

            _fileValidationScript ??= _scriptService.GetScripts(@"Resources\Scripts").ToList()
                .Where(s => s.Name == "run_FileValidation_on_active_tab")
                .Select(s => new ScriptFileViewModel(_settingsManager, ScriptSource.System, s))
                .FirstOrDefault();

            _facialSetups.Clear();
            _facialSetups.AddRange(_archiveManager.Search(".facialsetup", ArchiveManagerScope.Basegame).Select(f => f.FileName).ToList());
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
        private List<ChunkViewModel> SelectedChunks => ViewModel?.SelectedChunks ?? [];

        private ChunkViewModel? RootChunk => ViewModel?.RootChunk;

        private async void OnFindBrokenReferencesClick(object _, RoutedEventArgs e)
        {
            if (_projectManager.ActiveProject is null || CurrentTab?.FilePath is not string s || !File.Exists(s))
            {
                return;
            }

            _loggerService.Info("Scanning file for broken references. This is currently slow as foretold, please hold the line...");
            var allReferences = await _projectManager.ActiveProject.GetAllReferences(
                _progressService,
                _loggerService,
                [s.Replace(_projectManager.ActiveProject.ModDirectory, "")]
            );

            var brokenReferences = await _projectManager.ActiveProject.ScanForBrokenReferencePathsAsync(
                _archiveManager,
                _loggerService,
                _progressService,
                allReferences
            );

            if (brokenReferences.Keys.Count == 0)
            {
                _loggerService.Success("No broken references... that we can find!");
                return;
            }

            _loggerService.Info("Done!");
            Interactions.ShowBrokenReferencesList(("Broken references", brokenReferences));
        }
        
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

            if (!string.IsNullOrEmpty(destFolder))
            {
                return destFolder;
            }

            var projectName = _projectManager.ActiveProject?.Name ?? "yourProject";
            var subfolder = _settingsManager.ModderName ?? "YourName";
            return Path.Join(subfolder, projectName, "dependencies");
        }

        private async Task AddDependenciesToFile(ChunkViewModel _)
        {
            if (RootChunk is not ChunkViewModel rootChunk)
            {
                return;
            }

            RootChunk.ForceLoadPropertiesRecursive();
            
            if (RootChunk.ResolvedData is CMesh)
            {
                rootChunk.DeleteUnusedMaterialsCommand.Execute(true);
            }

            await LoadAndAnalyzeModArchives();

            var materialDependencies = await rootChunk.GetMaterialRefsFromFile();
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

            switch (rootChunk.ResolvedData)
            {
                case CMaterialInstance:
                    await SearchAndReplaceInChildNodes(rootChunk, pathReplacements, "values");
                    break;
                case Multilayer_Setup:
                    await SearchAndReplaceInChildNodes(rootChunk, pathReplacements, "layers");
                    break;
                case CMesh:
                    await SearchAndReplaceInChildNodes(rootChunk, pathReplacements, ChunkViewModel.LocalMaterialBufferPath,
                        ChunkViewModel.ExternalMaterialPath);
                    break;
                default:
                    break;
            }
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

            // await replacements
            await Task.WhenAll(childNodes.Select(async childNode =>
            {
                childNode.ForceLoadPropertiesRecursive();
                foreach (var (oldPath, newPath) in pathReplacements)
                {
                    if (await childNode.SearchAndReplaceAsync(oldPath, newPath, true, false) == 0)
                    {
                        continue;
                    }

                    dirtyNodes.Add(childNode);
                    isDirty = true;
                }
            }));

            // Wait for dirty nodes to refresh themselves
            await Task.WhenAll(dirtyNodes.Select(node => node.Refresh()));

            if (isDirty && cvm.Tab?.Parent is not null)
            {
                cvm.Tab.Parent.SetIsDirty(true);
            }
        }

        private async Task LoadAndAnalyzeModArchives()
        {
            if (!_archiveManager.GetModArchives().Any() && _archiveManager.IsInitialized || !AppArchiveManager.ArchivesNeedRescan)
            {
                return;
            }

            if (_settingsManager.CP77ExecutablePath is null)
            {
                throw new WolvenKitException(0x5001, "Can't add dependencies without a game executable path in the settings");
            }

            if (!_archiveManager.IsInitialized)
            {
                _loggerService.Info("Loading mod archives... this can take a moment. Wolvenkit will be unresponsive.");
                _archiveManager.Initialize(new FileInfo(_settingsManager.CP77ExecutablePath));
            }

            _loggerService.Info("Reading mod archive file table, this may take a moment...");
            await Task.Run(() =>
            {
                var ignoredArchives = _settingsManager.ArchiveNamesExcludeFromScan.Split(",").Select(m => m.Replace(".archive", ""))
                    .ToArray();
                _archiveManager.LoadModArchives(new FileInfo(_settingsManager.CP77ExecutablePath), true, ignoredArchives);

                if (_settingsManager.ExtraModDirPath is string extraModDir && !string.IsNullOrEmpty(extraModDir))
                {
                    _archiveManager.LoadAdditionalModArchives(extraModDir, true, ignoredArchives);
                }

                _loggerService.Info("... Done!");
            });
        }

        private async void OnAddDependencies(object? _, EventArgs eventArgs)
        {
            if (_projectManager.ActiveProject is null || ViewModel?.RootChunk is not ChunkViewModel cvm)
            {
                return;
            }

            _projectWatcher.Suspend();

            await AddDependenciesToFile(cvm);

            // Project browser will throw an error if we do it immediately - so let's not
            await Task.Run(async () =>
            {
                await Task.Delay(100);
                _projectWatcher.Refresh();
                _projectWatcher.Resume();
            });
        }

        private void OnChangeChunkMasksClick(object _, RoutedEventArgs e)
        {
            var dialog = new ChangeComponentChunkMaskDialog();
            if (dialog.ShowDialog() != true)
            {
                return;
            }

            if (dialog.ViewModel is null || string.IsNullOrEmpty(dialog.ViewModel.ComponentName))
            {
                return;
            }

            var chunkMask = dialog.ViewModel.ChunkMask;
            var depotPath = dialog.ViewModel.DepotPath;
            var meshAppearance = dialog.ViewModel.MeshAppearance;

            var selectedChunks = SelectedChunks;
            if (selectedChunks.Count == 0 && RootChunk is ChunkViewModel cvm)
            {
                selectedChunks.Add(cvm);
            }

            foreach (var chunkViewModel in SelectedChunks)
            {
                chunkViewModel.ReplaceMeshComponentProperties(dialog.ViewModel.ComponentName!, chunkMask, depotPath, meshAppearance);
            }  
        }

        private async void OnFindUnusedProjectFilesClick(object _, RoutedEventArgs e)
        {
            if (_projectManager.ActiveProject is null || CurrentTab?.FilePath is not string currentFile || !File.Exists(currentFile))
            {
                return;
            }

            var relativePath = currentFile.Replace(_projectManager.ActiveProject.ModDirectory, "");
            _loggerService.Info("Reading references from file...");
            var referencesInFile = await _projectManager.ActiveProject.GetAllReferences(
                _progressService,
                _loggerService,
                [relativePath]
            );

            if (!referencesInFile.TryGetValue(relativePath, out var tmp) || tmp is not List<string> allUsedPaths)
            {
                _loggerService.Warning($"Failed to read used file paths from {relativePath}");
                return;
            }

            var fileExtensions = referencesInFile.Values
                .SelectMany(list => list.Select(Path.GetExtension))
                .Distinct()
                .Where(x => x is not (".json" or ".ent"))
                .ToList();

            var allModFiles = _projectManager.ActiveProject.ModFiles.Where(f => fileExtensions.Contains(Path.GetExtension(f))).ToList();
            var unusedMeshPaths = allModFiles.Where(f => !allUsedPaths.Contains(f)).ToList();

            if (unusedMeshPaths.Count == 0)
            {
                _loggerService.Success("Nothing found! You're good!");
                return;
            }

            _loggerService.Info("Done!");
            Interactions.ShowBrokenReferencesList(("Unused files in project",
                new Dictionary<string, List<string>>() { { relativePath, unusedMeshPaths } }));
        }

        private MenuItem? _openMenu;

        private static List<string> _facialSetups = [];

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

        private void OnKeystateChanged(object sender, KeyEventArgs e) => _modifierStateService.OnKeystateChanged(e);

        private void SearchBar_OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Enter:
                    SearchBar_OnSubmit(this, e);
                    return;
                case Key.Escape:
                case Key.Back when ModifierViewStateService.IsShiftBeingHeld:
                case Key.Delete when ModifierViewStateService.IsShiftBeingHeld:
                    SearchBar_OnClear(this, e);
                    return;
                default:
                    return;
            }
        }

        private void SearchBar_OnSubmit(object sender, RoutedEventArgs e) => ViewModel?.OnSearchChanged(SearchBar?.Text ?? "");

        private void SearchBar_OnClear(object sender, RoutedEventArgs e)
        {
            SearchBar?.Clear();
            SearchBar_OnSubmit(this, e);
        }

        private void SearchBar_OnClick(object sender, MouseButtonEventArgs e)
        {
            if (ModifierViewStateService.IsShiftBeingHeld)
            {
                SearchBar?.SelectAll();
            }
            else if (ModifierViewStateService.IsCtrlBeingHeld)
            {
                SearchBar_OnClear(this, e);
            }
        }

        private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchBar?.Text == "")
            {
                SearchBar_OnClear(this, e);
            }
        }
     
        private void OnChangeAnimationClick(object sender, RoutedEventArgs e)
        {
            if (RootChunk?.ResolvedData is not appearanceAppearanceResource app)
            {
                return;
            }

            var appearanceChildren =
                (RootChunk.GetPropertyChild("appearances")?.Properties.ToList() ?? []).Where(cvm =>
                    cvm.ResolvedData is appearanceAppearanceDefinition).ToList();

            if (!appearanceChildren.Any())
            {
                return;
            }

            var dialog = new SelectFacialAnimationPathDialog(_facialSetups);
            if (dialog.ShowDialog() != true)
            {
                return;
            }

            var facialAnim = dialog.ViewModel?.SelectedFacialAnim;
            var animGraph = dialog.ViewModel?.SelectedGraph;
            var selectedAnims = dialog.ViewModel?.SelectedAnimEntries ?? [];

            foreach (var appNode in appearanceChildren)
            {
                appNode.CalculateProperties();
                if (appNode.GetPropertyChild("components") is not ChunkViewModel componentsNode)
                {
                    continue;
                }

                componentsNode.CalculateProperties();
                
                var animationChildren =
                    componentsNode.Properties.Where(prop => prop.ResolvedData is entAnimatedComponent).ToList() ?? [];
                var animationSetup =
                    componentsNode.Properties.Where(prop => prop.ResolvedData is entAnimationSetupExtensionComponent).ToList() ?? [];

                var appearanceChanged = ChangeAnimation(animationChildren, animGraph, facialAnim);
                var animationSetupsChanged = ChangeAnimationSetupEntries(animationSetup, selectedAnims);

                if (!appearanceChanged && !animationSetupsChanged)
                {
                    continue;
                }

                componentsNode.RecalculateProperties();
                RootChunk?.Tab?.Parent.SetIsDirty(true);
            }

        }

        private bool ChangeAnimationSetupEntries(List<ChunkViewModel> animNodes, List<string> selectedAnims)
        {
            if (animNodes.Count == 0 || selectedAnims.Count == 0)
            {
                return false;
            }

            var isChanged = false;

            foreach (var cvm in animNodes)
            {
                cvm.CalculateProperties();
                if (cvm.ResolvedData is not entAnimationSetupExtensionComponent comp)
                {
                    continue;
                }


                if (cvm.GetPropertyChild("animations", "gameplay") is not ChunkViewModel animationList ||
                    animationList.ResolvedData is not CArray<animAnimSetupEntry> animArray)
                {
                    continue;
                }

                animArray.Clear();

                foreach (var selectedAnim in selectedAnims)
                {
                    animArray.Add(new animAnimSetupEntry()
                    {
                        Priority = 200, AnimSet = new CResourceAsyncReference<animAnimSet>(selectedAnim), VariableNames = []
                    });
                }

                animationList.Data = animArray;

                var propertyChanged = true;

                if (!propertyChanged)
                {
                    continue;
                }

                // force refresh
                animationList.RecalculateProperties();
                isChanged = isChanged || propertyChanged;
            }

            return isChanged;
        }

        private static bool ChangeAnimation(List<ChunkViewModel> animNodes, string? selectedGraph, string? selectedFacialAnim)
        {
            if (animNodes.Count == 0 || (string.IsNullOrEmpty(selectedGraph) && string.IsNullOrEmpty(selectedFacialAnim)))
            {
                return false;
            }

            var isChanged = false;

            foreach (var cvm in animNodes)
            {
                if (cvm.ResolvedData is not entAnimatedComponent comp || comp.Name.GetResolvedText() != "face_rig")
                {
                    continue;
                }

                var propertyChanged = false;
                if (!string.IsNullOrEmpty(selectedFacialAnim))
                {
                    comp.Graph = new CResourceReference<animAnimGraph>(selectedFacialAnim);
                    propertyChanged = true;
                }

                if (!string.IsNullOrEmpty(selectedGraph))
                {
                    comp.FacialSetup = new CResourceAsyncReference<animFacialSetup>(selectedGraph);
                    propertyChanged = true;
                }

                if (propertyChanged)
                {
                    // force refresh
                    cvm.RecalculateProperties();
                }
            }

            return isChanged;
        }

        private const int s_maxNumberReplacerAppearances = 100;

        private void OnConvertToPhotoModeClick(object sender, RoutedEventArgs e)
        {
            if (RootChunk?.ResolvedData is not appearanceAppearanceResource)
            {
                return;
            }

            if (RootChunk.Tab?.Parent.IsDirty == true)
            {
                _loggerService.Error("File has un-saved changes! Please save before converting!");
            }

            var dialog = new SelectPhotoModeAppDialog();

            if (dialog.ShowDialog() != true)
            {
                return;
            }

            var photoModeApp = dialog.ViewModel?.SelectedApp;
            var renameAppearances = dialog.ViewModel?.RenameEntries ?? false;
            var appearanceChildren = RootChunk.GetPropertyChild("appearances")?.Properties
                .Where(cvm => cvm.ResolvedData is appearanceAppearanceDefinition)
                .ToList() ?? [];

            // nothing to do
            if (appearanceChildren.Count == 0 || (!renameAppearances && string.IsNullOrEmpty(photoModeApp)))
            {
                return;
            }

            // user clicked cancel
            if (!Interactions.ShowQuestionYesNo(("You can't un-do this. Are you sure?", "Convert .app file?")))
            {
                return;
            }
            
            if (renameAppearances)
            {
                if (appearanceChildren.Count > s_maxNumberReplacerAppearances)
                {
                    var message = string.Join(Environment.NewLine,
                    [
                        $"Nibbles Replacer only supports {s_maxNumberReplacerAppearances} appearances.",
                        "Your app has ${appearanceChildren.Count}.",
                        "Do you want to convert the extra appearances anyway?",
                    ]);

                    if (!Interactions.ShowQuestionYesNo((message, "Too many appearances!")))
                    {
                        appearanceChildren = appearanceChildren.Take(s_maxNumberReplacerAppearances).ToList();
                    }
                    
                }

                var counter = 01;
                foreach (var appNode in appearanceChildren)
                {
                    // type check has already been done when selecting the nodes
                    var resolvedData = (appearanceAppearanceDefinition)appNode.ResolvedData;

                    resolvedData.Name = counter < 100 ? $"appearance_{counter:D2}" : $"appearance_{counter:D3}";
                    counter += 1;
                    appNode.RecalculateProperties();
                }
            }

            if (string.IsNullOrEmpty(photoModeApp))
            {
                return;
            }

            if (RootChunk.Tab is null || _projectManager.ActiveProject is null || RootChunk.Tab.FilePath is not string s || !File.Exists(s))
            {
                _loggerService.Error($"Can't automatically move your file. Please move it to the following path: ");
                _loggerService.Error($"\t{photoModeApp}");
                return;
            }

            RootChunk.Tab.Parent.SaveCommand.Execute(null);
            var destPath = Path.Join(_projectManager.ActiveProject.ModDirectory, photoModeApp);
            if (Path.GetDirectoryName(destPath) is string parentFolder && !Directory.Exists(parentFolder))
            {
                Directory.CreateDirectory(parentFolder);
            }

            if (_appViewModel.ActiveDocument is not null)
            {
                _appViewModel.CloseFile(_appViewModel.ActiveDocument);
            }

            File.Move(s, destPath);
            _appViewModel.OpenFileFromDepotPath(photoModeApp);
        }
    }
}