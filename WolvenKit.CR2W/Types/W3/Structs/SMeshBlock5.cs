using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class SMeshBlock5 : CVariable
    {
        private const int fixedbuffersize = 46;

        CUInt16 bytesize;
        CBytes unk1;

        public SMeshBlock5(CR2WFile cr2w) :
            base(cr2w)
        {
            bytesize = new CUInt16(cr2w) { Name = "size" };
            unk1 = new CBytes(cr2w) { Name = "unk1" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            bytesize.Read(file, 2);

            if ((int)bytesize.val != fixedbuffersize)
                throw new NotImplementedException();

            unk1.Read(file, (uint)bytesize.val - 2);
        }

        public override void Write(BinaryWriter file)
        {
            bytesize.Write(file);
            unk1.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SMeshBlock5(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (SMeshBlock5)base.Copy(context);

            var.bytesize = (CUInt16)bytesize.Copy(context);
            var.unk1 = (CBytes)unk1.Copy(context);
            

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>()
            {
                bytesize,
                unk1
            };
        }

        public override string ToString()
        {
            return "";
        }
    }
}