using CsvHelper.Configuration;
using WolvenKit.RED3.CR2W.Types;

namespace WolvenKit.Models
{
    public class CBoolMap : ClassMap<CBool>
    {
        #region Constructors

        public CBoolMap() => Map(m => m.val);

        #endregion Constructors
    }

    public class CFloatMap : ClassMap<CFloat>
    {
        #region Constructors

        public CFloatMap() => Map(m => m.Value);

        #endregion Constructors
    }

    public class CInt16Map : ClassMap<CInt16>
    {
        #region Constructors

        public CInt16Map() => Map(m => m.val);

        #endregion Constructors
    }

    public class CInt32Map : ClassMap<CInt32>
    {
        #region Constructors

        public CInt32Map() => Map(m => m.val);

        #endregion Constructors
    }

    public class CInt64Map : ClassMap<CInt64>
    {
        #region Constructors

        public CInt64Map() => Map(m => m.val);

        #endregion Constructors
    }

    public class CInt8Map : ClassMap<CInt8>
    {
        #region Constructors

        public CInt8Map() => Map(m => m.val);

        #endregion Constructors
    }

    public class CNameMap : ClassMap<CName>
    {
        #region Constructors

        public CNameMap() => Map(m => m.Value);

        #endregion Constructors
    }

    public class CStringMap : ClassMap<CString>
    {
        #region Constructors

        public CStringMap() => Map(m => m.Value);

        #endregion Constructors
    }

    public class CUInt16Map : ClassMap<CUInt16>
    {
        #region Constructors

        public CUInt16Map() => Map(m => m.val);

        #endregion Constructors
    }

    public class CUInt32Map : ClassMap<CUInt32>
    {
        #region Constructors

        public CUInt32Map() => Map(m => m.val);

        #endregion Constructors
    }

    public class CUInt64Map : ClassMap<CUInt64>
    {
        #region Constructors

        public CUInt64Map() => Map(m => m.val);

        #endregion Constructors
    }

    public class CUInt8Map : ClassMap<CUInt8>
    {
        #region Constructors

        public CUInt8Map() => Map(m => m.val);

        #endregion Constructors
    }
}
