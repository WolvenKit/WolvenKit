using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CFXTrackItem : CVector
    {
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
            base.Read(file, size);

            buffername.Read(file, 2);
            count.Read(file, size);
            unk.Read(file, 1);
            buffer.Read(file, 0, count.val);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            buffername.Write(file);
            count.Write(file);
            unk.Write(file);
            buffer.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CFXTrackItem(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CFXTrackItem) base.Copy(context);

            var.buffername = (CName)buffername.Copy(context);
            var.count = (CDynamicInt)count.Copy(context);
            var.unk = (CUInt8)unk.Copy(context);
            var.buffer = (CCompressedBuffer<CBufferUInt16<CFloat>>)buffer.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                buffername,
                count,
                unk,
                buffer
            };
        }
    }
}