using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;
using FastMember;

namespace WolvenKit.CR2W.Types
{
   




    [REDMeta(EREDMetaInfo.REDStruct)]
    public class CurvePiece : CVariable
    {
        [Ordinal(0)] [RED] public CUInt16 valueCount { get; set; }
        [Ordinal(1)] [RED] public CCompressedBuffer<CFloat> values { get; set; }

        public CurvePiece(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            // This has a fixed size in memory, but for some reason file format is allowed to not provide all,
            // leaving the rest to zero values. Possibly has individual fields instead of an array.
            values = new CCompressedBuffer<CFloat>(cr2w, this, nameof(values)) { IsSerialized = true };
            valueCount = new CUInt16(cr2w, this, "count") { val = 16, IsSerialized = true};


        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var copy = base.Copy(context) as CurvePiece;
            copy.valueCount = valueCount.Copy(context) as CUInt16;
            copy.values = values.Copy(context) as CCompressedBuffer<CFloat>;

            return copy;
        }

        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new CurvePiece(cr2w, parent, name);
        }

        public override void Read(BinaryReader file, uint size)
        {
            valueCount.Read(file, size);

            if (valueCount.val > 16)
            {
                Debug.Print("Read: curve piece value count " + valueCount.val + " exceeds limit " + values.Count);
            }

            values.Read(file, size, valueCount.val);
        }

        public override void Write(BinaryWriter file)
        {
            ushort writtenCount = Math.Min(valueCount.val, (ushort)values.Count);

            if (writtenCount != valueCount.val)
            {
                Debug.Print("Write: curve piece value count " + valueCount.val + " exceeds limit " + values.Count);
            }

            file.Write(writtenCount);
            values.Write(file);
        }
    }
}