using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta()]
    public class CSwarmCellMap : CResource
    {
        [RED("cellSize")] public CFloat CellSize { get; set; }


        [REDBuffer()] public CFloat CellSize1 { get; set; }
        [REDBuffer()] public CInt32 DataSizeBits1 { get; set; }
        [REDBuffer()] public CUInt16 DataSize1 { get; set; }
        [REDBuffer()] public CByteArray Data { get; set; }
        [REDBuffer()] public CFloat CornerPositionX { get; set; }
        [REDBuffer()] public CFloat CornerPositionY { get; set; }
        [REDBuffer()] public CFloat CornerPositionZ { get; set; }
        [REDBuffer()] public CInt32 DataSizeX { get; set; }
        [REDBuffer()] public CInt32 DataSizeY { get; set; }
        [REDBuffer()] public CInt32 DataSizeZ { get; set; }
        [REDBuffer()] public CInt32 DataSizeBits { get; set; }
        [REDBuffer()] public CFloat SizeInKbytes { get; set; }


        public CSwarmCellMap(CR2WFile cr2w) : base(cr2w)
        {

        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);


        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);


        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CSwarmCellMap(cr2w);
        }
    }
}
