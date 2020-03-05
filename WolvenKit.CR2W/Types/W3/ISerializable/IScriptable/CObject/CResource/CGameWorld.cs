using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;

namespace WolvenKit.CR2W.Types
{
    public class CGameWorld : CVector
    {
        public CHandle firstlayer;
            
        public CGameWorld(CR2WFile cr2w) :
            base(cr2w)
        {
            firstlayer = new CHandle(cr2w)
            {
                Name = "firstlayer"
            };
            
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            firstlayer.Read(file, 0);
           
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            firstlayer.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CGameWorld(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CGameWorld) base.Copy(context);

            var.firstlayer = (CHandle)firstlayer.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                firstlayer
            };
        }
    }
}