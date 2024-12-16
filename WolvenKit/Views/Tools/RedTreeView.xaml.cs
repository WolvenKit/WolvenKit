using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ReactiveUI;
using Splat;
using Syncfusion.UI.Xaml.TreeView;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Dialogs.Windows;

namespace WolvenKit.Views.Tools
{
    /// <summary>
    /// Interaction logic for RedTreeView.xaml
    /// </summary>
    public partial class RedTreeView : UserControl
    {
        private readonly IModifierViewStateService _modifierViewStateSvc;
        private readonly ILoggerService _loggerService;
        private readonly IProgressService<double> _progressService;
        private readonly AppViewModel _appViewModel;

        public RedTreeView()
        {
            _modifierViewStateSvc = Locator.Current.GetService<IModifierViewStateService>();
            _loggerService = Locator.Current.GetService<ILoggerService>();
            _progressService = Locator.Current.GetService<IProgressService<double>>();
            _appViewModel = Locator.Current.GetService<AppViewModel>(); 
            
            InitializeComponent();

            TreeView.ApplyTemplate();

            Loaded += RedTreeView_Loaded;
            Unloaded += RedTreeView_Unloaded;
        }

        /// <summary>
        /// Called when editor tab gains focus. 
        /// </summary>
        private void RedTreeView_Loaded(object sender, RoutedEventArgs e)
        {
            DataContextChanged += OnDataContextChanged;
            RedDocumentTabViewModel.CopiedChunkChanged += OnCopiedChunkChanged;

            SyncPasteStatus();
        }

        /// <summary>
        /// Called when editor tab loses focus.
        /// </summary>
        private void RedTreeView_Unloaded(object sender, RoutedEventArgs e)
        {
            RedDocumentTabViewModel.CopiedChunkChanged -= OnCopiedChunkChanged;
            DataContextChanged -= OnDataContextChanged;
        }

        private void OnCopiedChunkChanged(object sender, EventArgs e) => SyncPasteStatus();

