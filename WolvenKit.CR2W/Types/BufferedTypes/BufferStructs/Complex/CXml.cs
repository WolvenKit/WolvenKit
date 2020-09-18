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
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class CXml : CVariable
    {
        public CXml(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        private byte[] backingfield;
        public XDocument Data
        {
            get
            {
                if (backingfield == null || (backingfield != null && backingfield.Length <= 0)) return new XDocument();
                using (var ms = new MemoryStream(backingfield))
                {
                    return new XDocument(XDocument.Load(ms));
                }
            }
            set => backingfield = Encoding.ASCII.GetBytes(value.ToString());
        }


        public override void Read(BinaryReader file, uint size)
        {
            var len = file.ReadInt32();
            backingfield = file.ReadBytes(len);
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(backingfield.Length);
            file.Write(backingfield);
        }

        public override CVariable SetValue(object val)
        {
            switch (val)
            {
                case XDocument document:
                    Data = document;
                    break;
                case CXml cvar:
                    this.Data = cvar.Data;
                    break;
            }

            return this;
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CXml) base.Copy(context);
            var.backingfield = backingfield;
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

        //public override void SerializeToXml(XmlWriter xw)
        //{
        //    DataContractSerializer ser = new DataContractSerializer(this.GetType());
        //    using (var ms = new MemoryStream())
        //    {
        //        ser.WriteStartObject(xw, this);
        //        ser.WriteObjectContent(xw, this);
        //        xw.WriteStartElement("XMLData");
        //        Data.Save(xw);
        //        xw.WriteEndElement();
        //        ser.WriteEndObject(xw);
        //    }

        //}
    }
}
