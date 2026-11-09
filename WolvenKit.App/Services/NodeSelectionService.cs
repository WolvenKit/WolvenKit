using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WolvenKit.App.ViewModels.Documents;
using GraphNodeViewModel = WolvenKit.App.ViewModels.GraphEditor.NodeViewModel;

namespace WolvenKit.App.Services
{
    /// <summary>
    /// Singleton service for managing node selection state across the application
    /// </summary>
    public class NodeSelectionService : INodeSelectionService
    {
        private static NodeSelectionService? _instance;
        private GraphNodeViewModel? _selectedNode;
        private readonly Dictionary<RedDocumentViewModel, GraphNodeViewModel> _selectedNodesByDocument = new();

        public static NodeSelectionService Instance => _instance ??= new NodeSelectionService();

        public GraphNodeViewModel? SelectedNode
        {
            get => _selectedNode;
            set => SetSelectedNode(value);
        }

        public GraphNodeViewModel? GetSelectedNode(RedDocumentViewModel document) =>
            _selectedNodesByDocument.TryGetValue(document, out var node) ? node : null;

        public void SetSelectedNode(GraphNodeViewModel? node, GraphNodeViewModel? previousNode = null)
        {
            if (node is not null)
            {
                if (node.DocumentViewModel is RedDocumentViewModel document)
                {
                    _selectedNodesByDocument[document] = node;
                    SelectionChanged?.Invoke(this, EventArgs.Empty);
                }

                if (_selectedNode != node)
                {
                    _selectedNode = node;
                    OnPropertyChanged(nameof(SelectedNode));
                }

                return;
            }

            var documentToClear = previousNode?.DocumentViewModel ?? _selectedNode?.DocumentViewModel;
            if (documentToClear is not null)
            {
                _selectedNodesByDocument.Remove(documentToClear);
                SelectionChanged?.Invoke(this, EventArgs.Empty);
            }

            if (previousNode is null || ReferenceEquals(_selectedNode, previousNode) ||
                ReferenceEquals(_selectedNode?.DocumentViewModel, documentToClear))
            {
                if (_selectedNode is not null)
                {
                    _selectedNode = null;
                    OnPropertyChanged(nameof(SelectedNode));
                }
            }
        }

        public void ClearSelectionForDocument(RedDocumentViewModel document)
        {
            var removed = _selectedNodesByDocument.Remove(document);
            if (_selectedNode?.DocumentViewModel == document)
            {
                _selectedNode = null;
                OnPropertyChanged(nameof(SelectedNode));
            }

            if (removed)
            {
                SelectionChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public void ClearSelection() => SetSelectedNode(null);

        public event EventHandler? SelectionChanged;

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
