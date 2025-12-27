using System;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.Dialogs;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class AddRadioExtFilesDialog : IViewFor<AddRadioExtFilesDialogViewModel>
    {
        private static string s_lastIcon = "";
        private static string s_lastName = "";
        private static string s_lastSongFolder = "";
        private static double s_lastFrequency = 0.0;

        public static bool IsInstanceOpen { get; private set; }

        public AddRadioExtFilesDialog()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<AddRadioExtFilesDialogViewModel>();
            DataContext = ViewModel;

            LoadLastSelection();

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        x => x.IconFilePath,
                        x => x.IconTextBox.Text)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        x => x.StationName,
                        x => x.StationNameTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.SongFolderPath,
                        x => x.SongFolderTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.SongFolderPath,
                        x => x.SongFolderTextBox.Text)
                    .DisposeWith(disposables);
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

        private void LoadLastSelection()
        {
            if (ViewModel is null)
            {
                return;
            }

            ViewModel.IconFilePath = s_lastIcon;
            ViewModel.StationName = s_lastName;
            ViewModel.Frequency = s_lastFrequency;
            ViewModel.SongFolderPath = s_lastSongFolder;
        }

        private void SaveLastSelection()
        {
            if (ViewModel is null)
            {
                return;
            }

            if (!string.IsNullOrEmpty(ViewModel.IconFilePath))
            {
                s_lastIcon = ViewModel.IconFilePath;
            }

            if (!string.IsNullOrEmpty(ViewModel.StationName))
            {
                s_lastName = ViewModel.StationName;
            }

            if (ViewModel.Frequency != 0.0)
            {
                s_lastFrequency = ViewModel.Frequency;
            }

            if (!string.IsNullOrEmpty(ViewModel.SongFolderPath))
            {
                s_lastSongFolder = ViewModel.SongFolderPath;
            }
        }


        private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
            {
                return;
            }

            SaveLastSelection();
            e.Handled = true;
            DialogResult = true;
            Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            IsInstanceOpen = false;
            base.OnClosed(e);
        }

        private void WizardControl_OnFinish(object sender, RoutedEventArgs e) => SaveLastSelection();

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

        private void SearchSongFolderButton_OnClick(object sender, RoutedEventArgs e)
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

            // TODO: Add to viewmodel list
        }

        private void RowDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
