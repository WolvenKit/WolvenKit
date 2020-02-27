using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W
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