using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CMatrix4x4 : CVariable
    {
        public CVariable[] fields;
        public CFloat ax, ay, az, aw, bx, by, bz, bw, cx, cy, cz, cw, dx, dy, dz, dw;

        public CMatrix4x4(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {

            fields = new CVariable[] {
                ax = new CFloat(cr2w, this, "ax"),
                ay = new CFloat(cr2w, this, "ay"),
                az = new CFloat(cr2w, this, "az"),
                aw = new CFloat(cr2w, this, "aw"),
                bx = new CFloat(cr2w, this, "bx"),
                by = new CFloat(cr2w, this, "by"),
                bz = new CFloat(cr2w, this, "bz"),
                bw = new CFloat(cr2w, this, "bw"),
                cx = new CFloat(cr2w, this, "cx"),
                cy = new CFloat(cr2w, this, "cy"),
                cz = new CFloat(cr2w, this, "cz"),
                cw = new CFloat(cr2w, this, "cw"),
                dx = new CFloat(cr2w, this, "dx"),
                dy = new CFloat(cr2w, this, "dy"),
                dz = new CFloat(cr2w, this, "dz"),
                dw = new CFloat(cr2w, this, "dw")
            };
        }

        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new CMatrix4x4(cr2w, parent, name);
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(fields);
        }

        public override void Read(BinaryReader file, uint size)
        {
            foreach (var variable in fields)
            {
                variable.Read(file, size);
            }
        }

        public override void Write(BinaryWriter file)
        {
            foreach (var variable in fields)
            {
                variable.Write(file);
            }
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var copy = base.Copy(context) as CMatrix4x4;

            for (int i = 0; i < fields.Length; i++)
            {
                (copy.fields[i] as CFloat).val = (fields[i] as CFloat).val;
            }

            return copy;
        }

        public override CVariable SetValue(object val)
        {
            if (val is CMatrix4x4 v)
                this.fields = v.fields;

            return this;
        }

        public override string ToString()
        {
            var builder = new StringBuilder().Append(fields.Length);

            if (fields.Length > 0)
            {
                builder.Append(":");

                foreach (var element in fields)
                {
                    builder.Append(" <").Append(element.ToString()).Append(">");

                    if (builder.Length > 100)
                    {
                        builder.Remove(100, builder.Length - 100);
                        break;
                    }
                }
            }

            return builder.ToString();
        }
    }
}