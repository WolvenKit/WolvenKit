using System;
using System.CodeDom;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta()]
    public class CBytes : CVariable, IByteSource
    {
        public CBytes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public byte[] Bytes { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            Bytes = file.ReadBytes((int) size);
        }

        public override void Write(BinaryWriter file)
        {
            if (Bytes != null && Bytes.Length != 0)
            {
                file.Write(Bytes);
            }
            else
            {

            }
        }

        public override CVariable SetValue(object val)
        {
            if (val is byte[])
            {
                Bytes = (byte[]) val;
            }
            else if (val is CBytes cvar)
            {
                this.Bytes = cvar.Bytes;
            }

            return this;
        }

        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new CBytes(cr2w, parent, name);
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
            if (Bytes == null)
                Bytes = Array.Empty<byte>();

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

        public override bool RemoveVariable(IEditableVariable child)
        {
            return false;
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

        public override void SerializeToXml(XmlWriter xw)
        {
            DataContractSerializer ser = new DataContractSerializer(this.GetType());
            using (var ms = new MemoryStream())
            {
                ser.WriteStartObject(xw, this);
                ser.WriteObjectContent(xw, this);
                xw.WriteElementString("Length", Bytes.Length.ToString());
                if (Bytes.Length > 0)
                {
                    xw.WriteElementString("Bytes", HexStr(Bytes));
                }
                ser.WriteEndObject(xw);
            }
        }
    }
}