using System;
using System.Drawing;
using System.Windows.Forms;
using Cyotek.Windows.Forms;

namespace WolvenKit.CR2W.Types
{
    class CColorShift : CVector
    {
        public CColorShift(CR2WFile cr2w) : base(cr2w)
        {

        }
        private HslColor _color = new HslColor(Color.Black);

        public override Control GetEditor()
        {
            _color.H = ((CUInt16)this.GetVariableByName("hue")).val/360;
            _color.S = ((CInt8)this.GetVariableByName("saturation")).val/360;
            _color.L = ((CInt8)this.GetVariableByName("luminance")).val/360;
            var btn = new Button();
            btn.BackColor = _color;
            btn.Text = "Pick color";
            btn.Click += panel_Click;
            btn.Height = 18;
            return btn;
        }

        private void panel_Click(object sender, EventArgs e)
        {
            var dlg = new Form();
            dlg.Controls.Add(new ColorEditor()
            {
                Dock = DockStyle.Fill
            });
            ((ColorEditor)dlg.Controls[0]).HslColor = _color;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _color = ((ColorEditor)dlg.Controls[0]).HslColor;
                ((CUInt16) this.GetVariableByName("hue")).val = (ushort)(_color.H*360);
                ((CInt8) this.GetVariableByName("saturation")).val = (sbyte)(_color.S*360);
                ((CInt8) this.GetVariableByName("luminance")).val = (sbyte)(_color.L*360);
                ((Panel)sender).BackColor = _color.ToRgbColor(); 
            }
        }
    }
}
