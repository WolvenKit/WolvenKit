using WolvenKit.ViewModels.Documents;

namespace WolvenKit.Model
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
