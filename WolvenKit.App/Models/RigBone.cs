using System.Collections.Generic;

namespace WolvenKit.App.Models;

public class RigBone : INode
{
    public RigBone(string name) => Name = name;

    public string Name { get; set; }
    public List<RigBone> Children { get; set; } = new();
    public SeparateMatrix Matrix { get; set; } = new();

    public void AddChild(RigBone child)
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
