using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using W3Edit.CR2W.Editors;

namespace W3Edit.CR2W.Types
{
    public class CEngineTransform : CVariable
    {
        public CFloat x, y, z;
        public CFloat pitch, yaw, roll;
        public CFloat scale_x, scale_y, scale_z;
        public byte flags;

        public string type;

        public CEngineTransform(CR2WFile cr2w)
            : base(cr2w)
        {
            x = new CFloat(null) { Name = "x", Type = "Float" };
            y = new CFloat(null) { Name = "y", Type = "Float" };
            z = new CFloat(null) { Name = "z", Type = "Float" };
            pitch = new CFloat(null) { Name = "pitch", Type = "Float" };
            yaw = new CFloat(null) { Name = "yaw", Type = "Float" };
            roll = new CFloat(null) { Name = "roll", Type = "Float" };
            scale_x = new CFloat(null) { Name = "scale x", Type = "Float" };
            scale_y = new CFloat(null) { Name = "scale y", Type = "Float" };
            scale_z = new CFloat(null) { Name = "scale z", Type = "Float" };
        }

        public override void Read(BinaryReader file, UInt32 size)
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
            if (pitch.val != 0 || yaw.val != 0 || roll.val != 0)
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
            return new CEngineTransform(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CEngineTransform)base.Copy(context);
            var.type = type;
            var.flags = flags;
            var.x.val = x.val;
            var.y.val = y.val;
            var.z.val = z.val;
            var.roll.val = roll.val;
            var.yaw.val = yaw.val;
            var.pitch.val = pitch.val;
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
