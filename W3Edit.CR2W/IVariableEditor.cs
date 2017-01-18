using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.CR2W
{
    public interface IVariableEditor
    {
        void CreateVariableEditor(Types.CVariable editvar, EVariableEditorAction action);
    }

    public enum EVariableEditorAction
    {
        Open,
        Export,
        Import
    }
}
