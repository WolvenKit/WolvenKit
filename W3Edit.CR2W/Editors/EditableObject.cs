using System;
using System.Collections.Generic;
using System.Windows.Forms;
using W3Edit.CR2W.Types;

namespace W3Edit.CR2W.Editors
{
    public class EditableObject : IEditableVariable
    {
        public EditableObject(object o, CR2WFile cr2w)
        {
            Name = "";
            Type = "";
            Object = o;
            CR2WOwner = cr2w;
        }

        public object Object { get; set; }
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

        public override string ToString()
        {
            return Object.ToString();
        }
    }
}