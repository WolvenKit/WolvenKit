using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class CColorShift : CVariable
    {
        [RED("hue")] public CUInt16 Hue { get; set; }

        [RED("saturation")] public CInt8 Saturation { get; set; }

        [RED("luminance")] public CInt8 Luminance { get; set; }



        public HslColor Color = new HslColor(0, 0, 0);

        public CColorShift(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Hue = new CUInt16(cr2w, this, nameof(Hue));
            Saturation = new CInt8(cr2w, this, nameof(Saturation));
            Luminance = new CInt8(cr2w, this, nameof(Luminance));
        }


        public override void Read(BinaryReader file, uint size) => base.Read(file, size);

        public override void Write(BinaryWriter file) => base.Write(file);

        public override CVariable SetValue(object val)
        {
            if (val is Color)
            {
                Color = HslColor.FromRgb((Color)val);
            }
            return this;
        }

        public override Control GetEditor()
        {
            var panel = new Panel();
            if (Hue != null)
                Color.SetHue(Hue.val);
            else
                Color.Hue = 0;
            if (Saturation != null)
                Color.SetSaturation(Saturation.val);
            else
                Color.Saturation = 0;
            if (Luminance != null)
                Color.SetLuminosity(Luminance.val);
            else
                Color.Luminosity = 0;
            panel.BackColor = Color.ToRgb();
            panel.Click += panel_Click;
            panel.Height = 18;
            return panel;
        }

        public override CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new CColorShift(cr2w, parent, name);
        }

        private void panel_Click(object sender, EventArgs e)
        {
            using (var cd = new ColorDialog())
            {
                cd.Color = Color.ToRgb();
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    Color = HslColor.FromRgb(cd.Color);
                    //TODO: Check if this can cause error! Sometimes the file breaks if we add the missing value. Needs more checks.
                    /*if (((CUInt16)this.GetVariableByName("hue")) == null)
                        cr2w.CreateVariable( "CUInt16", "hue");
                    if (((CInt8)this.GetVariableByName("saturation")) == null)
                        cr2w.CreateVariable("CInt8", "saturation");
                    if (((CInt8)this.GetVariableByName("luminance")) == null)
                        cr2w.CreateVariable("CInt8", "luminance");*/
                    if (Hue != null)
                        Hue.val = (ushort)Color.GetHue();
                    if (Saturation != null)
                        Saturation.val = (sbyte)Color.GetSaturation();
                    if (Luminance != null)
                        Luminance.val = (sbyte)Color.GetLuminosity();
                }
                ((Panel)sender).BackColor = Color.ToRgb();
            }
        }
    }
}
