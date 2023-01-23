namespace WolvenKit.RED4.Save;

public static class Extensions
{
    private static Dictionary<ulong, string> _tweakList = new Dictionary<ulong, string>();
    private static Dictionary<ulong, string> _factsList = new Dictionary<ulong, string>();
    private static bool _tweaksLoaded;
    private static bool _factsLoaded;

    private static void LoadTweaks()
    {
        // tweakdb.str
        // var data = File.ReadAllBytes(@"");
        // 
        // using var ms = new MemoryStream(data);
        // using var br = new BinaryReader(ms);
        // 
        // br.ReadBytes(0x14);
        // while (br.BaseStream.Position < br.BaseStream.Length)
        // {
        //     var str = br.ReadLengthPrefixedString();
        //     var id = Crc32Algorithm.Compute(str) + ((ulong)str.Length << 32);
        // 
        //     _tweakList.TryAdd(id, str);
        // }

        _tweaksLoaded = true;
    }

    private static void LoadFacts()
    {
        // list of facts
        // var lines = File.ReadAllLines(@"");
        // foreach (var line in lines)
        // {
        //     _factsList.TryAdd(FNV1A32HashAlgorithm.HashString(line), line);
        // }

        _factsLoaded = true;
    }

    public static Fact ReadFact(this BinaryReader reader)
    {
        if (!_factsLoaded)
        {
            LoadFacts();
        }

        var val = reader.ReadUInt32();
        if (_factsList.ContainsKey(val))
        {
            return _factsList[val];
        }

        return val;
    }
}
