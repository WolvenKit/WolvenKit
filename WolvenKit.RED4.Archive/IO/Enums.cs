namespace WolvenKit.RED4.Archive.IO
{
    public enum EFileReadErrorCodes
    {
        NoError,
        NoCr2w,
        UnsupportedVersion,
    }

    public enum EHashVersion
    {
        Unknown,
        Pre120,
        Latest,
    }
}
