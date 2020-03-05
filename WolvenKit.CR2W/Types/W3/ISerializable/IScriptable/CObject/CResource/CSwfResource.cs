using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class CSwfResource : CVector
    {
        public CByteArray swfResource;
        public CUInt32 unk1;


        public CSwfResource(CR2WFile cr2w) :
            base(cr2w)
        {
            swfResource = new CByteArray(cr2w)
            {
                Name = "swfResource"
            };

            unk1 = new CUInt32(cr2w)
            {
                Name = "unk1"
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
            swfResource.Read(file, size);
            unk1.Read(file, 0);

            //dbg
            if (unk1.val > 0)
            {
                Debugger.Break();
                throw new NotImplementedException();
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            swfResource.Write(file);

            unk1.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CSwfResource(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CSwfResource) base.Copy(context);

            var.swfResource = (CByteArray) swfResource.Copy(context);
            var.unk1 = (CUInt32)unk1.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables);
            list.Add(swfResource);
            list.Add(unk1);
            return list;
        }
    }
}