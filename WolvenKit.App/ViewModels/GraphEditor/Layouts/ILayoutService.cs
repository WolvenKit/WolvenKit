using System.Collections.Generic;
using System.Windows;

namespace WolvenKit.App.ViewModels.GraphEditor;

public interface ILayoutService
{
    Rect ArrangeNodes(double xOffset = 0, double yOffset = 0);
    void CenterOnSelectedNodes(IList<object> nodes);
    void FitToScreen(System.Windows.Rect rect);
}