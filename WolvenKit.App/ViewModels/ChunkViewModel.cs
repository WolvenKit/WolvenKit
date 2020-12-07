using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W;

namespace WolvenKit.Common.Model
{
    public class ChunkViewModel
    {
        private readonly CR2WExportWrapper _export;

        public ChunkViewModel(CR2WExportWrapper export)
        {
            _export = export;
        }

        public string Name => _export.REDName;
        public List<CR2WExportWrapper> Children => _export.VirtualChildrenChunks;
    }
}
