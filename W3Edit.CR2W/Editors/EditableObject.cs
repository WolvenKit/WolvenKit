using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.CR2W.Editors
{
    public class EditableObject : IEditableVariable
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public object Object { get; set; }

        private CR2WFile cr2w;

        public CR2WFile CR2WOwner
        {
            get { return cr2w; }
        }

        public EditableObject(object o, CR2WFile cr2w)
        {
            Name = "";
            Type = "";
            Object = o;
            this.cr2w = cr2w;
        }

        public override string ToString()
        {
            return Object.ToString();
        }

        public System.Windows.Forms.Control GetEditor()
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

        public void AddVariable(Types.CVariable var)
        {
            throw new NotImplementedException();
        }

        public void RemoveVariable(IEditableVariable child)
        {
            throw new NotImplementedException();
        }
    }
}
