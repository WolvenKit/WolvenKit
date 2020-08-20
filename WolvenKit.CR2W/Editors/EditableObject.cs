using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W.Editors
{
    [DataContract(Namespace = "")]
    public class EditableObject : IEditableVariable
    {
        public EditableObject(object o, CR2WFile cr2w)
        {
            Name = "";
            Type = "";
            Object = o;
            CR2WOwner = cr2w;
        }

        [DataMember]
        public object Object { get; set; }
        [DataMember]
        public string Name { get; set; }
        public string Type { get; set; }
        public CR2WFile CR2WOwner { get; }

        public Control GetEditor()
        {
            return null;
        }

        public List<IEditableVariable> GetEditableVariables()
        {
            return null;
        }

        public bool CanRemoveVariable(IEditableVariable child)
        {
            return false;
        }

        public bool CanAddVariable(IEditableVariable newvar)
        {
            return false;
        }

        public void AddVariable(CVariable var)
        {
            throw new NotImplementedException();
        }

        public void RemoveVariable(IEditableVariable child)
        {
            throw new NotImplementedException();
        }

        public CVariable CreateDefaultVariable()
        {
            return null;
        }

        public override string ToString()
        {
            return Object.ToString();
        }

        public virtual void SerializeToXml(XmlWriter xw)
        {
            DataContractSerializer ser = new DataContractSerializer(this.GetType());
            using (var ms = new MemoryStream())
            {
                ser.WriteStartObject(xw, this);
                ser.WriteObjectContent(xw, this);

                if (GetEditableVariables() != null)
                {
                    foreach (var v in GetEditableVariables())
                    {
                        v.SerializeToXml(xw);
                    }
                }
                ser.WriteEndObject(xw);
            }
        }
    }
}