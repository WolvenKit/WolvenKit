using CsvHelper.Configuration;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Model
{
    public class CNameMap : ClassMap<CR2W.Types.CName>
    {
        public CNameMap() => Map(m => m.Value);
    }

    public class CStringMap : ClassMap<CR2W.Types.CString>
    {
        public CStringMap() => Map(m => m.val);
    }

    public class CBoolMap : ClassMap<CR2W.Types.CBool>
    {
        public CBoolMap() => Map(m => m.val);
    }

    public class CFloatMap : ClassMap<CR2W.Types.CFloat>
    {
        public CFloatMap() => Map(m => m.val);
    }

    public class CUInt8Map : ClassMap<CR2W.Types.CUInt8>
    {
        public CUInt8Map() => Map(m => m.val);
    }

    public class CUInt16Map : ClassMap<CR2W.Types.CUInt16>
    {
        public CUInt16Map() => Map(m => m.val);
    }

    public class CUInt32Map : ClassMap<CR2W.Types.CUInt32>
    {
        public CUInt32Map() => Map(m => m.val);
    }

    public class CUInt64Map : ClassMap<CR2W.Types.CUInt64>
    {
        public CUInt64Map() => Map(m => m.val);
    }

    public class CInt8Map : ClassMap<CR2W.Types.CInt8>
    {
        public CInt8Map() => Map(m => m.val);
    }

    public class CInt16Map : ClassMap<CR2W.Types.CInt16>
    {
        public CInt16Map() => Map(m => m.val);
    }

    public class CInt32Map : ClassMap<CR2W.Types.CInt32>
    {
        public CInt32Map() => Map(m => m.val);
    }

    public class CInt64Map : ClassMap<CR2W.Types.CInt64>
    {
        public CInt64Map() => Map(m => m.val);
    }
}