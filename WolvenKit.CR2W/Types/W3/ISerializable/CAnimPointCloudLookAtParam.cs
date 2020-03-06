using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;

namespace WolvenKit.CR2W.Types
{
    public class CAnimPointCloudLookAtParam : CVector
    {
        public CBufferVLQ<SAnimPointCloudLookAtParamData> buffer;
            
        public CAnimPointCloudLookAtParam(CR2WFile cr2w) :
            base(cr2w)
        {
            buffer = new CBufferVLQ<SAnimPointCloudLookAtParamData>(cr2w, _ => new SAnimPointCloudLookAtParamData(_)) { Name = "buffer" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            buffer.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            buffer.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CAnimPointCloudLookAtParam(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CAnimPointCloudLookAtParam) base.Copy(context);

            var.buffer = (CBufferVLQ<SAnimPointCloudLookAtParamData>)buffer.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                buffer
            };
        }
    }
}