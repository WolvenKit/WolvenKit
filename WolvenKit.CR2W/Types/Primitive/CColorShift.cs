using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta()]
    public class CColorShift : CVariable
    {
        [Ordinal(1)] [RED("hue")] public CUInt16 Hue { get; set; }

        [Ordinal(2)] [RED("saturation")] public CInt8 Saturation { get; set; }

        [Ordinal(3)] [RED("luminance")] public CInt8 Luminance { get; set; }



        public HslColor Color = new HslColor(0, 0, 0);

        public CColorShift(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }


        public override void Read(BinaryReader file, uint size) => base.Read(file, size);

        public override void Write(BinaryWriter file) => base.Write(file);

        public override CVariable SetValue(object val)
        {
            switch (val)
            {
                case Color o:
                    Color = HslColor.FromRgb(o);
                    break;
                case CColorShift cvar:
                    Color = cvar.Color;
                    break;
            }

            return this;
        }
    }
}
