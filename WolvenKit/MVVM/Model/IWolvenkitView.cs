using WolvenKit.MVVM.ViewModels.Shell.Editor.Documents;

namespace WolvenKit.MVVM.Model
{
    /// <summary>
    /// A CR2W Form
    /// </summary>
    public interface IWolvenkitView
    {
        #region Properties

        string FileName { get; }

        #endregion Properties



        #region Methods

        void Activate();

        void Close();

        Old_IDocumentViewModel GetViewModel();

        #endregion Methods
    }
}
