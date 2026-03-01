#nullable enable
using System;
using System.Linq;
using System.Windows.Controls;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaktionslogik für NodePropertiesView.xaml
    /// </summary>
    public partial class NodePropertiesView : UserControl
    {
        public NodePropertiesView()
        {
            InitializeComponent();
            
            // Subscribe to property panel refresh requests (e.g., from timeline editor)
            NodePropertyUpdateService.PropertyPanelRefreshRequested += OnPropertyPanelRefreshRequested;
            NodePropertyUpdateService.EventSelectionRequested += OnEventSelectionRequested;
            Unloaded += OnUnloaded;
        }
        
        private void OnPropertyPanelRefreshRequested(object? sender, EventArgs e)
        {
            // Trigger a re-evaluation of the property panel by notifying the selection service
            // This causes the binding converter to re-create ChunkViewModels with fresh data
            var selectedNode = NodeSelectionService.Instance.SelectedNode;
            if (selectedNode != null)
            {
                // Temporarily clear and restore selection to force binding refresh
                NodeSelectionService.Instance.SelectedNode = null;
                NodeSelectionService.Instance.SelectedNode = selectedNode;
            }
        }
        
        private void OnEventSelectionRequested(object? sender, EventSelectionRequestedEventArgs e)
        {
            // Find the "events" property in the property panel and select the specific event
            var selectedProperty = NodePropertiesSelectionService.Instance.SelectedProperty;
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
                    return;
                
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
                    NodePropertiesSelectionService.Instance.SelectedProperty = eventChunk;
                }
            }
            catch (Exception)
            {
                // Silently handle any errors during selection
            }
        }
        
        private void OnUnloaded(object sender, System.Windows.RoutedEventArgs e)
        {
            NodePropertyUpdateService.PropertyPanelRefreshRequested -= OnPropertyPanelRefreshRequested;
            NodePropertyUpdateService.EventSelectionRequested -= OnEventSelectionRequested;
        }
    }
}