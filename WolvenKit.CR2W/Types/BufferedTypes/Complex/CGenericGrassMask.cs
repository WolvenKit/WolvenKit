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

    public partial class CGenericGrassMask : CResource
    {

        [REDBuffer(true)] public CBytes grassmask { get; set; }

        public CGenericGrassMask(CR2WFile cr2w) : base(cr2w)
        {
            grassmask = new CBytes(cr2w)
            {
                REDName = "Grass mask data",
                Bytes = new byte[0],
                Parent = this
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
            if ((cr2w.GetChunkByType("CGenericGrassMask").data as CGenericGrassMask).MaskRes != null)
            {
                var res = (cr2w.GetChunkByType("CGenericGrassMask").data as CGenericGrassMask).MaskRes.val;
                grassmask.Bytes = file.ReadBytes((int)(res * res >> 3));
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
            if (grassmask.Bytes.Length > 0)
                grassmask.Write(file);
        }

    }
}
