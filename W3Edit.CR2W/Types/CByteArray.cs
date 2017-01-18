using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using W3Edit.CR2W.Editors;

namespace W3Edit.CR2W.Types
{
    public class CByteArray : CVariable, IByteSource
    {
        private byte[] bytes;

        public byte[] Bytes
        {
            get
            {
                return bytes;
            }
            set
            {
                bytes = value;
            }
        }

        public CByteArray(CR2WFile cr2w)
            : base(cr2w)
        {

        }


        public override void Read(BinaryReader file, UInt32 size)
        {
            var arraysize = file.ReadUInt32();
            bytes = file.ReadBytes((int)arraysize);
        }

        public override void Write(BinaryWriter file)
        {
            file.Write((UInt32)bytes.Length);
            file.Write(bytes);
        }

        public override CVariable SetValue(object val)
        {
            if (val is byte[])
            {
                bytes = (byte[])val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CByteArray(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CByteArray)base.Copy(context);
            var newbytes = new byte[bytes.Length];
            bytes.CopyTo(newbytes, 0);
            var.bytes = newbytes;
            return var;
        }


        public override System.Windows.Forms.Control GetEditor()
        {
            var editor = new ByteArrayEditor();
            editor.Variable = this;
            return editor;
        }

        public override string ToString()
        {
            return bytes.Length.ToString() + " bytes";
        }
    }
}
