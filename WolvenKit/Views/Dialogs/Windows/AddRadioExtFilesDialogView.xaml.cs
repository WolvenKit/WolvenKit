using System;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using ReactiveUI;
using Splat;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.ViewModels.Dialogs;
using DragEventArgs = System.Windows.DragEventArgs;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class AddRadioExtFilesDialog : IViewFor<AddRadioExtFilesDialogViewModel>
    {
        public static bool IsInstanceOpen { get; private set; }

        public AddRadioExtFilesDialog(Cp77Project project)
        {
            InitializeComponent();

            ViewModel = new AddRadioExtFilesDialogViewModel(project);
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
                Title = "Select icon file (200x200)", Multiselect = false, Filter = "*.png"
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
                Title = "Add songs", Multiselect = true, Filter = "*.mp3|*.wav|*.ogg|*.flac|*.mp2|*.wav"
            };

            if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK || string.IsNullOrEmpty(dlg.FileName))
            {
                return;
            }

            ViewModel.AddSong("", "");

        }

        private void RowDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel is null)
            {
                return;
            }

            ViewModel.RemoveSong("", "");
        }


        private void SongsGrid_OnDrop(object sender, DragEventArgs e)
        {
            if (ViewModel is null)
            {
                return;
            }

            ViewModel.MoveSongOrder("", 0);
        }

    }
}
