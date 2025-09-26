using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;
using Splat;
using WolvenKit.Core.Interfaces;

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

        /// <summary>
        /// Auto-select important properties for specific node types
        /// </summary>
        public void AutoSelectImportantProperty(ChunkViewModel rootChunk)
        {
            if (rootChunk?.ResolvedData == null)
                return;

            try
            {
                if (rootChunk.ResolvedData is questJournalNodeDefinition)
                {
                    var pathProperty = FindPropertyRecursive(rootChunk, "path");
                    if (pathProperty != null)
                    {
                        SelectedProperty = pathProperty;
                        return;
                    }
                }

                if (rootChunk.ResolvedData is questFactsDBManagerNodeDefinition)
                {
                    var typeProperty = FindPropertyRecursive(rootChunk, "type");
                    if (typeProperty != null)
                    {
                        SelectedProperty = typeProperty;
                        return;
                    }
                }

                if (rootChunk.ResolvedData is questConditionNodeDefinition or questPauseConditionNodeDefinition)
                {
                    var typeProperty = FindPropertyRecursive(rootChunk, "type");
                    if (typeProperty != null)
                    {
                        SelectedProperty = typeProperty;
                        return;
                    }
                }

                if (rootChunk.ResolvedData is questUIManagerNodeDefinition or
                    questEnvironmentManagerNodeDefinition or
                    questTimeManagerNodeDefinition)
                {
                    var typeProperty = FindPropertyRecursive(rootChunk, "type");
                    if (typeProperty != null)
                    {
                        SelectedProperty = typeProperty;
                        return;
                    }
                }

                if (rootChunk.ResolvedData is scnQuestNode)
                {
                    try
                    {
                        rootChunk.CalculateProperties();
                    }
                    catch
                    {
                        // Ignore calculation errors
                    }

                    var questNodeProperty = FindPropertyRecursive(rootChunk, "questNode") ??
                                           FindPropertyRecursive(rootChunk, "QuestNode");

                    if (questNodeProperty != null)
                    {
                        AutoSelectImportantProperty(questNodeProperty);
                        return;
                    }
                }


            }
            catch (System.Exception ex)
            {
                Locator.Current.GetService<ILoggerService>()?.Error($"Failed to auto-select property: {ex.Message}");
            }
        }

        /// <summary>
        /// Recursively find a property by name in the chunk hierarchy
        /// </summary>
        private ChunkViewModel? FindPropertyRecursive(ChunkViewModel chunk, string propertyName)
        {
            if (chunk == null)
                return null;

            // Check direct children first
            var directMatch = chunk.TVProperties?.FirstOrDefault(p =>
                p.Name.Equals(propertyName, System.StringComparison.OrdinalIgnoreCase));

            if (directMatch != null)
                return directMatch;

            // If not found, search in children recursively
            if (chunk.TVProperties != null)
            {
                foreach (var child in chunk.TVProperties)
                {
                    // Try to calculate properties if not already done
                    if (child.TVProperties == null || !child.TVProperties.Any())
                    {
                        try
                        {
                            child.CalculateProperties();
                        }
                        catch
                        {
                            // Ignore errors, continue searching
                        }
                    }

                    var recursiveMatch = FindPropertyRecursive(child, propertyName);
                    if (recursiveMatch != null)
                        return recursiveMatch;
                }
            }

            return null;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}