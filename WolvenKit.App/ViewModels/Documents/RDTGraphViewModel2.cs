using System;
using System.Collections.Generic;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Factories;
using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

public partial class RDTGraphViewModel2 : RedDocumentTabViewModel
{
    private readonly INodeWrapperFactory _nodeWrapperFactory;

    protected IRedType _data;

    [ObservableProperty]
    private RedGraph _mainGraph;

    public RDTGraphViewModel2(IRedType data, RedDocumentViewModel file, INodeWrapperFactory nodeWrapperFactory) : base(file, "Graph View")
    {
        _nodeWrapperFactory = nodeWrapperFactory;

        _data = data;
        _mainGraph = new RedGraph("ERROR", new RedDummy());
    }

    protected override void OnPropertyChanging(PropertyChangingEventArgs e)
    {
        if (e.PropertyName == nameof(MainGraph))
        {
            History.Clear();
        }

        base.OnPropertyChanging(e);
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(MainGraph))
        {
            History.Add(MainGraph);
        }

        base.OnPropertyChanged(e);
    }

    public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.MainFile;

    public List<RedGraph> History { get; } = new();

    public void UpdateDataAndReload(IRedType newData)
    {
        _data = newData;
        Load();
    }

    public override void Load()
    {
        MainGraph.Dispose();

        RedGraph? mainGraph = null;

        try
        {
            if (_data is graphGraphResource questResource)
            {
                if (questResource.Graph.Chunk is { } questGraph)
                {
                    mainGraph = RedGraph.GenerateQuestGraph(Parent.Header, questGraph, _nodeWrapperFactory);
                }
            }

            if (_data is scnSceneResource sceneResource)
            {
                mainGraph = RedGraph.GenerateSceneGraph(Parent.Header, sceneResource, Parent);
            }
        }
        catch (Exception)
        {
            throw;
        }

        if (mainGraph == null)
        {
            mainGraph = new RedGraph("ERROR", new RedDummy());
        }
        mainGraph.DocumentViewModel = Parent;

        MainGraph = mainGraph;
    }
}