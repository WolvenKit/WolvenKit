using System.Collections.Generic;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

public partial class RDTGraphViewModel2 : RedDocumentTabViewModel
{
    private readonly RedGraphFactory _graphFactory;

    protected readonly IRedType _data;

    [ObservableProperty]
    private RedGraph? _mainGraph;

    public RDTGraphViewModel2(IRedType data, RedDocumentViewModel file, RedGraphFactory graphFactory) : base(file, "Graph View")
    {
        _graphFactory = graphFactory;

        _data = data;

        _mainGraph = null;
    }

    protected override void OnPropertyChanging(PropertyChangingEventArgs e)
    {
        if (MainGraph is null)
        {
            return;
        }

        if (e.PropertyName == nameof(MainGraph))
        {
            History.Clear();
        }

        base.OnPropertyChanging(e);
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        if (MainGraph is null)
        {
            return;
        }

        if (e.PropertyName == nameof(MainGraph))
        {
            History.Add(MainGraph);
        }

        base.OnPropertyChanged(e);
    }

    public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.MainFile;

    public List<RedGraph> History { get; } = new();

    public override void Load()
    {
        this.
        MainGraph?.Dispose();

        var context = new GraphContext(this, Parent);

        MainGraph = _graphFactory.Create(Parent.Header, _data, context);
    }
}

