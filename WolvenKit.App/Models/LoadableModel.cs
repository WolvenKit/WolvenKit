using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Media.Media3D;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Models;

public class LoadableModel : IBindable, INode
{
    public LoadableModel(string name) => Name = name;


    public int AppearanceIndex { get; set; }
    public string? AppearanceName { get; set; }
    public CR2WFile? MeshFile { get; set; }
    public ResourcePath DepotPath { get; set; }
    public List<SubmeshComponent> Meshes { get; set; } = new();
    public string? FilePath { get; set; }
    public Model3D? OriginalModel { get; set; }
    public Model3D? Model { get; set; }
    public Transform3D? Transform { get; set; }
    public bool IsEnabled { get; set; }
    public string Name { get; set; }

    public List<Material> Materials { get; set; } = new();

    public SeparateMatrix Matrix { get; set; } = new();
    public string? BindName { get; set; }
    public string? SlotName { get; set; }

    public ulong ChunkMask { get; set; } = ulong.MaxValue;
    public List<bool> ChunkList { get; set; } = new(64);
    public ObservableCollection<int> AllChunks { get; set; } = new();
    public ObservableCollection<int> EnabledChunks { get; set; } = new();

    public INode? Parent { get; set; }
    public List<LoadableModel> Models { get; set; } = new();

    public CName ComponentName { get; set; } = CName.Empty;

    public void AddModel(LoadableModel child)
    {
        child.Parent = this;
        Models.Add(child);
    }
}
