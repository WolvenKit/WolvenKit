using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;
using Point = System.Windows.Point;

namespace WolvenKit.App.ViewModels.GraphEditor;

public abstract partial class NodeViewModel : ObservableObject, IDisposable
{
    private readonly ILoggerService? _logger = Locator.Current.GetService<ILoggerService>();
    
    public abstract uint UniqueId { get; }

    [ObservableProperty]
    private Point _location;

    public Size Size { get; set; }

    public string Title { get; protected set; } = null!;
    
    /// <summary>
    /// The node ID for display outside the node
    /// </summary>
    public string NodeIdText => $"[{UniqueId}]";
    
    private Dictionary<string, string> _details = new();
    public Dictionary<string, string> Details 
    { 
        get => _details;
        protected set
        {
            if (_details != value)
            {
                _details = value;
                OnPropertyChanged(nameof(Details));
            }
        }
    }

    public ObservableCollection<InputConnectorViewModel> Input { get; } = new();
    public ObservableCollection<OutputConnectorViewModel> Output { get; } = new();

    public RedBaseClass Data { get; }
    
    /// <summary>
    /// Reference to the document view model for marking dirty and other operations
    /// </summary>
    public RedDocumentViewModel? DocumentViewModel { get; set; }

    /// <summary>
    /// Flag to indicate if this node is being created during initial graph loading
    /// When true, socket changes won't mark the document as dirty
    /// </summary>
    public bool IsInitialLoad { get; set; } = true;

    protected NodeViewModel(RedBaseClass data)
    {
        Data = data;
        
        // Wire up property change notifications for syncing
        if (Data is INotifyPropertyChanged notifyPropertyChanged)
        {
            notifyPropertyChanged.PropertyChanged += DataOnPropertyChanged;
        }
        if (Data is INotifyPropertyChanging notifyPropertyChanging)
        {
            notifyPropertyChanging.PropertyChanging += DataOnPropertyChanging;
        }
        
        // Listen for property updates from the property panel
        NodePropertyUpdateService.NodePropertyUpdated += OnNodePropertyUpdated;
        
        // Centralized auto-subscribe: whenever outputs are added, subscribe to their destinations
        Output.CollectionChanged += OnOutputCollectionChanged;
    }

    protected virtual void DataOnPropertyChanging(object? sender, PropertyChangingEventArgs e)
    {
        // Override in derived classes if pre-change logic is needed
    }

    protected virtual void DataOnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        // Mark document as dirty when any property changes (but not during initial loading)
        if (!IsInitialLoad)
        {
            DocumentViewModel?.SetIsDirty(true);
        }
        
