using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Models.Nodify;

public partial class ReferenceSocket : ObservableObject, INodeSocket<INode>
{
    public INode? Node { get; set; }

    [ObservableProperty] private ResourcePath _file;

    [ObservableProperty] private string _property = "";

    [ObservableProperty] private System.Windows.Point _anchor;

    [ObservableProperty] private bool _isConnected;

    [ObservableProperty] private string _type = "";

    public ReferenceSocket(ResourcePath file, string property = "", string type = "")
    {
        _file = file;
        _property = property;
        _type = type;
    }
}
