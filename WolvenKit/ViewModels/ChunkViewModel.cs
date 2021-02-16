using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.CR2W.Types;
using Color = System.Drawing.Color;

namespace WolvenKit.Common.Model
{
    public class ChunkViewModel
    {
        private readonly ICR2WExport _export;

        public ChunkViewModel(ICR2WExport export)
        {
            _export = export;
        }

        public IEditableVariable Data => _export.data;

        public string Name => _export.REDName;
        public List<ChunkViewModel> Children => _export.VirtualChildrenChunks.Select(_ => new ChunkViewModel(_)).ToList();

        public List<ChunkPropertyViewModel> ChildrenProperties =>
            Data.ChildrEditableVariables.Select(_ => new ChunkPropertyViewModel(_)).ToList();
    }

    public class ChunkPropertyViewModel
    {
        private readonly IEditableVariable _property;

        public ChunkPropertyViewModel(IEditableVariable prop)
        {
            _property = prop;

            Name = prop.REDName;
            Type = prop.REDType;
            Value = prop.REDValue;

        }

        public System.Windows.Media.Brush ForegroundColor => _property.IsSerialized 
            ? System.Windows.Media.Brushes.Green 
            : System.Windows.Media.Brushes.Azure;


        public string Name { get; }
        public string Type { get; }
        public string Value { get; set; }

        public List<ChunkPropertyViewModel> Children => _property.ChildrEditableVariables.Select(_ => new ChunkPropertyViewModel(_)).ToList();

    }
}
