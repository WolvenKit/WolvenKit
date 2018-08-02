
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    class CLayerInfo : CVector
    {


        public CLayerInfo(CR2WFile cr2w) : base(cr2w)
        {

				
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file,size);

        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
				
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CLayerInfo(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
                var var = (CLayerInfo)base.Copy(context);
            

				
            
                return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables)
            {

            };
            return list;
        }
    }
}
