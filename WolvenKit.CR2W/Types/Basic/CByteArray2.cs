using System.IO;
using System.Windows.Forms;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class CByteArray2 : CVariable, IByteSource
    {
        public CByteArray2(CR2WFile cr2w)
            : base(cr2w)
        {
            Type = typeof(CByteArray2).Name;
        }

        public byte[] Bytes { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            var arraysize = file.ReadUInt32();
            Bytes = file.ReadBytes((int) arraysize - 4);
        }

        public override void Write(BinaryWriter file)
        {
            file.Write((uint) Bytes.Length + 4);
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
            return new CByteArray2(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CByteArray2) base.Copy(context);
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