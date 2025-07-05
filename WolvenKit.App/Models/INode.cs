using System.Collections.Generic;

namespace WolvenKit.App.Models;

public interface INode
{
    public string Name { get; set; }
    public SeparateMatrix Matrix { get; set; }
    public INode? Parent { get; set; }
    public List<LoadableModel> Models { get; set; }

    public void AddModel(LoadableModel child);
}
