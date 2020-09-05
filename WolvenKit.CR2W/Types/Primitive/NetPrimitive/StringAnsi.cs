using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta()]
    public class StringAnsi : CVariable
    {
        public bool isUTF;

        public StringAnsi(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        public string val { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            var len = (int) file.ReadByte();

            if (len >= 128)
            {
                len = len - 128;
                isUTF = true;
                len = len*2;
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

            if (isUTF || string.IsNullOrEmpty(val))
            {
                len = len + 128;
            }

            file.Write((byte) len);

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
                this.val = (string) val;
            }
            else if (val is StringAnsi cvar)
            {
                this.val = cvar.val;
            }
            return this;
        }

        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new StringAnsi(cr2w, parent, name);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (StringAnsi) base.Copy(context);
            var.val = val;
            var.isUTF = isUTF;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return val;
        }
        public override void SerializeToXml(XmlWriter xw)
        {
            DataContractSerializer ser = new DataContractSerializer(this.GetType());
            using (var ms = new MemoryStream())
            {
                ser.WriteStartObject(xw, this);
                ser.WriteObjectContent(xw, this);
                xw.WriteElementString("val", this.val.Replace("\x00", ""));
                ser.WriteEndObject(xw);
            }
        }
    }
}