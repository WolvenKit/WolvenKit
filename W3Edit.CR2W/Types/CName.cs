using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.CR2W.Types
{
    public class CName : CVariable
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public UInt16 val
        {
            get
            {
                return (UInt16)cr2w.GetStringIndex(Value, true);
            }
            set
            {
                Value = cr2w.strings[value].str;
            }
        }

        public string Value { get; set; }

        public CName(CR2WFile cr2w)
            : base(cr2w)
        {

        }

        public override void Read(BinaryReader file, UInt32 size)
        {
            val = file.ReadUInt16();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is string)
            {
                Value = (string)val;
            }
            else if (val is UInt16)
            {
                this.val = (UInt16)val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CName(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CName)base.Copy(context);
            var.Value = Value;
            return var;
        }

        public override System.Windows.Forms.Control GetEditor()
        {
            var editor = new System.Windows.Forms.TextBox();
            editor.DataBindings.Add("Text", this, "Value");
            return editor;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
