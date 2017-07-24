using System;
using System.Drawing;
using System.Windows.Forms;
using Cyotek.Windows.Forms;

namespace WolvenKit.CR2W.Types
{
    class CColorShift : CVector
    {
        public HslColor Color = new HslColor(System.Drawing.Color.Black);

        public CColorShift(CR2WFile cr2w) : base(cr2w) {  }


        public override CVariable Create(CR2WFile cr2w)
        {
            return new CColorShift(cr2w);
        }

        public override CVariable SetValue(object val)
        {
            if (val is Color)
            {
                Color = (Color)val;
            }
            return this;
        }

        public override Control GetEditor()
        {
            var panel = new Panel();
            if (((CUInt16) this.GetVariableByName("hue")) != null)
                Color.H = ((CUInt16) this.GetVariableByName("hue")).val / 360;
            else
                Color.H = 0;
            if (((CInt8) this.GetVariableByName("saturation")) != null)
                Color.S = ((CInt8) this.GetVariableByName("saturation")).val / 100;
            else
                Color.S = 0;
            if (((CInt8) this.GetVariableByName("luminance")) != null)
                Color.L = ((CInt8) this.GetVariableByName("luminance")).val / 100;
            else
                Color.L = 0;
            panel.BackColor = Color;
            panel.Click += panel_Click;
            panel.Height = 18;
            return panel;
        }

        private void panel_Click(object sender, EventArgs e)
        {
            var dlg = new Form();
            dlg.Controls.Add(new ColorEditor()
            {
                Dock = DockStyle.Fill
            });
            ((ColorEditor)dlg.Controls[0]).HslColor = Color;
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                Color = ((ColorEditor)dlg.Controls[0]).HslColor;
                if (((CUInt16)this.GetVariableByName("hue")) == null)
                    cr2w.CreateVariable(this, "CUInt16", "hue");
                ((CUInt16)this.GetVariableByName("hue")).val = (ushort)(Color.H * 360);
                if (((CInt8)this.GetVariableByName("saturation")) == null)
                    cr2w.CreateVariable(this, "CInt8", "saturation");
                ((CInt8)this.GetVariableByName("saturation")).val = (sbyte)(Color.S * 100);
                if (((CInt8)this.GetVariableByName("luminance")) == null)
                    cr2w.CreateVariable(this, "CInt8", "luminance");
                ((CInt8)this.GetVariableByName("luminance")).val = (sbyte)(Color.L * 100);
            }
            ((Panel)sender).BackColor = Color.ToRgbColor();
        }
    }
}
