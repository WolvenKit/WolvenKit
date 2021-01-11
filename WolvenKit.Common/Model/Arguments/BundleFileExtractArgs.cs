namespace WolvenKit.Common.Model.Arguments
{
    public class BundleFileExtractArgs
    {
        public BundleFileExtractArgs(string fullpath, EUncookExtension extension = EUncookExtension.tga)
        {
            FileName = fullpath;
            Extension = extension;
        }
        public string FileName { get; set; }
        public EUncookExtension Extension { get; set; }
    }
}