using System.ComponentModel;
using WolvenKit.App.ViewModels.GraphEditor;

namespace WolvenKit.App.Services
{
    /// <summary>
    /// Service for managing node selection state across the application
    /// </summary>
    public interface INodeSelectionService : INotifyPropertyChanged
    {
        /// <summary>
        /// Currently selected node in the graph editor
        /// </summary>
        NodeViewModel? SelectedNode { get; set; }

        /// <summary>
        /// Clear the current selection
        /// </summary>
        void ClearSelection();
    }
} 