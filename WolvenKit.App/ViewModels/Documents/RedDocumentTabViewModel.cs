using System.Collections.Generic;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Documents
{
    public abstract class RedDocumentTabViewModel : ReactiveObject
    {
        public abstract ERedDocumentItemType DocumentItemType { get; }
        public string Header { get; set; }
        public string FilePath { get; set; }

        [Reactive] public bool CanClose { get; set; }

        //[Reactive] public RedDocumentViewModel File { get; set; }

        public static IRedType CopiedChunk;

        public static List<IRedType> CopiedChunks = new();

        public RedDocumentTabViewModel()
        {

        }

    }
}
