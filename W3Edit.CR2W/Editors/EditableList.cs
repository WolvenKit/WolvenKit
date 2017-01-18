using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3Edit.CR2W.Types;

namespace W3Edit.CR2W.Editors
{
    public class EditableList<T> : IEditableVariable 
                        where T : CVariable
    {

        public string Name { get; set; }

        public string Type { get; set; }

        public List<T> List { get; set; }

        private CR2WFile cr2w;

        public CR2WFile CR2WOwner
        {
            get { return cr2w; }
        }

        public EditableList(List<T> list, CR2WFile cr2w)
        {
            Type = "";
            Name = "";
            List = list;
            this.cr2w = cr2w;
        }

        public System.Windows.Forms.Control GetEditor()
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
                List.Add((T)var);

                var.ParentVariable = null;
            }
        }

        public void RemoveVariable(IEditableVariable child)
        {
            if (child is T)
            {
                List.Remove((T)child);
                if(child is CVariable)
                {
                    ((CVariable)child).ParentVariable = null;
                }
            }
        }

        public override string ToString()
        {
            return "";
        }


    }
}
