using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    class CXml : CVariable
    {
        public CXml(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        public XDocument Data { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            var len = file.ReadInt32();
            using (var ms = new MemoryStream(file.ReadBytes(len)))
            {
                Data = new XDocument(XDocument.Load(ms));
            }
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(Data.ToString().Length);
            file.Write(Encoding.ASCII.GetBytes(Data.ToString()));
        }

        public override CVariable SetValue(object val)
        {
            if (val is XDocument)
            {
                Data = (XDocument) val;
            }
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CXml(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CXml) base.Copy(context);
            var.Data = new XDocument(Data);
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new Panel();
            var exportbutton = new Button();
            exportbutton.Text = "Export";
            exportbutton.Click += (sender, args) =>
            {
                using (var sf = new SaveFileDialog()
                {
                    Filter = "XML Files | *.xml",
                    Title = "Select a place to save the xml file!"
                })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        Data.Save(sf.FileName);
                    }
                }
            };
            editor.Controls.Add(exportbutton);
            var importbutton = new Button();
            exportbutton.Text = "Import";
            exportbutton.Click += (sender, args) =>
            {
                using (var of = new OpenFileDialog()
                {
                    Filter = "XML Files | *.xml",
                    Title = "Please select the file you would like to import!"
                })
                {
                    if (of.ShowDialog() == DialogResult.OK)
                    {
                        Data = new XDocument(File.ReadAllText(of.FileName));
                    }
                }
            };
            editor.Controls.Add(exportbutton);
            editor.PerformLayout();
            return editor;
        }

        public override string ToString()
        {
            return Data.ToString().Length + " chars";
        }

        public override void SerializeToXml(XmlWriter xw)
        {
            DataContractSerializer ser = new DataContractSerializer(this.GetType());
            using (var ms = new MemoryStream())
            {
                ser.WriteStartObject(xw, this);
                ser.WriteObjectContent(xw, this);
                xw.WriteStartElement("XMLData");
                Data.Save(xw);
                xw.WriteEndElement();
                ser.WriteEndObject(xw);
            }

        }
    }
}
