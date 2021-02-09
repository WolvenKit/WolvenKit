using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.Common.Model
{
    public class ChunkViewModel
    {
        private readonly ICR2WExport _export;

        public ChunkViewModel(ICR2WExport export)
        {
            _export = export;
        }

#pragma warning disable CA1416 // Validate platform compatibility
        public IEditableVariable Data => _export.data;

        public string Name => _export.REDName;
        public List<ICR2WExport> Children => _export.VirtualChildrenChunks;
#pragma warning restore CA1416 // Validate platform compatibility

    }
}