        // Update visual aspects that might be affected by property changes
        UpdateFromPropertyChange(e.PropertyName);
    }
    
    /// <summary>
    /// Called when a property on the underlying data changes to update visual elements
    /// </summary>
    /// <param name="propertyName">Name of the property that changed</param>
    protected virtual void UpdateFromPropertyChange(string? propertyName)
    {
        switch (propertyName)
        {
            case "Name" or "Caption" or "Comment":
                // Update title when common name properties change
                UpdateTitle();
                TriggerPropertyChanged(nameof(Title));
                break;
                
            case "OutputSockets" or "InputSockets":
                // SOCKET SYNC FIX: We no longer regenerate sockets here because:
                // 1. Socket count changes are handled manually in Add*/Remove* methods
                // 2. Destination changes are handled by direct socket subscription 
                // 3. Regenerating here breaks UI connections unnecessarily
                break;
                
            default:
                // For other properties, just refresh the title in case it's derived
                UpdateTitle();
                TriggerPropertyChanged(nameof(Title));
                break;
        }
    }
    
    /// <summary>
    /// Update the node title - override in derived classes for custom title logic
    /// </summary>
    protected virtual void UpdateTitle()
    {
        // Default implementation - derived classes can override
        var typeName = Data.GetType().Name;
        if (typeName.StartsWith("scn"))
            typeName = typeName[3..];
        if (typeName.EndsWith("Node"))
            typeName = typeName[..^4];
            
        Title = typeName;
    }

    /// <summary>
    /// Forces a refresh of the node's visual state from its data
    /// </summary>
    public void UpdateFromData()
    {
        // Update title
        UpdateTitle();
        TriggerPropertyChanged(nameof(Title));
        
        // Regenerate sockets
        GenerateSockets();
        TriggerPropertyChanged(nameof(Output));
        TriggerPropertyChanged(nameof(Input));
        
        // Ensure all output connectors are subscribed for property panel sync
        EnsureSocketSubscriptions();
        
        // Notify other properties that might be affected
        OnPropertyChanged(nameof(Details));
    }

    internal abstract void GenerateSockets();

    /// <summary>
    /// Public method to trigger property change notifications for external synchronization
    /// </summary>
    /// <param name="propertyName">Name of the property that changed</param>
    public void TriggerPropertyChanged(string propertyName)
    {
        OnPropertyChanged(propertyName);

        // Ensure the Node Properties panel reflects the latest socket list
        if (propertyName is nameof(Input) or nameof(Output))
        {
            // Notify that underlying data may have changed to refresh property panel bindings
            OnPropertyChanged(nameof(Data));

            // Mark the document dirty because socket topology changed (but not during initial loading)
            if (!IsInitialLoad)
            {
                DocumentViewModel?.SetIsDirty(true);
            }
        }
    }

    /// <summary>
    /// Triggers property change notifications to sync with the Node Properties panel
    /// and refresh the Graph Editor collections without regenerating connectors.
    /// </summary>
    /// <param name="propertyName">Name of the property that changed on the Data object</param>
    protected void TriggerDataPropertyChanged(string propertyName)
    {
        // Refresh the property panel by notifying that the Data reference changed
        OnPropertyChanged(nameof(Data));
        
        // Refresh the Graph Editor collections for socket-related changes
        if (propertyName is "OutputSockets" or "InputSockets")
        {
            TriggerPropertyChanged(nameof(Output));
            TriggerPropertyChanged(nameof(Input));
        }
    }

    private void OnNodePropertyUpdated(object? sender, NodePropertyUpdatedEventArgs e)
    {
        // Check if this update is for our data
        if (ReferenceEquals(e.NodeData, Data))
        {
            RefreshFromData();
        }
    }
    
    /// <summary>
    /// Refresh the node's visual state from the underlying data
    /// Override in derived classes to update specific visual elements
    /// </summary>
    public virtual void RefreshFromData()
    {
        // Update title
        UpdateTitle();
        OnPropertyChanged(nameof(Title));
        
        // Regenerate sockets
        GenerateSockets();
        OnPropertyChanged(nameof(Output));
        OnPropertyChanged(nameof(Input));
        
        // Ensure all output connectors are subscribed for property panel sync
        EnsureSocketSubscriptions();
        
        // Refresh details if implemented by derived class
        if (this is IRefreshableDetails refreshable)
        {
            refreshable.RefreshDetails();
        }
    }

    #region IDisposable

    private bool _disposedValue;

    ~NodeViewModel() => Dispose(false);

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                // Unhook property change notifications to prevent memory leaks
                if (Data is INotifyPropertyChanged notifyPropertyChanged)
                {
                    notifyPropertyChanged.PropertyChanged -= DataOnPropertyChanged;
                }
                if (Data is INotifyPropertyChanging notifyPropertyChanging)
                {
                    notifyPropertyChanging.PropertyChanging -= DataOnPropertyChanging;
                }
                
                // Unsubscribe from socket destination changes
                foreach (var output in Output.OfType<SceneOutputConnectorViewModel>())
                {
                    if (output.Data?.Destinations is INotifyCollectionChanged notifyCollection)
                    {
                        notifyCollection.CollectionChanged -= OnSocketDestinationsChanged;
                    }
                }
                
                // Unsubscribe from property update service
                NodePropertyUpdateService.NodePropertyUpdated -= OnNodePropertyUpdated;
            }

            _disposedValue = true;
        }
    }

    #endregion IDisposable

    /// <summary>
    /// Subscribes to destination changes on output sockets to update the property panel
    /// without regenerating connectors
    /// </summary>
    protected void SubscribeToSocketDestinations(OutputConnectorViewModel connector)
    {
        if (connector is SceneOutputConnectorViewModel sceneConnector && sceneConnector.Data != null)
        {
            var socket = sceneConnector.Data;
            
            // Check if the destinations collection supports change notifications
            if (socket.Destinations is INotifyCollectionChanged notifyCollection)
            {
                // Unsubscribe first to avoid duplicates
                notifyCollection.CollectionChanged -= OnSocketDestinationsChanged;
                notifyCollection.CollectionChanged += OnSocketDestinationsChanged;
            }
        }
    }

    /// <summary>
    /// Handles destination changes for individual sockets
    /// </summary>
    private void OnSocketDestinationsChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {        
        // Only refresh the property panel, don't regenerate connectors
        OnPropertyChanged(nameof(Data));
        
        // Update UI collections so the Node Properties panel shows connection counts
        TriggerPropertyChanged(nameof(Output));
        
        // Mark document dirty because a connection was added/removed (but not during initial loading)
        if (!IsInitialLoad)
        {
            DocumentViewModel?.SetIsDirty(true);
        }
    }

    /// <summary>
    /// Helper method for dynamic socket operations to notify UI and mark document dirty
    /// </summary>
    protected void NotifySocketsChanged()
    {        
        if (DocumentViewModel != null)
        {
            var sceneGraphTab = DocumentViewModel.TabItemViewModels
                .OfType<SceneGraphViewModel>()
                .FirstOrDefault();
                
            if (sceneGraphTab?.MainGraph is RedGraph graph)
            {
                // Use reflection to call InvalidateConverterCacheForNode (same as destinations)
                var invalidateMethod = graph.GetType().GetMethod("InvalidateConverterCacheForNode", 
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                if (invalidateMethod != null)
                {
                    invalidateMethod.Invoke(graph, new object[] { UniqueId });
                }
            }
        }
        
        if (Data is INotifyPropertyChanged notifyData)
        {
            // Try reflection approach for non-ObservableObject types
            var propertyChangedField = Data.GetType()
                .GetField("PropertyChanged", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            
            if (propertyChangedField?.GetValue(Data) is PropertyChangedEventHandler handler)
            {
                handler.Invoke(Data, new PropertyChangedEventArgs("OutputSockets"));
            }

        }

         
        TriggerPropertyChanged(nameof(Output));
         
        // Only mark dirty if this is not during initial loading
        if (!IsInitialLoad)
        {
            if (DocumentViewModel == null)
            {
                _logger?.Error($"[SYNC] ERROR: DocumentViewModel is NULL on node {UniqueId} ({GetType().Name}) - cannot mark dirty!");
                return;
            }
            DocumentViewModel?.SetIsDirty(true);
        }

    }

    /// <summary>
    /// Handles when output connectors are added/removed to automatically subscribe to destination changes
    /// </summary>
    private void OnOutputCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        if (e.NewItems != null)
        {
            foreach (var item in e.NewItems)
            {
                if (item is SceneOutputConnectorViewModel output)
                {
                    SubscribeToSocketDestinations(output);
                }
            }
        }
    }

    /// <summary>
    /// Ensures all output connectors are subscribed to destination changes
    /// for property panel synchronization
    /// </summary>
    private void EnsureSocketSubscriptions()
    {
        foreach (var output in Output.OfType<SceneOutputConnectorViewModel>())
        {
            SubscribeToSocketDestinations(output);
        }
    }
}