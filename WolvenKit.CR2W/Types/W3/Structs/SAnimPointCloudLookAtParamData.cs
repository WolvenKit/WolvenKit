using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Linq;
using System.Globalization;

namespace WolvenKit.CR2W.Types
{
    public class SAnimPointCloudLookAtParamData : CVariable
    {
        public CUInt16 unk1;
        public CUInt16 unk2;
        public CUInt16 unk3;

        public SAnimPointCloudLookAtParamData(CR2WFile cr2w) : base(cr2w)
        {
            unk1 = new CUInt16(cr2w) { Name = "unk1" };
            unk2 = new CUInt16(cr2w) { Name = "unk2" };
            unk3 = new CUInt16(cr2w) { Name = "unk3" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            unk1.Read(file, 2);
            unk2.Read(file, 2);
            unk3.Read(file, 2);
        }

        public override void Write(BinaryWriter file)
        {
            unk1.Write(file);
            unk2.Write(file);
            unk3.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SAnimPointCloudLookAtParamData(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (SAnimPointCloudLookAtParamData)base.Copy(context);

            var.unk1 = (CUInt16)unk1.Copy(context);
            var.unk2 = (CUInt16)unk2.Copy(context);
            var.unk3 = (CUInt16)unk3.Copy(context);
            

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>()
            {
                unk1,
                unk2,
                unk3
            };
        }

        public override string ToString()
        {
            return $"[{unk1.ToString()}, {unk2.ToString()}, {unk3.ToString()}]";
        }
    }
}