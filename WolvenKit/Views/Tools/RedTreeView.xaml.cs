using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using Splat;
using Syncfusion.Data.Extensions;
using Syncfusion.UI.Xaml.TreeView;
using Syncfusion.UI.Xaml.TreeView.Helpers;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Dialogs.Windows;
using WolvenKit.Views.Shell;

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
        private readonly ProjectResourceTools _projectResourceTools;
        private readonly ISettingsManager _settingsManager;


        public RedTreeView()
        {
            _modifierViewStateSvc = Locator.Current.GetService<IModifierViewStateService>();
            _loggerService = Locator.Current.GetService<ILoggerService>();
            _progressService = Locator.Current.GetService<IProgressService<double>>();
            _appViewModel = Locator.Current.GetService<AppViewModel>();
            _projectResourceTools = Locator.Current.GetService<ProjectResourceTools>();
            _settingsManager = Locator.Current.GetService<ISettingsManager>();

            InitializeComponent();

            TreeView.ApplyTemplate();

            Loaded += RedTreeView_Loaded;
            Unloaded += RedTreeView_Unloaded;

            if (_appViewModel.ActiveDocument is RedDocumentViewModel
                {
                    SelectedTabItemViewModel: RDTDataViewModel rdtd
                })
            {
                _rdtDataViewModel = rdtd;
            }
        }

        /// <summary>
        /// Called when editor tab gains focus.
        /// </summary>
        private void RedTreeView_Loaded(object sender, RoutedEventArgs e)
        {
            RDTDataViewModel.OnSearchStringChanged += OnCurrentSearchChanged;
            RedDocumentTabViewModel.OnCopiedChunkChanged += OnCopiedChunkChanged;

            SyncEditorStates();
        }


        /// <summary>
        /// Called when editor tab loses focus.
        /// </summary>
        private void RedTreeView_Unloaded(object sender, RoutedEventArgs e)
        {
            RedDocumentTabViewModel.OnCopiedChunkChanged -= OnCopiedChunkChanged;
            RDTDataViewModel.OnSearchStringChanged -= OnCurrentSearchChanged;
        }

        private void OnCopiedChunkChanged(object sender, EventArgs e) => SyncPasteStates();

        private void OnCurrentSearchChanged(object _, List<ChunkViewModel> e) => UpdateFilteredItemsSource(e);

        private void SyncEditorStates()
        {
            SetCurrentValue(IsShiftBeingHeldProperty, ModifierViewStateService.IsShiftBeingHeld);
            SetCurrentValue(IsCtrlBeingHeldProperty, ModifierViewStateService.IsCtrlBeingHeld);

            SyncPasteStates();

            GetRoot()?.SetEditorLevel(_settingsManager.DefaultEditorDifficultyLevel);
        }

        private void SyncPasteStates()
        {
            SetCurrentValue(HasSingleItemCopiedProperty, true);
            SetCurrentValue(HasHandleCopiedProperty, ChunkViewModel.IsHandle(RedDocumentTabViewModel.CopiedChunk));
            SetCurrentValue(HasMultipleItemsCopiedProperty, RedDocumentTabViewModel.GetCopiedChunks().Count > 1);

            RefreshPasteCommandStatus();
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
            else
            {
                // Reloading/reopening file should clear selected properties
                SelectedItems?.Clear();
                SetCurrentValue(SelectedItemProperty, null);
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ItemsSource)));
        }

        private void OnExpanded(object sender, NodeExpandedCollapsedEventArgs e)
        {
            if (e.Node.Content is not ChunkViewModel chunk)
            {
                return;
            }

            if (ModifierViewStateService.IsShiftBeingHeld)
            {
                chunk.SetChildExpansionStates(true);
            }

            if (!ModifierViewStateService.IsCtrlBeingHeld)
            {
                return;
            }

            foreach (var child in chunk.TVProperties)
            {
                child.IsExpanded = true;
            }
        }

        private async void OnCollapsed(object sender, NodeExpandedCollapsedEventArgs e)
        {
            if (e.Node.Content is not ChunkViewModel cvm)
            {
                return;
            }

            if (ModifierViewStateService.IsShiftBeingHeld)
            {
                cvm.SetChildExpansionStates(false);
            }

            if (ModifierViewStateService.IsCtrlBeingHeld)
            {
                foreach (var child in cvm.TVProperties)
                {
                    child.IsExpanded = false;
                }

                return;
            }

            if (e.Node.Level != 0 || cvm.ResolvedData is not worldStreamingSector)
            {
                return;
            }

            await _rdtDataViewModel?.Chunks.First()?.RefreshAsync();
        }


        #region properties

        //// https://help.syncfusion.com/wpf/treeview/selection?cs-save-lang=1&cs-lang=csharp#how-to-add-selection-on-right-click
        //private bool IsMouseOverOnExpander(Syncfusion.UI.Xaml.TreeView.TreeViewItem treeViewItem, System.Windows.Point point)
        //{
        //    if (treeViewItem.TreeViewItemInfo.TreeView.ExpanderPosition == ExpanderPosition.Start)
        //    {
        //        return point.X < treeViewItem.IndentationWidth + treeViewItem.ExpanderWidth;
        //    }
        //    else
        //    {
        //        return point.X > (treeViewItem.ActualWidth - treeViewItem.ExpanderWidth);
        //    }
        //}
        //// https://help.syncfusion.com/wpf/treeview/selection?cs-save-lang=1&cs-lang=csharp#how-to-add-selection-on-right-click
        private void OnMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            //    var treeViewNode = TreeView.GetNodeAt(e.GetPosition(TreeView));
            //    var itemInfo = TreeView.GetItemInfo(treeViewNode.Content);
            //    var itemPoint = e.GetPosition(itemInfo.Element);

            //    if (!TreeView.FullRowSelect && IsMouseOverOnExpander(itemInfo.Element, itemPoint))
            //    {
            //        return;
            //    }

            //    if (!IsCtrlBeingHeld)
            //    {
            //        TreeView.SetCurrentValue(SfTreeView.SelectedItemsProperty, new ObservableCollection<object>());
            //        TreeView.SetCurrentValue(SfTreeView.SelectedItemProperty, null);
            //    }

            //    if (!TreeView.SelectedItems.Contains(treeViewNode.Content))
            //    {
            //        TreeView.SelectedItems.Add(treeViewNode.Content);
            //    }

            //    TreeView.SetCurrentValue(SfTreeView.SelectedItemProperty, treeViewNode.Content);

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
            if (e.Property.Name is (nameof(SelectedItem)) or (nameof(SelectedItems)))
            {
                SetCurrentValue(HasSelectionProperty, GetSelectedChunks().Count > 0);
            }
        }

        public object ItemsSource
        {
            get => GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        /// <summary>Identifies the <see cref="SelectedItem"/> dependency property.</summary>
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register(
                nameof(SelectedItem),
                typeof(ChunkViewModel),
                typeof(RedTreeView),
                new PropertyMetadata(null, new PropertyChangedCallback(OnSelectedItemChanged))
                );

        private static void OnSelectedItemChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            if (sender is not RedTreeView view)
            {
                return;
            }

            // old value
            if (args.OldValue is ChunkViewModel oldCvm)
            {
                oldCvm.IsSelected = false;
            }

            // new value
            if (args.NewValue is ChunkViewModel newCvm)
            {
                newCvm.IsSelected = true;
            }

            view.RefreshContextMenuFlags();
            view.RefreshSelectedItemsContextMenuFlags();
            view.RefreshCommandStatus();
        }

        /// <summary>Bound to <see cref="RDTDataViewModel.SelectedChunk"/> </summary>
        public ChunkViewModel SelectedItem
        {
            get => (ChunkViewModel)GetValue(SelectedItemProperty);
            set => SetValue(SelectedItemProperty, value);
        }

        /// <summary>Identifies the <see cref="SelectedItems"/> dependency property.</summary>
        public static readonly DependencyProperty SelectedItemsProperty =
            DependencyProperty.Register(
                nameof(SelectedItems), typeof(ObservableCollection<object>),
                typeof(RedTreeView),
                new PropertyMetadata(null, new PropertyChangedCallback(OnSelectedItemsChanged))
                );

        private static void OnSelectedItemsChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            if (sender is not RedTreeView view)
            {
                return;
            }

            if (args.OldValue is ObservableCollection<object> oldItems)
            {
                foreach (var item in oldItems)
                {
                    if (item is ChunkViewModel cvm)
                    {
                        cvm.IsSelected = false;
                    }
                }
            }

            if (args.NewValue is ObservableCollection<object> newItems)
            {
                foreach (var item in newItems)
                {
                    if (item is ChunkViewModel cvm)
                    {
                        cvm.IsSelected = true;
                    }
                }
            }

            view.RefreshContextMenuFlags();
            view.RefreshSelectedItemsContextMenuFlags();
            view.RefreshCommandStatus();
        }

        /// <summary>Bound to <see cref="RDTDataViewModel.SelectedChunks"/> </summary>
        public ObservableCollection<object> SelectedItems
        {
            get => (ObservableCollection<object>)GetValue(SelectedItemsProperty);
            set => SetValue(SelectedItemsProperty, value);
        }

        /// <summary>Identifies the <see cref="IsArraySelected"/> dependency property.</summary>
        public static readonly DependencyProperty IsArraySelectedProperty =
            DependencyProperty.Register(nameof(IsArraySelected), typeof(bool), typeof(RedTreeView));

        /// <summary>Updates with <see cref="RDTDataViewModel.SelectedChunk"/> </summary>

        public bool IsArraySelected
        {
            get => (bool)GetValue(IsArraySelectedProperty);
            set => SetValue(IsArraySelectedProperty, value);
        }

        /// <summary>Identifies the <see cref="IsArrayItemSelected"/> dependency property.</summary>
        public static readonly DependencyProperty IsArrayItemSelectedProperty =
            DependencyProperty.Register(nameof(IsArrayItemSelected), typeof(bool), typeof(RedTreeView));

        /// <summary>Updates with <see cref="RDTDataViewModel.SelectedChunk"/> </summary>
        public bool IsArrayItemSelected
        {
            get => (bool)GetValue(IsArrayItemSelectedProperty);
            set => SetValue(IsArrayItemSelectedProperty, value);
        }

        /// <summary>Identifies the <see cref="IsHandleSelected"/> dependency property.</summary>
        public static readonly DependencyProperty IsHandleSelectedProperty =
            DependencyProperty.Register(nameof(IsHandleSelected), typeof(object), typeof(RedTreeView));

        public object IsHandleSelected
        {
            get => GetValue(IsHandleSelectedProperty);
            set => SetValue(IsHandleSelectedProperty, value);
        }


        /// <summary>Identifies the <see cref="IsCtrlBeingHeld"/> dependency property.</summary>
        public static readonly DependencyProperty IsCtrlBeingHeldProperty =
            DependencyProperty.Register(nameof(IsCtrlBeingHeld), typeof(bool), typeof(RedTreeView));

        /// <summary>Updates in <see cref="TreeViewContextMenu_OnKeyChanged"/> </summary>
        public bool IsCtrlBeingHeld
        {
            get => (bool)GetValue(IsCtrlBeingHeldProperty);
            set => SetValue(IsCtrlBeingHeldProperty, value);
        }

        /// <summary>Identifies the <see cref="IsShiftBeingHeld"/> dependency property.</summary>
        public static readonly DependencyProperty IsShiftBeingHeldProperty =
            DependencyProperty.Register(nameof(IsShiftBeingHeld), typeof(bool), typeof(RedTreeView));

        /// <summary>Updates in <see cref="TreeViewContextMenu_OnKeyChanged"/> </summary>
        public bool IsShiftBeingHeld
        {
            get => (bool)GetValue(IsShiftBeingHeldProperty);
            set => SetValue(IsShiftBeingHeldProperty, value);
        }

        /// <summary>Identifies the <see cref="ShouldShowArrayOps"/> dependency property.</summary>
        public static readonly DependencyProperty ShouldShowArrayOpsProperty =
            DependencyProperty.Register(nameof(ShouldShowArrayOps), typeof(bool), typeof(RedTreeView));

        /// <summary>Updates in <see cref="RefreshContextMenuFlags"/> </summary>
        public bool ShouldShowArrayOps
        {
            get => (bool)GetValue(ShouldShowArrayOpsProperty);
            set => SetValue(ShouldShowArrayOpsProperty, value);
        }

        /// <summary>Identifies the <see cref="IsMultipleItemsSelected"/> dependency property.</summary>
        public static readonly DependencyProperty IsMultipleItemsSelectedProperty =
            DependencyProperty.Register(nameof(IsMultipleItemsSelected), typeof(bool), typeof(RedTreeView));

        /// <summary>Updates in <see cref="RefreshContextMenuFlags"/> </summary>
        public bool IsMultipleItemsSelected
        {
            get => (bool)GetValue(IsMultipleItemsSelectedProperty);
            set => SetValue(IsMultipleItemsSelectedProperty, value);
        }

        #endregion

        // Drag & Drop Functionality

        #region dragAndDrop

        private bool IsAllowDrop(TreeViewItemDragOverEventArgs e)
        {
            var source = e.DraggingNodes.Select(n => n.Content).OfType<ChunkViewModel>()
                .FirstOrDefault(n => n.IsSelected);

            if (source is null || e.TargetNode?.Content is not ChunkViewModel target ||
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
            if (e.DraggingNodes?.Any(node => node.Content is ChunkViewModel { IsSelected: true }) != true
                || e.TargetNode.Content is not ChunkViewModel { Parent: not null } target
                || e.DropPosition is not (DropPosition.DropBelow or DropPosition.DropAbove)
               )
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
            var names = GetSelectedChunks()
                .SelectMany(cvm => cvm.Properties.Select(prop => prop.Descriptor))
                .Where(s => !string.IsNullOrEmpty(s))
                .ToList();

            if (names.Count == 0)
            {
                return;
            }

            if (ModifierViewStateService.IsCtrlBeingHeld)
            {
                Clipboard.SetText(string.Join(",\n", names.Select(name => $"\"{name}\"")));
            }
            else
            {
                Clipboard.SetText(string.Join("\n", names));
            }
        }

        public bool CanCopySelection()
        {
            return GetSelectedChunks() is { Count: > 0 } list && list.All(cvm => cvm.CanCopySelection());
        }

        private void CopySingleSelection(ChunkViewModel single, bool copyAsHandle = false)
        {
            RedDocumentTabViewModel.CopiedChunk = single.CopyData(copyAsHandle);
            single.RefreshCommandStatus();
            single.RefreshContextMenuFlags();
            SetCurrentValue(HasSingleItemCopiedProperty, true);
            SetCurrentValue(HasHandleCopiedProperty, ChunkViewModel.IsHandle(RedDocumentTabViewModel.CopiedChunk));
            RefreshCommandStatus();
        }

        [RelayCommand(CanExecute = nameof(CanCopySelection))]
        private void CopySelection()
        {
            var selection = GetSelectedChunks();

            if (selection.Count == 1 && selection.First() is ChunkViewModel single)
            {
                CopySingleSelection(single);
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

        [RelayCommand(CanExecute = nameof(CanCopySelection))]
        private void CopyHandle()
        {
            if (SelectedItem is not ChunkViewModel single)
            {
                return;
            }

            CopySingleSelection(single, true);
        }

        #endregion

        private void ReapplySearchAsync(IEnumerable<ChunkViewModel> chunks)
        {
            var list = chunks.ToList();

            if (list.Count == 0)
            {
                return;
            }

            TreeView.Dispatcher.Invoke(() => 
            {
                foreach (var cvm in list)
                {
                    ReapplySearch(cvm);
                }
            });
        }

        #region paste

        private bool CanPasteSingleSelection() => HasSingleItemCopied && SelectedItem?.CanPasteSelection(true) == true;

        private bool CanPasteSelection() => HasMultipleItemsCopied && SelectedItem?.CanPasteSelection() == true;

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

            var onlyArraysSelected = selectedNodes.All(s => s.IsArray);
            var groupedNodes = GroupByArrayOrParent(selectedNodes, (cvm) => cvm.CanPasteSelection(useSingle))
                .Where(group => group.Key.IsArray).ToList();

                foreach (var group in groupedNodes)
                {
                    if (onlyArraysSelected)
                    {
                        // clear out array and paste copied nodes
                        group.Key.ClearChildren();
                        group.Key.PasteAtIndex(copiedChunks, -1);
                    }
                    else
                    {
                        // delete selection, then paste at index of last selected child
                        group.Key.DeleteNodes(selectedNodes);
                        var pasteIndex = group.LastOrDefault()?.NodeIdxInParent ?? -1;
                        group.Key.PasteAtIndex(copiedChunks, pasteIndex);
                    }
                }

                ReapplySearchAsync(groupedNodes.Select(g => g.Key));
        }

        /// <summary>
        /// Will group list by next array in hierarchy (if the node is an array, it will be used for grouping)
        /// </summary>
        /// <param name="items">list of items (from selection)</param>
        /// <param name="callback">Optional: A callback to filter by</param>
        /// <returns></returns>
        private static IEnumerable<IGrouping<ChunkViewModel, ChunkViewModel>>
            GroupByArrayOrParent(List<ChunkViewModel> items, Func<ChunkViewModel, bool> callback = null)
        {
            // If we selected a bunch of nodes and the array they are in
            var itemParents = items.Select(chunk => chunk.Parent).ToList();
            return items
                .Except(itemParents)
                .Where((chunk) => callback is null || callback(chunk))
                .OrderBy(chunk => chunk.NodeIdxInParent)
                .GroupBy(chunk => chunk.IsArray ? chunk : chunk.Parent);
        }

        [RelayCommand(CanExecute = nameof(CanPasteSingleSelection))]
        private void OverwriteSelectionWithSingle() => OverwriteSelectedInternal(true);

        [RelayCommand(CanExecute = nameof(CanPasteSelection))]
        private void OverwriteSelectionWithPaste() => OverwriteSelectedInternal();

        [RelayCommand]
        private void ClearArray()
        {
            var chunkViewModels = GetSelectedChunks();
            if (ItemsSource is not ICollectionView collectionView || chunkViewModels.Count == 0)
            {
                return;
            }

            var groupedNodes = GroupByArrayOrParent(GetSelectedChunks()).Where(g => g.Key.IsArray).ToList();
            using (collectionView.DeferRefresh())
            {
                foreach (var group in groupedNodes)
                {
                    group.Key.ClearChildren();
                }
            }

            ReapplySearchAsync(groupedNodes.Select(g => g.Key));
        }

        [RelayCommand(CanExecute = nameof(CanPasteSelection))]
        private void ClearAndPasteSelection()
        {
            var copiedChunks = RedDocumentTabViewModel.GetCopiedChunks();
            if (ItemsSource is not ICollectionView collectionView || copiedChunks.Count == 0)
            {
                return;
            }

            var groupedNodes = GroupByArrayOrParent(GetSelectedChunks(), cvm => cvm.CanPasteSelection())
                .Where(group => group.Key.IsArray).ToList();

            using (collectionView.DeferRefresh())
            {
                foreach (var group in groupedNodes)
                {
                    group.Key.ClearChildren();
                    group.Key.PasteAtIndex(copiedChunks);
                    group.Key.RecalculateProperties();
                }
            }


            ReapplySearchAsync(groupedNodes.Select(g => g.Key));
        }

        [RelayCommand(CanExecute = nameof(CanPasteSingleSelection))]
        private void PasteSingleSelection() => PasteSelectionInternal(true);

        [RelayCommand(CanExecute = nameof(CanPasteSingleSelection))]
        private void ClearAndPasteSingle()
        {
            var selectedChunks = GetSelectedChunks();
            if (ItemsSource is not ICollectionView collectionView || selectedChunks.Count == 0 ||
                RedDocumentTabViewModel.CopiedChunk is null)
            {
                return;
            }

            _rdtDataViewModel?.ClearSelection();

            var groupedNodes = GroupByArrayOrParent(selectedChunks, i => i.CanPasteSelection(true))
                .Where(group => group.Key.IsArray).ToList();
            using (collectionView.DeferRefresh())
            {
                foreach (var group in groupedNodes)
                {
                    group.Key.ClearChildren();
                    group.Key.PasteAtIndex([RedDocumentTabViewModel.CopiedChunk]);
                    group.Key.RecalculateProperties();
                }
            }

            ReapplySearchAsync(groupedNodes.Select(g => g.Key));
        }

        private void PasteSelectionInternal(bool pasteSingleSelect = false)
        {
            List<IRedType> copiedChunks = [];
            if (pasteSingleSelect && RedDocumentTabViewModel.CopiedChunk is not null)
            {
                copiedChunks.Add(RedDocumentTabViewModel.CopiedChunk);
            }
            else if (!pasteSingleSelect)
            {
                copiedChunks.AddRange(RedDocumentTabViewModel.GetCopiedChunks());
            }

            if (ItemsSource is not ICollectionView collectionView || copiedChunks.Count == 0)
            {
                return;
            }

            var selectedChunks = GetSelectedChunks();
            List<ChunkViewModel> refreshSelection = [];

            using (collectionView.DeferRefresh())
            {
                foreach (var group in GroupByArrayOrParent(selectedChunks))
                {
                    if (group.FirstOrDefault() is not ChunkViewModel cvm)
                    {
                        if (!group.Key.IsArray)
                        {
                            continue;
                        }

                        cvm = group.Key;
                    }

                    var idx = cvm.IsArray ? -1 : cvm.NodeIdxInParent + 1;

                    if (pasteSingleSelect)
                    {
                        cvm.PasteAtIndex([RedDocumentTabViewModel.CopiedChunk], idx);
                    }
                    else
                    {
                        cvm.PasteAtIndex(copiedChunks, idx);
                    }

                    refreshSelection.Add(cvm);
                }

                refreshSelection.AddRange(selectedChunks);
            }


            ReapplySearchAsync(refreshSelection.Distinct());
        }

        private void ReapplySelection(List<ChunkViewModel> oldSelection)
        {
            var newSelection = GetSelectedChunks();
            newSelection.AddRange(oldSelection);

            // If we have an array and several children selected, deselect everything but the array
            var selectionChildren = newSelection.Where(x => newSelection.Contains(x.Parent)).ToList();

            foreach (var cvm in selectionChildren)
            {
                cvm.IsSelected = false;
            }

            newSelection = newSelection.Except(selectionChildren).ToList();

            _rdtDataViewModel.SetSelection(newSelection);
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

            ClearArrayCommand.NotifyCanExecuteChanged();
            ClearAndPasteSingleCommand.NotifyCanExecuteChanged();
            ClearAndPasteSelectionCommand.NotifyCanExecuteChanged();

            OverwriteSelectionWithSingleCommand.NotifyCanExecuteChanged();
            OverwriteSelectionWithPasteCommand.NotifyCanExecuteChanged();
        }

        private void RefreshContextMenuFlags()
        {
            var selectedItems = GetSelectedChunks();
            var selectedItem = selectedItems.LastOrDefault();

            SetCurrentValue(HasSelectionProperty, selectedItems.Count > 0);
            SetCurrentValue(HasMultipleItemsSelectedProperty, selectedItems.Count > 1);

            var isArray = selectedItem?.IsArray == true;
            var isInArray = selectedItem?.IsInArray == true;
            SetCurrentValue(IsArraySelectedProperty, isArray);
            SetCurrentValue(IsArrayItemSelectedProperty, isInArray);
            SetCurrentValue(IsHandleSelectedProperty, IsHandle(selectedItem));
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
            CopyHandleCommand.NotifyCanExecuteChanged();

            SelectedItem?.RefreshCommandStatus();
        }


        [RelayCommand]
        private void DuplicateSelectionAsNew()
        {
            if (ItemsSource is not ICollectionView collectionView)
            {
                return;
            }

            List<ChunkViewModel> chunksByParent = [];

            var chunks = GetSelectedChunks();

            using (collectionView.DeferRefresh())
            {
                foreach (var cvm in chunks)
                {
                    if (cvm.DuplicateAsNewChunk() is ChunkViewModel newChunk)
                    {
                        chunksByParent.Add(newChunk);
                    }
                }
            }

            SetSelectedItems(chunksByParent, true);
        }

        private void DuplicateSelectedChunks(bool preserveIndex = false)
        {
            if (ItemsSource is not ICollectionView collectionView)
            {
                return;
            }

            List<ChunkViewModel> chunksByParent = [];
            foreach (var chunks in GetSelectedChunks().GroupBy(chunk => chunk.Parent))
            {
                if (!preserveIndex)
                {
                    foreach (var cvm in chunks.OrderBy(cvm => cvm.NodeIdxInParent))
                    {
                        var newChunk = cvm.DuplicateChunk(cvm.NodeIdxInParent + chunks.Count());
                        if (newChunk is not null)
                        {
                            chunksByParent.Add(newChunk);
                        }
                    }
                }
                else
                {
                    foreach (var cvm in chunks)
                    {
                        var newChunk = cvm.DuplicateChunk(-1);
                        if (newChunk is not null)
                        {
                            chunksByParent.Add(newChunk);
                        }
                    }
                }
            }

            SetSelectedItems(chunksByParent);
        }

        /// <summary>
        /// Duplicates each chunk in selection. Will preserve index order if shift key is pressed.
        /// </summary>
        [RelayCommand]
        private void DuplicateSelection() => DuplicateSelectedChunks(ModifierViewStateService.IsShiftBeingHeld);

        [RelayCommand]
        private void AddToProject()
        {
            if (SelectedItem?.PropertyType.IsAssignableTo(typeof(IRedRef)) == true)
            {
                _projectResourceTools.AddToProject(((IRedRef)SelectedItem.ResolvedData).DepotPath);
            }
        }

        private bool CanOpenSearchAndReplaceDialog => !_isContextMenuOpen &&
                                                      SelectedItem is ChunkViewModel { Parent: not null } &&
                                                      !SearchAndReplaceDialog.IsInstanceOpen;

        // [RelayCommand(CanExecute = nameof(CanOpenSearchAndReplaceDialog))] this doesn't work if item is called from menu
        [RelayCommand]
        private void OpenSearchAndReplaceDialog()
        {
            var selectedChunkViewModels = GetSelectedChunks();
            if (selectedChunkViewModels.Count == 0)
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
            if (IsShiftBeingHeld)
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
        private void SetSelectedItems(List<ChunkViewModel> selectedChunkViewModels, bool forceLocal = false)
        {

            SetCurrentValue(SelectedItemsProperty, null);
            SetCurrentValue(SelectedItemProperty, null);

            if (_rdtDataViewModel is not null && !forceLocal)
            {
                _rdtDataViewModel.SetSelection(selectedChunkViewModels);
            }
            else
            {
                SetCurrentValue(SelectedItemsProperty, new ObservableCollection<object>(selectedChunkViewModels));
                SetCurrentValue(SelectedItemProperty, selectedChunkViewModels.LastOrDefault());
            }
        }

        private static void ReapplySearch(ChunkViewModel chunk)
        {
            if (string.IsNullOrEmpty(RedDocumentViewToolbarModel.CurrentActiveSearch))
            {
                return;
            }

            // force re-applying search
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

        private static bool IsHandle(ChunkViewModel cvm)
        {
            if (cvm is null)
            {
                return false;
            }

            return IsHandle(cvm.Data)
                   // Data can be a RedDummy after the object has been reset
                   || cvm.Type.StartsWith("whandle:")
                   || cvm.Type.StartsWith("handle:");
        }

        // Comparing strings - e.g. "wHandle:inkwidget"
        // For logic, see https://github.com/WolvenKit/WolvenKit/pull/2294#issuecomment-2760342954
        private static bool IsTypeCompatible(string pasteType, string targetType)
        {
            if (pasteType == targetType)
            {
                return true;
            }

            if (!pasteType.Contains(':') || !targetType.Contains(':'))
            {
                return false;
            }

            var pasteTypeParts = pasteType.Split(":");
            var targetTypeParts = targetType.Split(":");

            if (targetTypeParts[1] != pasteTypeParts[1])
            {
                return false;
            }

            // only handle may paste into handle, and that has been covered by the first check
            return targetType != "handle";
        }

        // For logic, see https://github.com/WolvenKit/WolvenKit/pull/2294#issuecomment-2760342954
        private bool CanPasteHandleSingle()
        {
            return IsHandle(SelectedItem) && RedDocumentTabViewModel.CopiedChunk is IRedType copiedItem && (
                // handle is directly compatible
                copiedItem.GetType().IsAssignableTo(SelectedItem.Data.GetType())

                // in case the target item has been reset, the types must match
                || (IsHandle(copiedItem) && IsTypeCompatible(copiedItem.RedType, SelectedItem.Type))
            );
        }

        [RelayCommand(CanExecute = nameof(CanPasteHandleSingle))]
        private void PasteHandleSingle()
        {
            var selectedChunks = GetSelectedChunks();

            if (ItemsSource is not ICollectionView collectionView ||
                !IsHandle(RedDocumentTabViewModel.CopiedChunk) ||
                selectedChunks.Count != 1 || SelectedItem is not ChunkViewModel cvm)
            {
                return;
            }

            using (collectionView.DeferRefresh())
            {
                if (PasteHandle(cvm, (IRedBaseHandle)RedDocumentTabViewModel.CopiedChunk!) != true)
                {
                    return;
                }

                cvm.SetVisibilityStatusBySearchString(RedDocumentViewToolbarModel.CurrentActiveSearch);
            }

            ReapplySearch(cvm.Parent);

            RefreshContextMenuFlags();
            RefreshSelectedItemsContextMenuFlags();
            RefreshCommandStatus();
        }

        // pasting logic: See fuzzo comment https://github.com/WolvenKit/WolvenKit/pull/2294#issuecomment-2760342954
        private static bool PasteHandle(ChunkViewModel cvm, IRedBaseHandle sourceHandle)
        {
            if (sourceHandle.GetValue() is not RedBaseClass srcHandleValue)
            {
                return false;
            }

            /*
             * handle -> handle => deepcopy
             * handle -> whandle => ref
             * whandle -> whandle => ref
             */

            switch (cvm.Data)
            {
                case IRedBaseHandle destinationHandle:
                {
                    if (!destinationHandle.InnerType.IsInstanceOfType(srcHandleValue))
                    {
                        return false;
                    }

                    if (cvm.PropertyType.GetGenericTypeDefinition() == typeof(CHandle<>))
                    {
                        cvm.Data = CHandle.Parse(sourceHandle.InnerType, srcHandleValue);
                    }
                    else if (cvm.PropertyType.GetGenericTypeDefinition() == typeof(CWeakHandle<>))
                    {
                        destinationHandle.SetValue(srcHandleValue);
                    }

                    cvm.RecalculateProperties(cvm.Data);
                    return true;
                }
                case RedDummy:
                case null:
                {
                    if (cvm.PropertyType.GetGenericTypeDefinition() == typeof(CHandle<>))
                    {
                        cvm.Data = CHandle.Parse(sourceHandle.InnerType, srcHandleValue);
                    }
                    else if (cvm.PropertyType.GetGenericTypeDefinition() == typeof(CWeakHandle<>))
                    {
                        cvm.Data = CWeakHandle.Parse(sourceHandle.InnerType, srcHandleValue);
                    }
                    else
                    {
                        return false;
                    }

                    cvm.RecalculateProperties(cvm.Data);
                    return true;
                }
            }

            return false;
        }

        #endregion

        private bool CanDeleteSelection() => SelectedItem is not null;

        [RelayCommand(CanExecute = nameof(CanDeleteSelection))]
        private void DeleteAllButSelection()
        {
            if (ItemsSource is not ICollectionView collectionView)
            {
                return;
            }

            var groupedNodes = GetSelectedChunks()
                .GroupBy(chunk => chunk.Parent).ToList();

            using (collectionView.DeferRefresh())
            {
                foreach (var chunkSiblings in groupedNodes.Select(group => group.ToList()))
                {
                    if (chunkSiblings.FirstOrDefault() is not ChunkViewModel cvm || cvm.Parent is null)
                    {
                        continue;
                    }

                    var chunksToDelete = cvm.Parent.TVProperties.Except(chunkSiblings).ToList();

                    cvm.DeleteNodesInParent(chunksToDelete);
                }
            }

            ReapplySearchAsync(groupedNodes.Select(g => g.Key));
        }


        [RelayCommand(CanExecute = nameof(CanDeleteSelection))]
        private void DeleteSelection()
        {
            if (ItemsSource is not ICollectionView collectionView)
            {
                return;
            }

            var groupedNodes = GetSelectedChunks().GroupBy(chunk => chunk.Parent).ToList();

            using (collectionView.DeferRefresh())
            {
                foreach (var chunkSiblings in from kvp in groupedNodes where kvp.Any() select kvp.ToList())
                {
                    chunkSiblings.First().DeleteNodesInParent(chunkSiblings);
                }
            }

            groupedNodes.FirstOrDefault()?.Key.Tab?.Parent.SetIsDirty(true);
            ReapplySearchAsync(groupedNodes.Select(g => g.Key));
        }

        private bool CanGenerateMissingMaterials()
        {
            return SelectedItem is ChunkViewModel
            {
                ResolvedData: CMesh,
                Parent: null
            };
        }

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
        private List<ChunkViewModel> GetSelectedChunks()
        {
            if (SelectedItems is not null)
            {
                return [.. SelectedItems.Cast<ChunkViewModel>()];
            }

            if (SelectedItem is not null)
            {
                return [SelectedItem];
            }

            return [];

        }

        private void OnSelectionChanged(object sender, ItemSelectionChangedEventArgs e)
        {
            if (sender is not SfTreeView treeView)
                return;

            var selectedChunks = treeView.SelectedItems?.OfType<ChunkViewModel>().ToList() ?? new List<ChunkViewModel>();

            // Update the dependency properties
            SetCurrentValue(SelectedItemsProperty, new ObservableCollection<object>(selectedChunks));
            SetCurrentValue(SelectedItemProperty, selectedChunks.LastOrDefault());

            // Update the RDTDataViewModel
            if (selectedChunks.Count > 0)
            {
                _rdtDataViewModel?.SetSelection(selectedChunks);
            }
            else
            {
                _rdtDataViewModel?.ClearSelection();
            }
        }

        private void OnDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (SelectedItem is null)
            {
                return;
            }

            // If the current chunk is not expanded, collapse all of its siblings
            if (!SelectedItem.IsExpanded && SelectedItem.Parent is ChunkViewModel parent)
            {
                SetCurrentValue(SelectedItemProperty, parent);
            }

            var expansionState = SelectedItem.IsExpanded;

            var expansionStates = SelectedItem.GetAllProperties().Select((child) => child.IsExpanded).ToList();
            SelectedItem.SetChildExpansionStates(!expansionStates.Contains(true));

            SelectedItem.IsExpanded = expansionState;
        }

        private ChunkViewModel GetRoot()
        {
            if (ItemsSource is not ListCollectionView selection)
            {
                return null;
            }

            return selection.Cast<ChunkViewModel>().ToList().FirstOrDefault((cvm) => cvm.Parent is null);
        }

        #region context_menu_and_keystates

        private bool _isContextMenuOpen;

        private readonly RDTDataViewModel _rdtDataViewModel;


        private void RefreshSelectedItemsContextMenuFlags()
        {
            SetCurrentValue(ShouldShowArrayOpsProperty,
                SelectedItem?.IsInArray == true || SelectedItem?.IsArray == true);

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
                    // update shift key state
                    if (IsShiftBeingHeld != ModifierViewStateService.IsShiftBeingHeld)
                    {
                        var scrollMode = ModifierViewStateService.IsShiftBeingHeld ? ScrollUnit.Item : ScrollUnit.Pixel;
                        TreeView.SetCurrentValue(VirtualizingPanel.ScrollUnitProperty, scrollMode);
                    }

                    SetCurrentValue(IsShiftBeingHeldProperty, ModifierViewStateService.IsShiftBeingHeld);
                    SetCurrentValue(IsCtrlBeingHeldProperty, ModifierViewStateService.IsCtrlBeingHeld);
                    break;
            }
        }

        #endregion


    }

}
