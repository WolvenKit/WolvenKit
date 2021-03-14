using CsvHelper.Configuration;

namespace WolvenKit.Models
{
    public class CBoolMap : ClassMap<CR2W.Types.CBool>
    {
        #region Constructors

        public CBoolMap() => Map(m => m.val);

        #endregion Constructors
    }

    public class CFloatMap : ClassMap<CR2W.Types.CFloat>
    {
        #region Constructors

        public CFloatMap() => Map(m => m.val);

        #endregion Constructors
    }

    public class CInt16Map : ClassMap<CR2W.Types.CInt16>
    {
        #region Constructors

        public CInt16Map() => Map(m => m.val);

        #endregion Constructors
    }

    public class CInt32Map : ClassMap<CR2W.Types.CInt32>
    {
        #region Constructors

        public CInt32Map() => Map(m => m.val);

        #endregion Constructors
    }

    public class CInt64Map : ClassMap<CR2W.Types.CInt64>
    {
        #region Constructors

        public CInt64Map() => Map(m => m.val);

        #endregion Constructors
    }

    public class CInt8Map : ClassMap<CR2W.Types.CInt8>
    {
        #region Constructors

        public CInt8Map() => Map(m => m.val);

        #endregion Constructors
    }

    public class CNameMap : ClassMap<CR2W.Types.CName>
    {
        #region Constructors

        public CNameMap() => Map(m => m.Value);

        #endregion Constructors
    }

    public class CStringMap : ClassMap<CR2W.Types.CString>
    {
        #region Constructors

        public CStringMap() => Map(m => m.val);

        #endregion Constructors
    }

    public class CUInt16Map : ClassMap<CR2W.Types.CUInt16>
    {
        #region Constructors

        public CUInt16Map() => Map(m => m.val);

        #endregion Constructors
    }

    public class CUInt32Map : ClassMap<CR2W.Types.CUInt32>
    {
        #region Constructors

        public CUInt32Map() => Map(m => m.val);

        #endregion Constructors
    }

    public class CUInt64Map : ClassMap<CR2W.Types.CUInt64>
    {
        #region Constructors

        public CUInt64Map() => Map(m => m.val);

        #endregion Constructors
    }

    public class CUInt8Map : ClassMap<CR2W.Types.CUInt8>
    {
        #region Constructors

        public CUInt8Map() => Map(m => m.val);

        #endregion Constructors
    }
}
