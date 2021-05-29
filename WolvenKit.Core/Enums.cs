namespace WolvenKit.Common
{

    public enum Logtype
    {
        Normal,
        Error,
        Important,
        Success,
        Warning,
        Wcc
    }

    public enum EArchiveType
    {
        ANY,
        Bundle,
        CollisionCache,
        TextureCache,
        SoundCache,
        Speech,
        Archive,
        Shader,
    }

    /// <summary>
    /// Possible file extensions of cooked redengine files
    /// </summary>
    public enum ECookedFileFormat
    {
        mesh,
        xbm,
        csv,
        json,
        mlmask,
        cubemap,
        envprobe,
        texarray
    }

    /// <summary>
    /// Possible file extensions of raw files
    /// </summary>
    public enum ERawFileFormat
    {
        tga,
        dds,
        fbx
    }

    /// <summary>
    /// Possible file extensions of raw files
    /// </summary>
    public enum EExportState
    {
        Exportable,
        Importable
    }

    public enum ECustomImageKeys
    {
        OpenDirImageKey, //= "<ODIR>";
        ClosedDirImageKey, //= "<CDIR>";
        ModImageKey, //= "<MOD>";
        DlcImageKey, //= "<DLC>";
        DlcCookedImageKey, //= "<DLCC>";
        DlcUncookedImageKey, //= "<DLCU>";
        ModCookedImageKey, //= "<MODC>";
        ModUncookedImageKey, //= "<MODU>";
        RawImageKey, //= "<RAW>";
        RadishImageKey,
        RawModImageKey,
        RawDlcImageKey
    }

    public enum EFileReadErrorCodes
    {
        NoError,
        NoCr2w,
        UnsupportedVersion,
    }

    public enum EProjectFolders
    {
        Cooked,
        Uncooked,
        Raw
    }




    /// IMPORT FLAGS
    [System.Flags]
    public enum EImportFlags
    {
        Default = 0x0,      // done
        Obligatory = 0x1,
        Template = 0x2,     // done
        Soft = 0x4,         // done
        HashedPath = 0x8,
        Inplace = 0x10,     // done
    };
}