        private void SyncPasteStatus()
        {
            SetCurrentValue(HasSingleItemCopiedProperty, true);
            SetCurrentValue(HasHandleCopiedProperty, IsHandle(RedDocumentTabViewModel.CopiedChunk));
            SetCurrentValue(HasMultipleItemsCopiedProperty, RedDocumentTabViewModel.GetCopiedChunks().Count > 1);

            RefreshPasteCommandStatus();
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (e.OldValue is INotifyPropertyChanged oldViewModel)
            {
                oldViewModel.PropertyChanged -= OnViewModelPropertyChanged;
            }

            if (e.NewValue is INotifyPropertyChanged newViewModel)
            {
                newViewModel.PropertyChanged += OnViewModelPropertyChanged;
            }
        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (sender is RDTDataViewModel dtm && e.PropertyName == nameof(dtm.CurrentSearch))
            {
                UpdateFilteredItemsSource(dtm.Chunks);
            }
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
                collectionView.Filter = item =>
                    (item as ChunkViewModel)?.IsHiddenByEditorDifficultyLevel != true &&
                    (item as ChunkViewModel)?.IsHiddenBySearch != true;
                SetCurrentValue(ItemsSourceProperty, collectionView);
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ItemsSource)));
        }

        private void OnExpanded(object sender, NodeExpandedCollapsedEventArgs e)
        {
            if (!ModifierViewStateService.IsShiftBeingHeld || e.Node.Content is not ChunkViewModel chunk)
            {
                return;
            }

            chunk.SetChildExpansionStates(true);
        }

        private void OnCollapsed(object sender, NodeExpandedCollapsedEventArgs e)
        {
            if (e.Node.Content is not ChunkViewModel cvm)
            {
                return;
            }

            if (ModifierViewStateService.IsShiftBeingHeld)
            {
                cvm.SetChildExpansionStates(false);
            }

            if (e.Node.Level != 0 || cvm.ResolvedData is not worldStreamingSector)
            {
                return;
            }

            var tt = Locator.Current.GetService<AppViewModel>();

            if (tt.ActiveDocument is not RedDocumentViewModel { SelectedTabItemViewModel: RDTDataViewModel rdtd })
            {
                return;
            }

            var chunk = rdtd.Chunks.First();
            chunk.Refresh().GetAwaiter().GetResult();
        }


        #region properties

        private void OnSelectionChanged(object sender, ItemSelectionChangedEventArgs e)
        {
            foreach (var removedItem in e.RemovedItems.OfType<ISelectableTreeViewItemModel>())
            {
                removedItem.IsSelected = false;
            }

            foreach (var addedItem in e.AddedItems.OfType<ISelectableTreeViewItemModel>())
            {
                addedItem.IsSelected = true;
            }

            RefreshContextMenuFlags();
            RefreshSelectedItemsContextMenuFlags();
            RefreshCommandStatus();
        }


        public bool HasSelection
        {
            get => (bool)GetValue(HasSelectionProperty);
            set => SetValue(HasSelectionProperty, value);
        }

        public static readonly DependencyProperty HasSelectionProperty =
            DependencyProperty.Register(nameof(HasSelection), typeof(bool), typeof(RedTreeView));

        public static readonly DependencyProperty HasMultipleItemsSelectedProperty =
            DependencyProperty.Register(nameof(HasMultipleItemsSelected), typeof(bool), typeof(RedTreeView), new PropertyMetadata(false));

        public bool HasMultipleItemsSelected
        {
            get => (bool)GetValue(HasMultipleItemsSelectedProperty);
            set => SetValue(HasMultipleItemsSelectedProperty, value);
        }

        public static readonly DependencyProperty HasSingleItemCopiedProperty =
            DependencyProperty.Register(nameof(HasSingleItemCopied), typeof(bool), typeof(RedTreeView), new PropertyMetadata(false));

        public bool HasSingleItemCopied
        {
            get => (bool)GetValue(HasSingleItemCopiedProperty);
            set => SetValue(HasSingleItemCopiedProperty, value);
        }

        public static readonly DependencyProperty HasHandleCopiedProperty =
            DependencyProperty.Register(nameof(HasHandleCopied), typeof(bool), typeof(RedTreeView), new PropertyMetadata(false));

        public bool HasHandleCopied
        {
            get => (bool)GetValue(HasHandleCopiedProperty);
            set => SetValue(HasHandleCopiedProperty, value);
        }

        public static readonly DependencyProperty HasMultipleItemsCopiedProperty =
            DependencyProperty.Register(nameof(HasMultipleItemsCopied), typeof(bool), typeof(RedTreeView), new PropertyMetadata(false));

        public bool HasMultipleItemsCopied
        {
            get => (bool)GetValue(HasMultipleItemsCopiedProperty);
            set => SetValue(HasMultipleItemsCopiedProperty, value);
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

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            if (e.Property == SelectedItem || e.Property == SelectedItems)
            {
                SetCurrentValue(HasSelectionProperty, GetSelectedChunks(true).Count > 0);
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

        /// <summary>Identifies the <see cref="SelectedItems"/> dependency property.</summary>
        public static readonly DependencyProperty SelectedItemsProperty =
            DependencyProperty.Register(nameof(SelectedItems), typeof(object), typeof(RedTreeView));

        public object SelectedItems
        {
            get => GetValue(SelectedItemsProperty);
            set => SetValue(SelectedItemsProperty, value);
        }

        /// <summary>Identifies the <see cref="SelectedItems"/> dependency property.</summary>
        public static readonly DependencyProperty IsArraySelectedProperty =
            DependencyProperty.Register(nameof(IsArraySelected), typeof(object), typeof(RedTreeView));

        public object IsArraySelected
        {
            get => GetValue(IsArraySelectedProperty);
            set => SetValue(IsArraySelectedProperty, value);
        }

        /// <summary>Identifies the <see cref="SelectedItems"/> dependency property.</summary>
        public static readonly DependencyProperty IsArrayItemSelectedProperty =
            DependencyProperty.Register(nameof(IsArrayItemSelected), typeof(object), typeof(RedTreeView));

        public object IsArrayItemSelected
        {
            get => GetValue(IsArrayItemSelectedProperty);
            set => SetValue(IsArrayItemSelectedProperty, value);
        }


        /// <summary>Identifies the <see cref="IsCtrlBeingHeld"/> dependency property.</summary>
        public static readonly DependencyProperty IsCtrlBeingHeldProperty =
            DependencyProperty.Register(nameof(IsCtrlBeingHeld), typeof(bool), typeof(RedTreeView));

        public bool IsCtrlBeingHeld
        {
            get => (bool)GetValue(IsCtrlBeingHeldProperty);
            set => SetValue(IsCtrlBeingHeldProperty, value);
        }

        /// <summary>Identifies the <see cref="IsShiftBeingHeld"/> dependency property.</summary>
        public static readonly DependencyProperty IsShiftBeingHeldProperty =
            DependencyProperty.Register(nameof(IsShiftBeingHeld), typeof(bool), typeof(RedTreeView));

        public bool IsShiftBeingHeld
        {
            get => (bool)GetValue(IsShiftBeingHeldProperty);
            set => SetValue(IsShiftBeingHeldProperty, value);
        }


        /// <summary>Identifies the <see cref="ShouldShowArrayOps"/> dependency property.</summary>
        public static readonly DependencyProperty ShouldShowArrayOpsProperty =
            DependencyProperty.Register(nameof(ShouldShowArrayOps), typeof(bool), typeof(RedTreeView));

        public bool ShouldShowArrayOps
        {
            get => (bool)GetValue(ShouldShowArrayOpsProperty);
            set => SetValue(ShouldShowArrayOpsProperty, value);
        }

        /// <summary>Identifies the <see cref="IsMultipleItemsSelected"/> dependency property.</summary>
        public static readonly DependencyProperty IsMultipleItemsSelectedProperty =
            DependencyProperty.Register(nameof(IsMultipleItemsSelected), typeof(bool), typeof(RedTreeView));

        public bool IsMultipleItemsSelected
        {
            get => (bool)GetValue(IsMultipleItemsSelectedProperty);
            set => SetValue(IsMultipleItemsSelectedProperty, value);
        }

        #endregion

        // Drag & Drop Functionality

        #region dragAndDrop
        //private string dropFileLocation;
        //private RedTypeDto dropFile;

        private void SfTreeView_ItemDragStarting(object sender, TreeViewItemDragStartingEventArgs e)
        {
            //var record = e.DraggingNodes[0].Content as ChunkViewModel;
            //if (typeof(CBool).IsAssignableTo(record.Data.GetType()))
            //    e.Cancel = true;
        }
        
        private bool IsAllowDrop(TreeViewItemDragOverEventArgs e)
        {
            if (e.DraggingNodes?[0].Content is not ChunkViewModel source ||
                e.TargetNode?.Content is not ChunkViewModel target ||
                source == target || target.Parent == null || target.Parent.IsReadOnly)
            {
                return false;
            }


            switch (IsCtrlBeingHeld)
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

        private void SfTreeView_ItemDropping(object sender, TreeViewItemDroppingEventArgs e)
        {
            if (e.DraggingNodes == null
                || e.TargetNode.Content is not ChunkViewModel target
                || target.Parent == null
                || (e.DropPosition != DropPosition.DropBelow && e.DropPosition != DropPosition.DropAbove))
            {
                e.Handled = true;
                return;
            }

            var indexOffset = e.DropPosition == DropPosition.DropBelow ? 1 : 0;
            var targetIndex = target.Parent.Properties.IndexOf(target) + indexOffset;

            foreach (var node in e.DraggingNodes.Where(node => node.Content is ChunkViewModel))
            {
                var source = (ChunkViewModel)node.Content;

                if (IsCtrlBeingHeld && source.Data is IRedCloneable irc)
                {
                    if (Interactions.ShowMessageBox($"Duplicate {source.Data.GetType().Name} here?",
                            "Duplicate Confirmation", WMessageBoxButtons.YesNo) == WMessageBoxResult.Yes)
                    {
                        target.Parent.InsertChild(targetIndex, (IRedType)irc.DeepCopy());
                    }
                }
                else
                {
                    Debug.WriteLine("Moved a node to " + targetIndex);
                    target.Parent.MoveChild(targetIndex, source);
                }
            }

            e.Handled = true;
        }

        #endregion

        #region copy
        private void Copy_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (sender is not Grid { DataContext: ChunkViewModel cvm } || cvm.Value == "null")
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

        /// <summary>
        /// Copies the names of the selected chunks to the clipboard.
        /// </summary>
        [RelayCommand]
        private void CopySelectionNames()
        {
            var names = GetSelectedChunks(true)
                .SelectMany(cvm => cvm.Properties.Select(prop => prop.Descriptor))
                .ToList();

            names.RemoveAll(string.IsNullOrEmpty);

            if (names.Count == 0)
            {
                return;
            }

            Clipboard.SetText(string.Join("\n", names));
        }

        public bool CanCopySelection() => GetSelectedChunks(true) is { Count: > 0 } list && list.All(cvm => cvm.CanCopySelection());

        [RelayCommand(CanExecute = nameof(CanCopySelection))]
        private void CopySelection()
        {
            var selection = GetSelectedChunks(true);

            if (selection.Count == 1 && selection.First() is ChunkViewModel single)
            {
                RedDocumentTabViewModel.CopiedChunk = single.CopyData();
                single.RefreshCommandStatus();
                single.RefreshContextMenuFlags();
                SetCurrentValue(HasSingleItemCopiedProperty, true);
                SetCurrentValue(HasHandleCopiedProperty, IsHandle(RedDocumentTabViewModel.CopiedChunk));
                RefreshCommandStatus();
                return;
            }

            RedDocumentTabViewModel.ClearCopiedChunks();
            foreach (var redType in selection.Select(cvm => cvm.CopyData()).Where(d => d is not null))
            {
                RedDocumentTabViewModel.AddToCopiedChunks(redType);
            }

            SetCurrentValue(HasMultipleItemsCopiedProperty, RedDocumentTabViewModel.GetCopiedChunks().Count > 1);

            foreach (var cvm in selection)
            {
                cvm.RefreshContextMenuFlags();
                cvm.RefreshCommandStatus();
            }

            RefreshPasteCommandStatus();
        }

        #endregion

        #region paste

        private bool CanPasteSingleSelection() => HasSingleItemCopied && SelectedItem is ChunkViewModel cvm && cvm.CanPasteSelection(true);
        private bool CanPasteSelection() => HasMultipleItemsCopied && SelectedItem is ChunkViewModel cvm && cvm.CanPasteSelection();

        private void OverwriteSelectedInternal(bool useSingle = false)
        {
            var copiedChunks = new List<IRedType>();

            switch (useSingle)
            {
                case true when RedDocumentTabViewModel.CopiedChunk is not null:
                    copiedChunks.Add(RedDocumentTabViewModel.CopiedChunk);
                    break;
                case false:
                    copiedChunks.AddRange(RedDocumentTabViewModel.GetCopiedChunks());
                    break;
            }

            var selectedNodes = GetSelectedChunks();
            if (ItemsSource is not ICollectionView collectionView || copiedChunks.Count == 0 || selectedNodes.Count == 0)
            {
                return;
            }

            using (collectionView.DeferRefresh())
            {
                foreach (var group in selectedNodes
                             .Where(cvm => cvm.CanPasteSelection())
                             .Where(cvm => cvm.IsInArray)
                             .GroupBy(chunk => chunk.Parent))
                {
                    var pasteIndex = group.FirstOrDefault()?.NodeIdxInParent ?? -2;
                    group.Key.DeleteNodes(selectedNodes);
                    group.Key.PasteAtIndex(copiedChunks, pasteIndex + 1);
                    ReapplySearch(group.Key);
                }
            }
        }
        
        [RelayCommand(CanExecute = nameof(CanPasteSingleSelection))]
        private void OverwriteSelectionWithSingle() => OverwriteSelectedInternal(true);

        [RelayCommand(CanExecute = nameof(CanPasteSelection))]
        private void OverwriteSelectionWithPaste() => OverwriteSelectedInternal();

        [RelayCommand]
        private void ClearArray()
        {
            var chunkViewModels = GetSelectedChunks(true);
            if (ItemsSource is not ICollectionView collectionView || chunkViewModels.Count == 0)
            {
                return;
            }

            using (collectionView.DeferRefresh())
            {
                foreach (var group in GetSelectedChunks()
                             .Where(cvm => cvm.CanPasteSelection())
                             .GroupBy(chunk => chunk.Parent))
                {
                    if (group.Key.IsArray)
                    {
                        group.Key.ClearChildren();
                        ReapplySearch(group.Key);
                        continue;
                    }


                    foreach (var cvm in group.Where(cvm => cvm.IsArray))
                    {
                        cvm.ClearChildren();
                    }
                }
            }
        }

        [RelayCommand(CanExecute = nameof(CanPasteSelection))]
        private void ClearAndPasteSelection()
        {
            var copiedChunks = RedDocumentTabViewModel.GetCopiedChunks();
            if (ItemsSource is not ICollectionView collectionView || copiedChunks.Count == 0)
            {
                return;
            }

            using (collectionView.DeferRefresh())
            {
                foreach (var group in GetSelectedChunks()
                             .Where(cvm => cvm.CanPasteSelection())
                             .GroupBy(chunk => chunk.Parent))
                {
                    if (group.Key.IsArray)
                    {
                        group.Key.ClearChildren();
                        group.Key.PasteAtIndex(copiedChunks, -1);
                        ReapplySearch(group.Key);
                        continue;
                    }

                    if (group.FirstOrDefault() is not ChunkViewModel cvm || !cvm.IsInArray || cvm.Parent is null)
                    {
                        continue;
                    }

                    cvm.Parent.ClearChildren();
                    cvm.Parent.PasteAtIndex(copiedChunks, -1);
                    ReapplySearch(cvm.Parent);
                }
            
            }
        }

        [RelayCommand(CanExecute = nameof(CanPasteSingleSelection))]
        private void PasteSingleSelection() => PasteSelectionInternal(true);

        [RelayCommand(CanExecute = nameof(CanPasteSingleSelection))]
        private void ClearAndPasteSingle()
        {
            var copiedChunks = RedDocumentTabViewModel.GetCopiedChunks();
            if (ItemsSource is not ICollectionView collectionView || SelectedItem is not ChunkViewModel cvm ||
                RedDocumentTabViewModel.CopiedChunk is null)
            {
                return;
            }

            using (collectionView.DeferRefresh())
            {
                if (cvm.IsInArray && cvm.Parent is not null)
                {
                    cvm.Parent.ClearChildren();
                    cvm.Parent.PasteAtIndex([RedDocumentTabViewModel.CopiedChunk], -1);
                    ReapplySearch(cvm.Parent);
                }
                else if (cvm.IsArray)
                {
                    cvm.ClearChildren();
                    cvm.PasteAtIndex([RedDocumentTabViewModel.CopiedChunk], -1);
                    ReapplySearch(cvm.Parent);
                }
            }
        }

        private void PasteSelectionInternal(bool pasteSingleSelect = false)
        {
            var copiedChunks = RedDocumentTabViewModel.GetCopiedChunks();
            if (ItemsSource is not ICollectionView collectionView
                || (pasteSingleSelect && RedDocumentTabViewModel.CopiedChunk is null)
                || (!pasteSingleSelect && copiedChunks.Count == 0))
            {
                return;
            }

            using (collectionView.DeferRefresh())
            {
                foreach (var group in GetSelectedChunks()
                             .GroupBy(chunk => chunk.Parent))
                {
                    if (group.FirstOrDefault() is not ChunkViewModel cvm)
                    {
                        continue;
                    }

                    var node = cvm.IsArray ? cvm : group.Key;
                    var idx = cvm.IsArray ? -1 : cvm.NodeIdxInParent + 1;

                    if (pasteSingleSelect)
                    {
                        node.PasteAtIndex([RedDocumentTabViewModel.CopiedChunk], idx);
                    }
                    else
                    {
                        node.PasteAtIndex(copiedChunks, idx);
                    }

                    ReapplySearch((cvm.IsArray ? cvm : group.Key));
                }
            }
        }

        [RelayCommand(CanExecute = nameof(CanPasteSelection))]
        private void PasteSelection() => PasteSelectionInternal();

        #endregion

        #region commands

        private void RefreshPasteCommandStatus()
        {
            PasteHandleSingleCommand.NotifyCanExecuteChanged();

            PasteSelectionCommand.NotifyCanExecuteChanged();
            PasteSingleSelectionCommand.NotifyCanExecuteChanged();

            ClearAndPasteSingleCommand.NotifyCanExecuteChanged();
            ClearAndPasteSelectionCommand.NotifyCanExecuteChanged();

            OverwriteSelectionWithSingleCommand.NotifyCanExecuteChanged();
            OverwriteSelectionWithPasteCommand.NotifyCanExecuteChanged();
        }

        private void RefreshContextMenuFlags()
        {
            var selectedItems = GetSelectedChunks(true);
            var selectedItem = selectedItems.FirstOrDefault();

            SetCurrentValue(HasSelectionProperty, selectedItems.Count > 0);
            SetCurrentValue(HasMultipleItemsSelectedProperty, selectedItems.Count > 1);

            var isArray = selectedItem?.IsArray == true;
            var isInArray = selectedItem?.IsInArray == true;
            SetCurrentValue(IsArraySelectedProperty, isArray);
            SetCurrentValue(IsArrayItemSelectedProperty, isInArray);
            SetCurrentValue(ShouldShowArrayOpsProperty, isArray || isInArray);
        }

        private void RefreshCommandStatus()
        {
            DuplicateSelectionCommand.NotifyCanExecuteChanged();

            RefreshPasteCommandStatus();

            CopySelectionCommand.NotifyCanExecuteChanged();

            ClearArrayCommand.NotifyCanExecuteChanged();
            DeleteSelectionCommand.NotifyCanExecuteChanged();
            DeleteAllButSelectionCommand.NotifyCanExecuteChanged();

            if (SelectedItem is ChunkViewModel chunk)
            {
                chunk.RefreshCommandStatus();
            }
        }


        [RelayCommand]
        private async Task DuplicateSelectionAsNew()
        {
            if (ItemsSource is not ICollectionView collectionView)
            {
                return;
            }

            using (collectionView.DeferRefresh())
            {
                var chunks = GetSelectedChunks();

                foreach (var cvm in chunks)
                {
                    await cvm.DuplicateChunkAsNewAsync();
                }
            }
        }

        private async Task DuplicateSelectedChunks(bool preserveIndex = false)
        {
            if (ItemsSource is not ICollectionView collectionView)
            {
                return;
            }

            using (collectionView.DeferRefresh())
            {
                var chunks = GetSelectedChunks();

                if (!preserveIndex)
                {
                    var nodeIndices = chunks.Select(c => c.NodeIdxInParent).Order().ToList();
                    if (nodeIndices.Zip(nodeIndices.Skip(1), (a, b) => b - a).Any(diff => diff != 1))
                    {
                        preserveIndex = true;
                    }
                }

                var tasks = chunks.Select(cvm => cvm.DuplicateChunkAsync(preserveIndex ? -1 : cvm.NodeIdxInParent + chunks.Count)).ToList();

                var duplicatedChunks = await Task.WhenAll(tasks);

                var newChunks = duplicatedChunks.Where(newChunk => newChunk != null).ToList();

                foreach (var cvm in chunks)
                {
                    cvm.IsSelected = false;
                }

                foreach (var cvm in newChunks)
                {
                    cvm.IsSelected = true;
                }
            }
        }

        /// <summary>
        /// Duplicates each chunk in selection. Will preserve index order if shift key is pressed.
        /// </summary>
        [RelayCommand]
        private async Task DuplicateSelection() => await DuplicateSelectedChunks(ModifierViewStateService.IsShiftBeingHeld);


        private bool CanOpenSearchAndReplaceDialog => !_isContextMenuOpen &&
                                                      SelectedItem is ChunkViewModel { Parent: not null } &&
                                                      !SearchAndReplaceDialog.IsInstanceOpen;

        // [RelayCommand(CanExecute = nameof(CanOpenSearchAndReplaceDialog))] this doesn't work if item is called from menu
        [RelayCommand]
        private void OpenSearchAndReplaceDialog()
        {
            var selectedChunkViewModels = GetSelectedChunks();
            if (selectedChunkViewModels.Count == 0 || SelectedItem is not ChunkViewModel cvm)
            {
                return;
            }

            // cvm.PropertyChanged += OnCvmExpansionStateChange;

            _progressService.IsIndeterminate = true;

            var dialog = new SearchAndReplaceDialog();
            if (dialog.ShowDialog() != true)
            {
                _progressService.IsIndeterminate = false;
                return;
            }

            var searchText = dialog.ViewModel?.SearchText ?? "";
            var replaceText = dialog.ViewModel?.ReplaceText ?? "";
            var isRegex = dialog.ViewModel?.IsRegex ?? false;
            var isWholeWord = dialog.ViewModel?.IsWholeWord ?? false;

            ChunkViewModel.SearchAndReplace_ResetCaches();
            if (selectedChunkViewModels.Count < 20)
            {
                selectedChunkViewModels.ForEach(child => child.ForceLoadPropertiesRecursive());
            }

            var results = selectedChunkViewModels
                .Select(item => item.SearchAndReplace(searchText, replaceText, isWholeWord, isRegex))
                .ToList();

            var numReplaced = results.Sum();

            _loggerService.Info($"Replaced {numReplaced} occurrences of '{searchText}' with '{replaceText}'");

            if (numReplaced <= 0)
            {
                _progressService.IsIndeterminate = false;
                return;
            }

            GetRoot().Tab?.Parent.SetIsDirty(true);

            SetSelectedItems(selectedChunkViewModels);

            _progressService.IsIndeterminate = false;
        }

        // Re-select nodes, enforcing change detection. Without setting it to null first, e.g. search&replace won't work.
        private void SetSelectedItems(List<ChunkViewModel> selectedChunkViewModels)
        {
            SetCurrentValue(SelectedItemsProperty, null);
            SetCurrentValue(SelectedItemProperty, null);

            SetCurrentValue(SelectedItemsProperty, new ObservableCollection<object>(selectedChunkViewModels));
            SetCurrentValue(SelectedItemProperty, selectedChunkViewModels.LastOrDefault());
        }



        private void ReapplySearch(ChunkViewModel chunk)
        {
            if (string.IsNullOrEmpty(RedDocumentViewToolbarModel.CurrentActiveSearch))
            {
                return;
            }

            // forde re-applying search
            foreach (var chunkViewModel in chunk.Properties)
            {
                chunkViewModel.IsHiddenBySearch = false;
            }

            chunk.SetVisibilityStatusBySearchString(RedDocumentViewToolbarModel.CurrentActiveSearch);
        }

        #region handles

        private static bool IsHandle(IRedType potentialHandle)
        {
            if (potentialHandle is null)
            {
                return false;
            }

            var propertyType = potentialHandle.GetType();
            return
                propertyType.IsAssignableTo(typeof(IRedBaseHandle)) && (
                    propertyType.GetGenericTypeDefinition() == typeof(CHandle<>) ||
                    propertyType.GetGenericTypeDefinition() == typeof(CWeakHandle<>));
        }

        private bool CanPasteHandleSingle() => IsHandle(RedDocumentTabViewModel.CopiedChunk);

        [RelayCommand(CanExecute = nameof(CanPasteHandleSingle))]
        private void PasteHandleSingle()
        {
            var selectedChunks = GetSelectedChunks(true);

            if (ItemsSource is not ICollectionView collectionView || !IsHandle(RedDocumentTabViewModel.CopiedChunk) ||
                selectedChunks.Count != 1)
            {
                return;
            }

            using (collectionView.DeferRefresh())
            {
                var cvm = selectedChunks.FirstOrDefault();
                if (cvm?.PasteHandle((IRedBaseHandle)RedDocumentTabViewModel.CopiedChunk!) != true)
                {
                    return;
                }

                cvm.SetVisibilityStatusBySearchString(RedDocumentViewToolbarModel.CurrentActiveSearch);
                ReapplySearch(cvm.Parent);
            }

            RefreshContextMenuFlags();
            RefreshSelectedItemsContextMenuFlags();
            RefreshCommandStatus();
        }

        private bool CanPasteHandles() =>
            RedDocumentTabViewModel.GetCopiedChunks() is List<IRedType> { Count: > 0 } lst && lst.All(IsHandle);

        [RelayCommand(CanExecute = nameof(CanPasteHandles))]
        private void PasteHandles()
        {
            var selectedChunks = GetSelectedChunks(true);

            if (ItemsSource is not ICollectionView collectionView || !IsHandle(RedDocumentTabViewModel.CopiedChunk) ||
                selectedChunks.Count != 1)
            {
                return;
            }

            using (collectionView.DeferRefresh())
            {
                var cvm = selectedChunks.FirstOrDefault();
                if (cvm?.PasteHandle((IRedBaseHandle)RedDocumentTabViewModel.CopiedChunk!) != true)
                {
                    return;
                }

                cvm.SetVisibilityStatusBySearchString(RedDocumentViewToolbarModel.CurrentActiveSearch);
                ReapplySearch(cvm.Parent);
            }

            RefreshSelectedItemsContextMenuFlags();
            RefreshCommandStatus();
        }

        #endregion
        
        private bool CanDeleteSelection() => SelectedItem is ChunkViewModel;

        [RelayCommand(CanExecute = nameof(CanDeleteSelection))]
        private void DeleteAllButSelection()
        {
            if (ItemsSource is not ICollectionView collectionView)
            {
                return;
            }

            using (collectionView.DeferRefresh())
            {
                foreach (var chunkSiblings in GetSelectedChunks()
                             .GroupBy(chunk => chunk.Parent)
                             .Select(group => group.ToList()))
                {
                    if (chunkSiblings.FirstOrDefault() is not ChunkViewModel cvm || cvm.Parent is null)
                    {
                        continue;
                    }

                    var chunksToDelete = cvm.Parent.TVProperties.Except(chunkSiblings).ToList();

                    cvm.DeleteNodesInParent(chunksToDelete);
                    ReapplySearch(cvm.Parent);
                }
            }
        }


        [RelayCommand(CanExecute = nameof(CanDeleteSelection))]
        private void DeleteSelection()
        {
            if (ItemsSource is not ICollectionView collectionView)
            {
                return;
            }

            using (collectionView.DeferRefresh())
            {
                foreach (var kvp in GetSelectedChunks()
                             .GroupBy(chunk => chunk.Parent))
                {
                    if (!kvp.Any())
                    {
                        continue;
                    }

                    var chunkSiblings = kvp.ToList();
                    chunkSiblings.First().DeleteNodesInParent(chunkSiblings);

                    chunkSiblings.First().Tab?.Parent.SetIsDirty(true);

                    ReapplySearch(kvp.Key);
                }
            }
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

            cvm.Tab?.Parent.SetIsDirty(true);
        }

        #endregion

        /// <summary>
        /// Gets all selected chunks. If none are selected / if selection is invalid, it will return an empty list.
        /// </summary>
        private List<ChunkViewModel> GetSelectedChunks(bool includeSingleSelect = false)
        {
            var uniqueItems = new HashSet<(object Parent, string Name)>();
            
            if (SelectedItems is not ObservableCollection<object> selection)
            {
                return includeSingleSelect && SelectedItem is ChunkViewModel cvm ? [cvm] : [];
            }

            return selection.OfType<ChunkViewModel>().Where(x => uniqueItems.Add((x.Parent, x.Name))).ToList();
        }

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

        #region context_menu_and_keystates

        private bool _isContextMenuOpen;


        private void RefreshSelectedItemsContextMenuFlags()
        {
            SetCurrentValue(ShouldShowArrayOpsProperty, SelectedItem is ChunkViewModel cvm && (cvm.IsInArray || cvm.IsArray));
            
            if (ItemsSource is not ICollectionView collectionView)
            {
                foreach (var chunkViewModel in GetSelectedChunks())
                {
                    chunkViewModel.RefreshContextMenuFlags();
                }

                return;
            }

            using (collectionView.DeferRefresh())
            {
                foreach (var chunkViewModel in GetSelectedChunks())
                {
                    chunkViewModel.RefreshContextMenuFlags();
                }
            }
        }

        private void TreeViewContextMenu_OnOpened(object sender, RoutedEventArgs e)
        {
            _isContextMenuOpen = true;
            RefreshSelectedItemsContextMenuFlags();
            RefreshCommandStatus();
        }

        private void TreeViewContextMenu_OnClosed(object sender, RoutedEventArgs e) => _isContextMenuOpen = false;

        private void TreeViewContextMenu_OnKeyChanged(object sender, KeyEventArgs e)
        {
            _modifierViewStateSvc.OnKeystateChanged(e);
            SetCurrentValue(IsShiftBeingHeldProperty, ModifierViewStateService.IsShiftBeingHeld);
            SetCurrentValue(IsCtrlBeingHeldProperty, ModifierViewStateService.IsCtrlBeingHeld);
            RefreshSelectedItemsContextMenuFlags();
        }


        private void TreeView_OnKeyChanged(object sender, KeyEventArgs e)
        {
            
            if (_isContextMenuOpen)
            {
                return;
            }

            switch (e.Key)
            {
                case Key.F2 when e.IsUp && CanOpenSearchAndReplaceDialog:
                    OpenSearchAndReplaceDialog();
                    return;
                case Key.W when e.IsDown && e.KeyboardDevice.Modifiers == ModifierKeys.Control:
                    _appViewModel.CloseLastActiveDocument();
                    return;
                default:
                    _modifierViewStateSvc.OnKeystateChanged(e);
                    SetCurrentValue(IsShiftBeingHeldProperty, ModifierViewStateService.IsShiftBeingHeld);
                    SetCurrentValue(IsCtrlBeingHeldProperty, ModifierViewStateService.IsCtrlBeingHeld);
                    break;
            }
        }

        #endregion

    }
    
}
