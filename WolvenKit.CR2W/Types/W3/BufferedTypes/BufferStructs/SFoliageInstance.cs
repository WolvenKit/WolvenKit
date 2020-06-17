using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class SFoliageInstance : CVariable
    {
        public SVector3D position;
        public CFloat Yaw, Pitch, Roll;

        public SFoliageInstance(CR2WFile cr2w) : base(cr2w)
        {
            position = new SVector3D(cr2w)
            {
                Name = "Position"
            };
            Yaw = new CFloat(cr2w);
            Yaw.Name = "Yaw";
            Pitch = new CFloat(cr2w);
            Pitch.Name = "Pitch";
            Roll = new CFloat(cr2w);
            Roll.Name = "Roll";
        }

        public override void Read(BinaryReader file, uint size)
        {
            position.Read(file,size);
            Yaw.Read(file, size);
            Pitch.Read(file, size);
            Roll.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            position.Write(file);
            Yaw.Write(file);
            Pitch.Write(file);
            Roll.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SFoliageInstance(cr2w);
        }
    }
}
