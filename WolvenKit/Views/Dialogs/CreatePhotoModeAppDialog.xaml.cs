using System;
using System.ComponentModel;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using HandyControl.Tools.Extension;
using ReactiveUI;
using WolvenKit.App;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Interfaces.Extensions;
using Window = System.Windows.Window;

namespace WolvenKit.Views.Dialogs
{
    public partial class CreatePhotoModeAppDialog : IViewFor<CreatePhotoModeAppViewModel>
    {
        // save dialogue values for repeated runs
        private static PhotomodeBodyGender s_lastBodyGender = PhotomodeBodyGender.Female;
        private static string s_lastPhotomodeFolder = "";
        private static string s_lastNpcName = "";
        
        private static string s_lastAppFileName = "";
        private static string s_lastEntFileName = "";
        private static string s_lastJsonFileName = "";
        private static string s_lastYamlFileName = "";
        private static string s_lastXlFileName = "";
        private static string s_lastInkatlasFileName = "";

        private static bool s_lastCreateAppFile = true;
        private static bool s_lastCreateEntFile = true;
        private static bool s_lastCreateJsonFile = true;
        private static bool s_lastCreateYamlFile = true;
        private static bool s_lastCreateXlFile = true;
        private static bool s_lastCreateInkatlasFile = true;
        private static bool s_lastOverwrite;

        public CreatePhotoModeAppDialog(Cp77Project activeProject, ISettingsManager settingsManager,
            ProjectResourceTools projectResourceTools)
        {
            InitializeComponent();

            ViewModel = new CreatePhotoModeAppViewModel(activeProject, settingsManager, projectResourceTools)
            {
                AppFileName = s_lastAppFileName,
                EntFileName = s_lastEntFileName,
                SelectedBodyGender = s_lastBodyGender,
                PhotomodeRelativeFolder = s_lastPhotomodeFolder,
                NpcName = s_lastNpcName,
                XlFileName = s_lastXlFileName,
                YamlFileName = s_lastYamlFileName,
                JsonFileName = s_lastJsonFileName,
                InkatlasFileName = s_lastInkatlasFileName,
                IsCreateAppFile = s_lastCreateAppFile,
                IsCreateEntFile = s_lastCreateEntFile,
                IsCreateJsonFile = s_lastCreateJsonFile,
                IsCreateXlFile = s_lastCreateXlFile,
                IsCreateYamlFile = s_lastCreateYamlFile,
                IsCreateInkatlasFile = s_lastCreateInkatlasFile,
                IsOverwrite = s_lastOverwrite,
            };
            DataContext = ViewModel;

            this.WhenActivated(_ =>
            {
                ViewModel?.AutoSetValues();
            });
        }

