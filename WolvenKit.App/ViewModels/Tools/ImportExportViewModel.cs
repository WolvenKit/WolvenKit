using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using Ab3d.Assimp;
using Assimp;
using CP77.CR2W;
using DynamicData;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Modkit.RED4.Opus;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.ViewModels.Tools
{
    public class ImportExportViewModel : ToolViewModel
    {
        #region fields

        private const string s_selectedInGrid = "Selected in Grid";

        /// <summary>
        /// Identifies the <see ref="ContentId"/> of this tool window.
        /// </summary>
        public const string ToolContentId = "ImportExport_Tool";

        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "Import Export Tool";

        /// <summary>
        /// Private Readonly ModTools
        /// </summary>
        private readonly IModTools _modTools;

        private readonly ILoggerService _loggerService;
        private readonly INotificationService _notificationService;
        private readonly IProjectManager _projectManager;
        private readonly IWatcherService _watcherService;
        private readonly IGameControllerFactory _gameController;
        private readonly MeshTools _meshTools;
        private readonly ISettingsManager _settingsManager;
        private readonly IArchiveManager _archiveManager;

        /// <summary>
        /// Private NameOf Selected Item in Grid.
        /// </summary>
        private string _CurrentSelectionInGridName;

        /// <summary>
        /// Private Last Selected Item, Used for Selection Lock.
        /// </summary>
        private ImportExportItemViewModel lastselected;

        private readonly ReadOnlyObservableCollection<ConvertableItemViewModel> _convertableItems;

        private readonly ReadOnlyObservableCollection<ImportableItemViewModel> _importableItems;

        private readonly ReadOnlyObservableCollection<ExportableItemViewModel> _exportableItems;

        #endregion fields

        /// <summary>
        /// Import Export ViewModel Constructor
        /// </summary>
        /// <param name="projectManager"></param>
        /// <param name="loggerService"></param>
        /// <param name="messageService"></param>
        /// <param name="watcherService"></param>
        /// <param name="gameController"></param>
        /// <param name="modTools"></param>
        public ImportExportViewModel(
           IProjectManager projectManager,
           ILoggerService loggerService,
           IWatcherService watcherService,
           INotificationService notificationService,
           IGameControllerFactory gameController,
           ISettingsManager settingsManager,
           IModTools modTools,
           MeshTools meshTools,
           IArchiveManager archiveManager
           ) : base(ToolTitle)
        {
            _projectManager = projectManager;
            _loggerService = loggerService;
            _watcherService = watcherService;
            _modTools = modTools;
            _gameController = gameController;
            _notificationService = notificationService;
            _settingsManager = settingsManager;
            _meshTools = meshTools;
            _archiveManager = archiveManager;

            SetupToolDefaults();

            ProcessAllCommand = ReactiveCommand.CreateFromTask(ExecuteProcessAll);
            ProcessSelectedCommand = ReactiveCommand.CreateFromTask(ExecuteProcessSelected);
            CopyArgumentsTemplateToCommand = new DelegateCommand<string>(ExecuteCopyArgumentsTemplateTo, CanCopyArgumentsTemplateTo);
            SetCollectionCommand = new DelegateCommand<string>(ExecuteSetCollection, CanSetCollection);
            ConfirmCollectionCommand = new DelegateCommand<string>(ExecuteConfirmCollection, CanConfirmCollection);

            AddItemsCommand = new DelegateCommand<ObservableCollection<object>>(ExecuteAddItems, CanAddItems);
            RemoveItemsCommand = new DelegateCommand<ObservableCollection<object>>(ExecuteRemoveItems, CanRemoveItems);

            _watcherService.Files
                .Connect()
                .Filter(_ => _.IsImportable)
                .Filter(_ => _.FullName.Contains(_projectManager.ActiveProject.RawDirectory))
                .Transform(_ => new ImportableItemViewModel(_))
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out _importableItems)
                .Subscribe();

            _watcherService.Files
                .Connect()
                .Filter(_ => _.IsExportable)
                .Filter(_ => _.FullName.Contains(_projectManager.ActiveProject.ModDirectory))
                .Transform(_ => new ExportableItemViewModel(_))
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out _exportableItems)
                .Subscribe();

            _watcherService.Files
                .Connect()
                .Filter(_ => _.IsConvertable)
                .Filter(_ => _.FullName.Contains(_projectManager.ActiveProject.RawDirectory))
                .Transform(_ => new ConvertableItemViewModel(_))
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out _convertableItems)
                .Subscribe();

            ////=> IsImportsSelected ? SelectedImport : IsExportsSelected ? SelectedExport : SelectedConvert;
            //this.WhenAnyValue(x => x.IsImportsSelected, y => y.IsExportsSelected, z => z.IsConvertsSelected)
            //    .Subscribe(b =>
            //{
            //    SelectedObject = IsImportsSelected ? SelectedImport : IsExportsSelected ? SelectedExport : SelectedConvert;
            //});


            this.WhenAnyValue(x => x.SelectedExport, y => y.SelectedImport, z => z.SelectedConvert)
                .Subscribe(b =>
                {
                    var x = b.Item1;
                    var y = b.Item2;
                    var z = b.Item3;

                    SelectedObject = IsImportsSelected ? SelectedImport : IsExportsSelected ? SelectedExport : SelectedConvert;
                });
        }

        #region properties

        [Reactive] public ObservableCollection<CollectionItemViewModel> CollectionAvailableItems { get; set; } = new();
        [Reactive] public ObservableCollection<CollectionItemViewModel> CollectionSelectedItems { get; set; } = new();

        public ReadOnlyObservableCollection<ConvertableItemViewModel> ConvertableItems => _convertableItems;

        /// <summary>
        /// Public Importable Items
        /// </summary>
        public ReadOnlyObservableCollection<ImportableItemViewModel> ImportableItems => _importableItems;

        /// <summary>
        /// Public Exportable items.
        /// </summary>
        public ReadOnlyObservableCollection<ExportableItemViewModel> ExportableItems => _exportableItems;

        [Reactive] public ConvertableItemViewModel SelectedConvert { get; set; }

        /// <summary>
        /// Selected Export Item
        /// </summary>
        [Reactive] public ExportableItemViewModel SelectedExport { get; set; }

        /// <summary>
        /// Selected Import Item
        /// </summary>
        [Reactive] public ImportableItemViewModel SelectedImport { get; set; }

        /// <summary>
        /// Selected object , returns a Importable/Exportable ItemVM based on "IsImportsSelected"
        /// </summary>
        [Reactive] public ImportExportItemViewModel SelectedObject { get; set; } //=> IsImportsSelected ? SelectedImport : IsExportsSelected ? SelectedExport : SelectedConvert;

        /// <summary>
        /// Lock Selection of items in grid.
        /// </summary>
        [Reactive] public bool SelectionLocked { get; set; } = false;

        /// <summary>
        /// Returns the name of current selected object in Import/Export Grid.
        /// </summary>
        public string CurrentSelectedInGridName
        {
            get
            {
                if (SelectedObject != null)
                {
                    if (!SelectionLocked)
                    {
                        lastselected = SelectedObject;
                        return SelectedObject.Name;
                    }
                    else
                    {
                        if (lastselected == null)
                        { return ""; }
                        else
                        {
                            return lastselected.Name;
                        }
                    }
                }
                else
                { return ""; }
            }
            set => _CurrentSelectionInGridName = value;
        }

        /// <summary>
        /// Is Import Selected, if false Export is default.
        /// </summary>
        [Reactive] public bool IsImportsSelected { get; set; }

        [Reactive] public bool IsExportsSelected { get; set; } = true;
        [Reactive] public bool IsConvertsSelected { get; set; }

        #endregion properties

        public ICommand AddItemsCommand { get; private set; }
        public ICommand RemoveItemsCommand { get; private set; }



        private bool CanAddItems(ObservableCollection<object> items) => true;

        private void ExecuteAddItems(ObservableCollection<object> items)
        {
            foreach (var item in items)
            {
                var newitem = item as CollectionItemViewModel;
                if (!CollectionSelectedItems.Contains(newitem))
                {
                    CollectionSelectedItems.Add(newitem);
                }
            }
        }

        private bool CanRemoveItems(ObservableCollection<object> items) => true;

        private void ExecuteRemoveItems(ObservableCollection<object> items)
        {
            var x = new List<CollectionItemViewModel>();
            foreach (var item in items)
            {
                var newitem = item as CollectionItemViewModel;
                x.Add(newitem);
            }
            CollectionSelectedItems.RemoveMany(x);
        }

        public ICommand ConfirmCollectionCommand { get; private set; }

        private bool CanConfirmCollection(string v) => true;

        private void ExecuteConfirmCollection(string v)
        {
            switch (SelectedExport)
            {
                case { Properties: MeshExportArgs meshExportArgs }:
                    switch (v)
                    {
                        case nameof(MeshExportArgs.MultiMeshMeshes):
                            meshExportArgs.MultiMeshMeshes =
                                CollectionSelectedItems.Select(_ => _.Model).Cast<FileEntry>().ToList();
                            _notificationService.Success($"Selected Meshes were added to MultiMesh arguments.");
                            meshExportArgs.meshExportType = MeshExportType.Multimesh;
                            break;

                        case nameof(MeshExportArgs.MultiMeshRigs):
                            meshExportArgs.MultiMeshRigs =
                                CollectionSelectedItems.Select(_ => _.Model).Cast<FileEntry>().ToList();
                            _notificationService.Success($"Selected Rigs were added to MultiMesh arguments.");
                            meshExportArgs.meshExportType = MeshExportType.Multimesh;
                            break;

                        case nameof(MeshExportArgs.Rig):
                            meshExportArgs.Rig = new List<FileEntry>() { CollectionSelectedItems.Select(_ => _.Model).Cast<FileEntry>().FirstOrDefault() };
                            _notificationService.Success($"Selected Rigs were added to WithRig arguments.");
                            meshExportArgs.meshExportType = MeshExportType.WithRig;
                            break;
                    }
                    break;

                case { Properties: OpusExportArgs opusExportArgs }:
                    switch (v)
                    {
                        case nameof(OpusExportArgs.SelectedForExport):
                            opusExportArgs.SelectedForExport =
                                new List<uint>(CollectionSelectedItems.Select(_ => _.Model).Cast<uint>());
                            _notificationService.Success($"Selected opus items were added.");
                            break;
                    }
                    break;

                default:
                    Trace.WriteLine("failed to confirm");
                    break;
            }
        }

        public ICommand SetCollectionCommand { get; private set; }

        private bool CanSetCollection(string selectedType) => true;

        private void ExecuteSetCollection(string argType)
        {
            switch (SelectedExport)
            {
                case { Properties: MeshExportArgs meshExportArgs }:
                    InitCollectionEditorForMesh(argType, meshExportArgs);

                    break;

                case { Properties: OpusExportArgs opusExportArgs }:
                    InitCollectionEditorForOpus(argType, opusExportArgs);
                    Trace.WriteLine(opusExportArgs.ModFolderPath + opusExportArgs.RawFolderPath);
                    break;
            }
        }

        private void InitCollectionEditorForMesh(string argType, MeshExportArgs meshExportArgs)
        {
            if (_gameController.GetController() is not RED4Controller cp77Controller)
            {
                return;
            }

            var fetchExtension = ERedExtension.rig;
            List<FileEntry> selectedEntries = new();
            switch (argType)
            {
                case nameof(MeshExportArgs.MultiMeshMeshes):
                    fetchExtension = ERedExtension.mesh;
                    selectedEntries = meshExportArgs.MultiMeshMeshes;
                    break;

                case nameof(MeshExportArgs.MultiMeshRigs):
                    selectedEntries = meshExportArgs.MultiMeshRigs;
                    break;

                case nameof(MeshExportArgs.Rig):
                    selectedEntries = meshExportArgs.Rig;
                    break;

                default:
                    break;
            }

            // set selected types
            if (CollectionSelectedItems != null)
            {
                CollectionSelectedItems.Clear();
                if (selectedEntries != null)
                {
                    CollectionSelectedItems.AddRange(selectedEntries.Select(_ => new CollectionItemViewModel(_)));
                }
            }

            // set available types
            if (CollectionAvailableItems.Any() && CollectionAvailableItems.First().Model is FileEntry entry &&
                entry.Extension.TrimStart('.').Equals(fetchExtension.ToString()))
            {
                return;
            }

            CollectionAvailableItems.Clear();
            if (_archiveManager != null)
            {
                CollectionAvailableItems.AddRange(_archiveManager.GetGroupedFiles()[$".{fetchExtension}"].Select(_ => new CollectionItemViewModel(_)));
            }
        }

        private void InitCollectionEditorForOpus(string argType, OpusExportArgs opusExportArgs)
        {
            var proj = _projectManager.ActiveProject;

            if (_gameController.GetController() is RED4Controller cp77Controller)
            {
                opusExportArgs.SoundbanksArchive = _archiveManager.Archives.Values
                    .Cast<Archive>()
                    .FirstOrDefault(_ => _.Name.Equals("audio_2_soundbanks.archive"));
            }

            OpusTools opusTools = new(
                opusExportArgs.SoundbanksArchive,
                proj.ModDirectory,
                proj.RawDirectory,
                opusExportArgs.UseMod);

            List<uint> selectedEntries = new();
            switch (argType)
            {
                case nameof(OpusExportArgs.SelectedForExport):
                    selectedEntries = opusExportArgs.SelectedForExport;
                    break;

                default:
                    break;
            }

            // set selected types
            if (CollectionSelectedItems != null)
            {
                CollectionSelectedItems.Clear();
                if (selectedEntries != null)
                {
                    CollectionSelectedItems.AddRange(selectedEntries.Select(_ => new CollectionItemViewModel(_)));
                }
            }

            // set available types
            if (CollectionAvailableItems.Any() && CollectionAvailableItems.First().Model is uint entry)
            {
                return;
            }

            CollectionAvailableItems.Clear();
            CollectionAvailableItems.AddRange(opusTools.Info.OpusHashes.Select(_ => new CollectionItemViewModel(_)));
        }

        public ICommand CopyArgumentsTemplateToCommand { get; private set; }

        private bool CanCopyArgumentsTemplateTo(string param) => true;

        private void ExecuteCopyArgumentsTemplateTo(string param)
        {
            var current = SelectedObject.Properties;

            if (IsImportsSelected)
            {
                if (current is not ImportArgs importArgs)
                {
                    return;
                }

                var results = param switch
                {
                    s_selectedInGrid => ImportableItems.Where(_ => _.IsChecked),
                    _ => ImportableItems
                };

                foreach (var item in results.Where(item => item.Properties.GetType() == current.GetType()))
                {
                    item.Properties = importArgs;
                }
            }
            if (IsExportsSelected)
            {
                if (current is not ExportArgs exportArgs)
                {
                    return;
                }

                var results = param switch
                {
                    s_selectedInGrid => ExportableItems.Where(_ => _.IsChecked),
                    _ => ExportableItems
                };

                foreach (var item in results.Where(item => item.Properties.GetType() == current.GetType()))
                {
                    item.Properties = exportArgs;
                }
            }
            if (IsConvertsSelected)
            {

                if (current is not ConvertArgs convertArgs)
                {
                    return;
                }

                var results = param switch
                {
                    s_selectedInGrid => ConvertableItems.Where(_ => _.IsChecked),
                    _ => ConvertableItems
                };

                foreach (var item in results.Where(item => item.Properties.GetType() == current.GetType()))
                {
                    item.Properties = convertArgs;
                }
            }

            _notificationService.Success($"Template has been copied to the selected items.");
        }

        public bool IsProcessing { get; set; } = false;

        /// <summary>
        /// Process all in Import / Export Grid Command.
        /// </summary>
        public ReactiveCommand<Unit, Unit> ProcessAllCommand { get; private set; }

        /// <summary>
        /// Execute Process all in Import / Export Grid Command.
        /// </summary>
        private async Task ExecuteProcessAll()
        {
            IsProcessing = true;

            if (IsImportsSelected)
            {
                var wavs = new List<string>();
                // split up wavs
                var toBeImported = ImportableItems.ToList();
                foreach (var item in toBeImported)
                {
                    if (item.Extension.Equals(ERawFileFormat.wav.ToString()))
                    {
                        wavs.Add(item.FullName);
                    }
                    else
                    {
                        await ImportSingle(item);
                    }
                }
                await ImportWavs(wavs);
            }
            if (IsExportsSelected)
            {
                var toBeExported = ExportableItems.ToList();
                foreach (var item in toBeExported)
                {
                    await ExportSingle(item);
                }
            }
            if (IsConvertsSelected)
            {
                var toBeConverted = ConvertableItems.ToList();
                foreach (var itemViewModel in toBeConverted)
                {
                    await Task.Run(() => ConvertSingle(itemViewModel));
                }
                
            }
            IsProcessing = false;
            _notificationService.Success($"Files have been processed and are available in the Project Explorer");
        }

        private async Task ImportWavs(List<string> wavs)
        {
            var proj = _projectManager.ActiveProject;
            if (_gameController.GetController() is RED4Controller cp77Controller)
            {
                var soundbanksArchive = _archiveManager.Archives.Values
                    .Cast<Archive>()
                    .FirstOrDefault(_ => _.Name.Equals("audio_2_soundbanks.archive"));

                OpusTools opusTools = new(
                    soundbanksArchive,
                    proj.ModDirectory,
                    proj.RawDirectory,
                    true);

                await Task.Run(() => opusTools.ImportWavs(wavs.ToArray()));
            }
        }

        /// <summary>
        /// Import Single item
        /// </summary>
        /// <param name="item"></param>
        private async Task ImportSingle(ImportableItemViewModel item)
        {
            if (_gameController.GetController() is not RED4Controller cp77Controller)
            {
                return;
            }

            var proj = _projectManager.ActiveProject;
            var fi = new FileInfo(item.FullName);
            if (fi.Exists)
            {
                if (item.Properties is GltfImportArgs gltfImportArgs)
                {
                    gltfImportArgs.Archives = _archiveManager.Archives.Values.Cast<Archive>().ToList();
                }
                var settings = new GlobalImportArgs().Register(item.Properties as ImportArgs);
                var rawDir = new DirectoryInfo(proj.RawDirectory);
                var redrelative = new RedRelativePath(rawDir, fi.GetRelativePath(rawDir));
                await Task.Run(() => _modTools.Import(redrelative, settings, new DirectoryInfo(proj.ModDirectory)));
            }
        }

        /// <summary>
        /// Export Single Item
        /// </summary>
        /// <param name="item"></param>
        private async Task ExportSingle(ExportableItemViewModel item)
        {
            var proj = _projectManager.ActiveProject;
            var fi = new FileInfo(item.FullName);
            if (fi.Exists)
            {
                if (item.Properties is MeshExportArgs meshExportArgs)
                {
                    if (_gameController.GetController() is RED4Controller cp77Controller)
                    {
                        meshExportArgs.Archives = _archiveManager.Archives.Values.Cast<Archive>().ToList();
                    }
                    meshExportArgs.MaterialRepo = _settingsManager.MaterialRepositoryPath;
                }
                if(item.Properties is MorphTargetExportArgs morphTargetExportArgs)
                {
                    if (_gameController.GetController() is RED4Controller cp77Controller)
                    {
                        morphTargetExportArgs.Archives = _archiveManager.Archives.Values.Cast<Archive>().ToList();
                    }
                    morphTargetExportArgs.ModFolderPath = _projectManager.ActiveProject.ModDirectory;
                }
                if (item.Properties is OpusExportArgs opusExportArgs)
                {
                    if (_gameController.GetController() is RED4Controller cp77Controller)
                    {
                        opusExportArgs.SoundbanksArchive = _archiveManager.Archives.Values
                            .Cast<Archive>()
                            .FirstOrDefault(_ => _.Name.Equals("audio_2_soundbanks.archive"));
                    }

                    opusExportArgs.RawFolderPath = proj.RawDirectory;
                    opusExportArgs.ModFolderPath = proj.ModDirectory;
                }
                if (item.Properties is EntityExportArgs entExportArgs)
                {
                    if (_gameController.GetController() is RED4Controller cp77Controller)
                    {
                        entExportArgs.Archives = _archiveManager.Archives.Values.Cast<Archive>().ToList();
                    }
                }
                if (item.Properties is AnimationExportArgs animationExportArgs)
                {
                    if (_gameController.GetController() is RED4Controller cp77Controller)
                    {
                        animationExportArgs.Archives = _archiveManager.Archives.Values.Cast<Archive>().ToList();
                    }
                }
                var settings = new GlobalExportArgs().Register(item.Properties as ExportArgs);
                await Task.Run(() => _modTools.Export(fi, settings,
                    new DirectoryInfo(proj.ModDirectory),
                    new DirectoryInfo(proj.RawDirectory)));
            }
        }

        /// <summary>
        /// Process selected in Import / Export Grid Command
        /// </summary>
        public ICommand ProcessSelectedCommand { get; private set; }


        /// <summary>
        /// Execute Process selected in Import / Export Grid Command
        /// </summary>
        private async Task ExecuteProcessSelected()
        {
            IsProcessing = true;
            if (IsImportsSelected)
            {
                var wavs = new List<string>();
                // split up wavs
                var toBeConverted = ImportableItems.Where(_ => _.IsChecked).ToList();
                foreach (var item in toBeConverted)
                {
                    if (item.Extension.Equals(ERawFileFormat.wav.ToString()))
                    {
                        wavs.Add(item.FullName);
                    }
                    else
                    {
                        await ImportSingle(item);
                    }
                }
                await ImportWavs(wavs);
            }
            if (IsExportsSelected)
            {
                var toBeConverted = ExportableItems.Where(_ => _.IsChecked).ToList();
                foreach (var item in toBeConverted)
                {
                    await ExportSingle(item);
                }
            }
            if (IsConvertsSelected)
            {

                var toBeConverted = ConvertableItems.Where(_ => _.IsChecked).ToList();
                foreach (var itemViewModel in toBeConverted)
                {
                    await Task.Run(() => ConvertSingle(itemViewModel));
                }
            }
            IsProcessing = false;
            _notificationService.Success($"Files have been processed and are available in the Project Explorer");
        }
        private Dictionary<string, object> _namedObjects;

        private async Task ConvertSingle(ConvertableItemViewModel item)
        {
            IsProcessing = true;




            if (item == null)
            {
                return;
            }
            var fi = new FileInfo(item.FullName);
            if (!fi.Exists)
            {
                return;
            }

            switch (item.Properties)
            {
                case CommonConvertArgs:
                    break;
                default:
                    return;
            }








            // Create an instance of AssimpWpfImporter
            var assimpWpfImporter = new AssimpWpfImporter();

            try
            {
                assimpWpfImporter.DefaultMaterial = new DiffuseMaterial(Brushes.Silver);
                assimpWpfImporter.AssimpPostProcessSteps = PostProcessSteps.Triangulate;

                // When ReadPolygonIndices is true, assimpWpfImporter will read PolygonIndices collection that can be used to show polygons instead of triangles.
                assimpWpfImporter.ReadPolygonIndices = false;

                var qx = item.GetBaseFile();
                var proj = _projectManager.ActiveProject;
                var relativename = qx.GetRelativeName(proj);
                var newname = Path.ChangeExtension(relativename, ".mesh");
                ulong hash = FNV1A64HashAlgorithm.HashString(newname);
                var cp77Controller = _gameController.GetController() as RED4Controller;

                string outfile;
                IGameFile file;
                if (_archiveManager.Items.Lookup(hash).HasValue)
                {
                    file = _archiveManager.Items.Lookup(hash).Value;
                    if (file != null)
                    {
                        outfile = _meshTools.ExportMeshSimple(file, qx.FullName,
                            Path.Combine(ISettingsManager.GetManagerCacheDir(), "Temp_OBJ"));
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    outfile = qx.FullName;
                }






                Model3D readModel3D;

                try
                {
                    readModel3D =
                        assimpWpfImporter.ReadModel3D(outfile,
                            texturesPath: null); // we can also define a textures path if the textures are located in some other directory (this is parameter can be skipped, but is defined here so you will know that you can use it)
                    _namedObjects = assimpWpfImporter.NamedObjects;
                }
                catch (Exception ex)
                {
                    readModel3D = null;
                    MessageBox.Show("Error importing file:\r\n" + ex.Message);
                }

                if (readModel3D != null)
                {
                    // First create an instance of AssimpWpfExporter
                    var assimpWpfExporter = new AssimpWpfExporter();
                    assimpWpfExporter.NamedObjects = _namedObjects;

                    // We can export Model3D, Visual3D or entire Viewport3D:
                    //assimpWpfExporter.AddModel(model3D);
                    //assimpWpfExporter.AddVisual3D(ContentModelVisual3D);
                    //assimpWpfExporter.AddViewport3D(MainViewport);

                    // Here we export Viewport3D:
                    assimpWpfExporter.AddModel(readModel3D);

                    bool isExported;

                    try
                    {

                        var qaz = item.Properties as CommonConvertArgs;
                        var test = Path.ChangeExtension(item.FullName, "." + qaz.EConvertableOutput.ToString());



                        // Item Full name has to be the end output aka raw folder ty :D
                        isExported = assimpWpfExporter.Export(test, qaz.EConvertableOutput.ToString());

                        if (!isExported)
                            MessageBox.Show("Not exported");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error exporting:\r\n" + ex.Message);
                        isExported = false;
                    }
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
            catch
            {

            }
            finally
            {
                // Dispose unmanaged resources
                assimpWpfImporter.Dispose();

            }

            await Task.CompletedTask;
        }

        /// <summary>
        /// Setup Tool defaults for tool window.
        /// </summary>
        private void SetupToolDefaults() => ContentId = ToolContentId;
    }

    public class CollectionItemViewModel : ObservableObject
    {
        public string Info =>
            Model switch
            {
                FileEntry fe => fe.Name,
                _ => ""
            };

        public string Name =>
            Model switch
            {
                FileEntry fe => fe.ShortName,
                _ => Model.ToString()
            };

        public CollectionItemViewModel(object model)
        {
            Model = model;
        }

        public object Model { get; set; }
    }
}
