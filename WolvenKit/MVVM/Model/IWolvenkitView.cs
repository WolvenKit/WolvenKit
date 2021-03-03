using WolvenKit.MVVM.ViewModels.Shell.Editor.Documents;

namespace WolvenKit.MVVM.Model
{
    /// <summary>
    /// A CR2W Form
    /// </summary>
    public interface IWolvenkitView
    {
        string FileName { get; }

        Old_IDocumentViewModel GetViewModel();

        void Close();
        void Activate();
    }
}
