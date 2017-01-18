using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.CR2W.Types
{
    public class CFloat : CVariable
    {
        public float val { get; set; }

        public CFloat(CR2WFile cr2w)
            : base(cr2w)
        {

        }

        public override void Read(BinaryReader file, UInt32 size)
        {
            val = file.ReadSingle();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is float)
            {
                this.val = (float)val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CFloat(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CFloat)base.Copy(context);
            var.val = val;
            return var;
        }

        public override System.Windows.Forms.Control GetEditor()
        {
            var editor = new System.Windows.Forms.TextBox();
            editor.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            editor.DataBindings.Add("Text", this, "val");
            //editor.Dock = System.Windows.Forms.DockStyle.Fill;
            //editor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            return editor;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }
}
