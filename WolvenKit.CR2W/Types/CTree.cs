using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W.GameEntity
{
    public class CTree : CVariable
    {
        public CFloat x, y, z;
        public CFloat Yaw, Pitch, Roll;

        public CTree(CR2WFile cr2w) : base(cr2w)
        {
            x = new CFloat(cr2w);
            x.Name = "X";
            y = new CFloat(cr2w);
            y.Name = "Y";
            z = new CFloat(cr2w);
            z.Name = "Z";
            Yaw = new CFloat(cr2w);
            Yaw.Name = "Yaw";
            Pitch = new CFloat(cr2w);
            Pitch.Name = "Pitch";
            Roll = new CFloat(cr2w);
            Roll.Name = "Roll";
        }

        public override void Read(BinaryReader file, uint size)
        {
            x.Read(file, 4);
            y.Read(file, 4);
            z.Read(file, 4);
            Yaw.Read(file, 4);
            Pitch.Read(file, 4);
            Roll.Read(file, 4);
        }

        public override void Write(BinaryWriter file)
        {
            x.Write(file);
            y.Write(file);
            z.Write(file);
            Yaw.Write(file);
            Pitch.Write(file);
            Roll.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CTree(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CTree)base.Copy(context);
            var.x = (CFloat) x.Copy(context);
            var.y = (CFloat) y.Copy(context);
            var.z = (CFloat) z.Copy(context);
            var.Yaw = (CFloat) Yaw.Copy(context);
            var.Pitch = (CFloat) Pitch.Copy(context);
            var.Roll = (CFloat) Roll.Copy(context);
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable> {x, y, z, Yaw, Pitch, Roll};
            return list;
        }
    }
}
