using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class CVLQArray : CVariable, IEnumerable<CVariable>
    {
        public List<CVariable> array = new List<CVariable>();
        public string elementtype;
        public bool fixedTypeArray;
        public string type;

        public CVLQArray(CR2WFile cr2w) : base(cr2w)
        {
        }

        public CVLQArray(string type, CR2WFile cr2w)
            : base(cr2w)
        {
            this.type = type;

            var reg = new Regex(@"(\d+),(\d+),(.+)");
            var match = reg.Match(type);
            if (match.Success)
            {
                elementtype = match.Groups[3].Value;
            }

            if (elementtype == "")
                Debugger.Break();
        }

        public CVLQArray(string type, string elementtype, bool fixedTypeArray, CR2WFile cr2w) : base(cr2w)
        {
            this.type = type;
            this.elementtype = elementtype;
            this.fixedTypeArray = fixedTypeArray;
            if (elementtype == "")
                Debugger.Break();
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
            var count = file.ReadBit6();

            for (var i = 0; i < count; i++)
            {
                var var = CR2WTypeManager.Get().GetByName(elementtype, i.ToString(), cr2w, false);
                if (var == null)
                    throw new NotImplementedException();
                var.Read(file, size);

                AddVariable(var);
            }
        }

        public override void Write(BinaryWriter file)
        {
            file.WriteBit6((int) array.Count);
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

        public static new CVariable Create(CR2WFile cr2w)
        {
            return new CVLQArray(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CVLQArray) base.Copy(context);
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
        }

        public override void RemoveVariable(IEditableVariable child)
        {
            if (child is CVariable)
            {
                var v = (CVariable) child;
                array.Remove(v);
                v.ParentVariable = null;
            }
        }

        public override string ToString()
        {
            return "";
        }
    }
}