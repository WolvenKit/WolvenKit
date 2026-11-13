using System.Collections.Generic;
using System.Windows.Media.Media3D;

namespace WolvenKit.App.Models;

public class SlotSet : IBindable
{
    public SlotSet(string name, string? bindname)
    {
        Name = name;
        BindName = bindname;
    }
    public string Name { get; set; }
    public Dictionary<string, string> Slots { get; set; } = new();

    /// <summary>Slot name → the slot's offset from its bone (relativePosition / relativeRotation).</summary>
    public Dictionary<string, Matrix3D> SlotTransforms { get; set; } = new();

    public SeparateMatrix Matrix { get; set; } = new();
    public string? BindName { get; set; }
    public string? SlotName { get; set; }
}
