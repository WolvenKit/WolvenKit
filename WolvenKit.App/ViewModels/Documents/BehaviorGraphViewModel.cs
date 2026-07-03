using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using Splat;
using WolvenKit.App.Controllers;
using WolvenKit.App.Factories;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Behavior;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

public class BehaviorTabDefinition
{
    public string Header { get; set; } = string.Empty;

    public string Icon { get; set; } = string.Empty;

    public Func<ChunkViewModel, bool> Filter { get; set; } = _ => false;
}

public partial class BehaviorGraphViewModel : RedDocumentTabViewModel, IDisposable
{
    private bool _disposed;
    private readonly AIbehaviorResource _behaviorData;
    private readonly ILoggerService? _logger = Locator.Current.GetService<ILoggerService>();

    public RDTDataViewModel RDTViewModel { get; }

    public RedGraph MainGraph { get; }

    public ObservableCollection<BehaviorTabDefinition> Tabs { get; } = new();

    public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.MainFile;

    public string FileName => Path.GetFileNameWithoutExtension(Parent?.Header ?? "Unknown");

    public int TotalNodes => MainGraph.Nodes.Count;

    public int TotalArguments => _behaviorData.Arguments?.Args?.Count ?? 0;

    public int TotalFsmNodes => MainGraph.Nodes.OfType<BehaviorNodeViewModel>().Count(x => x.Data is AIbehaviorFSMTreeNodeDefinition);

    public int TotalSubtrees => MainGraph.Nodes.OfType<BehaviorNodeViewModel>().Count(x => x.Data is AIbehaviorNestedTreeDefinition);

    [ObservableProperty]
    private BehaviorTabDefinition? _selectedTab;

    [ObservableProperty]
    private object? _selectedTabContent;

    [ObservableProperty]
    private bool _isGraphLoading = true;

    public BehaviorGraphViewModel(AIbehaviorResource data, RedDocumentViewModel parent, IChunkViewmodelFactory chunkViewmodelFactory)
        : base(parent, "Behavior Editor")
    {
        _behaviorData = data;

        var appViewModel = Locator.Current.GetService<AppViewModel>() ?? throw new ArgumentNullException(nameof(AppViewModel));
        var settingsManager = Locator.Current.GetService<ISettingsManager>() ?? throw new ArgumentNullException(nameof(ISettingsManager));
        var gameController = Locator.Current.GetService<IGameControllerFactory>() ?? throw new ArgumentNullException(nameof(IGameControllerFactory));

        RDTViewModel = new RDTDataViewModel(data, parent, appViewModel, chunkViewmodelFactory, settingsManager, gameController);
        MainGraph = RedGraph.GenerateBehaviorGraph(parent.Header, data, parent);

        CreateTabs();
        SelectedTab = Tabs.FirstOrDefault();

        if (SelectedTab != null)
        {
            UpdateTabContent(SelectedTab);
        }
    }

    public void SetGraphLoaded()
    {
        IsGraphLoading = false;
    }

    private void CreateTabs()
    {
        Tabs.Add(new BehaviorTabDefinition
        {
            Header = "Node Properties",
            Icon = "SitemapOutline",
            Filter = chunk => chunk.Name == "root"
        });

        Tabs.Add(new BehaviorTabDefinition
        {
            Header = "Arguments",
            Icon = "FormatListBulleted",
            Filter = chunk => chunk.Name == "arguments"
        });

        Tabs.Add(new BehaviorTabDefinition
        {
            Header = "Setup",
            Icon = "CogOutline",
            Filter = chunk => chunk.Name == "delegate" || chunk.Name == "initializationEvents"
        });
    }

    private void UpdateTabContent(BehaviorTabDefinition tab)
    {
        var rootChunk = RDTViewModel.GetRootChunk();
        if (rootChunk == null)
        {
            _logger?.Warning($"[PANEL] No root chunk found for tab '{tab.Header}'");
            SelectedTabContent = null;
            return;
        }

        if (!rootChunk.TVProperties.Any())
        {
            rootChunk.CalculateProperties();
        }

        foreach (var cvm in rootChunk.TVProperties)
        {
            if (tab.Filter(cvm))
            {
                cvm.CalculateProperties();
            }
        }

        SelectedTabContent = new List<ChunkViewModel>(rootChunk.TVProperties.Where(c => tab.Filter(c)));
    }

    partial void OnSelectedTabChanged(BehaviorTabDefinition? value)
    {
        if (value == null)
        {
            return;
        }

        UpdateTabContent(value);
    }

    public override void Unload()
    {
        Dispose();
        base.Unload();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed && disposing)
        {
            MainGraph.Dispose();
            _disposed = true;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
