using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using W3Edit.CR2W.Editors;

namespace W3Edit.CR2W.Types
{
    public class CBytes : CVariable, IByteSource
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

        public CBytes(CR2WFile cr2w) 
            : base(cr2w)
        {

        }

        public override void Read(BinaryReader file, UInt32 size)
        {
            bytes = file.ReadBytes((int)size);
        }

        public override void Write(BinaryWriter file)
        {
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
            return new CBytes(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CBytes)base.Copy(context);
            var newbytes = new byte[bytes.Length];
            bytes.CopyTo(newbytes, 0);
            var.bytes = newbytes;
            return var;
        }

        public override string ToString()
        {
            return bytes.Length + " bytes";
        }

        public override System.Windows.Forms.Control GetEditor()
        {
            var editor = new ByteArrayEditor();
            editor.Variable = this;
            return editor;
        }


        public override bool CanRemoveVariable(IEditableVariable child)
        {
            return false;
        }

        public override bool CanAddVariable(IEditableVariable newvar)
        {
            return true;
        }

        public override void RemoveVariable(IEditableVariable child)
        {
        }

        public override void AddVariable(CVariable var)
        {
            if (var is CBytes)
            {
                var b = (CBytes)var;

                bytes = new byte[b.bytes.Length];
                Buffer.BlockCopy(b.bytes, 0, bytes, 0, b.bytes.Length);
            }
        }
    }
}
