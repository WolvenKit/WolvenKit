using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class SVector2D : CVariable
    {
        public CFloat x, y;

        public SVector2D(CR2WFile cr2w = null)
            : base(cr2w)
        {
            x = new CFloat(null) { Name = "x" };
            y = new CFloat(null) { Name = "y" };
        }

        public void Read(BinaryReader file)
        {
            x.val = file.ReadSingle();
            y.val = file.ReadSingle();
        }

        public override void Read(BinaryReader file, uint size)
        {
            x.Read(file, size);
            y.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            x.Write(file);
            y.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            if (val is SVector2D v)
            {
                this.x = v.x;
                this.y = v.y;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SVector2D(cr2w);
        }


        public override string ToString()
        {
            return String.Format(CultureInfo.InvariantCulture, "V2[{0:0.00}, {1:0.00}]", x.val, y.val);
        }
    }
}