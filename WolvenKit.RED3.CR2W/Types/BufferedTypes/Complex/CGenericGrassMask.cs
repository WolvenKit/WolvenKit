using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

using WolvenKit.RED3.CR2W.Reflection;
using static WolvenKit.RED3.CR2W.Types.Enums;
using FastMember;

namespace WolvenKit.RED3.CR2W.Types
{

    public partial class CGenericGrassMask : CResource
    {

        [Ordinal(1000)] [REDBuffer(true)] public CBytes grassmask { get; set; }

        public CGenericGrassMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            grassmask = new CBytes(cr2w, this, nameof(grassmask))
            {
                Bytes = new byte[0],
                IsSerialized = true
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            if (MaskRes == null) return;
            var res = MaskRes.val;
            grassmask.Bytes = file.ReadBytes((int)(res * res >> 3));
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
            if (grassmask.Bytes.Length > 0)
                grassmask.Write(file);
        }

    }
}
