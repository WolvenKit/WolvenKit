using System.Windows.Media;
using ReactiveUI.Fody.Helpers;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Documents
{
    public class RDTMeshViewModel : RedDocumentTabViewModel
    {
        protected readonly RedBaseClass _data;
        public RedDocumentViewModel File;

        public RDTMeshViewModel(CMesh data, RedDocumentViewModel file)
        {
            Header = "Preview";
            File = file;
            _data = data;

        }

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;

        [Reactive] public ImageSource Image { get; set; }

        [Reactive] public object SelectedItem { get; set; }

    }
}
