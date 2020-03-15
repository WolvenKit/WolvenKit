using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CEngineQsTransform : CVariable
    {
        public byte flags;
        public CFloat pitch, yaw, roll, w;
        public CFloat scale_x, scale_y, scale_z;
        public string type;
        public CFloat x, y, z;

        public CEngineQsTransform(CR2WFile cr2w)
            : base(cr2w)
        {
            x = new CFloat(null) {Name = "x", Type = "Float"};
            y = new CFloat(null) {Name = "y", Type = "Float"};
            z = new CFloat(null) {Name = "z", Type = "Float"};
            pitch = new CFloat(null) {Name = "rotation x", Type = "Float"};
            yaw = new CFloat(null) {Name = "rotation y", Type = "Float"};
            roll = new CFloat(null) {Name = "rotation z", Type = "Float"};
            w = new CFloat(null) {Name = "rotation w", Type = "Float"};
            scale_x = new CFloat(null) {Name = "scale x", Type = "Float"};
            scale_y = new CFloat(null) {Name = "scale y", Type = "Float"};
            scale_z = new CFloat(null) {Name = "scale z", Type = "Float"};

            w.val = 1;
        }

        public override void Read(BinaryReader file, uint size)
        {
            flags = file.ReadByte();

            if ((flags & 1) == 1)
            {
                x.Read(file, 4);
                y.Read(file, 4);
                z.Read(file, 4);
            }


            if ((flags & 2) == 2)
            {
                pitch.Read(file, 4);
                yaw.Read(file, 4);
                roll.Read(file, 4);
                w.Read(file, 4);
            }

            if ((flags & 4) == 4)
            {
                scale_x.Read(file, 4);
                scale_y.Read(file, 4);
                scale_z.Read(file, 4);
            }
        }

        public override void Write(BinaryWriter file)
        {
            flags = 0;
            if (x.val != 0 || y.val != 0 || z.val != 0)
                flags |= 1;
            if (pitch.val != 0 || yaw.val != 0 || roll.val != 0 || w.val != 1)
                flags |= 2;
            if (scale_x.val != 0 || scale_y.val != 0 || scale_z.val != 0)
                flags |= 4;

            file.Write(flags);

            if ((flags & 1) == 1)
            {
                x.Write(file);
                y.Write(file);
                z.Write(file);
            }


            if ((flags & 2) == 2)
            {
                pitch.Write(file);
                yaw.Write(file);
                roll.Write(file);
                w.Write(file);
            }

            if ((flags & 4) == 4)
            {
                scale_x.Write(file);
                scale_y.Write(file);
                scale_z.Write(file);
            }
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CEngineQsTransform(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CEngineQsTransform) base.Copy(context);
            var.type = type;
            var.flags = flags;
            var.x.val = x.val;
            var.y.val = y.val;
            var.z.val = z.val;
            var.roll.val = roll.val;
            var.yaw.val = yaw.val;
            var.pitch.val = pitch.val;
            var.w.val = w.val;
            var.scale_x.val = scale_x.val;
            var.scale_y.val = scale_y.val;
            var.scale_z.val = scale_z.val;
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var vars = new List<IEditableVariable>();
            vars.Add(x);
            vars.Add(y);
            vars.Add(z);
            vars.Add(pitch);
            vars.Add(yaw);
            vars.Add(roll);
            vars.Add(w);
            vars.Add(scale_x);
            vars.Add(scale_y);
            vars.Add(scale_z);
            return vars;
        }

        public override string ToString()
        {
            return "";
        }
    }
}