using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Common.FNV1A;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

public enum ERedDocumentItemType
{
    MainFile,
    W2rcBuffer,
    Buffer,
    Editor
}

public partial class RedDocumentViewModel : DocumentViewModel
{
    protected readonly HashSet<string> _embedHashSet;

    private readonly string _path;

    public RedDocumentViewModel(CR2WFile file, string path) : base(path)
    {
        _embedHashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "yaml",
            "yml",
            "xl"
        };

        _path = path;


        _extension = Path.GetExtension(path) != "" ? Path.GetExtension(path)[1..] : "";

        Cr2wFile = file;
        _isInitialized = true;
        PopulateItems();
    }

    #region properties

    public CR2WFile Cr2wFile { get; set; }

    [ObservableProperty] private ObservableCollection<RedDocumentTabViewModel> _tabItemViewModels = new();

    [ObservableProperty] private int _selectedIndex;

    [ObservableProperty] private RedDocumentTabViewModel? _selectedTabItemViewModel;

    partial void OnSelectedTabItemViewModelChanged(RedDocumentTabViewModel? value)
    {
        value?.OnSelected();
    }

    // assume files that don't exist are relative paths
    public string RelativePath
    {
        get
        {
            return File.Exists(_path)
                ? Path.GetRelativePath(_projectManager.ActiveProject.NotNull().ModDirectory, _path)
                : _path;
        }
    }

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(NewEmbeddedFileCommand))]
    private string _extension;

    #endregion

    #region commands

    private bool CanExecuteNewEmbeddedFile() => !_embedHashSet.Contains(Extension);
    [RelayCommand(CanExecute = nameof(CanExecuteNewEmbeddedFile))]
    private async Task NewEmbeddedFile()
    {
        var existing = new ObservableCollection<string>(AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => p.IsAssignableTo(typeof(CResource)) && p.IsClass)
            .Select(x => x.Name));

        await _appViewModel.SetActiveDialog(new CreateClassDialogViewModel(existing, true)
        {
            DialogHandler = HandleEmbeddedFile
        });
    }

    #endregion

    #region methods

    public ILoggerService GetLoggerService() => _loggerService;

    public override Task Save(object? parameter)
    {
        var tmpPath = Path.ChangeExtension(FilePath, ".tmp");

        using var fs = new FileStream(tmpPath, FileMode.Create, FileAccess.ReadWrite);
        var file = GetMainFile();

        try
        {
            // if we're in a text view, use a normal StreamWriter, else use the CR2W one
            if (file is RDTTextViewModel textViewModel)
            {
                using var tw = new StreamWriter(fs);
                var text = textViewModel.Text;
                tw.Write(text);
            }
            else if (file is not null && Cr2wFile != null)
            {
                using var writer = new CR2WWriter(fs);
                writer.WriteFile(Cr2wFile);
            }
        }
        catch (Exception e)
        {
            _loggerService.Error($"Error while saving {FilePath}");
            _loggerService.Error(e);

            fs.Dispose();
            File.Delete(tmpPath);

            return Task.CompletedTask;
        }

        if (File.Exists(FilePath))
        {
            File.Delete(FilePath);
        }
        File.Move(tmpPath, FilePath);

        SetIsDirty(false);
        _loggerService.Success($"Saved file {FilePath}");

        return Task.CompletedTask;
    }

    public override void SaveAs(object parameter) => throw new NotImplementedException();

    public RedDocumentTabViewModel? GetMainFile()
    {
        if (SelectedTabItemViewModel is RDTTextViewModel textVM)
        {
            return textVM;
        }

        var r = TabItemViewModels
        .OfType<RDTDataViewModel>()
        .Where(x => x.DocumentItemType == ERedDocumentItemType.MainFile)
        .FirstOrDefault();
        return r;
    }

    protected void AddTabForRedType(RedBaseClass cls)
    {
        if (cls is CBitmapTexture xbm)
        {
            TabItemViewModels.Add(new RDTTextureViewModel(xbm, this));
        }
        if (cls is CCubeTexture cube)
        {
            TabItemViewModels.Add(new RDTTextureViewModel(cube, this));
        }
        if (cls is CTextureArray texa)
        {
            TabItemViewModels.Add(new RDTTextureViewModel(texa, this));
        }
        if (cls is CMesh mesh && mesh.RenderResourceBlob != null && mesh.RenderResourceBlob.GetValue() is rendRenderTextureBlobPC)
        {
            TabItemViewModels.Add(new RDTTextureViewModel(mesh, this));
        }
        if (cls is CReflectionProbeDataResource probe && probe.TextureData.RenderResourceBlobPC.GetValue() is rendRenderTextureBlobPC)
        {
            TabItemViewModels.Add(new RDTTextureViewModel(probe, this));
        }
        if (cls is Multilayer_Mask mlmask)
        {
            // maybe it makes more sense to put these all into one tab?
            ModTools.ConvertMultilayerMaskToDdsStreams(mlmask, out var streams);
            for (var i = 0; i < streams.Count; i++)
            {
                var tab = new RDTTextureViewModel(streams[i], this)
                {
                    Header = $"MultiLayer {i}"
                };
                TabItemViewModels.Add(tab);
            }
        }
        if (cls is inkTextureAtlas atlas)
        {
            var slot = atlas.Slots[0];
            if (slot != null)
            {
                var file = GetFileFromDepotPath(slot.Texture.DepotPath);
                if (file != null)
                {
                    TabItemViewModels.Add(new RDTInkTextureAtlasViewModel(atlas, (CBitmapTexture)file.RootChunk, this));
                }
            }
        }
        if (cls is inkWidgetLibraryResource library)
        {
            TabItemViewModels.Add(new RDTWidgetViewModel(library, this));
        }
        if (cls is CMesh mesh2)
        {
            TabItemViewModels.Add(new RDTMeshViewModel(mesh2, this));
        }
        if (cls is entEntityTemplate ent)
        {
            TabItemViewModels.Add(new RDTMeshViewModel(ent, this));
        }
        if (cls is worldStreamingSector wss)
        {
            TabItemViewModels.Add(new RDTMeshViewModel(wss, this));
        }
        if (cls is worldStreamingBlock wsb)
        {
            TabItemViewModels.Add(new RDTMeshViewModel(wsb, this));
        }
        if (cls is graphGraphResource ggr)
        {
            if (_globals.Value.ENABLE_NODE_EDITOR)
            {
                TabItemViewModels.Add(new RDTGraphViewModel(ggr, this));
            }
        }
        if (cls is scnSceneResource ssr)
        {
            if (_globals.Value.ENABLE_NODE_EDITOR)
            {
                TabItemViewModels.Add(new RDTGraphViewModel(ssr, this));
            }
        }
    }

    public void PopulateItems()
    {
        if (Cr2wFile is null)
        {
            return;
        }

        var root = new RDTDataViewModel(Cr2wFile.RootChunk, this)
        {
            FilePath = "(root)"
        };
        TabItemViewModels.Add(root);
        AddTabForRedType(Cr2wFile.RootChunk);

        foreach (var file in Cr2wFile.EmbeddedFiles)
        {
            if (file.Content != null)
            {
                var vm = new RDTDataViewModel(file.Content, this)
                {
                    FilePath = file.FileName,
                    IsEmbeddedFile = true
                };
                TabItemViewModels.Add(vm);
                AddTabForRedType(file.Content);
            }
        }

        SelectedIndex = 0;

        SelectedTabItemViewModel = TabItemViewModels.FirstOrDefault();
    }

    public Dictionary<ResourcePath, CR2WFile?> Files { get; set; } = new();

    public CR2WFile? GetFileFromDepotPathOrCache(ResourcePath depotPath)
    {
        lock (Files)
        {
            if (!Files.ContainsKey(depotPath))
            {
                var file = GetFileFromDepotPath(depotPath);
                Files[depotPath] = file;
            }

            if (Files[depotPath] != null)
            {
                foreach (var res in Files[depotPath]!.EmbeddedFiles)
                {
                    if (!Files.ContainsKey(res.FileName))
                    {
                        Files.Add(res.FileName, new CR2WFile()
                        {
                            RootChunk = res.Content
                        });
                    }
                }
            }
        }
        return Files[depotPath];
    }

    public void HandleEmbeddedFile(DialogViewModel? sender)
    {
        if (Cr2wFile is null)
        {
            return;
        }

        _appViewModel.CloseDialogCommand.Execute(null);
        if (sender is not null and CreateClassDialogViewModel dvm)
        {
            var instance = RedTypeManager.Create(dvm.SelectedClass.NotNull());

            var file = new CR2WEmbedded
            {
                Content = instance,
                FileName = "unnamed." + FileTypeHelper.GetFileExtensionsFromRootName(instance.GetType().Name)[0]
            };

            Cr2wFile.EmbeddedFiles.Add(file);
            IsDirty = true;

            var vm = new RDTDataViewModel(file.Content, this)
            {
                FilePath = file.FileName,
                IsEmbeddedFile = true
            };
            TabItemViewModels.Add(vm);
            AddTabForRedType(file.Content);
        }
    }

    public CR2WFile? GetFileFromDepotPath(ResourcePath depotPath, bool original = false)
    {
        if (depotPath == ResourcePath.Empty)
        {
            return null;
        }

        try
        {
            CR2WFile? cr2wFile = null;

            if (!original)
            {
                if (_projectManager.ActiveProject != null)
                {
                    string? path = null;
                    if (!string.IsNullOrEmpty(depotPath))
                    {
                        path = Path.Combine(_projectManager.ActiveProject.ModDirectory, depotPath.GetString().NotNull());
                    }
                    else
                    {
                        var fm = _watcherService.GetFileModelFromHash(depotPath.GetRedHash());
                        if (fm != null)
                        {
                            path = fm.FullName;
                        }
                    }

                    if (path != null && File.Exists(path))
                    {
                        using var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                        using var reader = new BinaryReader(stream);
                        cr2wFile = _parserService.ReadRed4File(reader);
                    }
                }
            }

            if (cr2wFile == null)
            {
                var file = _archiveManager.Lookup(depotPath.GetRedHash());
                if (file.HasValue && file.Value is FileEntry fe)
                {
                    using var stream = new MemoryStream();
                    fe.Extract(stream);

                    cr2wFile = _parserService.ReadRed4File(stream);
                }
            }

            if (cr2wFile != null)
            {
                if (!string.IsNullOrEmpty(depotPath))
                {
                    cr2wFile.MetaData.FileName = depotPath;
                }

                lock (Files)
                {
                    foreach (var res in cr2wFile.EmbeddedFiles)
                    {
                        if (!Files.ContainsKey(res.FileName))
                        {
                            Files.Add(res.FileName, new CR2WFile()
                            {
                                RootChunk = res.Content
                            });
                        }
                    }
                }

                return cr2wFile;
            }
        }
        catch (Exception)
        {
            // ignore
        }

        return null;
    }

    public RedDocumentTabViewModel? OpenRefAsTab(string path)
    {
        var tab = OpenRefAsTab(FNV1A64HashAlgorithm.HashString(path));
        if (tab is null)
        {
            return null;
        }

        tab.Header = Path.GetFileName(path);
        tab.FilePath = path;
        return tab;
    }

    public RedDocumentTabViewModel? OpenRefAsTab(ulong hash)
    {
        var file = GetFileFromDepotPath(hash);
        if (file == null)
        {
            return null;
        }

        var tab = new RDTDataViewModel(hash.ToString(), file.RootChunk, this);
        TabItemViewModels.Add(tab);
        return tab;
    }


    #endregion

}

