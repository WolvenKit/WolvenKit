using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace WolvenKit.ViewModels.Documents
{
    public abstract class RedDocumentItemViewModel : ReactiveObject
    {
        public abstract ERedDocumentItemType DocumentItemType { get; }

        public delegate void DirtyDelegate(bool isDirty);
        public DirtyDelegate SetIsDirty { get; set; }

        public RedDocumentItemViewModel()
        {

        }
        
    }
}
