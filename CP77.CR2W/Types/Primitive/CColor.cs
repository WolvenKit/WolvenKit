using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows.Media;
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

        private Color _value;
        public SolidColorBrush Value
        {
            get => new SolidColorBrush(_value);
            set => _value = value.Color;
        }

        public override CVariable SetValue(object val)
        {
            switch (val)
            {
                case Color color:
                    _value = color;
                    break;
                case CColor cvar:
                    Value = cvar.Value;
                    break;
            }

            return this;
        }

        
    }
}
