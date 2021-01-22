namespace WolvenKit.Common
{
    public enum EUncookExtension
    {
        tga,
        bmp,
        jpg,
        jpeg,
        png,
        dds,
        //HDR,
        //TIF,
        //TIFF,
        //WDP,
        //HDP,
        //JXR
    }




    public enum EFileReadErrorCodes
    {
        NoError,
        NoCr2w,
        UnsupportedVersion,
    }

    /// <summary>
    /// Possible file extensions of cooked redengine files
    /// </summary>
    public enum ECookedFileFormat
    {
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

    public enum EProjectFolders
    {
        Cooked,
        Uncooked,
        Raw
    }
}
