using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using W3Edit.CR2W.Editors;

namespace W3Edit.CR2W.Types
{
    public class CArray : CVariable, IEnumerable<CVariable>
    {
        public List<CVariable> array = new List<CVariable>();
        public string type;
        public string elementtype;
        public bool fixedTypeArray;

        public CArray(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        public CArray(string type, CR2WFile cr2w)
            : base(cr2w)
        {
            this.type = type;

            Regex reg = new Regex(@"(\d+),(\d+),(.+)");
            Match match = reg.Match(type);
            if(match.Success) {
                this.elementtype = match.Groups[3].Value;
            }

            if (elementtype == "")
                System.Diagnostics.Debugger.Break();
        }

        public CArray(string type, string elementtype, bool fixedTypeArray, CR2WFile cr2w)
            : base(cr2w)
        {
            this.type = type;
            this.elementtype = elementtype;
            this.fixedTypeArray = fixedTypeArray;
            if (elementtype == "")
                System.Diagnostics.Debugger.Break();
        }

        public override void Read(BinaryReader file, UInt32 size)
        {
            var count = file.ReadUInt32();

            for (int i = 0; i < count; i++)
            {
                var var = CR2WTypeManager.Get().GetByName(elementtype, i.ToString(), cr2w, false);
                if(var == null)
                    var = new CVector(cr2w);
                var.Read(file, 0);

                AddVariable(var);
            }
        }

        public override void Write(BinaryWriter file)
        {
            file.Write((UInt32)array.Count);
            for (int i = 0; i < array.Count; i++)
            {
                array[i].Write(file);
            }
        }

        public override CVariable SetValue(object val)
        {
            array.Clear();

            if(val is IEnumerable<CVariable>)
            {
                var e = (IEnumerable<CVariable>)val;
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
            var var = (CArray)base.Copy(context);
            var.type = type;
            var.elementtype = elementtype;

            foreach(var item in array)
            {
                 var.AddVariable(item.Copy(context));
            }
            return var;
        }

        public override System.Windows.Forms.Control GetEditor()
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
                var v = (CVariable)child;
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
                var v = (CVariable)child;
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

        public virtual IEnumerator<CVariable> GetEnumerator()
        {
            return array.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
