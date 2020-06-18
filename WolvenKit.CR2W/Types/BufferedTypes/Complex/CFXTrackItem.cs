using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta()]
    public class CFXTrackItem : CFXBase
    {
        [RED("timeBegin")] public CFloat TimeBegin { get; set; }

        [RED("timeDuration")] public CFloat TimeDuration { get; set; }

        [REDBuffer(true)] public CName buffername { get; set; }
        [REDBuffer(true)] public CDynamicInt count { get; set; }
        [REDBuffer(true)] public CUInt8 unk { get; set; }
        [REDBuffer(true)] public CCompressedBuffer<CBufferUInt16<CFloat>> buffer { get; set; }

        public CFXTrackItem(CR2WFile cr2w) :
            base(cr2w)
        {
            buffername = new CName(cr2w) { Name = "buffername", Parent = this };
            count = new CDynamicInt(cr2w) { Name = "count", Parent = this };
            unk = new CUInt8(cr2w) { Name = "unk", Parent = this };
            buffer = new CCompressedBuffer<CBufferUInt16<CFloat>>(cr2w, _ => new CBufferUInt16<CFloat>(_, x => new CFloat(x))) { Name = "buffer", Parent = this };
            
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

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CFXTrackItem(cr2w);
        }
    }
}