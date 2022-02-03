using WolvenKit.Common;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.ViewModels.Tools
{
    public class CollectionItemViewModel : ObservableObject
    {
        public string Info =>
            Model switch
            {
                FileEntry fe => fe.Name,
                _ => ""
            };

        public string Name =>
            Model switch
            {
                FileEntry fe => fe.ShortName,
                _ => Model.ToString()
            };

        public CollectionItemViewModel(object model)
        {
            Model = model;
        }

        public object Model { get; set; }
    }
}
