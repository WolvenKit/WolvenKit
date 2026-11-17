#nullable enable

using Syncfusion.UI.Xaml.TreeGrid;

namespace WolvenKit.Views.Others;

public class CancellableRowDragDropController : TreeGridRowDragDropController
{
    public void CancelPendingAutoExpand()
    {
        timer?.Stop();
        autoExpandNode = null;
    }
}
