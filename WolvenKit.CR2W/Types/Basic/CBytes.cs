using System;
using System.IO;
using System.Windows.Forms;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class CBytes : CVariable, IByteSource
    {
        public CBytes(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        public byte[] Bytes { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            Bytes = file.ReadBytes((int) size);
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(Bytes);
        }

        public override CVariable SetValue(object val)
        {
            if (val is byte[])
            {
                Bytes = (byte[]) val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CBytes(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CBytes) base.Copy(context);
            var newbytes = new byte[Bytes.Length];
            Bytes.CopyTo(newbytes, 0);
            var.Bytes = newbytes;
            return var;
        }

        public override string ToString()
        {
            return Bytes.Length + " bytes";
        }

        public override Control GetEditor()
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
                var b = (CBytes) var;

                Bytes = new byte[b.Bytes.Length];
                Buffer.BlockCopy(b.Bytes, 0, Bytes, 0, b.Bytes.Length);
            }
        }
    }
}