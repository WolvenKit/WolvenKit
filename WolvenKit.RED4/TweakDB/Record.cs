using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.TweakDB;

public sealed class Record
{
    public string Type { get; set; }

    public Dictionary<string, IRedType> Members { get; set; } = new();

    public override string ToString() => $"[{Type ?? "NO_TYPE"}] {string.Join(',', Members.Keys)}";
}