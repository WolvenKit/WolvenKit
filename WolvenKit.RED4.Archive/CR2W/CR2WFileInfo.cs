using System.Collections.Generic;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.CR2W
{
    public class CR2WFileInfo
    {
        public CR2WFileHeader FileHeader { get; internal set; }

        public Dictionary<uint, CName> StringDict { get; internal set; }

        public CR2WNameInfo[] NameInfo { get; internal set; }
        public CR2WImportInfo[] ImportInfo { get; internal set; }
        public CR2WPropertyInfo[] PropertyInfo { get; internal set; }
        public CR2WExportInfo[] ExportInfo { get; internal set; }
        public CR2WBufferInfo[] BufferInfo { get; internal set; }
        public CR2WEmbeddedInfo[] EmbeddedInfo { get; internal set; }

        public List<CName> GetImports()
        {
            var result = new List<CName>();
            foreach (var importInfo in ImportInfo)
            {
                result.Add(StringDict[importInfo.offset]);
            }

            return result;
        }
    }
}
