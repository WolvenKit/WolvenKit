using System;
using System.Drawing;
using System.Windows.Forms;

namespace WolvenKit.CR2W.Types
{
    class CColorShift : CVector
    {
        public HslColor Color = new HslColor(0,0,0);

        public CColorShift(CR2WFile cr2w) : base(cr2w) {  }


        public override CVariable Create(CR2WFile cr2w)
        {
            return new CColorShift(cr2w);
        }

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
            if (((CUInt16) this.GetVariableByName("hue")) != null)
                Color.SetHue(((CUInt16) this.GetVariableByName("hue")).val);
            else
                Color.Hue = 0;
            if (((CInt8) this.GetVariableByName("saturation")) != null)
                Color.SetSaturation(((CInt8) this.GetVariableByName("saturation")).val);
            else
                Color.Saturation = 0;
            if (((CInt8) this.GetVariableByName("luminance")) != null)
                Color.SetLuminosity(((CInt8) this.GetVariableByName("luminance")).val);
            else
                Color.Luminosity = 0;
            panel.BackColor = Color.ToRgb();
            panel.Click += panel_Click;
            panel.Height = 18;
            return panel;
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
                    if (((CUInt16)this.GetVariableByName("hue")) != null)
                        ((CUInt16)this.GetVariableByName("hue")).val = (ushort)Color.GetHue();
                    if (((CInt8)this.GetVariableByName("saturation")) != null)
                        ((CInt8)this.GetVariableByName("saturation")).val = (sbyte)Color.GetSaturation();
                    if (((CInt8)this.GetVariableByName("luminance")) != null)
                        ((CInt8)this.GetVariableByName("luminance")).val = (sbyte)Color.GetLuminosity();
                }
                ((Panel)sender).BackColor = Color.ToRgb();
            }
        }
    }
}
