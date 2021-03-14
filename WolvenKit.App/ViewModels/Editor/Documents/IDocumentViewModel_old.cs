namespace WolvenKit.ViewModels.Editor
{
    /// <summary>
    /// Represents a viewmodel
    /// </summary>
    public interface Old_IDocumentViewModel/* : INotifyPropertyChanged, INotifyPropertyChanging*/
    {
        #region Properties

        string FileName { get; }

        object SaveTarget { get; set; }

        string Title { get; }

        #endregion Properties

        #region Methods

        void Close();

        void SaveFile();

        #endregion Methods
    }
}
