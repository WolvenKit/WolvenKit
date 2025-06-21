using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;
using WolvenKit.Views.GraphEditor;
using WolvenKit.Views.Tools;
using MahApps.Metro.IconPacks;

namespace WolvenKit.Views.Documents;
/// <summary>
/// Interaktionslogik für RDTGraphView2.xaml
/// </summary>
public partial class RDTGraphView2
{
    private bool _isFullScreen = false;
    private System.Windows.Window _fullScreenWindow = null;
    private WolvenKit.App.ViewModels.Documents.RDTDataViewModel _fullScreenDataViewModel;
    private WolvenKit.App.ViewModels.Documents.RDTGraphViewModel2 _fullScreenGraphViewModel;
    private System.Windows.Threading.DispatcherTimer _graphRefreshTimer;
    private bool _graphRefreshPending = false;
    private System.Windows.Controls.StackPanel _fullScreenBreadcrumb;
    private WolvenKit.App.ViewModels.Shell.AppViewModel _appViewModel;
    private System.Windows.Controls.TabControl _curatedTabs;

    public RDTGraphView2()
    {
        InitializeComponent();

        KeyDown += OnKeyDown;

        this.WhenActivated(disposables =>
        {
            BuildBreadcrumb();
        });
    }

    private void Editor_OnNodeDoubleClick(object sender, RoutedEventArgs e) => HandleSubGraph();

