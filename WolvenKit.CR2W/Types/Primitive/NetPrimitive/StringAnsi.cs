using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta()]
    public class StringAnsi : CVariable
    {
       

        public StringAnsi(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        public string val { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadLengthPrefixedStringNullTerminated();
        }

        public override void Write(BinaryWriter file)
        {
            file.WriteLengthPrefixedStringNullTerminated(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is string)
            {
                this.val = (string) val;
            }
            else if (val is StringAnsi cvar)
            {
                this.val = cvar.val;
            }
            return this;
        }

        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new StringAnsi(cr2w, parent, name);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (StringAnsi) base.Copy(context);
            var.val = val;
            return var;
        }

        

        public override string ToString()
        {
            return val;
        }
        //public override void SerializeToXml(XmlWriter xw)
        //{
        //    DataContractSerializer ser = new DataContractSerializer(this.GetType());
        //    using (var ms = new MemoryStream())
        //    {
        //        ser.WriteStartObject(xw, this);
        //        ser.WriteObjectContent(xw, this);
        //        xw.WriteElementString("val", this.val.Replace("\x00", ""));
        //        ser.WriteEndObject(xw);
        //    }
        //}
    }
}