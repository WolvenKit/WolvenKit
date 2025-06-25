using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;
using Point = System.Windows.Point;

namespace WolvenKit.App.ViewModels.GraphEditor;

public abstract partial class NodeViewModel : ObservableObject, IDisposable
{
    public abstract uint UniqueId { get; }

    [ObservableProperty]
    private Point _location;

    public Size Size { get; set; }

    public string Title { get; protected set; } = null!;
    
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
    }

    protected virtual void DataOnPropertyChanging(object? sender, PropertyChangingEventArgs e)
    {
        // Override in derived classes if pre-change logic is needed
    }

    protected virtual void DataOnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        // Mark document as dirty when any property changes
        DocumentViewModel?.SetIsDirty(true);
        
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
                // Regenerate sockets when socket arrays change
                GenerateSockets();
                TriggerPropertyChanged(nameof(Output));
                TriggerPropertyChanged(nameof(Input));
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
            
        Title = $"[{UniqueId}] {typeName}";
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
    }

    private void OnNodePropertyUpdated(object? sender, NodePropertyUpdatedEventArgs e)
    {
        var logger = Locator.Current.GetService<ILoggerService>();
        
        // Check if this update is for our data
        if (ReferenceEquals(e.NodeData, Data))
        {
            logger?.Info($"Node {UniqueId} received property update notification - refreshing visual state");
            // Refresh our visual state
            RefreshFromData();
        }
        else
        {
            logger?.Debug($"Node {UniqueId} received property update notification but data doesn't match (event data: {e.NodeData.GetHashCode()}, our data: {Data.GetHashCode()})");
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
                
                // Unsubscribe from property update service
                NodePropertyUpdateService.NodePropertyUpdated -= OnNodePropertyUpdated;
            }

            _disposedValue = true;
        }
    }

    #endregion IDisposable
}