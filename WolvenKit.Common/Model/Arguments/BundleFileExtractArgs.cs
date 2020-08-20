using System.IO;

namespace WolvenKit.Common.Model
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