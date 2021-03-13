using System.Collections.Generic;
using System.IO;

using System.Diagnostics;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using static WolvenKit.RED3.CR2W.Types.Enums;
using FastMember;

namespace WolvenKit.RED3.CR2W.Types
{
    public partial class CFXTrackItem : CFXBase
    {

        [Ordinal(1000)] [REDBuffer(true)] public CName buffername { get; set; }
        [Ordinal(1001)] [REDBuffer(true)] public CDynamicInt count { get; set; }
        [Ordinal(1002)] [REDBuffer(true)] public CUInt8 unk { get; set; }
        [Ordinal(1003)] [REDBuffer(true)] public CCompressedBuffer<CBufferUInt16<CFloat>> buffer { get; set; }

        public CFXTrackItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            buffername = new CName(cr2w, this, nameof(buffername)) { IsSerialized = true };
            count = new CDynamicInt(cr2w, this, nameof(count)) { IsSerialized = true };
            unk = new CUInt8(cr2w, this, nameof(unk)) { IsSerialized = true };
            buffer = new CCompressedBuffer<CBufferUInt16<CFloat>>(cr2w, this, nameof(buffer)) { IsSerialized = true };

        }

        public override void Read(BinaryReader file, uint size)
        {
            var startpos = file.BaseStream.Position;
            base.Read(file, size);

            var endpos = file.BaseStream.Position;

            var bytesread = endpos - startpos;
            if (bytesread < size)
            {
                buffername.Read(file, 2);
                count.Read(file, size);
                unk.Read(file, 1);
                buffer.Read(file, 0, count.val);
            }
            else if (bytesread > size)
            {

            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            if (buffername != null)
                buffername.Write(file);
            if (count != null)
                count.Write(file);
            if (buffername != null)
                unk.Write(file);
            if (buffer != null)
                buffer.Write(file);
        }


    }
}