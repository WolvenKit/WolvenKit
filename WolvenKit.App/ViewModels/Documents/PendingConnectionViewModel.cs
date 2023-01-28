using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.ViewModels.Documents
{
    public partial class PendingConnectionViewModel : ObservableObject
    {
        public PendingConnectionViewModel(RDTGraphViewModel graph) => _graph = graph;


        [ObservableProperty] private RDTGraphViewModel _graph;

        [ObservableProperty] private SocketViewModel? _source;

        [ObservableProperty] private object? _previewTarge;

        [ObservableProperty] private string _previewText = "Drop on connector";

        //protected virtual void OnPreviewTargetChanged()
        //{
        //    bool canConnect = PreviewTarget != null && Graph.Schema.CanAddConnection(Source!, PreviewTarget);
        //    PreviewText = PreviewTarget switch
        //    {
        //        SocketViewModel con when con == Source => $"Can't connect to self",
        //        SocketViewModel con => $"{(canConnect ? "Connect" : "Can't connect")} to {con.Title ?? "pin"}",
        //        NodeViewModel flow => $"{(canConnect ? "Connect" : "Can't connect")} to {flow.Title ?? "node"}",
        //        _ => $"Drop on connector"
        //    };
        //}
    }
}
