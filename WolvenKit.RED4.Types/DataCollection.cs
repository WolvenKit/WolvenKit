using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace WolvenKit.RED4.Types;

public class DataCollection
{
    public string FileName { get; set; }
    public ulong Hash { get; set; }

    [JsonIgnore] public HashSet<string> RawStringList { get; } = new();
    [JsonIgnore] public HashSet<string> RawImportList { get; } = new();
    [JsonIgnore] public HashSet<string> RawUsedStrings { get; } = new();
    public List<string> UnusedStrings { get; set; }
    public List<string> Imports { get; set; }
    public List<string> UsedStrings { get; set; }

    public List<DataCollection> Buffers { get; set; }

    public void CleanUp()
    {
        var strList = RawStringList.ToList();
        strList.Remove("");

        if (strList.Count > 0)
        {
            UnusedStrings = strList;
        }

        if (RawImportList.Count > 0)
        {
            Imports = RawImportList.ToList();
        }

        if (RawUsedStrings.Count > 0)
        {
            UsedStrings = RawUsedStrings.ToList();
        }

        if (Buffers != null)
        {
            foreach (var dataCollection in Buffers)
            {
                dataCollection.CleanUp();
            }
        }
    }
}
