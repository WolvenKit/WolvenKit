using System.Text.Json.Serialization;

namespace WolvenKit.RED4.Types;

public class DataCollection
{
    public string FileName { get; set; }
    public ulong Hash { get; set; }

    [JsonIgnore] public HashSet<string> RawStringList { get; } = new();
    [JsonIgnore] public HashSet<string> RawImportList { get; } = new();
    [JsonIgnore] public HashSet<ulong> RawImportHashList { get; } = new();
    [JsonIgnore] public HashSet<string> RawUsedStrings { get; } = new();
    [JsonIgnore] public HashSet<string> RawTweakStrings { get; } = new();
    [JsonIgnore] public HashSet<string> RawFactStrings { get; } = new();
    [JsonIgnore] public HashSet<string> RawNodeRefs { get; } = new();
    public List<string> UnusedStrings { get; set; }
    public List<string> Imports { get; set; }
    public List<ulong> ImportHashs { get; set; }
    public List<string> UsedStrings { get; set; }
    public List<string> TweakStrings { get; set; }
    public List<string> FactStrings { get; set; }
    public List<string> NodeRefs { get; set; }

    public List<DataCollection> Buffers { get; set; }

    public void CleanUp()
    {
        var strList = RawStringList.ToList();
        strList.Remove("None");

        UnusedStrings = strList;
        Imports = RawImportList.ToList();
        ImportHashs = RawImportHashList.ToList();
        UsedStrings = RawUsedStrings.ToList();
        TweakStrings = RawTweakStrings.ToList();
        FactStrings = RawFactStrings.ToList();
        NodeRefs = RawNodeRefs.ToList();

        if (Buffers != null)
        {
            foreach (var dataCollection in Buffers)
            {
                dataCollection.CleanUp();
            }
        }
    }
}
