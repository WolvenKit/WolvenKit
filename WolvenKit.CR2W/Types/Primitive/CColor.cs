using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta()]
    public class CColor : CVariable
    {
        [Browsable(false)]
        [Ordinal(1)] [RED] public CUInt8 Red { get; set; }
        [Browsable(false)]
        [Ordinal(2)][RED] public CUInt8 Green { get; set; }
        [Browsable(false)]
        [Ordinal(3)][RED] public CUInt8 Blue { get; set; }
        [Browsable(false)]
        [Ordinal(4)][RED] public CUInt8 Alpha { get; set; }


        public CColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Red = new CUInt8(cr2w, this, nameof(Red));
            Green = new CUInt8(cr2w, this, nameof(Green));
            Blue = new CUInt8(cr2w, this, nameof(Blue));
            Alpha = new CUInt8(cr2w, this, nameof(Alpha));
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
        }

        public Color Color
        {
            get { return Color.FromArgb(Alpha.val, Red.val, Green.val, Blue.val); }
            set
            {
                Red.val = value.R;
                Green.val = value.G;
                Blue.val = value.B;
                Alpha.val = value.A;
            }
        }

        public override CVariable SetValue(object val)
        {
            if (val is Color)
            {
                Color = (Color)val;
            }
            else if (val is CColor cvar)
                Color = cvar.Color;

            return this;
        }
    }
}