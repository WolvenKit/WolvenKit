using System.Collections.Generic;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Documents
{
    public class Appearance
    {
        public Appearance(string name) => Name = name;

        public Dictionary<uint, List<SubmeshComponent>> LODLUT { get; set; } = new();

        private uint _selectedLOD = 1;
        public uint SelectedLOD
        {
            get => _selectedLOD;
            set
            {
                _selectedLOD = value;
                foreach (var lod in LODLUT.Keys)
                {
                    foreach (var submesh in LODLUT[lod])
                    {
                        submesh.IsRendering = lod == _selectedLOD && submesh.EnabledWithMask;
                    }
                }
            }
        }
        public string? AppearanceName { get; set; }
        public string Name { get; set; }

        public List<LoadableModel> Models { get; set; } = new();
        public CName Resource { get; set; }
        public List<INode> Nodes { get; set; } = new();
        public SmartElement3DCollection ModelGroup { get; set; } = new();
        public List<LoadableModel> BindableModels { get; set; } = new();
        public Dictionary<string, Material> RawMaterials { get; set; } = new();
    }
}
