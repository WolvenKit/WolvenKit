using System;
using System.Collections.Generic;
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
            IsSerialized = true;
            Value = val switch
            {
                Color color => color,
                CColor ccolor => ccolor.Value,
                _ => throw new ArgumentOutOfRangeException()
            };

            return this;
        }

        public object GetValue() => Value;

        // remove editable sub properties: serialization should have a custom serializer for CColor
        public override List<IEditableVariable> GetEditableVariables() => new();
    }
}
