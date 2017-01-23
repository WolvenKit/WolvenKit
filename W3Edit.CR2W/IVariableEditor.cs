using W3Edit.CR2W.Types;

namespace W3Edit.CR2W
{
    public interface IVariableEditor
    {
        void CreateVariableEditor(CVariable editvar, EVariableEditorAction action);
    }

    public enum EVariableEditorAction
    {
        Open,
        Export,
        Import
    }
}