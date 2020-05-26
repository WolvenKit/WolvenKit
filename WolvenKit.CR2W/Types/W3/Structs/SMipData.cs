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
    public class SMipData : CVariable
    {
        public CUInt32 Width;
        public CUInt32 Height;
        public CUInt32 Blocksize;

        public SMipData(CR2WFile cr2w) :
            base(cr2w)
        {
            Width = new CUInt32(cr2w) { Name = "Width" };
            Height = new CUInt32(cr2w) { Name = "Height" };
            Blocksize = new CUInt32(cr2w) { Name = "Blocksize" };
            
        }

        public override void Read(BinaryReader file, uint size)
        {
            Width.Read(file, 4);
            Height.Read(file, 4);
            Blocksize.Read(file, 4);
        }

        public override void Write(BinaryWriter file)
        {
            Width.Write(file);
            Height.Write(file);
            Blocksize.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SMipData(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (SMipData)base.Copy(context);

            var.Width = (CUInt32)Width.Copy(context);
            var.Height = (CUInt32)Height.Copy(context);
            var.Blocksize = (CUInt32)Blocksize.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>()
            {
                Width,
                Height,
                Blocksize,
            };
        }

        public override string ToString()
        {
            return "";
        }
    }
}