    private void OnKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Tab)
        {
            HandleSubGraph();
        }
    }

    private void HandleSubGraph()
    {
        if (Editor.SelectedNode is IGraphProvider provider)
        {
            var subGraph = provider.Graph;
            if (subGraph == null)
            {
                Locator.Current.GetService<ILoggerService>().Error("SubGraph is not defined!");
                return;
            }

            if (Editor.SelectedNode.Data is questPhaseNodeDefinition ph)
            {
                if (!ph.PhaseResource.IsSet)
                {
                    subGraph.StateParents = Editor.Source.StateParents + "." + ph.Id;
                    subGraph.DocumentViewModel = Editor.Source.DocumentViewModel;
                }
            }

            ViewModel!.History.Add(subGraph);
            Editor.SetCurrentValue(GraphEditorView.SourceProperty, subGraph);

            BuildBreadcrumb();
        }

        if (Editor.SelectedNode is questInputNodeDefinitionWrapper or questOutputNodeDefinitionWrapper)
        {
            if (ViewModel!.History.Count > 1)
            {
                ViewModel.History.Remove(ViewModel.History[^1]);
                Editor.SetCurrentValue(GraphEditorView.SourceProperty, ViewModel.History[^1]);

                BuildBreadcrumb();
            }
        }

        if (Editor.SelectedNode is scnStartNodeWrapper or scnEndNodeWrapper)
        {
            if (ViewModel!.History.Count > 1)
            {
                ViewModel.History.Remove(ViewModel.History[^1]);
                Editor.SetCurrentValue(GraphEditorView.SourceProperty, ViewModel.History[^1]);

                BuildBreadcrumb();
            }
        }
    }

    private void BuildBreadcrumb()
    {
        Breadcrumb.Children.Clear();

        // Add filename with dirty indicator at the beginning (only in fullscreen mode)
        if (_isFullScreen && ViewModel?.Parent is WolvenKit.App.ViewModels.Documents.RedDocumentViewModel docViewModel)
        {
            var filename = System.IO.Path.GetFileName(docViewModel.FilePath);
            var dirtyIndicator = docViewModel.IsDirty ? "*" : "";
            
            var fileElement = new TextBlock 
            { 
                Text = $"{filename}{dirtyIndicator}",
                FontWeight = System.Windows.FontWeights.Bold,
                Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.White),
                Margin = new System.Windows.Thickness(0, 0, 10, 0)
            };
            Breadcrumb.Children.Add(fileElement);
            
            // Add separator after filename if there are graph items
            if (ViewModel!.History.Count > 0)
            {
                AddNewElement("|", null);
            }
        }

        for (var i = 0; i < ViewModel!.History.Count; i++)
        {
            AddNewElement(ViewModel.History[i].Title, ViewModel.History[i]);

            if (i < ViewModel.History.Count - 1)
            {
                AddNewElement(">", null);
            }
        }

        void AddNewElement(string text, RedGraph graph)
        {
            if (Breadcrumb.Children.Count > 0)
            {
                text = " " + text;
            }

            var tmp = new TextBlock { Text = text, Tag = graph };
            tmp.PreviewMouseDown += BreadcrumbElement_OnPreviewMouseDown;

            Breadcrumb.Children.Add(tmp);
        }
    }

    private void BreadcrumbElement_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
        if (sender is not TextBlock { Tag: RedGraph graph } block)
        {
            return;
        }

        if (ViewModel!.History.Count == 1)
        {
            return;
        }

        if (block.Text.Trim() == ">")
        {
            return;
        }

        Editor.SetCurrentValue(GraphEditorView.SourceProperty, graph);

        for (var i = ViewModel.History.Count - 1; i >= 0; i--)
        {
            if (ReferenceEquals(ViewModel.History[i], graph))
            {
                break;
            }
            ViewModel.History.RemoveAt(i);
        }

        BuildBreadcrumb();
    }

    private void FullScreenButton_Click(object sender, RoutedEventArgs e)
    {
        ToggleFullScreen();
    }

    private void ToggleFullScreen()
    {
        if (!_isFullScreen)
        {
            EnterFullScreen();
        }
        else
        {
            ExitFullScreen();
        }
    }

    private void EnterFullScreen()
    {
        // Create a new full screen window
        _fullScreenWindow = new System.Windows.Window
        {
            WindowStyle = WindowStyle.None,
            WindowState = WindowState.Maximized,
            AllowsTransparency = false,
            Background = System.Windows.Media.Brushes.Black
        };

        // Check if this is a quest or scene file that can benefit from combined view
        if (ViewModel?.Parent is WolvenKit.App.ViewModels.Documents.RedDocumentViewModel docViewModel)
        {
            // Set initial window title with filename and dirty indicator
            UpdateFullScreenWindowTitle(docViewModel);
            
            // Subscribe to property changes to update title when dirty state changes
            docViewModel.PropertyChanged += OnDocumentPropertyChanged;

            // Intercept dialog system to show dialogs on fullscreen window instead of main window
            SetupDialogInterception();

            // Get the existing tab data instead of creating new view models
            var dataTab = docViewModel.TabItemViewModels.OfType<WolvenKit.App.ViewModels.Documents.RDTDataViewModel>().FirstOrDefault();
            var graphTab = docViewModel.TabItemViewModels.OfType<WolvenKit.App.ViewModels.Documents.RDTGraphViewModel2>().FirstOrDefault();
            
            if (dataTab != null && graphTab != null)
            {
                var data = dataTab.GetData();
                if (data is graphGraphResource or scnSceneResource)
                {
                    // Use existing loaded view models to avoid initialization issues
                    var fullScreenCombinedView = CreateFullScreenCombinedViewFromExisting(dataTab, graphTab);
                    _fullScreenWindow.SetCurrentValue(System.Windows.Window.ContentProperty, fullScreenCombinedView);
                }
                else
                {
                    // Not a quest/scene file, use regular fullscreen
                    CreateRegularFullScreenView();
                }
            }
            else
            {
                // Fallback to regular graph editor
                CreateRegularFullScreenView();
            }

            docViewModel.OnSaveCompleted += OnSaveCompleted;
        }
        else
        {
            // Regular graph editor fullscreen
            CreateRegularFullScreenView();
        }
        
        // Add escape key handler
        _fullScreenWindow.KeyDown += (s, e) =>
        {
            if (e.Key == Key.Escape || e.Key == Key.F11)
            {
                ExitFullScreen();
            }

            if (e.Key == Key.S && (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)))
            {
                ViewModel?.Parent?.Save(null);
                e.Handled = true; // prevent further handling
            }
        };
        
        _fullScreenWindow.Show();

        // Update button state
        _isFullScreen = true;
        UpdateFullScreenButtonIcon();

        // Handle window closing
        _fullScreenWindow.Closed += (s, e) => ExitFullScreen();
    }

    private void ExitFullScreen()
    {
        if (_fullScreenWindow == null) return;

        // Stop and cleanup the refresh timer
        if (_graphRefreshTimer != null)
        {
            _graphRefreshTimer.Stop();
            _graphRefreshTimer = null;
        }

        if (ViewModel?.Parent is WolvenKit.App.ViewModels.Documents.RedDocumentViewModel docViewModel)
        {
            docViewModel.OnSaveCompleted -= OnSaveCompleted;
            docViewModel.PropertyChanged -= OnDocumentPropertyChanged;
            docViewModel.PropertyChanged -= OnFullScreenDocumentPropertyChanged;
        }

        // Restore original dialog system
        RestoreDialogInterception();

        // Close and cleanup full screen window
        _fullScreenWindow.Close();
        _fullScreenWindow = null;
        
        // Clear references
        _fullScreenDataViewModel = null;
        _fullScreenGraphViewModel = null;
        _fullScreenBreadcrumb = null;
        _graphRefreshPending = false;
        _curatedTabs = null;
        
        // Update state
        _isFullScreen = false;
        UpdateFullScreenButtonIcon();
    }

    private void UpdateFullScreenButtonIcon()
    {
        if (FullScreenButton?.Content is Viewbox viewbox &&
            viewbox.Child is Canvas canvas &&
            canvas.Children[0] is System.Windows.Shapes.Path path)
        {
            if (_isFullScreen)
            {
                // Exit full screen icon
                path.Data = System.Windows.Media.Geometry.Parse("M5,16h3v3h2v-5H5V16z M8,8H5v2h5V5H8V8z M14,19h2v-3h3v-2h-5V19z M16,8V5h-2v5h5V8H16z");
            }
            else
            {
                // Enter full screen icon
                path.Data = System.Windows.Media.Geometry.Parse("M7,14H5v5h5v-2H7V14z M5,10h2V7h3V5H5V10z M17,7h-3v2h3v3h2V7V5h-2V7z M14,14h3v3h2v-5h-5V14z");
            }
        }
    }

    private void CreateRegularFullScreenView()
    {
        // Create a new GraphEditorView for the full screen window
        var fullScreenEditor = new GraphEditorView
        {
            Source = Editor.Source,
            SelectedNode = Editor.SelectedNode,
            SelectedNodes = Editor.SelectedNodes,
            ViewportLocation = Editor.ViewportLocation
        };
        
        _fullScreenWindow.SetCurrentValue(System.Windows.Window.ContentProperty, fullScreenEditor);
    }

    private System.Windows.UIElement CreateFullScreenCombinedViewFromExisting(
        WolvenKit.App.ViewModels.Documents.RDTDataViewModel dataViewModel,
        WolvenKit.App.ViewModels.Documents.RDTGraphViewModel2 graphViewModel)
    {
        // Create a top-level Grid with breadcrumb at the top
        var topLevelGrid = new System.Windows.Controls.Grid();
        topLevelGrid.RowDefinitions.Add(new System.Windows.Controls.RowDefinition { Height = System.Windows.GridLength.Auto }); // Breadcrumb row
        topLevelGrid.RowDefinitions.Add(new System.Windows.Controls.RowDefinition { Height = new System.Windows.GridLength(1, System.Windows.GridUnitType.Star) }); // Content row

        // Create breadcrumb panel at the very top
        var breadcrumbPanel = new System.Windows.Controls.StackPanel
        {
            Orientation = System.Windows.Controls.Orientation.Horizontal,
            VerticalAlignment = System.Windows.VerticalAlignment.Center,
            Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(48, 48, 48)),
            Height = 30,
            Margin = new System.Windows.Thickness(0, 0, 0, 2)
        };
        
        // Add filename with dirty indicator
        if (graphViewModel.Parent is WolvenKit.App.ViewModels.Documents.RedDocumentViewModel parentDoc)
        {
            var filename = System.IO.Path.GetFileName(parentDoc.FilePath);
            var dirtyIndicator = parentDoc.IsDirty ? "*" : "";
            
            var fileElement = new System.Windows.Controls.TextBlock 
            { 
                Text = $"{filename}{dirtyIndicator}",
                FontWeight = System.Windows.FontWeights.Bold,
                Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.White),
                Margin = new System.Windows.Thickness(10, 0, 10, 0),
                VerticalAlignment = System.Windows.VerticalAlignment.Center
            };
            breadcrumbPanel.Children.Add(fileElement);
            
            // Add separator
            var separator = new System.Windows.Controls.TextBlock 
            { 
                Text = "|",
                Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Gray),
                Margin = new System.Windows.Thickness(0, 0, 10, 0),
                VerticalAlignment = System.Windows.VerticalAlignment.Center
            };
            breadcrumbPanel.Children.Add(separator);
            
            // Store reference to breadcrumb for updates
            _fullScreenBreadcrumb = breadcrumbPanel;
            
            // Subscribe to property changes to update breadcrumb
            parentDoc.PropertyChanged += OnFullScreenDocumentPropertyChanged;
        }
        
        // Add the graph title
        var graphTitle = new System.Windows.Controls.TextBlock 
        { 
            Text = graphViewModel.MainGraph?.Title ?? "Graph",
            Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.White),
            VerticalAlignment = System.Windows.VerticalAlignment.Center
        };
        breadcrumbPanel.Children.Add(graphTitle);
        
        System.Windows.Controls.Grid.SetRow(breadcrumbPanel, 0);
        topLevelGrid.Children.Add(breadcrumbPanel);

        // Store references for synchronization BEFORE creating panels
        _fullScreenDataViewModel = dataViewModel;
        _fullScreenGraphViewModel = graphViewModel;

        // Create the main content grid for the combined fullscreen layout
        var mainGrid = new System.Windows.Controls.Grid();
        
        // Define columns: Curated Panels (50%) | Graph (50%) with splitter
        mainGrid.ColumnDefinitions.Add(new System.Windows.Controls.ColumnDefinition { Width = new System.Windows.GridLength(50, System.Windows.GridUnitType.Star) }); // Curated panels
        mainGrid.ColumnDefinitions.Add(new System.Windows.Controls.ColumnDefinition { Width = new System.Windows.GridLength(4, System.Windows.GridUnitType.Pixel) });
        mainGrid.ColumnDefinitions.Add(new System.Windows.Controls.ColumnDefinition { Width = new System.Windows.GridLength(50, System.Windows.GridUnitType.Star) }); // Graph (50%)

        // Check if this is a scene file to show curated panels
        var sceneData = dataViewModel.GetData();
        if (sceneData is scnSceneResource)
        {
            // Curated Scene Panels
            var curatedPanels = CreateCuratedScenePanels(dataViewModel);
            System.Windows.Controls.Grid.SetColumn(curatedPanels, 0);
            mainGrid.Children.Add(curatedPanels);
        }
        else
        {
            // Fallback to regular tree view for non-scene files
            var treePanel = CreateFullScreenTreePanel("Data Structure", dataViewModel);
            System.Windows.Controls.Grid.SetColumn(treePanel, 0);
            mainGrid.Children.Add(treePanel);
        }

        // Splitter
        var splitter1 = new System.Windows.Controls.GridSplitter
        {
            Width = 4,
            HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch,
            Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 64, 64))
        };
        System.Windows.Controls.Grid.SetColumn(splitter1, 1);
        mainGrid.Children.Add(splitter1);

        // Graph View Panel - Use the existing graph editor directly
        var graphPanel = CreateGraphPanelWithExistingEditor(graphViewModel);
        System.Windows.Controls.Grid.SetColumn(graphPanel, 2);
        mainGrid.Children.Add(graphPanel);

        // Add main grid to the content row
        System.Windows.Controls.Grid.SetRow(mainGrid, 1);
        topLevelGrid.Children.Add(mainGrid);

        return topLevelGrid;
    }

    private System.Windows.Controls.Border CreateFullScreenTreePanel(string title, WolvenKit.App.ViewModels.Documents.RDTDataViewModel treeViewModel)
    {
        var border = new System.Windows.Controls.Border
        {
            Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(32, 32, 32)),
            BorderBrush = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 64, 64)),
            BorderThickness = new System.Windows.Thickness(1, 1, 1, 1)
        };

        var mainGrid = new System.Windows.Controls.Grid();
        mainGrid.RowDefinitions.Add(new System.Windows.Controls.RowDefinition { Height = System.Windows.GridLength.Auto });
        mainGrid.RowDefinitions.Add(new System.Windows.Controls.RowDefinition { Height = new System.Windows.GridLength(1, System.Windows.GridUnitType.Star) });

        // Header
        var header = new System.Windows.Controls.Border
        {
            Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(48, 48, 48)),
            Padding = new System.Windows.Thickness(8, 4, 8, 4)
        };
        var headerText = new System.Windows.Controls.TextBlock
        {
            Text = title,
            FontWeight = System.Windows.FontWeights.Bold,
            FontSize = 14,
            Foreground = System.Windows.Media.Brushes.White
        };
        header.Child = headerText;
        System.Windows.Controls.Grid.SetRow(header, 0);
        mainGrid.Children.Add(header);

        // Content Grid - Contains tree and property editor side by side
        var contentGrid = new System.Windows.Controls.Grid();
        contentGrid.ColumnDefinitions.Add(new System.Windows.Controls.ColumnDefinition { Width = new System.Windows.GridLength(3, System.Windows.GridUnitType.Star) }); // Tree 30% (3/5 of 50%)
        contentGrid.ColumnDefinitions.Add(new System.Windows.Controls.ColumnDefinition { Width = new System.Windows.GridLength(4, System.Windows.GridUnitType.Pixel) });
        contentGrid.ColumnDefinitions.Add(new System.Windows.Controls.ColumnDefinition { Width = new System.Windows.GridLength(2, System.Windows.GridUnitType.Star) }); // Properties 20% (2/5 of 50%)

        // Tree View (left side)
        var treeView = new WolvenKit.Views.Tools.RedTreeView
        {
            ItemsSource = treeViewModel.Chunks,
            SelectedItem = treeViewModel.SelectedChunk,
            Margin = new System.Windows.Thickness(4, 4, 4, 4)
        };
        
        // Set up two-way binding for selected item
        var selectedItemBinding = new System.Windows.Data.Binding("SelectedChunk")
        {
            Source = treeViewModel,
            Mode = System.Windows.Data.BindingMode.TwoWay
        };
        treeView.SetBinding(WolvenKit.Views.Tools.RedTreeView.SelectedItemProperty, selectedItemBinding);
        
        // Set up two-way binding for selected items
        var selectedItemsBinding = new System.Windows.Data.Binding("SelectedChunks")
        {
            Source = treeViewModel,
            Mode = System.Windows.Data.BindingMode.TwoWay
        };
        treeView.SetBinding(WolvenKit.Views.Tools.RedTreeView.SelectedItemsProperty, selectedItemsBinding);
        
        System.Windows.Controls.Grid.SetColumn(treeView, 0);
        contentGrid.Children.Add(treeView);

        // Splitter between tree and properties
        var splitter = new System.Windows.Controls.GridSplitter
        {
            Width = 4,
            HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch,
            Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 64, 64))
        };
        System.Windows.Controls.Grid.SetColumn(splitter, 1);
        contentGrid.Children.Add(splitter);

        // Property Editor (right side)
        var propertyEditor = new WolvenKit.Views.Editors.RedTypeView();
        
        // Bind its DataContext to the SelectedChunk
        var dataContextBinding = new System.Windows.Data.Binding("SelectedChunk")
        {
            Source = treeViewModel,
            Mode = System.Windows.Data.BindingMode.OneWay
        };
        propertyEditor.SetBinding(System.Windows.Controls.UserControl.DataContextProperty, dataContextBinding);
        
        System.Windows.Controls.Grid.SetColumn(propertyEditor, 2);
        contentGrid.Children.Add(propertyEditor);

        System.Windows.Controls.Grid.SetRow(contentGrid, 1);
        mainGrid.Children.Add(contentGrid);

        border.Child = mainGrid;
        return border;
    }

    private System.Windows.Controls.Border CreateGraphPanelFromExisting(WolvenKit.App.ViewModels.Documents.RDTGraphViewModel2 graphViewModel)
    {
        var border = new System.Windows.Controls.Border
        {
            Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(32, 32, 32)),
            BorderBrush = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 64, 64)),
            BorderThickness = new System.Windows.Thickness(1, 1, 1, 1)
        };

        var grid = new System.Windows.Controls.Grid();
        grid.RowDefinitions.Add(new System.Windows.Controls.RowDefinition { Height = System.Windows.GridLength.Auto });
        grid.RowDefinitions.Add(new System.Windows.Controls.RowDefinition { Height = new System.Windows.GridLength(1, System.Windows.GridUnitType.Star) });

        // Header
        var header = new System.Windows.Controls.Border
        {
            Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(48, 48, 48)),
            Padding = new System.Windows.Thickness(8, 4, 8, 4)
        };
        var headerText = new System.Windows.Controls.TextBlock
        {
            Text = "Graph View",
            FontWeight = System.Windows.FontWeights.Bold,
            FontSize = 14,
            Foreground = System.Windows.Media.Brushes.White
        };
        header.Child = headerText;
        System.Windows.Controls.Grid.SetRow(header, 0);
        grid.Children.Add(header);

        // Graph content placeholder to avoid crashes
        var graphPlaceholder = new System.Windows.Controls.TextBlock
        {
            Text = "Graph View\n\nNote: Graph rendering in fullscreen mode is temporarily disabled due to initialization issues.\nPlease use the regular Graph tab for full graph functionality.",
            TextWrapping = System.Windows.TextWrapping.Wrap,
            FontSize = 14,
            Foreground = System.Windows.Media.Brushes.Gray,
            HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
            VerticalAlignment = System.Windows.VerticalAlignment.Center,
            Margin = new System.Windows.Thickness(20)
        };
        
        System.Windows.Controls.Grid.SetRow(graphPlaceholder, 1);
        grid.Children.Add(graphPlaceholder);

        border.Child = grid;
        return border;
    }

    private System.Windows.Controls.Border CreateGraphPanelWithExistingEditor(WolvenKit.App.ViewModels.Documents.RDTGraphViewModel2 graphViewModel)
    {
        var border = new System.Windows.Controls.Border
        {
            Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(32, 32, 32)),
            BorderBrush = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 64, 64)),
            BorderThickness = new System.Windows.Thickness(1, 1, 1, 1)
        };

        var grid = new System.Windows.Controls.Grid();
        grid.RowDefinitions.Add(new System.Windows.Controls.RowDefinition { Height = System.Windows.GridLength.Auto });
        grid.RowDefinitions.Add(new System.Windows.Controls.RowDefinition { Height = new System.Windows.GridLength(1, System.Windows.GridUnitType.Star) });

        // Header
        var header = new System.Windows.Controls.Border
        {
            Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(48, 48, 48)),
            Padding = new System.Windows.Thickness(8, 4, 8, 4)
        };
        var headerText = new System.Windows.Controls.TextBlock
        {
            Text = "Graph View",
            FontWeight = System.Windows.FontWeights.Bold,
            FontSize = 14,
            Foreground = System.Windows.Media.Brushes.White
        };
        header.Child = headerText;
        System.Windows.Controls.Grid.SetRow(header, 0);
        grid.Children.Add(header);

        // Create a simple wrapper to hold the graph without triggering automatic layout
        var graphWrapper = new System.Windows.Controls.Border
        {
            Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(32, 32, 32))
        };
        
        // Create a loading indicator
        var loadingPanel = new System.Windows.Controls.Grid();
        
        var progressRing = new HandyControl.Controls.LoadingCircle
        {
            Width = 60,
            Height = 60,
            HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
            VerticalAlignment = System.Windows.VerticalAlignment.Center,
            Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(100, 149, 237)) // Cornflower blue
        };
        
        var loadingText = new System.Windows.Controls.TextBlock
        {
            Text = "Loading graph...",
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = System.Windows.VerticalAlignment.Center,
                Foreground = System.Windows.Media.Brushes.Gray,
            FontSize = 14,
            Margin = new System.Windows.Thickness(0, 80, 0, 0)
        };
        
        loadingPanel.Children.Add(progressRing);
        loadingPanel.Children.Add(loadingText);
        graphWrapper.Child = loadingPanel;
        
        // Defer creating the actual graph view to avoid initialization issues
        System.Windows.Application.Current?.Dispatcher.BeginInvoke(
            new Action(() =>
            {
                try
                {
                    // Create the graph editor view directly without RDTGraphView2 wrapper
                    var graphEditorView = new GraphEditorView
                    {
                        Margin = new System.Windows.Thickness(4, 4, 4, 4)
                    };
                    
                    // Bind the Source property to the MainGraph on the viewmodel
                    var sourceBinding = new System.Windows.Data.Binding("MainGraph")
                    {
                        Source = graphViewModel,
                        Mode = System.Windows.Data.BindingMode.OneWay
                    };
                    graphEditorView.SetBinding(GraphEditorView.SourceProperty, sourceBinding);
                    
                    // Replace the loading text with the actual graph
                    graphWrapper.Child = graphEditorView;
                    
                    // Set up synchronization after the graph is loaded
                    if (_fullScreenDataViewModel != null && _fullScreenGraphViewModel != null)
                    {
                        SetupTreeGraphSync(_fullScreenDataViewModel, _fullScreenGraphViewModel, graphEditorView);
                    }
                }
                catch (Exception ex)
                {
                    // If there's still an error, show it
                    graphWrapper.Child = new System.Windows.Controls.TextBlock
                    {
                        Text = $"Error loading graph: {ex.Message}",
                        HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                        VerticalAlignment = System.Windows.VerticalAlignment.Center,
                        Foreground = System.Windows.Media.Brushes.Red,
                        FontSize = 12,
                        TextWrapping = System.Windows.TextWrapping.Wrap,
                        Margin = new System.Windows.Thickness(20)
                    };
                }
            }),
            System.Windows.Threading.DispatcherPriority.Background
        );
        
        System.Windows.Controls.Grid.SetRow(graphWrapper, 1);
        grid.Children.Add(graphWrapper);

        border.Child = grid;
        return border;
    }

    private T FindVisualChild<T>(System.Windows.DependencyObject parent, string name = null) where T : System.Windows.FrameworkElement
    {
        if (parent == null) return null;

        for (int i = 0; i < System.Windows.Media.VisualTreeHelper.GetChildrenCount(parent); i++)
        {
            var child = System.Windows.Media.VisualTreeHelper.GetChild(parent, i);
            
            if (child is T typedChild)
            {
                if (name == null || typedChild.Name == name)
                    return typedChild;
            }

            var result = FindVisualChild<T>(child, name);
            if (result != null)
                return result;
        }

        return null;
    }

    private void SetupTreeGraphSync(
        WolvenKit.App.ViewModels.Documents.RDTDataViewModel dataViewModel,
        WolvenKit.App.ViewModels.Documents.RDTGraphViewModel2 graphViewModel,
        GraphEditorView graphEditor)
    {
        // Subscribe to tree selection changes to update graph
        if (dataViewModel != null)
        {
            dataViewModel.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == nameof(dataViewModel.SelectedChunk))
                {
                    // When tree selection changes, try to find and select corresponding graph node
                    var selectedChunk = dataViewModel.SelectedChunk;
                    if (selectedChunk != null && graphViewModel?.MainGraph != null)
                    {
                        // Find corresponding node in graph
                        var correspondingNode = graphViewModel.MainGraph.Nodes?.FirstOrDefault(n => 
                            n.Data == selectedChunk.Data || 
                            (n.Data != null && selectedChunk.Data != null && n.Data.Equals(selectedChunk.Data)));
                        
                        if (correspondingNode != null && graphEditor != null)
                        {
                            // Update graph selection
                            graphEditor.SelectedNode = correspondingNode;
                            
                            // Center the node in view
                            if (correspondingNode.Location != default)
                            {
                                graphEditor.ViewportLocation = new System.Windows.Point(
                                    correspondingNode.Location.X - graphEditor.ActualWidth / 2,
                                    correspondingNode.Location.Y - graphEditor.ActualHeight / 2);
                            }
                        }
                    }
                }
            };

            // Subscribe to data changes in tree to update graph
            SetupTreeDataChangeSync(dataViewModel, graphViewModel, graphEditor);
        }

        // Subscribe to graph selection changes to update tree
        if (graphViewModel?.MainGraph != null && graphEditor != null)
        {
            graphEditor.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == nameof(graphEditor.SelectedNode))
                {
                    var selectedNode = graphEditor.SelectedNode;
                    if (selectedNode != null && dataViewModel != null)
                    {
                        // Only sync tree selection if the Node Properties tab is active
                        if (_curatedTabs != null && _curatedTabs.SelectedIndex == 1) // 1 is the index for "Node Properties"
                    {
                        // Find corresponding chunk in tree
                            var correspondingChunk = FindChunkInTree(dataViewModel.GetRootChunk(), selectedNode.Data);
                        if (correspondingChunk != null)
                        {
                                // Expand all parent nodes to make the selection visible
                                ExpandParentNodes(correspondingChunk);
                            dataViewModel.SelectedChunk = correspondingChunk;
                                dataViewModel.ScrollToNode(correspondingChunk);
                            }
                            else
                            {
                                // If direct match fails, try to find the node in the graph structure
                                var nodeData = selectedNode.Data;
                                if (nodeData != null)
                                {
                                    ChunkViewModel foundChunk = null;

                                    // Try to find in scene graph structure
                                    if (dataViewModel.GetData() is scnSceneResource)
                                    {
                                        var rootChunk = dataViewModel.GetRootChunk();
                                        if (rootChunk != null)
                                        {
                                            rootChunk.CalculateProperties();
                                            rootChunk.IsExpanded = true;
                                            
                                            var sceneGraphChunk = rootChunk.GetPropertyChild("sceneGraph");
                                            if (sceneGraphChunk != null)
                                            {
                                                sceneGraphChunk.IsExpanded = true;
                                                
                                                var graphChunk = sceneGraphChunk.GetPropertyChild("graph");
                                                if (graphChunk != null)
                                                {
                                                    graphChunk.IsExpanded = true;
                                                    
                                                    // For scene graphs, the "graph" property IS the nodes array
                                                    foundChunk = FindNodeInArray(graphChunk, nodeData);
                                                }
                                            }
                                        }
                                    }
                                    // Try to find in quest graph structure
                                    else if (dataViewModel.GetData() is graphGraphResource)
                                    {
                                        var rootChunk = dataViewModel.GetRootChunk();
                                        if (rootChunk != null)
                                        {
                                            rootChunk.IsExpanded = true;
                                            
                                            var graphChunk = rootChunk.GetPropertyChild("graph");
                                            if (graphChunk != null)
                                            {
                                                graphChunk.IsExpanded = true;
                                                
                                                var nodesArray = graphChunk.GetPropertyChild("nodes");
                                                if (nodesArray != null)
                                                {
                                                    nodesArray.IsExpanded = true;
                                                    foundChunk = FindNodeInArray(nodesArray, nodeData);
                                                }
                                            }
                                        }
                                    }
                                    
                                    if (foundChunk != null)
                                    {
                                        // Expand the found node itself to show its properties
                                        foundChunk.IsExpanded = true;
                                        
                                        // For scnQuestNode, also expand the questNode property to show its contents
                                        if (foundChunk.Data is scnQuestNode)
                                        {
                                            // Ensure properties are calculated before trying to access them
                                            foundChunk.CalculateProperties();
                                            var questNodeProperty = foundChunk.GetPropertyChild("questNode");
                                            if (questNodeProperty != null)
                                            {
                                                questNodeProperty.IsExpanded = true;
                                            }
                                        }
                                        else if (foundChunk.Data is IRedBaseHandle handle && handle.GetValue() is scnQuestNode)
                                        {
                                            // Handle case where scnQuestNode is wrapped in a handle
                                            foundChunk.CalculateProperties();
                                            var questNodeProperty = foundChunk.GetPropertyChild("questNode");
                                            if (questNodeProperty != null)
                                            {
                                                questNodeProperty.IsExpanded = true;
                                            }
                                        }
                                        
                                        // Expand all parent nodes to make the selection visible
                                        ExpandParentNodes(foundChunk);
                                        
                                        // Select the node
                                        dataViewModel.SelectedChunk = foundChunk;
                                        
                                        // Scroll to the selected node with a small delay to ensure UI has updated
                                        System.Windows.Application.Current?.Dispatcher.BeginInvoke(new Action(() =>
                                        {
                                            dataViewModel.ScrollToNode(foundChunk);
                                        }), System.Windows.Threading.DispatcherPriority.Background);
                                    }
                                }
                            }
                        }
                    }
                }
            };

            // Subscribe to graph data changes to update tree
            SetupGraphDataChangeSync(dataViewModel, graphViewModel);
        }
    }

    private ChunkViewModel FindNodeInArray(ChunkViewModel nodesArray, object nodeData)
    {
        if (nodesArray?.TVProperties == null) return null;
        
        foreach (var nodeChunk in nodesArray.TVProperties)
        {
            // For scene graphs, the chunk data is a CHandle<scnSceneGraphNode>, so we need to get the actual node
            var actualNodeData = nodeChunk.Data;
            if (nodeChunk.Data is IRedBaseHandle handle && handle.GetValue() is scnSceneGraphNode actualSceneNode)
            {
                actualNodeData = actualSceneNode;
            }
            
            // Check if this chunk's data matches
            if (actualNodeData == nodeData || 
                (actualNodeData != null && nodeData != null && actualNodeData.Equals(nodeData)))
            {
                return nodeChunk;
            }
            
            // For scene nodes, check the nodeId
            if (nodeData is scnSceneGraphNode sceneNode && 
                actualNodeData is scnSceneGraphNode chunkSceneNode)
            {
                if (sceneNode.NodeId.Id == chunkSceneNode.NodeId.Id)
                {
                    return nodeChunk;
                }
            }
            
            // For quest nodes, check the id
            if (nodeData is questNodeDefinition questNode && 
                nodeChunk.Data is questNodeDefinition chunkQuestNode)
            {
                if (questNode.Id == chunkQuestNode.Id)
                {
                    return nodeChunk;
                }
            }
            
            // Additional check for quest phase nodes
            if (nodeData is questPhaseNodeDefinition questPhaseNode && 
                nodeChunk.Data is questPhaseNodeDefinition chunkQuestPhaseNode &&
                questPhaseNode.Id == chunkQuestPhaseNode.Id)
            {
                return nodeChunk;
            }
            
            // Check for other quest node types by id property
            var nodeDataType = nodeData?.GetType();
            var chunkDataType = nodeChunk.Data?.GetType();
            if (nodeDataType != null && chunkDataType != null && nodeDataType == chunkDataType)
            {
                // Try to get Id property using reflection
                var nodeIdProp = nodeDataType.GetProperty("Id");
                var nodeNodeIdProp = nodeDataType.GetProperty("NodeId");
                
                if (nodeIdProp != null)
                {
                    var nodeId = nodeIdProp.GetValue(nodeData);
                    var chunkId = nodeIdProp.GetValue(nodeChunk.Data);
                    if (nodeId != null && chunkId != null && nodeId.Equals(chunkId))
                    {
                        return nodeChunk;
                    }
                }
                else if (nodeNodeIdProp != null)
                {
                    var nodeNodeId = nodeNodeIdProp.GetValue(nodeData);
                    var chunkNodeId = nodeNodeIdProp.GetValue(nodeChunk.Data);
                    
                    // For scnSceneNodeId, we need to compare the Id property within it
                    if (nodeNodeId != null && chunkNodeId != null)
                    {
                        var nodeIdType = nodeNodeId.GetType();
                        var idProp = nodeIdType.GetProperty("Id");
                        if (idProp != null)
                        {
                            var nodeIdValue = idProp.GetValue(nodeNodeId);
                            var chunkIdValue = idProp.GetValue(chunkNodeId);
                            if (nodeIdValue != null && chunkIdValue != null && nodeIdValue.Equals(chunkIdValue))
                            {
                                return nodeChunk;
                            }
                        }
                    }
                }
            }
        }
        
        return null;
    }

    private void ExpandParentNodes(ChunkViewModel chunk)
    {
        if (chunk.Parent != null)
        {
            chunk.Parent.IsExpanded = true;
            ExpandParentNodes(chunk.Parent);
        }
    }

    private ChunkViewModel FindChunkInTree(ChunkViewModel root, object targetData)
    {
        if (root == null || targetData == null) return null;

        // Check if this chunk matches
        if (root.Data == targetData || (root.Data != null && root.Data.Equals(targetData)))
        {
            return root;
        }

        // Recursively search children
        if (root.Properties != null)
        {
            foreach (var property in root.Properties)
            {
                var found = FindChunkInTree(property, targetData);
                if (found != null) return found;
            }
        }

        if (root.TVProperties != null)
        {
            foreach (var property in root.TVProperties)
            {
                var found = FindChunkInTree(property, targetData);
                if (found != null) return found;
            }
        }

        return null;
    }

    private void SetupTreeDataChangeSync(
        WolvenKit.App.ViewModels.Documents.RDTDataViewModel dataViewModel,
        WolvenKit.App.ViewModels.Documents.RDTGraphViewModel2 graphViewModel,
        GraphEditorView graphEditor)
    {
        if (dataViewModel?.GetRootChunk() == null || graphViewModel?.MainGraph == null) return;

        // The old logic for real-time sync via timers is being replaced
        // by the OnSaveCompleted event, which is more reliable.
        // We can leave this method empty for now, or remove the call to it.
    }

    private void SetupGraphDataChangeSync(
        WolvenKit.App.ViewModels.Documents.RDTDataViewModel dataViewModel,
        WolvenKit.App.ViewModels.Documents.RDTGraphViewModel2 graphViewModel)
    {
        if (graphViewModel?.MainGraph?.Nodes == null || dataViewModel == null) return;

        // Subscribe to changes in graph nodes
        foreach (var node in graphViewModel.MainGraph.Nodes)
        {
            if (node is System.ComponentModel.INotifyPropertyChanged notifyNode)
            {
                notifyNode.PropertyChanged += (sender, e) =>
                {
                    // When graph node changes, find corresponding tree item and refresh it
                    var changedNode = sender as WolvenKit.App.ViewModels.GraphEditor.NodeViewModel;
                    if (changedNode?.Data != null)
                    {
                        var correspondingChunk = FindChunkInTree(dataViewModel.RootChunk, changedNode.Data);
                        if (correspondingChunk != null)
                        {
                            // Trigger tree refresh using dispatcher
                            System.Windows.Application.Current?.Dispatcher.BeginInvoke(() =>
                            {
                                // Force tree UI refresh by marking as dirty
                                if (!dataViewModel.DirtyChunks.Contains(correspondingChunk))
                                {
                                    dataViewModel.DirtyChunks.Add(correspondingChunk);
                                }
                                dataViewModel.Parent?.SetIsDirty(true);
                            });
                        }
                    }
                };
            }
        }

        // Subscribe to node collection changes (add/remove nodes)
        if (graphViewModel.MainGraph.Nodes is System.Collections.Specialized.INotifyCollectionChanged nodeCollection)
        {
            nodeCollection.CollectionChanged += (sender, e) =>
            {
                // When nodes are added/removed in graph, refresh the entire tree structure
                System.Windows.Application.Current?.Dispatcher.BeginInvoke(() =>
                {
                    // Force full tree refresh by marking root as dirty
                    var rootChunk = dataViewModel.GetRootChunk();
                    if (rootChunk != null && !dataViewModel.DirtyChunks.Contains(rootChunk))
                    {
                        dataViewModel.DirtyChunks.Add(rootChunk);
                    }
                    dataViewModel.Parent?.SetIsDirty(true);
                });
                
                // Re-setup subscriptions for new nodes
                if (e.NewItems != null)
                {
                    foreach (var newNode in e.NewItems.OfType<System.ComponentModel.INotifyPropertyChanged>())
                    {
                        newNode.PropertyChanged += (nodeSender, nodeE) =>
                        {
                            var changedNode = nodeSender as WolvenKit.App.ViewModels.GraphEditor.NodeViewModel;
                            if (changedNode?.Data != null)
                            {
                                var correspondingChunk = FindChunkInTree(dataViewModel.GetRootChunk(), changedNode.Data);
                                if (correspondingChunk != null)
                                {
                                    System.Windows.Application.Current?.Dispatcher.BeginInvoke(() =>
                                    {
                                        // Force tree UI refresh by marking as dirty
                                        if (!dataViewModel.DirtyChunks.Contains(correspondingChunk))
                                        {
                                            dataViewModel.DirtyChunks.Add(correspondingChunk);
                                        }
                                        dataViewModel.Parent?.SetIsDirty(true);
                                    });
                                }
                            }
                        };
                    }
                }
            };
        }
    }

    private void SubscribeToChunkChanges(WolvenKit.App.ViewModels.Shell.ChunkViewModel chunk, System.Action<WolvenKit.App.ViewModels.Shell.ChunkViewModel> onChunkChanged)
    {
        if (chunk == null) return;

        // Subscribe to this chunk's property changes
        chunk.PropertyChanged += (sender, e) =>
        {
            onChunkChanged(chunk);
        };

        // Subscribe to collection changes for Properties
        if (chunk.Properties is System.Collections.Specialized.INotifyCollectionChanged propertiesCollection)
        {
            propertiesCollection.CollectionChanged += (sender, e) =>
            {
                onChunkChanged(chunk);
                
                // Subscribe to new items
                if (e.NewItems != null)
                {
                    foreach (var newItem in e.NewItems)
                    {
                        if (newItem is WolvenKit.App.ViewModels.Shell.ChunkViewModel newChunk)
                        {
                            SubscribeToChunkChanges(newChunk, onChunkChanged);
                        }
                    }
                }
            };
        }

        // Subscribe to collection changes for TVProperties
        if (chunk.TVProperties is System.Collections.Specialized.INotifyCollectionChanged tvPropertiesCollection)
        {
            tvPropertiesCollection.CollectionChanged += (sender, e) =>
            {
                onChunkChanged(chunk);
                
                // Subscribe to new items
                if (e.NewItems != null)
                {
                    foreach (var newItem in e.NewItems)
                    {
                        if (newItem is WolvenKit.App.ViewModels.Shell.ChunkViewModel newChunk)
                        {
                            SubscribeToChunkChanges(newChunk, onChunkChanged);
                        }
                    }
                }
            };
        }

        // Recursively subscribe to all existing child chunks
        if (chunk.Properties != null)
        {
            foreach (var property in chunk.Properties)
            {
                SubscribeToChunkChanges(property, onChunkChanged);
            }
        }

        if (chunk.TVProperties != null)
        {
            foreach (var property in chunk.TVProperties)
            {
                SubscribeToChunkChanges(property, onChunkChanged);
            }
        }
    }

    private void MonitorSceneGraphChanges(object sceneGraph)
    {
        // Monitor scene graph for changes
        var graphType = sceneGraph.GetType();
        var nodesProperty = graphType.GetProperty("Nodes");
        if (nodesProperty != null)
        {
            var nodes = nodesProperty.GetValue(sceneGraph);
            if (nodes is System.Collections.Specialized.INotifyCollectionChanged nodesCollection)
            {
                nodesCollection.CollectionChanged += (sender, e) =>
                {
                    // Direct array modification detected
                    if (!_graphRefreshPending)
                    {
                        _graphRefreshPending = true;
                        _graphRefreshTimer.Stop();
                        _graphRefreshTimer.Start();
                    }
                };
            }
        }
    }

    private void OnSaveCompleted(object sender, EventArgs e)
    {
        // A save happened, so the underlying data model is now up-to-date.
        // We need to refresh our graph with the new data.
        if (_fullScreenGraphViewModel != null && sender is WolvenKit.App.ViewModels.Documents.RedDocumentViewModel docVm)
        {
            System.Windows.Application.Current?.Dispatcher.BeginInvoke(new Action(() =>
            {
                _fullScreenGraphViewModel.UpdateDataAndReload(docVm.Cr2wFile.RootChunk);
                // After the save and refresh, bring focus back to the fullscreen window.
                _fullScreenWindow?.Activate();
            }), System.Windows.Threading.DispatcherPriority.Input);
        }
    }

    private void UpdateFullScreenWindowTitle(WolvenKit.App.ViewModels.Documents.RedDocumentViewModel docViewModel)
    {
        if (_fullScreenWindow != null)
        {
            var filename = System.IO.Path.GetFileName(docViewModel.FilePath);
            var dirtyIndicator = docViewModel.IsDirty ? "*" : "";
            _fullScreenWindow.SetCurrentValue(System.Windows.Window.TitleProperty, $"WolvenKit - {filename}{dirtyIndicator} - Full Screen");
        }
    }

    private void OnDocumentPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "IsDirty" && sender is WolvenKit.App.ViewModels.Documents.RedDocumentViewModel docViewModel)
        {
            UpdateFullScreenWindowTitle(docViewModel);
            // Also rebuild breadcrumb to update dirty indicator
            BuildBreadcrumb();
        }
    }

    private void OnFullScreenDocumentPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "IsDirty" && sender is WolvenKit.App.ViewModels.Documents.RedDocumentViewModel docViewModel && _fullScreenBreadcrumb != null)
        {
            // Update the filename element in the breadcrumb
            if (_fullScreenBreadcrumb.Children[0] is System.Windows.Controls.TextBlock fileElement)
            {
                var filename = System.IO.Path.GetFileName(docViewModel.FilePath);
                var dirtyIndicator = docViewModel.IsDirty ? "*" : "";
                fileElement.Text = $"{filename}{dirtyIndicator}";
            }
        }
    }

    private System.Windows.Controls.Border CreateCuratedScenePanels(WolvenKit.App.ViewModels.Documents.RDTDataViewModel dataViewModel)
    {
        var border = new System.Windows.Controls.Border
        {
            Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(32, 32, 32)),
            BorderBrush = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 64, 64)),
            BorderThickness = new System.Windows.Thickness(1, 1, 1, 1)
        };

        var tabControl = new System.Windows.Controls.TabControl
        {
            Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(32, 32, 32)),
            BorderThickness = new System.Windows.Thickness(0),
            Margin = new System.Windows.Thickness(4)
        };

        // Create and add the tabs
        var actorsTab = CreateFilteredTab("Actors & Props", PackIconMaterialKind.AccountGroupOutline, dataViewModel, new[] { "actors", "playerActors", "debugSymbols", "props" });
        var nodesTab = CreateFilteredTab("Node Properties", PackIconMaterialKind.SitemapOutline, dataViewModel, new[] { "sceneGraph" });
        var resourcesTab = CreateFilteredTab("Resource Definition", PackIconMaterialKind.PackageVariantClosed, dataViewModel, new[]
        {
            "resouresReferences",
            "ridResources",
            "effectInstances",
            "effectDefinitions",
            "workspotInstances",
            "workspots"
        });
        var localizationTab = CreateFilteredTab("Localization", PackIconMaterialKind.Translate, dataViewModel, new[] { "screenplayStore", "locStore", "voInfo" });
        var logicTab = CreateFilteredTab("Scene Logic", PackIconMaterialKind.ArrowDecisionOutline, dataViewModel, new[]
        {
            "entryPoints",
            "exitPoints",
            "notablePoints",
            "interruptionScenarios",
            "executionTags",
            "executionTagEntries",
            "sceneCategoryTag"
        });
        var metadataTab = CreateFilteredTab("Metadata & Markers", PackIconMaterialKind.TagOutline, dataViewModel, new[]
        {
            "localMarkers",
            "referencePoints",
            "version",
            "sceneSolutionHash",
            "cookingPlatform"
        });

        tabControl.Items.Add(actorsTab);
        tabControl.Items.Add(nodesTab);
        tabControl.Items.Add(resourcesTab);
        tabControl.Items.Add(localizationTab);
        tabControl.Items.Add(logicTab);
        tabControl.Items.Add(metadataTab);
        
        _curatedTabs = tabControl;

        // Add event handler to clear selection on tab switch
        tabControl.SelectionChanged += (sender, args) =>
        {
            if (args.Source is System.Windows.Controls.TabControl)
            {
                // When a new tab is selected, select the first item in its tree
                if (tabControl.SelectedItem is System.Windows.Controls.TabItem { Content: System.Windows.Controls.Border { Child: System.Windows.Controls.Grid contentGrid } } selectedTab)
                {
                    if (contentGrid.Children.OfType<WolvenKit.Views.Tools.RedTreeView>().FirstOrDefault() is { } treeView)
                    {
                        var items = treeView.ItemsSource as System.Collections.IEnumerable;
                        if (items?.OfType<GroupedChunkViewModel>().FirstOrDefault() is { } group &&
                            group.TVProperties.Any())
                        {
                            dataViewModel.SelectedChunk = group.TVProperties.First();
                        }
                    }
                }
            }
        };

        border.Child = tabControl;
        return border;
    }

    private System.Windows.Controls.TabItem CreateFilteredTab(string tabTitle, PackIconMaterialKind iconKind, WolvenKit.App.ViewModels.Documents.RDTDataViewModel dataViewModel, string[] propertyNames)
    {
        // Create a header with an icon and text
        var headerPanel = new System.Windows.Controls.StackPanel
        {
            Orientation = System.Windows.Controls.Orientation.Horizontal
        };
        headerPanel.Children.Add(new PackIconMaterial 
        { 
            Kind = iconKind, 
            VerticalAlignment = System.Windows.VerticalAlignment.Center, 
            Margin = new System.Windows.Thickness(0, 0, 6, 0) 
        });
        headerPanel.Children.Add(new System.Windows.Controls.TextBlock 
        { 
            Text = tabTitle, 
            VerticalAlignment = System.Windows.VerticalAlignment.Center 
        });
        
        var tabItem = new System.Windows.Controls.TabItem
        {
            Header = headerPanel,
            Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(48, 48, 48)),
            Foreground = System.Windows.Media.Brushes.White,
            Padding = new System.Windows.Thickness(8, 5, 8, 5)
        };
        
        // Add a border around the content
        var contentBorder = new System.Windows.Controls.Border
        {
            BorderBrush = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 64, 64)),
            BorderThickness = new System.Windows.Thickness(1),
            Margin = new System.Windows.Thickness(0, 4, 0, 0) // Add some space from the tab header
        };
        
        // Content Grid
        var contentGrid = new System.Windows.Controls.Grid();
        contentGrid.ColumnDefinitions.Add(new System.Windows.Controls.ColumnDefinition { Width = new System.Windows.GridLength(3, System.Windows.GridUnitType.Star) });
        contentGrid.ColumnDefinitions.Add(new System.Windows.Controls.ColumnDefinition { Width = new System.Windows.GridLength(4, System.Windows.GridUnitType.Pixel) });
        contentGrid.ColumnDefinitions.Add(new System.Windows.Controls.ColumnDefinition { Width = new System.Windows.GridLength(2, System.Windows.GridUnitType.Star) });

        // Tree View
        var treeView = new WolvenKit.Views.Tools.RedTreeView
        {
            Margin = new System.Windows.Thickness(4, 4, 4, 4)
        };
        treeView.SetBinding(System.Windows.Controls.UserControl.DataContextProperty, new System.Windows.Data.Binding { Source = dataViewModel });
        treeView.SetBinding(WolvenKit.Views.Tools.RedTreeView.SelectedItemProperty, new System.Windows.Data.Binding("SelectedChunk") { Mode = System.Windows.Data.BindingMode.TwoWay });
        treeView.SetBinding(WolvenKit.Views.Tools.RedTreeView.SelectedItemsProperty, new System.Windows.Data.Binding("SelectedChunks") { Mode = System.Windows.Data.BindingMode.TwoWay });
        
        System.Windows.Controls.Grid.SetColumn(treeView, 0);
        contentGrid.Children.Add(treeView);

        // Defer data loading
        System.Windows.Application.Current?.Dispatcher.BeginInvoke(new Action(() =>
        {
            var rootChunk = dataViewModel.GetRootChunk();
            if (rootChunk == null) return;
            
            rootChunk.IsExpanded = true;

            System.Windows.Application.Current?.Dispatcher.BeginInvoke(new Action(() =>
            {
                var propertiesToShow = new System.Collections.Generic.List<ChunkViewModel>();

                if (rootChunk.TVProperties != null)
                {
                    foreach (var propertyName in propertyNames)
                    {
                        var chunk = rootChunk.TVProperties.FirstOrDefault(p => p.Name == propertyName);
                        if (chunk != null)
                        {
                            propertiesToShow.Add(chunk);
                        }
                    }
                }

                if (propertiesToShow.Any())
                {
                    var filteredRoot = new GroupedChunkViewModel(tabTitle, propertiesToShow)
                    {
                        IsExpanded = true
                    };
                    treeView.ItemsSource = new System.Collections.ObjectModel.ObservableCollection<object> { filteredRoot };
                }

            }), System.Windows.Threading.DispatcherPriority.Background);
        }), System.Windows.Threading.DispatcherPriority.Loaded);

        // Splitter
        var splitter = new System.Windows.Controls.GridSplitter
        {
            Width = 4,
            HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch,
            Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 64, 64))
        };
        System.Windows.Controls.Grid.SetColumn(splitter, 1);
        contentGrid.Children.Add(splitter);

        // Property Editor
        var propertyEditor = new WolvenKit.Views.Editors.RedTypeView();
        propertyEditor.SetBinding(System.Windows.Controls.UserControl.DataContextProperty, new System.Windows.Data.Binding("SelectedChunk") { Source = dataViewModel });
        System.Windows.Controls.Grid.SetColumn(propertyEditor, 2);
        contentGrid.Children.Add(propertyEditor);
        
        contentBorder.Child = contentGrid;
        tabItem.Content = contentBorder;
        return tabItem;
    }

    private void SetupDialogInterception()
    {
        _appViewModel = Locator.Current.GetService<WolvenKit.App.ViewModels.Shell.AppViewModel>();
        if (_appViewModel != null)
        {
            // Subscribe to property changes to intercept dialog activation
            _appViewModel.PropertyChanged += OnAppViewModelPropertyChanged;
        }
    }

    private void RestoreDialogInterception()
    {
        if (_appViewModel != null)
        {
            // Unsubscribe from property changes
            _appViewModel.PropertyChanged -= OnAppViewModelPropertyChanged;
            _appViewModel = null;
        }
    }

    private void OnAppViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(WolvenKit.App.ViewModels.Shell.AppViewModel.ActiveDialog) && 
            _fullScreenWindow != null && 
            _appViewModel?.ActiveDialog != null)
        {
            // A dialog was just set - intercept it and show on fullscreen window instead
            var dialogViewModel = _appViewModel.ActiveDialog;
            
            // Clear the dialog from the main window
            _appViewModel.ActiveDialog = null;
            _appViewModel.CloseDialogCommand.Execute(null);
            
                         // Show it on our fullscreen window
            System.Windows.Application.Current?.Dispatcher.BeginInvoke(new System.Action(() =>
            {
                ShowDialogOnFullScreenWindow(dialogViewModel);
            }));
        }
    }

    private void ShowDialogOnFullScreenWindow(WolvenKit.App.ViewModels.Dialogs.DialogViewModel dialogViewModel)
    {
        // Create the appropriate dialog view based on the view model type
        System.Windows.Window dialog = null;
        
        switch (dialogViewModel)
        {
            case WolvenKit.App.ViewModels.Dialogs.TypeSelectorDialogViewModel typeSelectorViewModel:
                // Create a window wrapper for the TypeSelectorDialog UserControl
                dialog = CreateTypeSelectorDialogWindow(typeSelectorViewModel);
                break;
            case WolvenKit.App.ViewModels.Dialogs.InputDialogViewModel inputViewModel:
                dialog = new WolvenKit.Views.Dialogs.InputDialogView();
                dialog.DataContext = inputViewModel;
                break;
            case WolvenKit.App.ViewModels.Dialogs.RenameDialogViewModel renameViewModel:
                dialog = new WolvenKit.Views.Dialogs.Windows.RenameDialog();
                dialog.DataContext = renameViewModel;
                break;
            // Add more dialog types as needed
        }

        if (dialog != null)
        {
            // Set the fullscreen window as the owner
            dialog.Owner = _fullScreenWindow;
            dialog.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
            
            // Show the dialog
            var result = dialog.ShowDialog();
            
            // Handle the result if needed
            if (result == true && dialogViewModel.DialogHandler != null)
            {
                dialogViewModel.DialogHandler(dialogViewModel);
            }
        }
    }

    private System.Windows.Window CreateTypeSelectorDialogWindow(WolvenKit.App.ViewModels.Dialogs.TypeSelectorDialogViewModel viewModel)
    {
        // Create a window to host the TypeSelectorDialog UserControl
        var window = new System.Windows.Window
        {
            Title = "Select Type",
            Width = 600,
            Height = 400,
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner,
            ResizeMode = System.Windows.ResizeMode.CanResize,
            Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(32, 32, 32))
        };

        // Create the TypeSelectorDialog UserControl
        var typeSelectorDialog = new WolvenKit.Views.Dialogs.TypeSelectorDialog
        {
            ViewModel = viewModel,
            DataContext = viewModel
        };

        // Add OK and Cancel buttons
        var grid = new System.Windows.Controls.Grid();
        grid.RowDefinitions.Add(new System.Windows.Controls.RowDefinition { Height = new System.Windows.GridLength(1, System.Windows.GridUnitType.Star) });
        grid.RowDefinitions.Add(new System.Windows.Controls.RowDefinition { Height = System.Windows.GridLength.Auto });

        // Add the TypeSelectorDialog to the top row
        System.Windows.Controls.Grid.SetRow(typeSelectorDialog, 0);
        grid.Children.Add(typeSelectorDialog);

        // Add button panel
        var buttonPanel = new System.Windows.Controls.StackPanel
        {
            Orientation = System.Windows.Controls.Orientation.Horizontal,
            HorizontalAlignment = System.Windows.HorizontalAlignment.Right,
            Margin = new System.Windows.Thickness(10)
        };

        var okButton = new System.Windows.Controls.Button
        {
            Content = "OK",
            Width = 75,
            Height = 25,
            Margin = new System.Windows.Thickness(5, 0, 0, 0),
            IsDefault = true
        };
        okButton.Click += (s, e) =>
        {
            if (viewModel.OkCommand.CanExecute(null))
            {
                viewModel.OkCommand.Execute(null);
                window.DialogResult = true;
                window.Close();
            }
        };

        var cancelButton = new System.Windows.Controls.Button
        {
            Content = "Cancel",
            Width = 75,
            Height = 25,
            Margin = new System.Windows.Thickness(5, 0, 0, 0),
            IsCancel = true
        };
        cancelButton.Click += (s, e) =>
        {
            if (viewModel.CancelCommand.CanExecute(null))
            {
                viewModel.CancelCommand.Execute(null);
            }
            window.DialogResult = false;
            window.Close();
        };

        buttonPanel.Children.Add(okButton);
        buttonPanel.Children.Add(cancelButton);

        System.Windows.Controls.Grid.SetRow(buttonPanel, 1);
        grid.Children.Add(buttonPanel);

        window.Content = grid;
        return window;
    }
}

