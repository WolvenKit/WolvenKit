#nullable enable

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using Splat;
using WolvenKit.App;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Scripting;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevel;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Dialogs.Windows;
using appearanceAppearanceDefinition = WolvenKit.RED4.Types.appearanceAppearanceDefinition;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;
using WikiLinks = WolvenKit.Core.WikiLinks;

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
            _cr2WTools = Locator.Current.GetService<Cr2WTools>()!;

            _appViewModel = Locator.Current.GetService<AppViewModel>()!;

            // Enforce instance generation and service injection. One would assume that registering a singleton
            // is enough. One would be wrong.
            _documentTools = Locator.Current.GetService<DocumentTools>()!;

            InitializeComponent();

            InitializeInstanceObjects();

            DataContext = new RedDocumentViewToolbarModel(
                _settingsManager,
                _modifierStateService,
                _projectManager,
                _documentTools,
                Locator.Current.GetService<CRUIDService>()!) { CurrentTab = _currentTab };
            ViewModel = DataContext as RedDocumentViewToolbarModel;

            _modifierStateService.ModifierStateChanged += OnModifierStateChanged;

            this.WhenActivated(disposable =>
            {
                if (DataContext is not RedDocumentViewToolbarModel vm)
                {
                    return;
                }

                vm.SetEditorLevel(_settingsManager.DefaultEditorDifficultyLevel);
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

        private async Task RunFileValidationAsync()
        {
            if (_fileValidationScript is null || !File.Exists(_fileValidationScript.Path))
            {
                string[] exceptionMsg =
                [
                    "File validation script not found!",
                    "Try deleting '%APPDATA%\\REDModding\\WolvenKit\\Scripts\\Wolvenkit_FileValidation.wscript',",
                    "then restart Wolvenkit. If that does not help, please get in touch with the devs."
                ];
                throw new WolvenKitException(0x5002, string.Join('\n', exceptionMsg));
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
            try
            {
                if (_projectManager.ActiveProject is null || CurrentTab?.FilePath is not string s || !File.Exists(s))
                {
                    return;
                }

                _loggerService.Info(
                    "Scanning file for broken references. This is currently slow as foretold, please hold the line...");
                var allReferences = await _projectManager.ActiveProject.GetAllReferencesAsync(
                    _progressService,
                    _loggerService,
                    [s.Replace($"{_projectManager.ActiveProject.ModDirectory}{Path.DirectorySeparatorChar}", "")]
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
            catch (Exception err)
            {
                _loggerService.Error("Error while scanning for broken references:");
                _loggerService.Error(err);
            }
        }

        private async void OnFileValidationClick(object _, RoutedEventArgs e)
        {
            try
            {
                // in .app or root entity: warn with >5 appearances, because this can take a while
                if (ViewModel?.RootChunk is ChunkViewModel cvm
                    && ((cvm.ResolvedData is appearanceAppearanceResource app && app.Appearances.Count > 5) ||
                        (cvm.ResolvedData is entEntityTemplate ent && ent.Appearances.Count > 5)))
                {
                    if (!Interactions.ShowQuestionYesNo((
                            "Run file validation now? (Wolvenkit will be unresponsive)",
                            "Validate files now?")))
                    {
                        return;
                    }
                }

                // This needs to be inside the DispatcherHelper, or the UI button will make everything explode
                DispatcherHelper.RunOnMainThread(() =>
                    _loggerService.Info("Running file validation, please wait. The UI will be unresponsive."));

                await RunFileValidationAsync();
            }
            catch (Exception ex)
            {
                _loggerService.Error("Error while running file validation:");
                _loggerService.Error(ex);
            }
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

        private void OnCopyMaterialsFromMeshClick(object _, RoutedEventArgs e)
        {
            if (ViewModel?.CurrentTab?.Parent.IsDirty == true)
            {
                Interactions.ShowMessageBox("This will reload your file. Press Ctrl+S to save now.", "Save your file!");
                return;
            }

            if (ViewModel?.RootChunk is not ChunkViewModel { ResolvedData: CMesh mesh } || ViewModel.FilePath is null ||
                _projectManager.ActiveProject is not { } project)
            {
                return;
            }

            var files = _documentTools.CollectProjectFiles(".mesh").Where(f => f != ViewModel.FilePath)
                .ToList();

            if (Interactions.AskForDropdownOption((files, "Select .mesh file", "Select .mesh file",
                    WikiLinks.MeshMaterials, true, "From ArchiveXL patch mesh")) is not string meshFileName ||
                string.IsNullOrEmpty(meshFileName))
            {
                return;
            }

            try
            {
                // Only reload if we wrote anything
                if (_documentTools.CopyMeshMaterials(meshFileName, ViewModel.FilePath))
                {
                    ViewModel.CurrentTab?.Parent.Reload(true);
                }
                else if (meshFileName == SelectDropdownEntryDialogViewModel.ButtonClickResult)
                {
                    _loggerService.Error(
                        "Failed to copy mesh materials from patch mesh. Try picking a mesh, or adding the file path directly.");
                }
                else
                {
                    _loggerService.Error(
                        "Failed to copy mesh materials: No mesh(es) found, or selected mesh files don't contain any material information.");
                }
            }
            catch (Exception err)
            {
                _loggerService.Error($"Failed to copy mesh materials: {err.Message}");
            }
        }

        private void OnUnDynamifyMaterialsClick(object _, RoutedEventArgs e)
        {
            if (ViewModel?.RootChunk is not { ResolvedData: CMesh mesh } cvm ||
                cvm.GetPropertyChild("appearances") is not ChunkViewModel appearances)
            {
                return;
            }

            cvm.ConvertPreloadMaterialsCommand.Execute(null);

            appearances.CalculatePropertiesRecursive();

            var templatesAndValues = ArchiveXlHelper.GetMaterialSubstitutionMap(mesh.Appearances);

            // nothing to do here
            if (templatesAndValues.Count == 0)
            {
                return;
            }

            var expandedData = ArchiveXlHelper.ExpandAppearanceTemplate(mesh.Appearances);
            appearances.Data = ArchiveXlHelper.UnDynamifyChunkNames(expandedData);

            appearances.RecalculateProperties();

            cvm.GetPropertyChild("materials")?.CalculateProperties();
            cvm.GetPropertyChild("localMaterialBuffer", "materials")?.CalculateProperties();

            // iterate over dictionary and create new materials
            foreach (var (matName, resolvedMatNames) in templatesAndValues)
            {
                var material = mesh.MaterialEntries.FirstOrDefault(m => m.Name == $"@{matName}");
                if (material is null || mesh.LocalMaterialBuffer.Materials.Count < material.Index)
                {
                    _loggerService.Warning($"Can't un-dynamify material: Failed to resolve {matName}");
                    continue;
                }

                var matInstance = (CMaterialInstance)mesh.LocalMaterialBuffer.Materials[material.Index];
                var baseMaterialPath = matInstance.BaseMaterial.DepotPath.GetResolvedText() ?? "";

                var maxIndex = mesh.MaterialEntries.Where(m => m.IsLocalInstance.Equals(material.IsLocalInstance))
                    .Select(m => m.Index).Max();

                foreach (var newMatName in resolvedMatNames.Distinct())
                {
                    maxIndex += 1;
                    mesh.MaterialEntries.Add(new CMeshMaterialEntry()
                    {
                        Name = $"{matName}_{newMatName}", Index = maxIndex, IsLocalInstance = material.IsLocalInstance
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
                            CResourceReference<Multilayer_Setup> mlsetup => new CResourceReference<Multilayer_Setup>(
                                ReplaceMaterialPath(mlsetup.DepotPath, newMatName), InternalEnums.EImportFlags.Default),
                            CResourceReference<Multilayer_Mask> mlmask => new CResourceReference<Multilayer_Mask>(
                                ReplaceMaterialPath(mlmask.DepotPath, newMatName), InternalEnums.EImportFlags.Default),
                            CResourceReference<ITexture> tex => new CResourceReference<ITexture>(
                                ReplaceMaterialPath(tex.DepotPath, newMatName), InternalEnums.EImportFlags.Default),
                            CResourceAsyncReference<Multilayer_Setup> mlsetup => new
                                CResourceAsyncReference<Multilayer_Setup>(
                                    ReplaceMaterialPath(mlsetup.DepotPath, newMatName),
                                    InternalEnums.EImportFlags.Default),
                            CResourceAsyncReference<Multilayer_Mask> mlmask => new
                                CResourceAsyncReference<Multilayer_Mask>(
                                    ReplaceMaterialPath(mlmask.DepotPath, newMatName),
                                    InternalEnums.EImportFlags.Default),
                            CResourceAsyncReference<ITexture> tex => new CResourceAsyncReference<ITexture>(
                                ReplaceMaterialPath(tex.DepotPath, newMatName), InternalEnums.EImportFlags.Default),
                            IRedResourceReference val => new CResourceReference<CResource>(
                                ReplaceMaterialPath(val.DepotPath, newMatName), InternalEnums.EImportFlags.Default),
                            IRedResourceAsyncReference asyncVal => new CResourceAsyncReference<CResource>(
                                ReplaceMaterialPath(asyncVal.DepotPath, newMatName),
                                InternalEnums.EImportFlags.Default),
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

            ViewModel.DeleteUnusedMaterialsCommand?.NotifyCanExecuteChanged();
            return;

            static string ReplaceMaterialPath(ResourcePath? depotPath, string newMatName) =>
                (depotPath?.GetResolvedText() ?? "").Replace("{material}", newMatName).Replace("*", "");
        }

        private void OnConvertHairToCCXLMaterials(object _, RoutedEventArgs e)
        {
            if (ViewModel?.RootChunk is not ChunkViewModel cvm || cvm.ResolvedData is not CMesh mesh ||
                _projectManager.ActiveProject is not Cp77Project activeProject)
            {
                return;
            }


            var dialog = new ConvertHairToCCXLMaterialsDialog(activeProject);
            if (dialog.ShowDialog() != true)
            {
                return;
            }

            if (mesh.Appearances.Count == 0)
            {
                _loggerService.Info("No appearance found for CCXL, adding an appearance");
                var newMeshApp = new meshMeshAppearance { Name = "black_carbon" };
                mesh.Appearances.Add(newMeshApp);
            }


            var app = mesh.Appearances.First();

            var appName = ((meshMeshAppearance)app!).Name;

            var mainHairMiFile = dialog.ViewModel?.SelectedMiFile;
            var mainHairMiType = dialog.ViewModel?.SelectedMiType;

            if (mainHairMiType is null || mainHairMiFile is null)
            {
                _loggerService.Info("main hair information not selected, aborting conversion");
                return;
            }

            var mainMiPath = (CName)(mainHairMiFile);

            if (mainHairMiType is "Cap01")
            {
                mainHairMiType = "Cap";
            }


            cvm.GetPropertyChild("appearances")?.CalculateProperties();
            cvm.GetPropertyChild("materialEntries")?.CalculateProperties();
            cvm.GetPropertyChild("externalMaterials")?.CalculateProperties();

            ViewModel.ClearMaterialsCommand.Execute(true);

            mesh.Appearances.Clear();

            app.Chunk!.ChunkMaterials =
            [
                appName + "@" + mainHairMiType.ToLower()
            ];


            mesh.MaterialEntries.Add(new CMeshMaterialEntry()
            {
                Name = "@context", Index = (CUInt16)0, IsLocalInstance = true
            });

            var mainMi = new CMeshMaterialEntry()
            {
                Name = "@" + mainHairMiType.ToLower(), Index = (CUInt16)1, IsLocalInstance = true
            };


            mesh.MaterialEntries.Add(mainMi);


            var mainMiValue = new CResourceReference<CHairProfile>(
                @"*base\characters\common\hair\textures\hair_profiles\{material}.hp",
                InternalEnums.EImportFlags.Soft);


            mesh.LocalMaterialBuffer.Materials.Add(new CMaterialInstance
            {
                Values = [new CKeyValuePair(mainHairMiType + "BaseMaterial", mainMiPath)]
            });

            mesh.LocalMaterialBuffer.Materials.Add(new CMaterialInstance
                {
                    BaseMaterial =
                        new CResourceReference<IMaterial>(mainHairMiFile, InternalEnums.EImportFlags.Default),
                    Values = [new CKeyValuePair("HairProfile", mainMiValue)]
                }
            );


            if (dialog.ViewModel?.IsCap is true)
            {
                app.Chunk!.ChunkMaterials =
                [
                    appName + "@" + mainHairMiType.ToLower(),
                    appName + "@cap"
                ];

                var capHairMiFile = dialog.ViewModel?.SelectedCapMiFile;
                var capMiNameType = "Cap";
                var capMiPath = (CName)(capHairMiFile!);


                mesh.LocalMaterialBuffer.Materials.RemoveAt(0);

                mesh.LocalMaterialBuffer.Materials.Insert(0, new CMaterialInstance
                {
                    Values =
                    [
                        new CKeyValuePair(mainHairMiType + "BaseMaterial", mainMiPath),
                        new CKeyValuePair(capMiNameType + "BaseMaterial", capMiPath)
                    ]
                });


                var capMi = new CMeshMaterialEntry()
                {
                    Name = "@" + capMiNameType.ToLower(), Index = (CUInt16)2, IsLocalInstance = true
                };

                mesh.MaterialEntries.Add(capMi);


                var capValues = new CResourceReference<ITexture>(
                    @"*base\characters\common\hair\textures\cap_gradiants\hh_cap_grad__{material}.xbm",
                    InternalEnums.EImportFlags.Soft);
                mesh.LocalMaterialBuffer.Materials.Add(new CMaterialInstance
                    {
                        BaseMaterial =
                            new CResourceReference<IMaterial>(capHairMiFile!, InternalEnums.EImportFlags.Default),
                        Values = [new CKeyValuePair("GradientMap", capValues)]
                    }
                );
            }


            mesh.Appearances.Add(app);
            cvm.AdjustSubmeshCountCommand.Execute(true);

            cvm.GetPropertyChild("appearances")?.RecalculateProperties();
            cvm.GetPropertyChild("materialEntries")?.RecalculateProperties();
            cvm.GetPropertyChild("externalMaterials")?.RecalculateProperties();

            _loggerService.Success("Hair mesh converted to CCXL!");
            cvm.Tab?.Parent.SetIsDirty(true);
        }

        private void OnEditorModeClick(EditorDifficultyLevel level) =>
            _settingsManager.DefaultEditorDifficultyLevel = level;

        private void OnEditorModeClick_Easy(object _, RoutedEventArgs e) =>
            OnEditorModeClick(EditorDifficultyLevel.Easy);

        private void OnEditorModeClick_Default(object _, RoutedEventArgs e) =>
            OnEditorModeClick(EditorDifficultyLevel.Default);

        private void OnEditorModeClick_Advanced(object _, RoutedEventArgs e) =>
            OnEditorModeClick(EditorDifficultyLevel.Advanced);

        private string GetTextureDirForDependencies(bool useTextureSubfolder) =>
            ViewModel?.GetTextureDirForDependencies(useTextureSubfolder) ?? "";

        // If this is static, we can't use Path.Join
        private readonly List<string> _ignoredDependencyPartials =
        [
            ".mltemplate",
            ".mt",
            ".remt",
            Path.Join("base", "surfaces", "microblends"),
            Path.Join("base", "materials"),
            Path.Join("base", "fx"),
            Path.Join("ep1", "materials"),
            Path.Join("ep1", "fx"),
            "engine",
        ];

        private readonly SemaphoreSlim _semaphore = new(1, 1); //  only one thread/task can enter

        private async Task AddDependenciesToFileAsync(ChunkViewModel _, bool addBasegameFiles = false)
        {
            if (RootChunk is not ChunkViewModel rootChunk || RootChunk.ResolvedData is not CMesh)
            {
                return;
            }

            // Wait asynchronously to acquire the semaphore
            if (!await _semaphore.WaitAsync(200))
            {
                _loggerService.Error("Already on it! Please wait...");
                return;
            }

            try
            {
                RootChunk.ForceLoadPropertiesRecursive();
                rootChunk.DeleteUnusedMaterialsCommand.Execute(true);

                await LoadAndAnalyzeModArchivesAsync();

                var materialDependencies = await rootChunk.GetMaterialRefsFromFile();

                // Filter files: Ignore base game files unless shift key is pressed
                materialDependencies = materialDependencies
                    .Where(refPathHash =>
                        {
                            var hasModFile = _archiveManager.Lookup(refPathHash, ArchiveManagerScope.Mods) is
                                { HasValue: true };
                            var gameFileOpt = _archiveManager.Lookup(refPathHash, ArchiveManagerScope.Basegame);

                            // Only files from mods. Filter out anything that overwrites basegame files.
                            if (hasModFile && !gameFileOpt.HasValue)
                            {
                                return true;
                            }

                            return addBasegameFiles && gameFileOpt.HasValue && !IsIgnoredDependency(gameFileOpt.Value);
                        }
                    )
                    .ToHashSet();

                if (materialDependencies.Count == 0)
                {
                    _loggerService.Info(
                        "Didn't find any dependencies to add.\n" +
                        "To include base game files, hold shift while clicking the menu entry."
                    );
                    return;
                }

                var destFolder = GetTextureDirForDependencies(true);

                // Use search and replace to fix file paths
                if (string.IsNullOrEmpty(destFolder))
                {
                    return;
                }

                var pathReplacements = await _projectResourceTools.AddDependenciesToProjectPathAsync(
                    destFolder, materialDependencies
                );

                // Nothing to replace in file - give user output
                if (pathReplacements.Count is 0)
                {
                    if (materialDependencies.Count > 0)
                    {
                        _loggerService.Info(
                            "Didn't find any dependencies to add.\n" +
                            "To include base game files, hold shift while clicking the menu entry." +
                            "If modded files could not be resolved, click the scan button in the mod browser " +
                            "(to the right of the search bar)."
                        );
                    }
                    else
                    {
                        _loggerService.Success(
                            "No dependencies left to replace. To double-check, run file validation now."
                        );
                    }

                    return;
                }

                switch (rootChunk.ResolvedData)
                {
                    case CMaterialInstance:
                        await SearchAndReplaceInChildNodesAsync(rootChunk, pathReplacements, "values");
                        break;
                    case Multilayer_Setup:
                        await SearchAndReplaceInChildNodesAsync(rootChunk, pathReplacements, "layers");
                        break;
                    case CMesh:
                        await SearchAndReplaceInChildNodesAsync(rootChunk, pathReplacements,
                            ChunkViewModel.LocalMaterialBufferPath,
                            ChunkViewModel.ExternalMaterialPath,
                            ChunkViewModel.PreloadMaterialPath,
                            ChunkViewModel.PreloadExternalMaterialPath
                        );
                        break;
                    default:
                        break;
                }
            }
            finally
            {
                _semaphore.Release();
            }

            return;
            bool IsIgnoredDependency(IGameFile gameFile)
            {
                return _ignoredDependencyPartials.Contains(gameFile.Extension) ||
                       _ignoredDependencyPartials.Any(p => gameFile.FileName.StartsWith(p));
            }
        }

        private static async Task SearchAndReplaceInChildNodesAsync(ChunkViewModel cvm,
            Dictionary<string, string> pathReplacements,
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
            await Task.WhenAll(dirtyNodes.Select(node => node.RefreshAsync()));

            if (isDirty && cvm.Tab?.Parent is not null)
            {
                cvm.Tab.Parent.SetIsDirty(true);
            }
        }

        private async Task LoadAndAnalyzeModArchivesAsync()
        {
            if (!AppArchiveManager.ArchivesNeedRescan ||
                (!_archiveManager.GetModArchives().Any() && _archiveManager.IsInitialized))
            {
                return;
            }

            if (_settingsManager.CP77ExecutablePath is null)
            {
                throw new WolvenKitException(0x5001,
                    "Can't add dependencies without a game executable path in the settings");
            }

            if (!_archiveManager.IsInitialized)
            {
                _loggerService.Info("Loading mod archives... this can take a moment. Wolvenkit will be unresponsive.");
                _loggerService.Info("Please wait... process will continue after the scan is complete.");
                _archiveManager.Initialize(new FileInfo(_settingsManager.CP77ExecutablePath));

                _loggerService.Info("Scan complete.");
            }

            _loggerService.Info("Reading mod archive file table, this may take a moment...");
            await Task.Run(() =>
            {
                var ignoredArchives = _settingsManager.ArchiveNamesExcludeFromScan.Split(",")
                    .Select(m => m.Replace(".archive", ""))
                    .ToArray();
                _archiveManager.LoadModArchives(new FileInfo(_settingsManager.CP77ExecutablePath), true,
                    ignoredArchives);

                if (_settingsManager.ExtraModDirPath is string extraModDir && !string.IsNullOrEmpty(extraModDir))
                {
                    _archiveManager.LoadAdditionalModArchives(extraModDir, true, ignoredArchives);
                }

                _loggerService.Info("... Done!");
            });
        }

        private async void OnAddDependencies(object? _, EventArgs eventArgs)
        {
            try
            {
                if (_projectManager.ActiveProject is null || ViewModel?.RootChunk is not ChunkViewModel cvm)
                {
                    return;
                }

                _projectWatcher.Suspend();

                await AddDependenciesToFileAsync(cvm, eventArgs is AddDependenciesFullEventArgs);
            }
            catch (Exception err)
            {
                _loggerService.Error("Failed to add dependencies:");
                _loggerService.Error(err);
            }
            finally
            {
                // Project browser will throw an error if we do it immediately - so let's not
                await Task.Run(async () =>
                {
                    await Task.Delay(100);
                    _projectWatcher.Refresh();
                    _projectWatcher.Resume();
                });
            }

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

        /// <summary>
        /// Filter selected chunks by type. If none are selected, the root chunk will be returned.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private List<ChunkViewModel> GetSelectedChunks(Type type)
        {
            var selectedChunks = SelectedChunks.ToList();
            if (!selectedChunks.All(c => c.PropertyType.IsAssignableTo(type)))
            {
                selectedChunks.Clear();
            }

            if (selectedChunks.Count == 0 && RootChunk is not null)
            {
                selectedChunks.Add(RootChunk);
            }

            return selectedChunks;
        }

        private void ClearAppearancePropertyChild(string propertyName)
        {
            if (RootChunk?.ResolvedData is not appearanceAppearanceResource ||
                RootChunk.GetPropertyChild("appearances") is not ChunkViewModel appearances)
            {
                return;
            }

            var numDeletions = 0;
            foreach (var propertyChild in appearances.TVProperties
                         .Select(a => a.GetPropertyChild(propertyName))
                         .Where(cvm => cvm is not null)
                         .Select(cvm => cvm!)
                    )
            {
                propertyChild.CalculateProperties();
                if (propertyChild.TVProperties.Count == 0)
                {
                    continue;
                }

                propertyChild.ClearChildren();
                numDeletions += 1;
                propertyChild.RecalculateProperties();
            }

            if (numDeletions == 0)
            {
                _loggerService.Success($"No '{propertyName}' in your .app file!");
                return;
            }

            appearances.RecalculateProperties();

            _loggerService.Success($"Cleared '{propertyName}' in {numDeletions} appearances");
            _currentTab?.Parent.SetIsDirty(true);
        }

        /// <summary>
        /// Called from view: remove all partsOverrides from appearances
        /// </summary>
        private void OnClearPartsOverridesClick(object _, RoutedEventArgs e) =>
            ClearAppearancePropertyChild("partsOverrides");

        /// <summary>
        /// Called from view: remove all partsValues from appearances
        /// </summary>
        private void OnClearPartsValuesClick(object _, RoutedEventArgs e) =>
            ClearAppearancePropertyChild("partsValues");

        /// <summary>
        /// Called from view: remove all animationComponents that are not used from all appearances
        /// </summary>
        private void OnDeleteUnusedAnimationComponentsClick(object _, RoutedEventArgs e)
        {
            if (CurrentTab?.FilePath is not string filePath || _projectManager.ActiveProject is null)
            {
                return;
            }

            if (!AppFileHelper.DeleteUnusedAnimComponents(_cr2WTools, _projectManager.ActiveProject, [filePath]).Any())
            {
                // nothing was deleted
                return;
            }

            _currentTab?.Parent.Reload(false);
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
                        appearances.TVProperties.SelectMany(appearance =>
                            GetComponentsByName(appearance, componentName)));
                    break;
                case CArray<CHandle<appearanceAppearanceDefinition>>:
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

            var selectedChunks = GetSelectedChunks(typeof(appearanceAppearanceDefinition));

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
            try
            {
                if (_projectManager.ActiveProject is null || CurrentTab?.FilePath is not string currentFile ||
                    !File.Exists(currentFile))
                {
                    return;
                }

                var relativePath = currentFile.Replace(_projectManager.ActiveProject.ModDirectory, "");
                _loggerService.Info("Reading references from file...");
                var referencesInFile = await _projectManager.ActiveProject.GetAllReferencesAsync(
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

                var allModFiles = _projectManager.ActiveProject.ModFiles
                    .Where(f => fileExtensions.Contains(Path.GetExtension(f))).ToList();
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
            catch (Exception ex)
            {
                _loggerService.Error("Failed to find unused project files:");
                _loggerService.Error(ex);
            }
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

        private void SearchBar_OnKeyDown(object _, KeyEventArgs e)
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

        private void SearchBar_OnSubmit(object sender, RoutedEventArgs e) =>
            ViewModel?.OnSearchChanged(SearchBar?.Text ?? "");

        private void SearchBar_OnClear(object _, RoutedEventArgs e)
        {
            SearchBar?.Clear();
            SearchBar_OnSubmit(this, e);
        }

        private void SearchBar_OnClick(object _, MouseButtonEventArgs e)
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
            if (RootChunk?.Tab is null || RootChunk?.ResolvedData is not appearanceAppearanceResource ||
                !File.Exists(RootChunk.Tab.FilePath))
            {
                return;
            }

            if (RootChunk.Tab.Parent.IsDirty)
            {
                _loggerService.Error("Please save the file before changing animations!");
                return;
            }

            var dialog = new SelectFacialAnimationPathDialog(s_facialSetups);
            if (dialog.ShowDialog() != true)
            {
                return;
            }

            _documentTools.SetFacialAnimations(RootChunk.Tab.FilePath, dialog.ViewModel?.SelectedFacialAnim,
                dialog.ViewModel?.SelectedGraph, dialog.ViewModel?.SelectedAnimEntries ?? []);

            // refresh components
            foreach (var cvm in (RootChunk.GetPropertyChild("appearances")?.TVProperties ?? []).SelectMany(appearance =>
                         appearance.GetPropertyChild("components")?.TVProperties ?? [])
                     .SelectMany(cvm => cvm.TVProperties).Where(cvm => cvm.ResolvedData is IRedRef))
            {
                cvm.RecalculateProperties();
            }
        }

        private void OnFileValidationMenuClicked(object sender, RoutedEventArgs e)
        {
            if (!ModifierViewStateService.IsShiftBeingHeld)
            {
                return;
            }

            e.Handled = true;
            OnFileValidationClick(sender, e);
        }
    }
}
