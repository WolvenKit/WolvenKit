using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CVector3D : CVariable
    {
        public string type = "CVector3D";
        public CFloat x, y, z;

        public CVector3D(CR2WFile cr2w = null)
            : base(cr2w)
        {
            x = new CFloat(null) { Name = "x", Type = "Float" };
            y = new CFloat(null) { Name = "y", Type = "Float" };
            z = new CFloat(null) { Name = "z", Type = "Float" };
        }

        public void Read(BinaryReader file, int compression)
        {
            if (compression == 0)
            {
                x.val = file.ReadSingle();
                y.val = file.ReadSingle();
                z.val = file.ReadSingle();
            }
            else if (compression == 1)
            {
                var bitsx = file.ReadUInt16() << 16 | file.ReadUInt16() << 8;
                var bitsy = file.ReadUInt16() << 16 | file.ReadUInt16() << 8;
                var bitsz = file.ReadUInt16() << 16 | file.ReadUInt16() << 8;
                x.val = BitConverter.ToSingle(BitConverter.GetBytes(bitsx), 0);
                y.val = BitConverter.ToSingle(BitConverter.GetBytes(bitsy), 0);
                z.val = BitConverter.ToSingle(BitConverter.GetBytes(bitsz), 0);
            }
            else if (compression == 2)
            {
                var bitsx = file.ReadUInt16() << 16;
                var bitsy = file.ReadUInt16() << 16;
                var bitsz = file.ReadUInt16() << 16;
                x.val = BitConverter.ToSingle(BitConverter.GetBytes(bitsx), 0);
                y.val = BitConverter.ToSingle(BitConverter.GetBytes(bitsy), 0);
                z.val = BitConverter.ToSingle(BitConverter.GetBytes(bitsz), 0);
            }
        }

        public override void Read(BinaryReader file, uint size)
        {
            x.Read(file, size);
            y.Read(file, size);
            z.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            x.Write(file);
            y.Write(file);
            z.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CVector3D(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CVector3D)base.Copy(context);
            var.type = type;
            var.x.val = x.val;
            var.y.val = y.val;
            var.z.val = z.val;
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var vars = new List<IEditableVariable>();
            vars.Add(x);
            vars.Add(y);
            vars.Add(z);
            return vars;
        }

        public override string ToString()
        {
            return String.Format(CultureInfo.InvariantCulture, "V3[{0:0.00}, {1:0.00}, {2:0.00}]", x.val, y.val, z.val);
        }
    }
}