using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WolvenKit.Views.Editor
{
    public partial class BulkEditorView : INotifyPropertyChanged
    {
        #region Constructors

        public BulkEditorView()
        {
            InitializeComponent();
            NotifyPropertyChanged();
        }

        #endregion Constructors

        #region Events

        public new event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Methods

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion Methods
    }
}
