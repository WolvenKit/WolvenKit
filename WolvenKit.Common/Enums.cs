namespace WolvenKit.Common
{
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

    /// <summary>
    /// Possible file extensions of raw files
    /// </summary>
    public enum ERawFileFormat
    {
        tga,
        dds,
        fbx
    }
}
