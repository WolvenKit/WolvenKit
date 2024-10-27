using System;
using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.ViewModels.GraphEditor.Interfaces;
using WolvenKit.App.ViewModels.GraphEditor.Null;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor;

public class RedGraphFactory(IEnumerable<Lazy<IGraphFactory>> factories, NullGraphFactory nullFactory)
{
    public RedGraph Create(string title, IRedType data, GraphContext context)
    {
        foreach (var factory in factories.Select(lazy => lazy.Value))
        {
            var graph = factory.Create(title, data, context);

            if (graph != null)
            {
                return graph;
            }
        }

        return nullFactory.Create(title, context);
    }
}