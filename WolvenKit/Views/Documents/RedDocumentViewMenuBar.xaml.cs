#nullable enable

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using ReactiveUI;
using Splat;
using WolvenKit.App;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Scripting;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevel;
using WolvenKit.Common;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Dialogs.Windows;
using appearanceAppearanceDefinition = WolvenKit.RED4.Types.appearanceAppearanceDefinition;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;

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
        private readonly ProjectExplorerViewModel _projectExplorer;
        private readonly AppViewModel _appViewModel;
        private readonly IProgressService<double> _progressService;
        private readonly ProjectResourceTools _projectResourceTools;
        private readonly DocumentTools _documentTools;
        private readonly Cr2WTools _cr2WTools;
        
        
        public RedDocumentViewMenuBar()
        {
            _scriptService = Locator.Current.GetService<AppScriptService>()!;
            _settingsManager = Locator.Current.GetService<ISettingsManager>()!;
            _projectManager = Locator.Current.GetService<IProjectManager>()!;
            _loggerService = Locator.Current.GetService<ILoggerService>()!;
            _projectWatcher = (WatcherService)Locator.Current.GetService<IWatcherService>()!;
            _archiveManager = Locator.Current.GetService<IAppArchiveManager>()!;
            _modifierStateService = Locator.Current.GetService<IModifierViewStateService>()!;
            _progressService = Locator.Current.GetService<IProgressService<double>>()!;
            _projectExplorer = Locator.Current.GetService<ProjectExplorerViewModel>()!;
            _projectResourceTools = Locator.Current.GetService<ProjectResourceTools>()!;
            _documentTools = Locator.Current.GetService<DocumentTools>()!;
            _cr2WTools = Locator.Current.GetService<Cr2WTools>()!;

            _appViewModel = Locator.Current.GetService<AppViewModel>()!;

            // Enforce instance generation and service injection. One would assume that registering a singleton
            // is enough. One would be wrong.
            Locator.Current.GetService<DocumentTools>();
            
            InitializeComponent();

            InitializeInstanceObjects();

            DataContext = new RedDocumentViewToolbarModel(
                _settingsManager,
                _modifierStateService,
                _projectManager) { CurrentTab = _currentTab };
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

            s_facialSetups.Clear();
            s_facialSetups.AddRange(_archiveManager.Search(".facialsetup", ArchiveManagerScope.Basegame)
                .Select(f => f.FileName).ToList());
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
                if (Interactions.ShowQuestionYesNo((
                        "Run file validation now? (Wolvenkit will be unresponsive)",
                        "Validate files now?")))
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

        private void OnUnDynamifyMaterialsClick(object _, RoutedEventArgs e)
        {
            if (ViewModel?.RootChunk is not ChunkViewModel cvm || cvm.ResolvedData is not CMesh mesh)
            {
                return;
            }

            cvm.ConvertPreloadMaterialsCommand.Execute(null);

            var appearancesByName = cvm.UnDynamifyAppearances();
            if (appearancesByName.Count == 0)
            {
                return;
            }

            cvm.GetPropertyChild("materials")?.CalculateProperties();
            cvm.GetPropertyChild("localMaterialBuffer", "materials")?.CalculateProperties();

            foreach (var (matName, resolvedMatNames) in appearancesByName)
            {
                var material = mesh.MaterialEntries.FirstOrDefault(m => m.Name == $"@{matName}");
                if (material is null || mesh.LocalMaterialBuffer.Materials.Count < material.Index)
                {
                    _loggerService.Warning($"Failed to resolve dynamic material {matName}");
                    continue;
                }


                var matInstance = (CMaterialInstance)mesh.LocalMaterialBuffer.Materials[material.Index];
                var baseMaterialPath = matInstance.BaseMaterial.DepotPath.GetResolvedText() ?? "";

                var maxIndex = mesh.MaterialEntries.Where(m => m.IsLocalInstance.Equals(material.IsLocalInstance))
                    .Select(m => m.Index).Max();

                foreach (var newMatName in resolvedMatNames)
                {
                    maxIndex += 1;
                    mesh.MaterialEntries.Add(new CMeshMaterialEntry()
                    {
                        Name = newMatName, Index = maxIndex, IsLocalInstance = material.IsLocalInstance
                    });


                    var newMaterialInstance = new CMaterialInstance()
                    {
                        BaseMaterial = new CResourceReference<IMaterial>(
                            baseMaterialPath.Replace("{material}", newMatName).Replace("*", ""),
                            InternalEnums.EImportFlags.Default),
                    };
                    foreach (var cvp in matInstance.Values)
                    {
                        var value = cvp.Value switch
                        {
                            IRedResourceReference val => new CResourceReference<CResource>(
                                (val.DepotPath.GetResolvedText() ?? "").Replace("{material}", newMatName)
                                .Replace("*", ""), InternalEnums.EImportFlags.Default),
                            IRedResourceAsyncReference asyncVal => new CResourceAsyncReference<CResource>(
                                (asyncVal.DepotPath.GetResolvedText() ?? "").Replace("{material}", newMatName)
                                .Replace("*", ""), InternalEnums.EImportFlags.Default),
                            _ => cvp.Value
                        };

                        newMaterialInstance.Values.Add(new CKeyValuePair(cvp.Key, value));
                    }

                    mesh.LocalMaterialBuffer.Materials.Add(newMaterialInstance);
                }
            }

            cvm.GetPropertyChild("materialEntries")?.RecalculateProperties();
            cvm.GetPropertyChild("localMaterialBuffer", "materials")?.RecalculateProperties();

            cvm.DeleteUnusedMaterialsCommand.Execute(true);
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

        private string GetTextureDirForDependencies(bool useTextureSubfolder) =>
            ViewModel?.GetTextureDirForDependencies(useTextureSubfolder) ?? "";

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
            var pathReplacements = await _projectResourceTools.AddDependenciesToProjectPathAsync(
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
            if (!AppArchiveManager.ArchivesNeedRescan ||
                (!_archiveManager.GetModArchives().Any() && _archiveManager.IsInitialized))
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

        private List<appearanceAppearanceDefinition> GetAppearancesFromSelectionOrRoot()
        {
            if (RootChunk?.ResolvedData is not appearanceAppearanceResource appResource)
            {
                return [];
            }

            var ret = SelectedChunks
                .Where(chunk => chunk.ResolvedData is appearanceAppearanceDefinition)
                .Select(chunk => chunk.ResolvedData as appearanceAppearanceDefinition)
                .Select(app => app!)
                .ToList();

            if (ret.Count == 0)
            {
                ret.AddRange(
                    appResource.Appearances.Select(appHandle => appHandle.Chunk)
                        .Where(app => app is not null)
                        .Select(app => app!)
                );
            }

            return ret;
        }
        private void OnDuplicateComponentAsNewClick(object _, RoutedEventArgs e)
        {
            if (RootChunk?.ResolvedData is not appearanceAppearanceResource)
            {
                return;
            }

            var componentNames = DocumentTools.GetAllComponentNames(GetAppearancesFromSelectionOrRoot());
            var componentModel = Interactions.ShowDeleteOrDuplicateComponentDialogue((componentNames, false));

            var selectedChunks = SelectedChunks.ToList();

            if (!selectedChunks.All(c => c.ResolvedData is appearanceAppearanceDefinition))
            {
                selectedChunks.Clear();
            }

            if (selectedChunks.Count == 0)
            {
                selectedChunks.Add(RootChunk);
            }

            if (componentModel is null || string.IsNullOrEmpty(componentModel.ComponentName) ||
                string.IsNullOrEmpty(componentModel.NewComponentName))
            {
                return;
            }

            ViewModel?.ClearSelection();
            
            
            foreach (var chunkViewModel in selectedChunks.SelectMany(cvm =>
                         GetComponentsByName(cvm, componentModel.ComponentName)).ToList())
            {
                // insert after existing node, not before
                var newNode = chunkViewModel.DuplicateChunk(chunkViewModel.NodeIdxInParent + 1);

                if (newNode?.Data is not entIComponent component)
                {
                    continue;
                }

                component.Name = componentModel.NewComponentName;
                newNode.RecalculateProperties();
                newNode.Parent?.RecalculateProperties();
            }

            // clear selection to work around invalid selection bug
            ViewModel?.ClearSelection();
        }

        private void OnDeleteComponentByNameClick(object _, RoutedEventArgs e)
        {
            if (RootChunk?.ResolvedData is not appearanceAppearanceResource)
            {
                return;
            }

            var componentNames = DocumentTools.GetAllComponentNames(GetAppearancesFromSelectionOrRoot());
            var componentModel = Interactions.ShowDeleteOrDuplicateComponentDialogue((componentNames, true));

            var selectedChunks = SelectedChunks.ToList();
            if (!selectedChunks.All(c => c.ResolvedData is appearanceAppearanceDefinition))
            {
                selectedChunks.Clear();
            }

            if (selectedChunks.Count == 0)
            {
                selectedChunks.Add(RootChunk);
            }

            if (componentModel is null || string.IsNullOrEmpty(componentModel.ComponentName) ||
                string.IsNullOrEmpty(componentModel.NewComponentName))
            {
                return;
            }

            ViewModel?.ClearSelection();

            foreach (var chunkViewModel in selectedChunks.SelectMany(cvm =>
                         GetComponentsByName(cvm, componentModel.ComponentName)).ToList())
            {
                chunkViewModel.DeleteNodesInParent([chunkViewModel]);
            }

        }

        private static List<ChunkViewModel> GetComponentsByName(ChunkViewModel cvm, string componentName)
        {
            List<ChunkViewModel> ret = [];
            cvm.CalculateProperties();
            switch (cvm.ResolvedData)
            {
                case appearanceAppearanceDefinition:
                    if (cvm.GetPropertyChild("components") is ChunkViewModel child)
                    {
                        child.CalculateProperties();
                        foreach (var grandChild in child.TVProperties)
                        {
                            grandChild.CalculateProperties();
                        }

                        ret.AddRange(child.TVProperties.Where(c =>
                            c.ResolvedData is entIComponent component && component.Name == componentName));
                    }

                    break;
                case appearanceAppearanceResource
                    when cvm.GetPropertyChild("appearances") is ChunkViewModel appearances:
                    appearances.CalculateProperties();
                    ret.AddRange(
                        appearances.TVProperties.SelectMany(
                            appearance => GetComponentsByName(appearance, componentName)));
                    break;
                case CArray<CHandle<appearanceAppearanceDefinition>> array:
                    ret.AddRange(cvm.GetPropertyChild("appearances")?.TVProperties
                        .SelectMany(handle => GetComponentsByName(handle, componentName)) ?? []);
                    break;
            }

            return ret;
        }

        private void OnChangeComponentPropertiesClick(object _, RoutedEventArgs e)
        {
            if (RootChunk?.ResolvedData is not appearanceAppearanceResource)
            {
                return;
            }

            RootChunk.CalculatePropertiesRecursive();

            var componentNames = DocumentTools.GetAllComponentNames(GetAppearancesFromSelectionOrRoot());

            var dialog = new ChangeComponentPropertiesDialog(componentNames);
            if (dialog.ShowDialog() != true)
            {
                return;
            }

            if (dialog.ViewModel is null || string.IsNullOrEmpty(dialog.ViewModel.ComponentName))
            {   
                return;
            }

            var selectedChunks = SelectedChunks.ToList();
            if (!selectedChunks.All(c => c.ResolvedData is appearanceAppearanceDefinition))
            {
                selectedChunks.Clear();
            }
            if (selectedChunks.Count == 0 && RootChunk is ChunkViewModel cvm)
            {
                selectedChunks.Add(cvm);
            }

            ViewModel?.ClearSelection();
            foreach (var chunkViewModel in selectedChunks)
            {
                chunkViewModel.ReplaceEntIComponentProperties(dialog.ViewModel.ComponentName!,
                    dialog.ViewModel.ChunkMask, dialog.ViewModel.DepotPath,
                    dialog.ViewModel.MeshAppearance, dialog.ViewModel.NewComponentName);
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

        private async void OnConnectToEntFileClick(object _, RoutedEventArgs e)
        {
            try
            {
                if (_projectManager.ActiveProject is not Cp77Project activeProject || RootChunk is not
                    {
                        ResolvedData: appearanceAppearanceResource
                    })
                {
                    return;
                }

                if (string.IsNullOrEmpty(RootChunk.Tab?.FilePath))
                {
                    _loggerService.Error($"Can't read current .app file!");
                    return;
                }

                var entFilePath = await Interactions.ShowInputBoxAsync("Enter .ent file path", "");
                if (string.IsNullOrEmpty(entFilePath))
                {
                    return;
                }


                if (!activeProject.Files.Contains(entFilePath.StartsWith("archive")
                        ? entFilePath
                        : Path.Join("archive", entFilePath)))
                {
                    _loggerService.Error($"Can't find .ent file {entFilePath}!");
                    return;
                }

                if (_archiveManager.GetGameFile(entFilePath, false, false) is not null)
                {
                    throw new WolvenKitException(0x3001,
                        $"Don't overwrite base game files! Use ArchiveXL resource patching instead!");
                }

                if (!Path.IsPathRooted(entFilePath))
                {
                    entFilePath = Path.Combine(_projectManager.ActiveProject.ModDirectory, entFilePath);
                }

                var appFilePath = RootChunk.Tab.FilePath;
                if (!Path.IsPathRooted(appFilePath))
                {
                    appFilePath = Path.Combine(_projectManager.ActiveProject.ModDirectory, appFilePath);
                }

                _documentTools.ConnectAppToEntFile(appFilePath, entFilePath);
            }
            catch (Exception err)
            {
                _loggerService.Error("Failed to connect .app to .ent file! An exception was thrown:");
                _loggerService.Error(err);
            }
        }
        
        private MenuItem? _openMenu;

        private static readonly List<string> s_facialSetups = [];

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
            if (RootChunk?.Tab is null || RootChunk?.ResolvedData is not appearanceAppearanceResource app ||
                !File.Exists(RootChunk.Tab.FilePath))
            {
                return;
            }

            if (RootChunk.Tab.Parent.IsDirty)
            {
                _loggerService.Error("Please save the file before changing animations!");
            }

            var dialog = new SelectFacialAnimationPathDialog(s_facialSetups);
            if (dialog.ShowDialog() != true)
            {
                return;
            }

            _documentTools.SetFacialAnimations(RootChunk.Tab.FilePath, dialog.ViewModel?.SelectedFacialAnim,
                dialog.ViewModel?.SelectedGraph, dialog.ViewModel?.SelectedAnimEntries ?? []);
            
        }
        
        

    }
}