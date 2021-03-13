using System.ComponentModel;
using System.Drawing;
using System.Runtime.Serialization;
using CP77.CR2W.Reflection;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;

namespace CP77.CR2W.Types
{
    [Editor(typeof(IColorEditor), typeof(IPropertyEditorBase))]
    [REDMeta()]
    public class CColor : CColor_, IREDColor
    {
        public CColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Red = new CUInt8(cr2w, this, nameof(Red));
            Green = new CUInt8(cr2w, this, nameof(Green));
            Blue = new CUInt8(cr2w, this, nameof(Blue));
            Alpha = new CUInt8(cr2w, this, nameof(Alpha));
        }

        public Color Value
        {
            get => Color.FromArgb(Alpha.Value, Red.Value, Green.Value, Blue.Value);
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
            Value = val switch
            {
                Color => Value,
                CColor cvar => cvar.Value,
                _ => Value
            };

            return this;
        }

        
    }
}
