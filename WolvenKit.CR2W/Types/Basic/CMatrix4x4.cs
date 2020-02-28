using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    class CMatrix4x4 : CVariable
    {
        public CVariable[] fields;
        public CFloat ax, ay, az, aw, bx, by, bz, bw, cx, cy, cz, cw, dx, dy, dz, dw;

        public CMatrix4x4(CR2WFile cr2w) : base(cr2w)
        {
            fields = new CVariable[] {
                ax = new CFloat(cr2w) { Name = "ax", Type = "Float" },
                ay = new CFloat(cr2w) { Name = "ay", Type = "Float" },
                az = new CFloat(cr2w) { Name = "az", Type = "Float" },
                aw = new CFloat(cr2w) { Name = "aw", Type = "Float" },
                bx = new CFloat(cr2w) { Name = "bx", Type = "Float" },
                by = new CFloat(cr2w) { Name = "by", Type = "Float" },
                bz = new CFloat(cr2w) { Name = "bz", Type = "Float" },
                bw = new CFloat(cr2w) { Name = "bw", Type = "Float" },
                cx = new CFloat(cr2w) { Name = "cx", Type = "Float" },
                cy = new CFloat(cr2w) { Name = "cy", Type = "Float" },
                cz = new CFloat(cr2w) { Name = "cz", Type = "Float" },
                cw = new CFloat(cr2w) { Name = "cw", Type = "Float" },
                dx = new CFloat(cr2w) { Name = "dx", Type = "Float" },
                dy = new CFloat(cr2w) { Name = "dy", Type = "Float" },
                dz = new CFloat(cr2w) { Name = "dz", Type = "Float" },
                dw = new CFloat(cr2w) { Name = "dw", Type = "Float" }
            };
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CMatrix4x4(cr2w);
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
    }
}