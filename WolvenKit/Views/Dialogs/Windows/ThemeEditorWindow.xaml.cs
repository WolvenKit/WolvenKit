using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Threading;
using Microsoft.Win32;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services.Themes;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs.Windows
{
    /// <summary>
    /// Theme editor: list of all themeable colors on the left, live preview on the right.
    /// </summary>
    public partial class ThemeEditorWindow : Window
    {
        private readonly IThemeService _themeService;
        private readonly ThemeEditorViewModel _viewModel;
        private readonly CollectionViewSource _entriesView;
        private readonly DispatcherTimer _previewTimer;

        private bool _appPreviewActive;

        public ThemeEditorWindow(IThemeService themeService, ThemeDto theme)
        {
            _themeService = themeService;
            _viewModel = new ThemeEditorViewModel(themeService, theme);

            InitializeComponent();
            DataContext = _viewModel;

            _entriesView = (CollectionViewSource)Resources["EntriesView"];
            _entriesView.SetCurrentValue(CollectionViewSource.SourceProperty, _viewModel.Entries);
            _entriesView.Filter += (_, e) => e.Accepted = e.Item is ThemeColorEntryViewModel entry && _viewModel.Matches(entry);

            // Rebuilding the preview dictionary for every color-picker tick is wasteful; debounce it.
            _previewTimer = new DispatcherTimer(DispatcherPriority.Background) { Interval = TimeSpan.FromMilliseconds(150) };
            _previewTimer.Tick += (_, _) =>
            {
                _previewTimer.Stop();
                UpdatePreview();
            };

            _viewModel.PaletteChanged += (_, _) => _previewTimer.Start();
            _viewModel.PropertyChanged += ViewModel_OnPropertyChanged;

            UpdatePreview();
        }

        /// <summary>The theme saved by "Save and use", or the last saved theme.</summary>
        public ThemeDto SavedTheme { get; private set; }

        private void ViewModel_OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(ThemeEditorViewModel.FilterText):
                case nameof(ThemeEditorViewModel.ShowOnlyOverridden):
                case nameof(ThemeEditorViewModel.Level):
                    _entriesView.View?.Refresh();
                    break;
                case nameof(ThemeEditorViewModel.PreviewInApp):
                    UpdatePreview();
                    break;
                default:
                    break;
            }
        }

        private void UpdatePreview()
        {
            var definition = _viewModel.BuildDefinition();
            PreviewHost.Resources = _themeService.CreateResourceDictionary(definition, complete: true);

            if (_viewModel.PreviewInApp)
            {
                _themeService.ApplyResources(definition);
                _appPreviewActive = true;
            }
            else
            {
                RevertAppPreview();
            }
        }

        private void RevertAppPreview()
        {
            if (!_appPreviewActive)
            {
                return;
            }
            _themeService.ApplyResources(_themeService.Current);
            _appPreviewActive = false;
        }

        private bool TrySave()
        {
            try
            {
                SavedTheme = _viewModel.Save();
                return true;
            }
            catch (Exception ex)
            {
                Interactions.ShowMessageBox(ex.Message, "Could not save theme", WMessageBoxButtons.Ok, WMessageBoxImage.Error);
                return false;
            }
        }

        private void SaveButton_OnClick(object sender, RoutedEventArgs e) => TrySave();

        private void SaveApplyButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (!TrySave())
            {
                return;
            }

            // Make sure the closing logic does not revert to the old theme.
            _appPreviewActive = false;
            _themeService.SetActive(SavedTheme.Name);
            DialogResult = true;
        }

        private void CloseButton_OnClick(object sender, RoutedEventArgs e) => Close();

        private void ExportButton_OnClick(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                Title = "Export theme",
                Filter = "WolvenKit theme (*.json)|*.json",
                FileName = $"{_viewModel.Name}.json"
            };
            if (dialog.ShowDialog(this) != true)
            {
                return;
            }

            try
            {
                // Flatten, so the file also works for people who don't have the base theme.
                _themeService.Export(_viewModel.BuildDefinition(), dialog.FileName, flatten: true);
            }
            catch (Exception ex)
            {
                Interactions.ShowMessageBox(ex.Message, "Could not export theme", WMessageBoxButtons.Ok, WMessageBoxImage.Error);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (DialogResult != true && _viewModel.IsDirty)
            {
                var result = Interactions.ShowMessageBox(
                    "Save changes to this theme?",
                    "Unsaved changes",
                    WMessageBoxButtons.YesNoCancel,
                    WMessageBoxImage.Question);

                if (result == WMessageBoxResult.Cancel || (result == WMessageBoxResult.Yes && !TrySave()))
                {
                    e.Cancel = true;
                    return;
                }
            }

            _previewTimer.Stop();
            RevertAppPreview();
            base.OnClosing(e);
        }
    }
}
