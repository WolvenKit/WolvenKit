#nullable enable
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using GraphNodeViewModel = WolvenKit.App.ViewModels.GraphEditor.NodeViewModel;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaktionslogik für NodePropertiesView.xaml
    /// </summary>
    public partial class NodePropertiesView : UserControl
    {
        private RedDocumentViewModel? _documentViewModel;

        public GraphNodeViewModel? SelectedNode
        {
            get => (GraphNodeViewModel?)GetValue(SelectedNodeProperty);
            private set => SetValue(SelectedNodeProperty, value);
        }

        public static readonly DependencyProperty SelectedNodeProperty =
            DependencyProperty.Register(nameof(SelectedNode), typeof(GraphNodeViewModel), typeof(NodePropertiesView));

        public NodePropertiesSelectionService? PropertySelection
        {
            get => (NodePropertiesSelectionService?)GetValue(PropertySelectionProperty);
            private set => SetValue(PropertySelectionProperty, value);
        }

        public static readonly DependencyProperty PropertySelectionProperty =
            DependencyProperty.Register(nameof(PropertySelection), typeof(NodePropertiesSelectionService), typeof(NodePropertiesView));

        public NodePropertiesView()
        {
            InitializeComponent();
            
            Loaded += OnLoaded;
            Unloaded += OnUnloaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            _documentViewModel = FindDocumentViewModel(this);
            NodePropertyUpdateService.PropertyPanelRefreshRequested += OnPropertyPanelRefreshRequested;
            NodePropertyUpdateService.EventSelectionRequested += OnEventSelectionRequested;
            NodeSelectionService.Instance.SelectionChanged += OnSelectionChanged;
            UpdateSelectedNode();
        }

        private void OnSelectionChanged(object? sender, EventArgs e) => UpdateSelectedNode();

        private void UpdateSelectedNode()
        {
            if (_documentViewModel is null)
            {
                return;
            }

            var selectedNode = NodeSelectionService.Instance.GetSelectedNode(_documentViewModel);
            if (ReferenceEquals(SelectedNode, selectedNode))
            {
                return;
            }

            PropertySelection?.ClearSelection();
            SetCurrentValue(SelectedNodeProperty, selectedNode);
            SetCurrentValue(
                PropertySelectionProperty,
                selectedNode is null ? null : NodePropertiesSelectionService.ForData(selectedNode.Data));
        }

        private static RedDocumentViewModel? FindDocumentViewModel(DependencyObject element)
        {
            for (var current = element; current is not null; current = GetParent(current))
            {
                if (current is FrameworkElement { DataContext: RedDocumentTabViewModel tabViewModel })
                {
                    return tabViewModel.Parent;
                }
            }

            return null;
        }

        private static DependencyObject? GetParent(DependencyObject element)
        {
            var parent = VisualTreeHelper.GetParent(element);
            if (parent is not null)
            {
                return parent;
            }

            return element is FrameworkElement frameworkElement ? frameworkElement.Parent : null;
        }
        
        private void OnPropertyPanelRefreshRequested(object? sender, EventArgs e)
        {
            var selectedNode = SelectedNode;
            if (selectedNode is not null &&
                ReferenceEquals(NodeSelectionService.Instance.SelectedNode?.DocumentViewModel, _documentViewModel))
            {
                PropertySelection?.ClearSelection();
                selectedNode.TriggerPropertyChanged(nameof(selectedNode.Data));
            }
        }
        
        private void OnEventSelectionRequested(object? sender, EventSelectionRequestedEventArgs e)
        {
            if (!ReferenceEquals(NodeSelectionService.Instance.SelectedNode?.DocumentViewModel, _documentViewModel))
            {
                return;
            }

            // Find the "events" property in the property panel and select the specific event
            var selectedProperty = PropertySelection?.SelectedProperty;
            if (selectedProperty == null)
            {
                // Try to find events from the root
                var rootProperties = FindName("PropertyTree") as ItemsControl;
                if (rootProperties?.ItemsSource is System.Collections.IEnumerable items)
                {
                    foreach (var item in items)
                    {
                        if (item is ChunkViewModel rootChunk)
                        {
                            SelectEventAtIndex(rootChunk, e.EventIndex);
                            return;
                        }
                    }
                }
                return;
            }
            
            // Find the root chunk and navigate to events
            var current = selectedProperty;
            while (current?.Parent != null)
            {
                current = current.Parent;
            }
            
            if (current != null)
            {
                SelectEventAtIndex(current, e.EventIndex);
            }
        }
        
        private void SelectEventAtIndex(ChunkViewModel rootChunk, int eventIndex)
        {
            try
            {
                // Ensure properties are calculated
                rootChunk.CalculateProperties();
                rootChunk.IsExpanded = true;
                
                // Find the "events" property
                var eventsProperty = rootChunk.TVProperties?.FirstOrDefault(p => 
                    p.Name.Equals("events", StringComparison.OrdinalIgnoreCase));
                
                if (eventsProperty == null)
                {
                    return;
                }
                
                // Expand the events array
                eventsProperty.CalculateProperties();
                eventsProperty.IsExpanded = true;
                
                // Find the specific event by index
                if (eventsProperty.TVProperties != null && eventIndex < eventsProperty.TVProperties.Count)
                {
                    var eventChunk = eventsProperty.TVProperties[eventIndex];
                    eventChunk.CalculateProperties();
                    eventChunk.IsExpanded = true;
                    
                    // Select this event in the property panel
                    if (PropertySelection is not null)
                    {
                        PropertySelection.SelectedProperty = eventChunk;
                    }
                }
            }
            catch (Exception)
            {
                // Silently handle any errors during selection
            }
        }
        
        private void OnUnloaded(object sender, System.Windows.RoutedEventArgs e)
        {
            NodeSelectionService.Instance.SelectionChanged -= OnSelectionChanged;
            NodePropertyUpdateService.PropertyPanelRefreshRequested -= OnPropertyPanelRefreshRequested;
            NodePropertyUpdateService.EventSelectionRequested -= OnEventSelectionRequested;
            _documentViewModel = null;
        }
    }
}
