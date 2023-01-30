using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.Functionality.Interfaces;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Documents
{
    public partial class ReferenceSocket : ObservableObject, INodeSocket<WolvenKit.Functionality.Interfaces.INode>
    {
        public WolvenKit.Functionality.Interfaces.INode? Node { get; set; }

        [ObservableProperty] private CName _file;

        [ObservableProperty] private string _property = "";

        [ObservableProperty] private System.Windows.Point _anchor;

        [ObservableProperty] private bool _isConnected;

        [ObservableProperty] private string _type = "";

        public ReferenceSocket(CName file, string property = "", string type = "")
        {
            _file = file;
            _property = property;
            _type = type;
        }
    }
}
