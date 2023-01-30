using System.Collections.Generic;

namespace WolvenKit.ViewModels.Documents
{
    public class Rig : IBindable, INode
    {
        public Rig(string name) => Name = name;

        public string Name { get; set; }
        public List<RigBone> Bones { get; set; } = new();
        public List<Rig> Children { get; set; } = new();

        public SeparateMatrix Matrix { get; set; } = new();
        public string? BindName { get; set; }
        public string? SlotName { get; set; }

        public void AddChild(Rig child)
        {
            child.Parent = this;
            Children.Add(child);
        }

        public INode? Parent { get; set; }
        public List<LoadableModel> Models { get; set; } = new();
        public void AddModel(LoadableModel child)
        {
            child.Parent = this;
            Models.Add(child);
        }
    }
}
