using System.ComponentModel;
using System.Drawing;
using System.Runtime.Serialization;
using WolvenKit.RED4.CR2W.Reflection;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta()]
    public class CColor : CColor_, IREDColor
    {
        public CColor(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

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
