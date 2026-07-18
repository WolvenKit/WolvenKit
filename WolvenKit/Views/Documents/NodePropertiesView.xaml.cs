#nullable enable
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaktionslogik für NodePropertiesView.xaml
    /// </summary>
    public partial class NodePropertiesView : UserControl
    {
        private readonly ISettingsManager _settingsManager;

        public NodePropertiesView()
        {
            InitializeComponent();

            _settingsManager = Locator.Current.GetService<ISettingsManager>() ?? throw new ArgumentNullException(nameof(ISettingsManager));
            _settingsManager.PropertyChanged += OnSettingsPropertyChanged;
            ApplyLayout();
            
            // Subscribe to property panel refresh requests (e.g., from timeline editor)
            NodePropertyUpdateService.PropertyPanelRefreshRequested += OnPropertyPanelRefreshRequested;
            NodePropertyUpdateService.EventSelectionRequested += OnEventSelectionRequested;
            Unloaded += OnUnloaded;
        }

        private void OnSettingsPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ISettingsDto.GraphEditorNodePropertiesLayout))
            {
                ApplyLayout();
            }
        }

        private void ApplyLayout()
        {
            PropertyContentGrid.RowDefinitions.Clear();
            PropertyContentGrid.ColumnDefinitions.Clear();

            if (_settingsManager.GraphEditorNodePropertiesLayout == GraphNodePropertiesLayout.Stacked)
            {
                PropertyContentGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
                PropertyContentGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(6) });
                PropertyContentGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Star) });
                PropertyContentGrid.ColumnDefinitions.Add(new ColumnDefinition());

                Grid.SetRow(PropertyTree, 0);
                Grid.SetColumn(PropertyTree, 0);
                Grid.SetRow(PropertySplitter, 1);
                Grid.SetColumn(PropertySplitter, 0);
                Grid.SetRow(PropertyEditor, 2);
                Grid.SetColumn(PropertyEditor, 0);

                PropertySplitter.SetCurrentValue(HeightProperty, double.NaN);
                PropertySplitter.SetCurrentValue(WidthProperty, double.NaN);
                PropertySplitter.SetCurrentValue(HorizontalAlignmentProperty, HorizontalAlignment.Stretch);
                PropertySplitter.SetCurrentValue(VerticalAlignmentProperty, VerticalAlignment.Stretch);
                PropertySplitter.SetCurrentValue(CursorProperty, Cursors.SizeNS);
                PropertySplitter.SetCurrentValue(IsHitTestVisibleProperty, true);
                PropertySplitter.SetCurrentValue(GridSplitter.ResizeDirectionProperty, GridResizeDirection.Rows);
            }
            else
            {
                PropertyContentGrid.RowDefinitions.Add(new RowDefinition());
                PropertyContentGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(3, GridUnitType.Star) });
                PropertyContentGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(6) });
                PropertyContentGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });

                Grid.SetRow(PropertyTree, 0);
                Grid.SetColumn(PropertyTree, 0);
                Grid.SetRow(PropertySplitter, 0);
                Grid.SetColumn(PropertySplitter, 1);
                Grid.SetRow(PropertyEditor, 0);
                Grid.SetColumn(PropertyEditor, 2);

                PropertySplitter.SetCurrentValue(HeightProperty, double.NaN);
                PropertySplitter.SetCurrentValue(WidthProperty, double.NaN);
                PropertySplitter.SetCurrentValue(HorizontalAlignmentProperty, HorizontalAlignment.Stretch);
                PropertySplitter.SetCurrentValue(VerticalAlignmentProperty, VerticalAlignment.Stretch);
                PropertySplitter.SetCurrentValue(CursorProperty, Cursors.SizeWE);
                PropertySplitter.SetCurrentValue(IsHitTestVisibleProperty, true);
                PropertySplitter.SetCurrentValue(GridSplitter.ResizeDirectionProperty, GridResizeDirection.Columns);
            }
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
            _settingsManager.PropertyChanged -= OnSettingsPropertyChanged;
        }
    }
}
