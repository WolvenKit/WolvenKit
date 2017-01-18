using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3Edit.CR2W.Types;

namespace W3Edit.CR2W.Editors
{
    public interface IEditableVariable
    {
        string Name { get; set; }
        string Type { get; set; }
        Control GetEditor();
        List<IEditableVariable> GetEditableVariables();

        bool CanRemoveVariable(IEditableVariable child);
        bool CanAddVariable(IEditableVariable newvar);
        void AddVariable(CVariable var);
        void RemoveVariable(IEditableVariable child);

        CR2WFile CR2WOwner { get; }
    }
}
