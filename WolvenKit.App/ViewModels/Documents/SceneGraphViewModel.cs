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

namespace WolvenKit.App.ViewModels.Documents
{
    public class SceneTabDefinition
    {
        public string Header { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public Func<ChunkViewModel, bool> Filter { get; set; } = _ => false;
    }

    public partial class SceneGraphViewModel : RedDocumentTabViewModel, IDisposable
    {
        private bool _disposed = false;

        public RDTDataViewModel RDTViewModel { get; }
        public RedGraph MainGraph { get; }
        public ObservableCollection<SceneTabDefinition> Tabs { get; } = new();

        [ObservableProperty]
        private SceneTabDefinition? _selectedTab;

        [ObservableProperty]
        private object? _selectedTabContent;

        [ObservableProperty]
        private bool _isGraphLoading = true;

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.MainFile;

        public SceneGraphViewModel(scnSceneResource data, RedDocumentViewModel parent, IChunkViewmodelFactory chunkViewmodelFactory, INodeWrapperFactory nodeWrapperFactory)
            : base(parent, "Scene Editor")
        {
            var appViewModel = Locator.Current.GetService<AppViewModel>() ?? throw new ArgumentNullException(nameof(AppViewModel));
            var settingsManager = Locator.Current.GetService<ISettingsManager>() ?? throw new ArgumentNullException(nameof(ISettingsManager));
            var gameController = Locator.Current.GetService<IGameControllerFactory>() ?? throw new ArgumentNullException(nameof(IGameControllerFactory));

            RDTViewModel = new RDTDataViewModel(data, parent, appViewModel, chunkViewmodelFactory, settingsManager, gameController);
            MainGraph = RedGraph.GenerateSceneGraph(parent.Header, data);
            
            // Set document reference for property change syncing
            MainGraph.DocumentViewModel = parent;

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
            // Create tab definitions using the CollectionViewHelper filters
            Tabs.Add(new SceneTabDefinition
            {
                Header = "Node Properties",
                Icon = "SitemapOutline",
                Filter = CollectionViewHelper.CreateNodePropertiesFilter()
            });

            Tabs.Add(new SceneTabDefinition
            {
                Header = "Actors & Props",
                Icon = "AccountGroupOutline",
                Filter = CollectionViewHelper.CreateActorsAndPropsFilter()
            });

            Tabs.Add(new SceneTabDefinition
            {
                Header = "Logic & Flow",
                Icon = "ArrowDecisionOutline",
                Filter = CollectionViewHelper.CreateLogicAndFlowFilter()
            });

            Tabs.Add(new SceneTabDefinition
            {
                Header = "Dialogue",
                Icon = "MessageTextOutline",
                Filter = CollectionViewHelper.CreateDialogueFilter()
            });

            Tabs.Add(new SceneTabDefinition
            {
                Header = "Asset Library",
                Icon = "PackageVariantClosed",
                Filter = CollectionViewHelper.CreateAssetLibraryFilter()
            });

            Tabs.Add(new SceneTabDefinition
            {
                Header = "Markers & Metadata",
                Icon = "TagOutline",
                Filter = CollectionViewHelper.CreateMarkersAndMetadataFilter()
            });
        }

        private void UpdateTabContent(SceneTabDefinition tab)
        {
            var rootChunk = RDTViewModel.GetRootChunk();
            if (rootChunk == null)
            {
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

        partial void OnSelectedTabChanged(SceneTabDefinition? value)
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

        ~SceneGraphViewModel()
        {
            Dispose(false);
        }
    }
} 