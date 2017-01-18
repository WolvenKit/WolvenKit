using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.CR2W.Types
{
    public class CLocalizedString : CVariable
    {
        public UInt32 val { get; set; }

        public String Text
        {
            get
            {
                var text = cr2w.GetLocalizedString(val);
                if (text != null)
                    return text;
                return val.ToString();
            }
        }

        public CLocalizedString(CR2WFile cr2w)
            : base(cr2w)
        {
            if (cr2w != null)
            {
                cr2w.LocalizedStrings.Add(this);
            }
        }

        public override void Read(BinaryReader file, UInt32 size)
        {
            val = file.ReadUInt32();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is UInt32)
            {
                this.val = (UInt32)val;
            }
            else if (val is int)
            {
                this.val = (UInt32)(int)val;
            }
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CLocalizedString(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CLocalizedString)base.Copy(context);
            var.val = val;
            return var;
        }

        public override System.Windows.Forms.Control GetEditor()
        {
            var editor = new System.Windows.Forms.TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
