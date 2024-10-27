using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Interfaces;


public interface IGraphFactory
{
    RedGraph? Create(string title, IRedType resource, GraphContext context);
}
