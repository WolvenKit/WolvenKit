using CsvHelper.Configuration;
using WolvenKit.CR2W.Types;

namespace WolvenKit.App.Model
{
    public class CNameMap : ClassMap<CName>
    {
        public CNameMap() => Map(m => m.Value);
    }

    public class CStringMap : ClassMap<CString>
    {
        public CStringMap() => Map(m => m.val);
    }

    public class CBoolMap : ClassMap<CBool>
    {
        public CBoolMap() => Map(m => m.val);
    }

    public class CFloatMap : ClassMap<CFloat>
    {
        public CFloatMap() => Map(m => m.val);
    }

    public class CUInt8Map : ClassMap<CUInt8>
    {
        public CUInt8Map() => Map(m => m.val);
    }

    public class CUInt16Map : ClassMap<CUInt16>
    {
        public CUInt16Map() => Map(m => m.val);
    }

    public class CUInt32Map : ClassMap<CUInt32>
    {
        public CUInt32Map() => Map(m => m.val);
    }

    public class CUInt64Map : ClassMap<CUInt64>
    {
        public CUInt64Map() => Map(m => m.val);
    }

    public class CInt8Map : ClassMap<CInt8>
    {
        public CInt8Map() => Map(m => m.val);
    }

    public class CInt16Map : ClassMap<CInt16>
    {
        public CInt16Map() => Map(m => m.val);
    }

    public class CInt32Map : ClassMap<CInt32>
    {
        public CInt32Map() => Map(m => m.val);
    }

    public class CInt64Map : ClassMap<CInt64>
    {
        public CInt64Map() => Map(m => m.val);
    }
}