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
    public class CMatrix3x3 : CVariable
    {
        public CVariable[] fields;
        public CFloat ax, ay, az, bx, by, bz, cx, cy, cz;

        public CMatrix3x3(CR2WFile cr2w) : base(cr2w)
        {
            Type = typeof(CMatrix3x3).Name;

            fields = new CVariable[] {
                ax = new CFloat(cr2w) { Name = "ax", Type = "Float" },
                ay = new CFloat(cr2w) { Name = "ay", Type = "Float" },
                az = new CFloat(cr2w) { Name = "az", Type = "Float" },
                bx = new CFloat(cr2w) { Name = "bx", Type = "Float" },
                by = new CFloat(cr2w) { Name = "by", Type = "Float" },
                bz = new CFloat(cr2w) { Name = "bz", Type = "Float" },
                cx = new CFloat(cr2w) { Name = "cx", Type = "Float" },
                cy = new CFloat(cr2w) { Name = "cy", Type = "Float" },
                cz = new CFloat(cr2w) { Name = "cz", Type = "Float" },
            };
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CMatrix3x3(cr2w);
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
            var copy = base.Copy(context) as CMatrix3x3;

            for (int i = 0; i < fields.Length; i++)
            {
                (copy.fields[i] as CFloat).val = (fields[i] as CFloat).val;
            }

            return copy;
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