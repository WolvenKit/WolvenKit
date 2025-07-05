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
            
            return total;
        }

        private int CountNodesInPhaseGraph(questQuestPrefabEntry phasePrefab)
        {
            // This would need to be implemented based on how phase prefabs contain nested graphs
            // For now, return 0 - this can be expanded when we understand the phase structure better
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