        public CreatePhotoModeAppViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (CreatePhotoModeAppViewModel)value; }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            return ShowDialog();
        }

        private void SaveLastValues()
        {
            if (ViewModel is null)
            {
                return;
            }

            if (!string.IsNullOrEmpty(ViewModel.AppFileName))
            {
                s_lastAppFileName = ViewModel.AppFileName;
            }

            if (!string.IsNullOrEmpty(ViewModel.EntFileName))
            {
                s_lastEntFileName = ViewModel.EntFileName;
            }

            if (!string.IsNullOrEmpty(ViewModel.XlFileName))
            {
                s_lastXlFileName = ViewModel.XlFileName;
            }

            if (!string.IsNullOrEmpty(ViewModel.InkatlasFileName))
            {
                s_lastInkatlasFileName = ViewModel.InkatlasFileName;
            }

            if (!string.IsNullOrEmpty(ViewModel.JsonFileName))
            {
                s_lastJsonFileName = ViewModel.JsonFileName;
            }

            if (!string.IsNullOrEmpty(ViewModel.NpcName))
            {
                s_lastNpcName = ViewModel.NpcName;
            }

            if (!string.IsNullOrEmpty(ViewModel.EntFileName))
            {
                s_lastEntFileName = ViewModel.EntFileName;
            }

            if (!string.IsNullOrEmpty(ViewModel.AppFileName))
            {
                s_lastAppFileName = ViewModel.AppFileName;
            }

            if (!string.IsNullOrEmpty(ViewModel.YamlFileName))
            {
                s_lastYamlFileName = ViewModel.YamlFileName;
            }

            if (!string.IsNullOrEmpty(ViewModel.PhotomodeRelativeFolder))
            {
                s_lastPhotomodeFolder = ViewModel.PhotomodeRelativeFolder;
            }

            s_lastBodyGender = ViewModel.SelectedBodyGender;

            // save bool flags
            s_lastCreateAppFile = ViewModel.IsCreateAppFile;
            s_lastCreateEntFile = ViewModel.IsCreateEntFile;
            s_lastCreateJsonFile = ViewModel.IsCreateJsonFile;
            s_lastCreateXlFile = ViewModel.IsCreateXlFile;
            s_lastCreateYamlFile = ViewModel.IsCreateYamlFile;
            s_lastCreateInkatlasFile = ViewModel.IsCreateInkatlasFile;
            s_lastOverwrite = ViewModel.IsOverwrite;        

        }


        private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter || ViewModel?.CanSave != true)
            {
                return;
            }

            e.Handled = true;
            DialogResult = true;
            Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            if (DialogResult == true)
            {
                SaveLastValues();
            }

            base.OnClosed(e);
        }


        // Make sure that we update the other fields accordingly
        private void OnNpcNameFocusLost(object sender, RoutedEventArgs e)
        {
            if (ViewModel is null || sender is not TextBox box || box.Text.IsNullOrEmpty() ||
                box.Text == ViewModel.NpcName)
            {
                return;
            }

            ViewModel.IsNpcNameTouched = true;
            ViewModel.PreselectAppAndEntFromNpcName(box.Text);

            ViewModel.PropertyChanged += OnNpcNameChanged;
        }

        private void OnNpcNameChanged(object sender, PropertyChangedEventArgs e)
        {
            if (ViewModel is null || e.PropertyName != nameof(ViewModel.NpcName))
            {
                return;
            }

            ViewModel.AutoSetValues();
            ViewModel.PropertyChanged -= OnNpcNameChanged;
        }

        private void OnYamlNameFocusLost(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox box && !box.Text.IsEmptyOrEndsWith(".yaml"))
            {
                box.Text += ".yaml";
            }

            if (ViewModel is not null)
            {
                ViewModel.IsYamlNameTouched = true;
            }
        }

        private void OnXlNameFocusLost(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox box && !box.Text.IsEmptyOrEndsWith(".xl"))
            {
                box.Text += ".archive.xl";
            }

            if (ViewModel is not null)
            {
                ViewModel.IsXlNameTouched = true;
            }
        }

        private void OnJsonNameFocusLost(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox box && !box.Text.IsEmptyOrEndsWith(".json"))
            {
                box.Text += ".json";
            }

            if (ViewModel is not null)
            {
                ViewModel.IsJsonNameTouched = true;
            }
        }

        private void OnAppNameFocusLost(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox box && !box.Text.IsEmptyOrEndsWith(".app"))
            {
                box.Text += ".app";
            }

            if (ViewModel is not null)
            {
                ViewModel.IsAppNameTouched = true;
            }
        }

        private void OnEntNameFocusLost(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox box && !box.Text.IsEmptyOrEndsWith(".ent"))
            {
                box.Text += ".ent";
            }

            if (ViewModel is not null)
            {
                ViewModel.IsEntNameTouched = true;
            }
        }

        private void OnInkatlasNameFocusLost(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox box && !box.Text.IsEmptyOrEndsWith(".inkatlas"))
            {
                box.Text += ".inkatlas";
            }

            if (ViewModel is not null)
            {
                ViewModel.IsInkatlasNameTouched = true;
            }
        }

        private void OnPhotoModePathFocusLost(object sender, RoutedEventArgs e)
        {
            if (ViewModel is not null)
            {
                ViewModel.IsPhotoModeDirectoryTouched = true;
            }
        }

    }
}