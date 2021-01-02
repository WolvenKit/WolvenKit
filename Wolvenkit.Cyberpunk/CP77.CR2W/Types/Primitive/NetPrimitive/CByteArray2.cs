using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using WolvenKit.Common.Model;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta()]
    public class CByteArray2 : CVariable, IByteSource
    {
        public CByteArray2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        private byte[] Bytes { get; set; }
        public byte[] GetBytes() => Bytes;

        public override void Read(BinaryReader file, uint size)
        {
            var arraysize = file.ReadUInt32();
            Bytes = file.ReadBytes((int) arraysize - 4);
        }

        public override void Write(BinaryWriter file)
        {
            if (Bytes != null && Bytes.Length != 0)
            {
                file.Write((uint)Bytes.Length + 4);
                file.Write(Bytes);
            }
            else
            {

            }
            
        }

        public override CVariable SetValue(object val)
        {
            switch (val)
            {
                case byte[] bytes:
                    Bytes = bytes;
                    break;
                case CByteArray2 cvar:
                    this.Bytes = cvar.Bytes;
                    break;
            }

            return this;
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var copy = (CByteArray2) base.Copy(context);

            if (Bytes == null) return copy;

            var newbytes = new byte[Bytes.Length];
            Bytes.CopyTo(newbytes, 0);
            copy.Bytes = newbytes;

            return copy;
        }

        public override string ToString()
        {
            if (Bytes == null)
                Bytes = Array.Empty<byte>();

            return Bytes.Length + " bytes";
        }
        //public override void SerializeToXml(XmlWriter xw)
        //{
        //    DataContractSerializer ser = new DataContractSerializer(this.GetType());
        //    using (var ms = new MemoryStream())
        //    {
        //        ser.WriteStartObject(xw, this);
        //        ser.WriteObjectContent(xw, this);
        //        xw.WriteElementString("Length", Bytes.Length.ToString());
        //        if (Bytes.Length > 0)
        //        {
        //            xw.WriteElementString("Bytes", HexStr(Bytes));
        //        }
        //        ser.WriteEndObject(xw);
        //    }
        //}

    }
}