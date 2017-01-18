using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3Edit.CR2W.Editors;

namespace W3Edit.CR2W.Types
{
    public class CVector : CVariable
    {
        public List<CVariable> variables = new List<CVariable>();

        public CVector(CR2WFile cr2w)
            : base(cr2w)
        {

        }

        public override void Read(BinaryReader file, UInt32 size)
        {
            var zero = file.ReadByte();

            while (true)
            {
                var var = cr2w.ReadVariable(file);
                if (var == null)
                    break;
                AddVariable(var);
            }
        }

        public override void Write(BinaryWriter file)
        {
            file.Write((byte)0);
            for (int i = 0; i < variables.Count; i++)
            {
                cr2w.WriteVariable(file, variables[i]);
            }
            file.Write((UInt16)0);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CVector(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var obj = (CVector)base.Copy(context);
            foreach (var item in variables)
            {
                if (context.ShouldCopy(item))
                {
                    obj.AddVariable(item.Copy(context));
                }
            }
            return obj;
        }

        public override System.Windows.Forms.Control GetEditor()
        {
            return null;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return variables.Cast<IEditableVariable>().ToList();
        }

        public override bool CanRemoveVariable(IEditableVariable child)
        {
            if (child is CVariable)
            {
                var v = (CVariable)child;
                return variables.Contains(v);
            }

            return false;
        }

        public override bool CanAddVariable(IEditableVariable newvar)
        {
            return newvar == null || newvar is CVariable;
        }

        public override void AddVariable(CVariable var)
        {
            variables.Add(var);
            var.ParentVariable = this;
        }

        public override void RemoveVariable(IEditableVariable child)
        {
            if (child is CVariable)
            {
                var v = (CVariable)child;
                variables.Remove(v);
                v.ParentVariable = null;
            }
        }

        public override string ToString()
        {
            return "";
        }
    }
}
