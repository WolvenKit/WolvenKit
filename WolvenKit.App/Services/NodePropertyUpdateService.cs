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
        /// Fire the event to notify that a node's properties have been updated
        /// </summary>
        /// <param name="nodeData">The node data that was updated</param>
        public static void NotifyPropertyUpdated(RedBaseClass nodeData)
        {
            NodePropertyUpdated?.Invoke(null, new NodePropertyUpdatedEventArgs(nodeData));
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
} 