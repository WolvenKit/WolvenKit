using System;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using ReactiveUI;
using Splat;
using Syncfusion.UI.Xaml.Grid;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.ViewModels.Dialogs;
using DragEventArgs = System.Windows.DragEventArgs;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class AddRadioExtFilesDialog : IViewFor<AddRadioExtFilesDialogViewModel>
    {
        public static bool IsInstanceOpen { get; private set; }

        public AddRadioExtFilesDialog(Cp77Project project, TemplateFileTools templateFileTools)
        {
            InitializeComponent();

            ViewModel = AddRadioExtFilesDialogViewModel.GetInstance(project, templateFileTools);
            DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        x => x.StationName,
                        x => x.StationNameTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.IconFilePath,
                        x => x.IconPathTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.Frequency,
                        x => x.StationFrequencyTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.UseStream,
                        x => x.UseStreamCheckBox.IsChecked)
                    .DisposeWith(disposables);

                // stream URL
                this.Bind(ViewModel,
                        x => x.StreamPath,
                        x => x.StreamPathTextBox.Text)
                    .DisposeWith(disposables);

                // Grid with songs
                this.Bind(ViewModel,
                        x => x.SongItems,
                        x => x.SongsGrid.ItemsSource)
                    .DisposeWith(disposables);

                SongsGrid.SetCurrentValue(Syncfusion.UI.Xaml.Grid.SfDataGrid.AllowDraggingRowsProperty, true);
                SongsGrid.SetCurrentValue(AllowDropProperty, true);
                SongsGrid.Drop += SongsGrid_OnDrop;
                SongsGrid.PreviewMouseLeftButtonDown += SongsGrid_PreviewMouseLeftButtonDown;
            });
        }

        public AddRadioExtFilesDialogViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (AddRadioExtFilesDialogViewModel)value; }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            IsInstanceOpen = true;
            return ShowDialog();
        }

        private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
            {
                return;
            }

            e.Handled = true;
            DialogResult = true;
            Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            IsInstanceOpen = false;
            base.OnClosed(e);
        }

        private void SearchIconButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel is null)
            {
                return;
            }

            var dlg = new OpenFileDialog
            {
                Title = @"Select icon file (200x200)", Multiselect = false, Filter = @"Image Files (png)|*.png"
            };

            if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK || string.IsNullOrEmpty(dlg.FileName))
            {
                return;
            }

            ViewModel.IconFilePath = dlg.FileName;
        }

        private void AddSongFilesButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel is null)
            {
                return;
            }

            var dlg = new OpenFileDialog
            {
                Title = @"Add songs", Multiselect = true, Filter = @"Audio Files|*.mp3;*.wav;*.ogg;*.flac;*.mp2;*.wav"
            };

            if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK || dlg.FileNames.Length == 0)
            {
                return;
            }

            // SongsGrid.SetCurrentValue(Syncfusion.UI.Xaml.Grid.SfDataGrid.ItemsSourceProperty, null);
            foreach (var audioFile in dlg.FileNames)
            {
                ViewModel.AddSong(new RadioSongItem(audioFile, 0));
            }

        }

        private void RowDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel is null)
            {
                return;
            }

            if (sender is System.Windows.Controls.Button { DataContext: RadioSongItem item })
            {
                ViewModel.RemoveSong(item);
            }
            else
            {
                Console.Write("");
            }

        }

        private RadioSongItem _draggedItem;

        // Handler to capture the source item when the user begins a drag
        private void SongsGrid_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is not SfDataGrid grid)
            {
                _draggedItem = null;
                return;
            }

            var point = e.GetPosition(grid);
            var hit = VisualTreeHelper.HitTest(grid, point);

            if (hit == null)
            {
                return;
            }

            _draggedItem = null;
            var current = hit.VisualHit;
            while (current != null)
            {
                if (current is FrameworkElement { DataContext: RadioSongItem rsi })
                {
                    _draggedItem = rsi;
                    break;
                }

                current = VisualTreeHelper.GetParent(current);
            }
        }

        // Update SongsGrid_OnDrop to use the captured item and fall back to drag data
        private void SongsGrid_OnDrop(object sender, DragEventArgs e)
        {
            if (ViewModel is null || sender is not SfDataGrid grid)
            {
                return;
            }

            var point = e.GetPosition(grid);
            var hit = VisualTreeHelper.HitTest(grid, point);
            RadioSongItem targetRecord = null;

            if (hit != null)
            {
                var current = hit.VisualHit;
                while (current != null)
                {
                    if (current is FrameworkElement { DataContext: RadioSongItem rsi })
                    {
                        targetRecord = rsi;
                        break;
                    }

                    current = VisualTreeHelper.GetParent(current);
                }
            }

            int targetIndex;
            if (targetRecord != null)
            {
                targetIndex = ViewModel.SongItems.IndexOf(targetRecord);
            }
            else
            {
                targetIndex = ViewModel.SongItems.Count;
            }

            if (targetIndex < 0)
            {
                return;
            }

            // Try to obtain source from captured field, then from drag data
            var source = _draggedItem;
            if (source == null && e.Data != null && e.Data.GetDataPresent(typeof(RadioSongItem)))
            {
                source = e.Data.GetData(typeof(RadioSongItem)) as RadioSongItem;
            }

            if (source != null)
            {
                ViewModel.MoveSongOrder(source, targetIndex);
            }

            // clear the captured reference
            _draggedItem = null;

            e.Handled = true;
        }

    }
}
