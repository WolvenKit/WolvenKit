using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class CVector : CVariable
    {
        public List<CVariable> variables = new List<CVariable>();

        public CVector(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        public override void Read(BinaryReader file, uint size)
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
            file.Write((byte) 0);
            for (var i = 0; i < variables.Count; i++)
            {
                CR2WFile.WriteVariable(file, variables[i]);
            }
            file.Write((ushort) 0);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CVector(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var obj = (CVector) base.Copy(context);
            foreach (var item in variables)
            {
                if (context.ShouldCopy(item))
                {
                    obj.AddVariable(item.Copy(context));
                }
            }
            return obj;
        }

        public override Control GetEditor()
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
                var v = (CVariable) child;
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
                var v = (CVariable) child;
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