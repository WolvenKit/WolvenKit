using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Null;

public class NullGraphFactory(ILoggerService log)
{
    public RedGraph Create(string title, GraphContext context)
    {
        var data = new GraphData(title, context);
        return new RedGraph(
            data,
            new NullGraphService(),
            log
        );
    }
}