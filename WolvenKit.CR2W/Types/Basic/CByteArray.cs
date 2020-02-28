using System.IO;
using System.Windows.Forms;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class CByteArray : CVariable, IByteSource
    {
        public CByteArray(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        public byte[] Bytes { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            var arraysize = file.ReadUInt32();
            Bytes = file.ReadBytes((int) arraysize);
        }

        public override void Write(BinaryWriter file)
        {
            file.Write((uint) Bytes.Length);
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
            return new CByteArray(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CByteArray) base.Copy(context);
            var newbytes = new byte[Bytes.Length];
            Bytes.CopyTo(newbytes, 0);
            var.Bytes = newbytes;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new ByteArrayEditor();
            editor.Variable = this;
            return editor;
        }

        public override string ToString()
        {
            return Bytes.Length + " bytes";
        }
    }
}