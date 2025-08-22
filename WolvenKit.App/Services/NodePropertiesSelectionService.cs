using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.App.Services
{
    /// <summary>
    /// Service for managing property selection within the node properties view
    /// </summary>
    public class NodePropertiesSelectionService : INotifyPropertyChanged
    {
        private static NodePropertiesSelectionService? _instance;
        private ChunkViewModel? _selectedProperty;
        private ObservableCollection<ChunkViewModel> _selectedProperties = new();

        public static NodePropertiesSelectionService Instance => _instance ??= new NodePropertiesSelectionService();

        public ChunkViewModel? SelectedProperty
        {
            get => _selectedProperty;
            set
            {
                if (_selectedProperty != value)
                {
                    _selectedProperty = value;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<ChunkViewModel> SelectedProperties
        {
            get => _selectedProperties;
            set
            {
                if (_selectedProperties != value)
                {
                    _selectedProperties = value;
                    OnPropertyChanged();
                }
            }
        }

        public void ClearSelection()
        {
            SelectedProperty = null;
            SelectedProperties?.Clear();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
} 