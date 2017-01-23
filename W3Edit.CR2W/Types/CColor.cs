using System;
using System.Drawing;
using System.Windows.Forms;

namespace W3Edit.CR2W.Types
{
    public class CColor : CVector
    {
        public CColor(CR2WFile cr2w) :
            base(cr2w)
        {
        }

        public Color Color
        {
            get { return Color.FromArgb(Alpha, Red, Green, Blue); }
            set
            {
                Red = value.R;
                Green = value.G;
                Blue = value.B;
                Alpha = value.A;
            }
        }

        public byte Red
        {
            get
            {
                var valObj = variables.GetVariableByName("Red");
                if (valObj is CUInt8)
                {
                    var val = (CUInt8) valObj;
                    return val.val;
                }

                return 0;
            }
            set
            {
                var valObj = variables.GetVariableByName("Red");
                if (valObj == null)
                {
                    valObj = cr2w.CreateVariable(this, "Uint8", "Red");
                }

                valObj.SetValue(value);
            }
        }

        public byte Green
        {
            get
            {
                var valObj = variables.GetVariableByName("Green");
                if (valObj is CUInt8)
                {
                    var val = (CUInt8) valObj;
                    return val.val;
                }

                return 0;
            }
            set
            {
                var valObj = variables.GetVariableByName("Green");
                if (valObj == null)
                {
                    valObj = cr2w.CreateVariable(this, "Uint8", "Green");
                }

                valObj.SetValue(value);
            }
        }

        public byte Blue
        {
            get
            {
                var valObj = variables.GetVariableByName("Blue");
                if (valObj is CUInt8)
                {
                    var val = (CUInt8) valObj;
                    return val.val;
                }

                return 0;
            }
            set
            {
                var valObj = variables.GetVariableByName("Blue");
                if (valObj == null)
                {
                    valObj = cr2w.CreateVariable(this, "Uint8", "Blue");
                }

                valObj.SetValue(value);
            }
        }

        public byte Alpha
        {
            get
            {
                var valObj = variables.GetVariableByName("Alpha");
                if (valObj is CUInt8)
                {
                    var val = (CUInt8) valObj;
                    return val.val;
                }

                return 0;
            }
            set
            {
                var valObj = variables.GetVariableByName("Alpha");
                if (valObj == null)
                {
                    valObj = cr2w.CreateVariable(this, "Uint8", "Alpha");
                }

                valObj.SetValue(value);
            }
        }

        public override CVariable SetValue(object val)
        {
            if (val is Color)
            {
                Color = (Color) val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CColor(cr2w);
        }

        public override Control GetEditor()
        {
            var panel = new Panel();
            panel.BackColor = Color.FromArgb(Red, Green, Blue);
            panel.Click += panel_Click;
            panel.Height = 18;
            return panel;
        }

        private void panel_Click(object sender, EventArgs e)
        {
            var dlg = new ColorDialog();
            dlg.Color = Color;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Red = dlg.Color.R;
                Green = dlg.Color.G;
                Blue = dlg.Color.B;

                ((Panel) sender).BackColor = dlg.Color;
            }
        }
    }
}