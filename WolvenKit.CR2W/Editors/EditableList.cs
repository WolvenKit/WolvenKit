using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W.Editors
{
    public class EditableList<T> : IEditableVariable
        where T : CVariable
    {
        public EditableList(List<T> list, CR2WFile cr2w)
        {
            Type = "";
            Name = "";
            List = list;
            CR2WOwner = cr2w;
        }

        public List<T> List { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public CR2WFile CR2WOwner { get; }

        public Control GetEditor()
        {
            return null;
        }

        public List<IEditableVariable> GetEditableVariables()
        {
            return List.Cast<IEditableVariable>().ToList();
        }

        public bool CanRemoveVariable(IEditableVariable child)
        {
            return List.Contains(child);
        }

        public bool CanAddVariable(IEditableVariable newvar)
        {
            return newvar == null || newvar is T;
        }

        public void AddVariable(CVariable var)
        {
            if (var is T)
            {
                List.Add((T) var);

                var.ParentVariable = null;
            }
        }

        public void RemoveVariable(IEditableVariable child)
        {
            if (child is T)
            {
                List.Remove((T) child);
                if (child is CVariable)
                {
                    ((CVariable) child).ParentVariable = null;
                }
            }
        }

        public CVariable CreateDefaultVariable()
        {
            return null;
        }
        public override string ToString()
        {
            return "";
        }
    }
}