using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Data;
using WolvenKit.App.Controllers;
using WolvenKit.App.Factories;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;
using Splat;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;
using WolvenKit.Core.Extensions;
using System.IO;

namespace WolvenKit.App.ViewModels.Documents
{
    public partial class QuestPhaseGraphViewModel : RedDocumentTabViewModel, IDisposable
    {
        private bool _disposed = false;
        private readonly ILoggerService? _logger = Locator.Current.GetService<ILoggerService>();
        private readonly questQuestPhaseResource _questPhaseData;

        public RDTDataViewModel RDTViewModel { get; }
        public RedGraph MainGraph { get; }
        public ObservableCollection<QuestPhaseTabDefinition> Tabs { get; } = new();
        
        // Navigation history for nested graphs
        public ObservableCollection<RedGraph> History { get; } = new();

        [ObservableProperty]
        private QuestPhaseTabDefinition? _selectedTab;

        [ObservableProperty]
        private object? _selectedTabContent;

        [ObservableProperty]
        private bool _isGraphLoading = true;

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.MainFile;

        // Quest phase statistics properties
        public string FileName => Path.GetFileNameWithoutExtension(Parent?.Header ?? "Unknown");
        
        public int TotalNodes => CalculateTotalNodes();
        
        public int TotalPhaseNodes => CalculatePhaseNodes();
        
        public int TotalPhasePrefabs => _questPhaseData.PhasePrefabs?.Count ?? 0;
        
        public int TotalInplacePhases => _questPhaseData.InplacePhases?.Count ?? 0;

        public QuestPhaseGraphViewModel(questQuestPhaseResource data, RedDocumentViewModel parent, IChunkViewmodelFactory chunkViewmodelFactory, INodeWrapperFactory nodeWrapperFactory)
            : base(parent, "Quest Phase Editor")
        {
            _questPhaseData = data;
            
            var appViewModel = Locator.Current.GetService<AppViewModel>() ?? throw new ArgumentNullException(nameof(AppViewModel));
            var settingsManager = Locator.Current.GetService<ISettingsManager>() ?? throw new ArgumentNullException(nameof(ISettingsManager));
            var gameController = Locator.Current.GetService<IGameControllerFactory>() ?? throw new ArgumentNullException(nameof(IGameControllerFactory));

            RDTViewModel = new RDTDataViewModel(data, parent, appViewModel, chunkViewmodelFactory, settingsManager, gameController);
            
            // Create MainGraph - handle cases where graph might be null
            try
            {
                if (data.Graph?.Chunk != null)
                {
                    MainGraph = RedGraph.GenerateQuestGraph(parent.Header, data.Graph.Chunk, nodeWrapperFactory);
                    
                    // Set document reference for property change syncing
                    MainGraph.DocumentViewModel = parent;

                    // Ensure all nodes have DocumentViewModel reference for dirty tracking
                    foreach (var node in MainGraph.Nodes)
                    {
                        node.DocumentViewModel = parent;
                    }
                }
                else
                {
                    _logger?.Warning($"Quest phase file '{parent.Header}' has no graph data. Creating empty graph.");
                    // Create an empty graph as fallback
                    MainGraph = new RedGraph(parent.Header, data);
                    MainGraph.DocumentViewModel = parent;
                }
            }
            catch (Exception ex)
            {
                _logger?.Error($"Failed to create quest phase graph for '{parent.Header}': {ex.Message}");
                // Create an empty graph as fallback
                MainGraph = new RedGraph(parent.Header, data);
                MainGraph.DocumentViewModel = parent;
            }

            // Initialize navigation history with the main graph
            History.Add(MainGraph);
            
            CreateTabs();
            
            // Set the first tab as selected
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
            // Create tab definitions for quest phase
            Tabs.Add(new QuestPhaseTabDefinition
            {
                Header = "Node Properties",
                Icon = "SitemapOutline",
                Filter = CollectionViewHelper.CreateQuestNodePropertiesFilter()
            });

            Tabs.Add(new QuestPhaseTabDefinition
            {
                Header = "Phase Resources",
                Icon = "PackageVariantClosed",
                Filter = CollectionViewHelper.CreateQuestPhaseResourcesFilter()
            });
        }

        private void UpdateTabContent(QuestPhaseTabDefinition tab)
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

            var list = new List<ChunkViewModel>(rootChunk.TVProperties.Where(c => tab.Filter(c)));
            SelectedTabContent = list;
        }

        private int CalculateTotalNodes()
        {
            int total = _questPhaseData.Graph?.Chunk?.Nodes?.Count ?? 0;
            
            // Add nodes from phase prefabs (nested graphs)
            if (_questPhaseData.PhasePrefabs != null)
            {
                foreach (var phasePrefab in _questPhaseData.PhasePrefabs)
                {
                    // Count nodes in nested phase graphs
                    total += CountNodesInPhaseGraph(phasePrefab);
                }
            }

            // Count nodes in phase nodes within the graph
            if (_questPhaseData.Graph?.Chunk?.Nodes != null)
            {
                foreach (var nodeHandle in _questPhaseData.Graph.Chunk.Nodes)
                {
                    if (nodeHandle.Chunk is questPhaseNodeDefinition phaseNode)
                    {
                        // Count nodes in phase graphs
                        if (phaseNode.PhaseGraph?.Chunk != null)
                        {
                            total += phaseNode.PhaseGraph.Chunk.Nodes?.Count ?? 0;
                        }

                        // Count nodes in phase instance prefabs
                        if (phaseNode.PhaseInstancePrefabs != null)
                        {
                            foreach (var instancePrefab in phaseNode.PhaseInstancePrefabs)
                            {
                                total += CountNodesInPrefab(instancePrefab);
                            }
                        }
                    }
                }
            }
            
            return total;
        }

        private int CalculatePhaseNodes()
        {
            int total = 0;
            
            // Count phase nodes in the main graph
            if (_questPhaseData.Graph?.Chunk?.Nodes != null)
            {
                total += _questPhaseData.Graph.Chunk.Nodes.Count(
                    nodeHandle => nodeHandle.Chunk is questPhaseNodeDefinition);
            }
            
            return total;
        }

        private int CountNodesInPhaseGraph(questQuestPrefabEntry phasePrefab)
        {
            // Count nodes in phase prefabs - this is a simplified implementation
            // In a full implementation, we might need to load the referenced resource
            return 0;
        }

        private int CountNodesInPrefab(questQuestPrefabEntry prefab)
        {
            // Count nodes in prefabs - this is a simplified implementation
            // In a full implementation, we might need to load the referenced resource
            return 0;
        }

        partial void OnSelectedTabChanged(QuestPhaseTabDefinition? value)
        {
            if (value == null) return;
            UpdateTabContent(value);
        }

        // Override Unload to ensure disposal when tab is closed
        public override void Unload()
        {
            Dispose();
            base.Unload();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~QuestPhaseGraphViewModel()
        {
            Dispose(false);
        }
    }
} 