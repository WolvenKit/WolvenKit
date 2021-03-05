using System.Drawing;
using System.Runtime.Serialization;
using CP77.CR2W.Reflection;

namespace CP77.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta()]
    public class CColor : CColor_
    {
        public CColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Red = new CUInt8(cr2w, this, nameof(Red));
            Green = new CUInt8(cr2w, this, nameof(Green));
            Blue = new CUInt8(cr2w, this, nameof(Blue));
            Alpha = new CUInt8(cr2w, this, nameof(Alpha));
        }

        public Color Color
        {
            get { return Color.FromArgb(Alpha.Value, Red.Value, Green.Value, Blue.Value); }
            set
            {
                Red.Value = value.R;
                Green.Value = value.G;
                Blue.Value = value.B;
                Alpha.Value = value.A;
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
