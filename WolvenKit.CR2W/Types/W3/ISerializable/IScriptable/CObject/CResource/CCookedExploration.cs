using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CCookedExplorations : CVector
    {
        public CByteArray explfile;
            
        public CCookedExplorations(CR2WFile cr2w) :
            base(cr2w)
        {
            explfile = new CByteArray(cr2w)
            {
                Name = "explfile"
            };
            
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            explfile.Read(file, 0);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            explfile.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CCookedExplorations(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CCookedExplorations) base.Copy(context);

            var.explfile = (CByteArray) explfile.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                explfile
            };
        }
    }
}