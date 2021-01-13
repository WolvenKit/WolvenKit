namespace WolvenKit.Common
{
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
