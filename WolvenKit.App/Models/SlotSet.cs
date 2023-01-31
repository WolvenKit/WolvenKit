using System.Collections.Generic;

namespace WolvenKit.App.Models;

public class SlotSet : IBindable
{
    public SlotSet(string name, string bindname)
    {
        Name = name;
        BindName = bindname;
    }
    public string Name { get; set; }
    public Dictionary<string, string> Slots { get; set; } = new();

    public SeparateMatrix Matrix { get; set; } = new();
    public string? BindName { get; set; }
    public string? SlotName { get; set; }
}
