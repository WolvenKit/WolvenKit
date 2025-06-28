using System.ComponentModel;
using System.Runtime.CompilerServices;
using WolvenKit.App.ViewModels.GraphEditor;

namespace WolvenKit.App.Services
{
    /// <summary>
    /// Singleton service for managing node selection state across the application
    /// </summary>
    public class NodeSelectionService : INodeSelectionService
    {
        private static NodeSelectionService? _instance;
        private NodeViewModel? _selectedNode;

        public static NodeSelectionService Instance => _instance ??= new NodeSelectionService();

        public NodeViewModel? SelectedNode
        {
            get => _selectedNode;
            set
            {
                if (_selectedNode != value)
                {
                    _selectedNode = value;
                    
                    // Clear the properties selection when node changes to prevent 
                    // properties from previous node persisting in the panel
                    NodePropertiesSelectionService.Instance.ClearSelection();
                    
                    OnPropertyChanged();
                }
            }
        }

        public void ClearSelection()
        {
            SelectedNode = null;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
} 