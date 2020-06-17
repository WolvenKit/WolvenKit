using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta]
    public class CCookedExplorations : CResource
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

       
    }
}