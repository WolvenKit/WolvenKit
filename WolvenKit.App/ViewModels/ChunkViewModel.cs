using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Common.Model
{
    public class ChunkViewModel
    {
        private readonly CR2WExportWrapper _export;

        public ChunkViewModel(CR2WExportWrapper export)
        {
            _export = export;
        }

        public CVariable Data => _export.data;

        public string Name => _export.REDName;
        public List<CR2WExportWrapper> Children => _export.VirtualChildrenChunks;
    }
}
