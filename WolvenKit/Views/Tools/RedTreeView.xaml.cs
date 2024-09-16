using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using CommunityToolkit.Mvvm.Input;
using DynamicData.Kernel;
using ReactiveUI;
using Splat;
using Syncfusion.UI.Xaml.TreeView;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Dialogs;
using WolvenKit.Views.Dialogs.Windows;
using Point = System.Windows.Point;
using TreeViewItem = System.Windows.Controls.TreeViewItem;

namespace WolvenKit.Views.Tools
{
    /// <summary>
    /// Interaction logic for RedTreeView.xaml
    /// </summary>
    public partial class RedTreeView : UserControl
    {
        private readonly IModifierViewStateService _modifierViewStateSvc;
        private ILoggerService _loggerService;

        public RedTreeView()
        {
            _modifierViewStateSvc = Locator.Current.GetService<IModifierViewStateService>();
            _loggerService = Locator.Current.GetService<ILoggerService>(); 
            
            InitializeComponent();

            // Listen for the "UpdateFilteredItemsSource" message
            MessageBus.Current.Listen<string>("Command")
                .Where(x => x == "UpdateFilteredItemsSource")
                .Subscribe(_ => UpdateFilteredItemsSource(ItemsSource));

            TreeView.ApplyTemplate();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void UpdateFilteredItemsSource(object value)
        {
            var collectionView = value switch
            {
                IEnumerable<ChunkViewModel> itemsSource => CollectionViewSource.GetDefaultView(itemsSource),
                ICollectionView view => view,
                _ => null
            };

            if (collectionView is not null)
            {
                collectionView.Filter = item => (item as ChunkViewModel)?.IsHiddenByEditorDifficultyLevel != true;
                SetCurrentValue(ItemsSourceProperty, collectionView);
            }



            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ItemsSource)));
        }

        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register(nameof(ItemsSource), typeof(object), typeof(RedTreeView),
                new PropertyMetadata(null, OnItemsSourceChanged));

        private static void OnItemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is RedTreeView redTreeView)
            {
                redTreeView.UpdateFilteredItemsSource(e.NewValue);
            }
        }
        
        public object ItemsSource
        {
            get => GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        /// <summary>Identifies the <see cref="SelectedItem"/> dependency property.</summary>
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register(nameof(SelectedItem), typeof(object), typeof(RedTreeView));

        public object SelectedItem
        {
            get => GetValue(SelectedItemProperty);
            set => SetValue(SelectedItemProperty, value);
        }

        public static readonly DependencyProperty SelectedItemsProperty =
            DependencyProperty.Register(nameof(SelectedItems), typeof(object), typeof(RedTreeView));

        public object SelectedItems
        {
            get => GetValue(SelectedItemsProperty);
            set => SetValue(SelectedItemsProperty, value);
        }

        private void OnSelectionChanged(object sender, Syncfusion.UI.Xaml.TreeView.ItemSelectionChangedEventArgs e)
        {
            foreach (var removedItem in e.RemovedItems)
            {
                if (removedItem is ISelectableTreeViewItemModel selectable)
                {
                    selectable.IsSelected = false;
                }
            }

            foreach (var removedItem in e.AddedItems)
            {
                if (removedItem is ISelectableTreeViewItemModel selectable)
                {
                    selectable.IsSelected = true;
                }

            }
        }

        public async void OnCollapsed(object sender, Syncfusion.UI.Xaml.TreeView.NodeExpandedCollapsedEventArgs e)
        {
            if (e.Node.Level != 0 || e.Node.Content is not ChunkViewModel { ResolvedData: worldStreamingSector })
            {
                return;
            }

            var tt = Locator.Current.GetService<AppViewModel>();

            if (tt.ActiveDocument is not RedDocumentViewModel { SelectedTabItemViewModel: RDTDataViewModel rdtd })
            {
                return;
            }

            var chunk = rdtd.Chunks.First();
            try
            {
                await chunk.Refresh();
            }
            catch (Exception ex) { Locator.Current.GetService<ILoggerService>().Error(ex); }
        }


        // Drag & Drop Functionality

        //private string dropFileLocation;
        //private RedTypeDto dropFile;

        private void SfTreeView_ItemDragStarting(object sender, TreeViewItemDragStartingEventArgs e)
        {
            //var record = e.DraggingNodes[0].Content as ChunkViewModel;
            //if (typeof(CBool).IsAssignableTo(record.Data.GetType()))
            //    e.Cancel = true;
        }

        public bool IsControlBeingHeld => _modifierViewStateSvc.IsCtrlKeyPressed;

        private bool IsAllowDrop(TreeViewItemDragOverEventArgs e)
        {
            if (e.DraggingNodes?[0].Content is not ChunkViewModel source ||
                e.TargetNode?.Content is not ChunkViewModel target ||
                source == target || target.Parent == null || target.Parent.IsReadOnly)
            {
                return false;
            }


            switch (IsControlBeingHeld)
            {
                case false when !target.IsInArray:
                case true when target.Parent.Data is IRedBufferPointer:
                    return true;
                case true:
                {
                    if (target.Parent.Data is not IRedArray arr)
                    {
                        return false;
                    }

                    var arrayType = target.Parent.Data.GetType().GetGenericTypeDefinition();

                    return arrayType == typeof(CArray<>) || (arrayType == typeof(CStatic<>) && arr.Count < arr.MaxSize);
                }
                default:
                    return true;
            }
        }

        private void SfTreeView_ItemDragOver(object sender, TreeViewItemDragOverEventArgs e)
        {
            if (sender is not SfTreeView)
            {
                return;
            }

            if (e.DropPosition is DropPosition.DropAsChild or DropPosition.DropHere)
            {
                e.DropPosition = DropPosition.DropBelow;
            }

            e.DropPosition = IsAllowDrop(e) ? e.DropPosition : DropPosition.None;

        }

        private async void SfTreeView_ItemDropping(object sender, TreeViewItemDroppingEventArgs e)
        {
            if (e.DraggingNodes == null
                || e.TargetNode.Content is not ChunkViewModel target
                || target.Parent == null
                || (e.DropPosition != DropPosition.DropBelow && e.DropPosition != DropPosition.DropAbove))
            {
                e.Handled = true;
                return;
            }

            var targetIndex = target.Parent.Properties.IndexOf(target);

            foreach (var node in e.DraggingNodes.Where(node => node.Content is ChunkViewModel))
            {
                var source = (ChunkViewModel)node.Content;

                if (IsControlBeingHeld && source.Data is IRedCloneable irc)
                {
                    if (await Interactions.ShowMessageBoxAsync($"Duplicate {source.Data.GetType().Name} here?",
                            "Duplicate Confirmation", WMessageBoxButtons.YesNo) == WMessageBoxResult.Yes)
                    {
                        target.Parent.InsertChild(
                            target.Parent.Properties.IndexOf(target) +
                            (e.DropPosition == DropPosition.DropBelow ? 1 : 0), (IRedType)irc.DeepCopy());
                    }
                }
                else
                {
                    Debug.WriteLine("Moved a node to " + targetIndex);
                    target.Parent.MoveChild(
                        targetIndex + (e.DropPosition == DropPosition.DropBelow ? 1 : 0),
                        source);
                    targetIndex += 1;
                }
            }


            e.Handled = true;
        }

        private void SfTreeView_ItemDropped(object sender, TreeViewItemDroppedEventArgs e)
        {
            //if (e.DraggingNodes != null && e.DraggingNodes[0].Content is ChunkViewModel source)
            //{
            //    if (e.TargetNode.Content is ChunkViewModel target)
            //    {
            //        if (source.Data is RedBaseClass rbc && target.Parent.Data is DataBuffer)
            //        {
            //            target.Parent.AddChunkToDataBuffer((RedBaseClass)rbc.DeepCopy(), target.Parent.Properties.IndexOf(target) + 1);
            //        }
            //    }
            //}

            //if (e.Data.GetDataPresent(DataFormats.FileDrop))
            //{
            //    if (e.TargetNode.Content is ChunkViewModel target)
            //    {
            //        var files = new List<string>((string[])e.Data.GetData(DataFormats.FileDrop));
            //        if (files.Count == 1)
            //        {
            //            if (dropFileLocation == files[0])
            //            {
            //                //target.Data = dropFile.Data;
            //            }
            //        }
            //    }
            //}
        }

        private void Copy_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (sender is not Grid g || g.DataContext is not ChunkViewModel cvm || cvm.Value == "null")
            {
                return;
            }

            e.CanExecute = true;
            e.Handled = true;

        }

        private void Copy_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (sender is not Grid { DataContext: ChunkViewModel cvm })
            {
                return;
            }

            if (cvm.Data is TweakDBID tweakDbId)
            {
                Clipboard.SetText(
                    (tweakDbId.IsResolvable ? tweakDbId.ResolvedText : ((ulong)tweakDbId).ToString("X16")) ??
                    string.Empty);
                return;
            }

            if (cvm.Value != null)
            {
                Clipboard.SetText(cvm.Value);
            }
        }

        public bool CanOpenSearchAndReplaceDialog => SelectedItem is ChunkViewModel { Parent: not null };

        // [RelayCommand(CanExecute = nameof(CanOpenSearchAndReplaceDialog))]
        [RelayCommand]
        private void OpenSearchAndReplaceDialog()
        {
            if (SelectedItem is null && SelectedItems is null)
            {
                return;
            }

            var dialog = new SearchAndReplaceDialog();
            var selectedChunkViewModels = GetSelectedChunks();
            if (dialog.ShowDialog() != true || selectedChunkViewModels.Count == 0)
            {
                return;
            }

            var searchText = dialog.ViewModel?.SearchText ?? "";
            var replaceText = dialog.ViewModel?.ReplaceText ?? "";

            var results = selectedChunkViewModels
                .Select(item => item.SearchAndReplace(searchText, replaceText))
                .ToList();

            var numReplaced = results.Count(r => r == true);

            var cvm = selectedChunkViewModels.FirstOrDefault();

            if (numReplaced <= 0)
            {
                _loggerService.Info("Nothing to replace!");
                return;
            }

            cvm?.Tab?.Parent.SetIsDirty(true);
            _loggerService.Info($"Replaced {ChunkViewModel.NumReplacedEntries} occurrences of '{searchText}' with '{replaceText}'");
        }


        private bool CanGenerateMissingMaterials() => SelectedItem is ChunkViewModel
        {
            ResolvedData: CMesh,
            Parent: null
        };

        [RelayCommand(CanExecute = nameof(CanGenerateMissingMaterials))]
        private void OpenGenerateMaterialsDialog()
        {
            var dialog = new CreateMaterialsDialog();
            if (GetRoot() is not ChunkViewModel cvm || dialog.ShowDialog() != true)
            {
                return;
            }

            var baseMaterial = dialog.ViewModel?.BaseMaterial ?? "";
            var isLocal = dialog.ViewModel?.IsLocalMaterial ?? true;
            var resolveSubstitutions = dialog.ViewModel?.ResolveSubstitutions ?? false;

            cvm.GenerateMissingMaterials(baseMaterial, isLocal, resolveSubstitutions);

            cvm?.Tab?.Parent.SetIsDirty(true);
        }

        /// <summary>
        /// Gets all selected chunks. If none are selected / if selection is invalid, it will return an empty list.
        /// </summary>
        private List<ChunkViewModel> GetSelectedChunks() =>
            SelectedItems is not ObservableCollection<object> selection ? [] : selection.OfType<ChunkViewModel>().ToList();

        private void OnDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (SelectedItem is not ChunkViewModel chunk)
            {
                return;
            }

            // If the current chunk is not expanded, collapse all of its siblings
            if (!chunk.IsExpanded && chunk.Parent is ChunkViewModel parent)
            {
                chunk = parent;
            }
            
            var expansionState = chunk.IsExpanded;
            
            var expansionStates = chunk.GetAllProperties().Select((child) => child.IsExpanded).ToList();
            chunk.SetChildExpansionStates(!expansionStates.Contains(true));


            chunk.IsExpanded = expansionState;
        }

        private ChunkViewModel GetRoot()
        {
            if (ItemsSource is not ListCollectionView selection)
            {
                return null;
            }
            
            return selection.OfType<ChunkViewModel>().ToList().FirstOrDefault((cvm) => cvm.Parent is null);
        }

        private void TreeView_OnItemContextMenuOpening(object sender, ItemContextMenuOpeningEventArgs e)
        {
            if (SelectedItem is ChunkViewModel cvm)
            {
                cvm.RefreshContextMenuFlags();
            }
        }

        private void TreeView_OnContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            if (SelectedItem is ChunkViewModel cvm)
            {
                cvm.RefreshContextMenuFlags();
            }
        }
    }
}
