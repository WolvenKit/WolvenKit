
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WolvenKit.MVVM.Views.Components.Editors
{
    public partial class BulkEditorView : INotifyPropertyChanged
    {
        public BulkEditorView()
        {
            InitializeComponent();
            NotifyPropertyChanged();
        }

        public new event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
