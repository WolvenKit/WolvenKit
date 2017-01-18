using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.CR2W.Types
{
    public class CStringAnsi : CVariable
    {
        public string val { get; set; }
        public bool isUTF;

        public CStringAnsi(CR2WFile cr2w)
            : base(cr2w)
        {

        }

        public override void Read(BinaryReader file, UInt32 size)
        {
            var len = (int)file.ReadByte();

            if (len >= 128)
            {
                len = len - 128;
                isUTF = true;
                len = len * 2;
            }

            if (isUTF)
            {
                val = Encoding.Unicode.GetString(file.ReadBytes(len));                
            }
            else
            {
                val = Encoding.Default.GetString(file.ReadBytes(len)); 
            }
        }

        public bool RequiresUTF()
        {
            foreach (var c in val)
            {
                if (c > 255)
                    return true;
            }
            return false;
        }

        public override void Write(BinaryWriter file)
        {
            isUTF = RequiresUTF();

            var len = val.Length;

            if (isUTF)
            {
                len = len + 128;
            }

            file.Write((byte)len);

            if (isUTF)
            {
                file.Write(Encoding.Unicode.GetBytes(val));
            }
            else
            {
                file.Write(Encoding.Default.GetBytes(val));
            }
        }

        public override CVariable SetValue(object val)
        {
            if (val is string)
            {
                this.val = (string)val;
            }
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CStringAnsi(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CStringAnsi)base.Copy(context);
            var.val = val;
            var.isUTF = isUTF;
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
            return val;
        }
    }
}
