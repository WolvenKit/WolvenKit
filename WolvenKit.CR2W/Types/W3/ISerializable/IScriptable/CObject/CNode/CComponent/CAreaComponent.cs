using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;

namespace WolvenKit.CR2W.Types
{
    public class CAreaComponent : CComponent
    {
        public CByteArray2 bufferdata;
            
        public CAreaComponent(CR2WFile cr2w) :
            base(cr2w)
        {
            bufferdata = new CByteArray2(cr2w)
            {
                Name = "bufferdata"
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            bufferdata.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            bufferdata.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CAreaComponent(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CAreaComponent) base.Copy(context);

            var.bufferdata = (CByteArray2)bufferdata.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(base.GetEditableVariables())
            {
                bufferdata
            };
        }
    }
}