using System.Collections.Generic;

namespace WolvenKit.ViewModels
{
    public class ChunkViewModel
    {
        private readonly CR2W.CR2WExportWrapper _export;

        public ChunkViewModel(CR2W.CR2WExportWrapper export)
        {
            _export = export;
        }

        public CR2W.Types.CVariable Data => _export.data;

        public string Name => _export.REDName;
        public List<CR2W.CR2WExportWrapper> Children => _export.VirtualChildrenChunks;
    }
}
