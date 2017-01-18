using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.CR2W.Types
{
    public class CString : CVariable
    {
        public string val { get; set; }
        public bool isUTF = false;

        public CString(CR2WFile cr2w)
            : base(cr2w)
        {

        }

        public override void Read(BinaryReader file, UInt32 size)
        {
            var len = (int) file.ReadByte();

            if (len >= 128)
            {
                len = len - 128;
                if (len >= 64)
                {
                    len = len - 64;
                    len = (int)file.ReadByte() * 64 + len;
                }

                val = Encoding.Default.GetString(file.ReadBytes(len));
            }
            else
            {
                isUTF = true;

                if (len >= 64)
                {
                    len = len - 64;
                    len = (int)file.ReadByte() * 64 + len;
                }
                len = len * 2;
                val = Encoding.Unicode.GetString(file.ReadBytes(len));
            }
        }

        public bool RequiresUTF()
        {
            foreach(var c in val)
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

            var secondByte = (int)(val.Length / 64);
            var firstByte = val.Length - (secondByte * 64);
            if (!isUTF)
                firstByte += 128;

            if (secondByte > 0)
                firstByte += 64;

            file.Write((byte)firstByte);
            if (secondByte > 0)
                file.Write((byte)secondByte);

            if (isUTF)
            {
                var bytearray = Encoding.Unicode.GetBytes(val);
                file.Write(bytearray);
            }
            else
            {
                var bytearray = Encoding.Default.GetBytes(val);
                file.Write(bytearray);
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
            return new CString(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CString)base.Copy(context);
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
