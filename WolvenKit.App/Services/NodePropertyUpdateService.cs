using System;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Services
{
    /// <summary>
    /// Simple service to notify when node properties are updated in the property panel
    /// </summary>
    public static class NodePropertyUpdateService
    {
        /// <summary>
        /// Event fired when a node's properties are updated in the property panel
        /// </summary>
        public static event EventHandler<NodePropertyUpdatedEventArgs>? NodePropertyUpdated;
        
        /// <summary>
        /// Event fired when the property panel should refresh its displayed values
        /// (e.g., when timeline editor changes event properties)
        /// </summary>
        public static event EventHandler? PropertyPanelRefreshRequested;
        
        /// <summary>
        /// Event fired when an event should be selected in the property panel
        /// </summary>
        public static event EventHandler<EventSelectionRequestedEventArgs>? EventSelectionRequested;
        
        /// <summary>
        /// Fire the event to notify that a node's properties have been updated
        /// </summary>
        /// <param name="nodeData">The node data that was updated</param>
        public static void NotifyPropertyUpdated(RedBaseClass nodeData)
        {
            NodePropertyUpdated?.Invoke(null, new NodePropertyUpdatedEventArgs(nodeData));
        }
        
        /// <summary>
        /// Request the property panel to refresh its displayed values
        /// </summary>
        public static void RequestPropertyPanelRefresh()
        {
            PropertyPanelRefreshRequested?.Invoke(null, EventArgs.Empty);
        }
        
        /// <summary>
        /// Request the property panel to select a specific event by index
        /// </summary>
        /// <param name="eventIndex">0-based index of the event in the events array</param>
        public static void RequestEventSelection(int eventIndex)
        {
            EventSelectionRequested?.Invoke(null, new EventSelectionRequestedEventArgs(eventIndex));
        }
    }
    
    public class NodePropertyUpdatedEventArgs : EventArgs
    {
        public RedBaseClass NodeData { get; }
        
        public NodePropertyUpdatedEventArgs(RedBaseClass nodeData)
        {
            NodeData = nodeData;
        }
    }
    
    public class EventSelectionRequestedEventArgs : EventArgs
    {
        public int EventIndex { get; }
        
        public EventSelectionRequestedEventArgs(int eventIndex)
        {
            EventIndex = eventIndex;
        }
    }
}