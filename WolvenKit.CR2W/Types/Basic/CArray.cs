using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CArray : CVariable, IEnumerable<CVariable>
    {
        public List<CVariable> array = new List<CVariable>();

        [DataMember(EmitDefaultValue = false)]
        public string elementtype;

        [DataMember(EmitDefaultValue = false)]
        public bool fixedTypeArray;

        [DataMember(EmitDefaultValue = false)]
        public string type;     //vl: mimics CVariable type??

        public CArray(CR2WFile cr2w) : base(cr2w)
        {
        }

        public CArray(string type, CR2WFile cr2w)
            : base(cr2w)
        {
            this.type = type;

            var reg = new Regex(@"(\d+),(\d+),(.+)");
            var match = reg.Match(type);
            if (match.Success)
            {
                elementtype = match.Groups[3].Value;
            }

            //if (elementtype == "")
            //    Debugger.Break();
        }

        public CArray(string type, string elementtype, bool fixedTypeArray, CR2WFile cr2w) : base(cr2w)
        {
            this.type = type;
            this.elementtype = elementtype;
            this.fixedTypeArray = fixedTypeArray;
            //if (elementtype == "")
            //    Debugger.Break();
        }

        public virtual IEnumerator<CVariable> GetEnumerator()
        {
            return array.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override void Read(BinaryReader file, uint size)
        {
            var count = file.ReadUInt32();

            for (var i = 0; i < count; i++)
            {
                var var = CR2WTypeManager.Get().GetByName(elementtype, i.ToString(), cr2w, false);
                if (var == null)
                    var = new CVector(cr2w);
                var.Read(file, (size - 4)/count);

                //var.Name = i.ToString();
                //var.Type = elementtype;

                AddVariable(var);
            }
        }

        public override void Write(BinaryWriter file)
        {
            file.Write((uint) array.Count);
            for (var i = 0; i < array.Count; i++)
            {
                array[i].Write(file);
            }
        }

        public override CVariable SetValue(object val)
        {
            array.Clear();

            if (val is IEnumerable<CVariable>)
            {
                var e = (IEnumerable<CVariable>) val;
                foreach (var item in e)
                {
                    AddVariable(item);
                }
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CArray(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CArray) base.Copy(context);
            var.type = type;
            var.elementtype = elementtype;

            foreach (var item in array)
            {
                var.AddVariable(item.Copy(context));
            }
            return var;
        }

        public override Control GetEditor()
        {
            return null;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return array.Cast<IEditableVariable>().ToList();
        }

        public override bool CanRemoveVariable(IEditableVariable child)
        {
            if (child is CVariable)
            {
                var v = (CVariable) child;
                return array.Contains(v);
            }

            return false;
        }

        public override bool CanAddVariable(IEditableVariable newvar)
        {
            return newvar == null || newvar is CVariable;
        }

        public override void AddVariable(CVariable v)
        {
            array.Add(v);
            v.ParentVariable = this;

            if (fixedTypeArray)
            {
                Type = "[" + array.Count + "]" + elementtype;
            }
        }

        public override void RemoveVariable(IEditableVariable child)
        {
            if (child is CVariable)
            {
                var v = (CVariable) child;
                array.Remove(v);
                v.ParentVariable = null;

                if (fixedTypeArray)
                {
                    Type = "[" + array.Count + "]" + elementtype;
                }
            }
        }

        public override string ToString()
        {
            return "";
        }

        public override void SerializeToXml(XmlWriter xw)
        {
            DataContractSerializer ser = new DataContractSerializer(this.GetType());
            using (var ms = new MemoryStream())
            {
                ser.WriteStartObject(xw, this);
                ser.WriteObjectContent(xw, this);
            }

            if (GetEditableVariables() != null)
            {
                xw.WriteStartElement("array");
                foreach (CVariable v in GetEditableVariables())
                {
                    v.SerializeToXml(xw);
                }
                xw.WriteEndElement();
            }
            ser.WriteEndObject(xw);
        }
    }
}