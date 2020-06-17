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
    [REDMeta]
    public class CFXTrackItem : CFXBase
    {
        [RED("timeBegin")] public CFloat TimeBegin { get; set; }

        [RED("timeDuration")] public CFloat TimeDuration { get; set; }

        public CName buffername;
        public CDynamicInt count;
        public CUInt8 unk;
        public CCompressedBuffer<CBufferUInt16<CFloat>> buffer;
            
        public CFXTrackItem(CR2WFile cr2w) :
            base(cr2w)
        {
            buffername = new CName(cr2w) { Name = "buffername" };
            count = new CDynamicInt(cr2w) { Name = "count" };
            unk = new CUInt8(cr2w) { Name = "unk" };
            buffer = new CCompressedBuffer<CBufferUInt16<CFloat>>(cr2w, _ => new CBufferUInt16<CFloat>(_, x => new CFloat(x))) { Name = "buffer" };
            
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

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CFXTrackItem) base.Copy(context);

            if (buffername != null)
                var.buffername = (CName)buffername.Copy(context);
            if (count != null)
                var.count = (CDynamicInt)count.Copy(context);
            if (buffername != null)
                var.unk = (CUInt8)unk.Copy(context);
            if (buffer != null)
                var.buffer = (CCompressedBuffer<CBufferUInt16<CFloat>>)buffer.Copy(context);

            return var;
        }

       
    }
}