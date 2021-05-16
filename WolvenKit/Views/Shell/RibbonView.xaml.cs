using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using Ab3d.DirectX;
using Ab3d.DirectX.Client.Settings;
using Ab3d.DXEngine.Wpf.Samples;
using Catel.Data;
using Orchestra;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.ViewModels.Shell;
using WolvenKit.Views.Dialogs;
using WolvenKit.Views.Editor;
using WolvenKit.Views.Editor.AudioTool;
using WolvenKit.Views.Editor.VisualEditor;

namespace WolvenKit.Views.Shell
{
    public partial class RibbonView
    {
        public RibbonView()
        {
            InitializeComponent();




            ribbon.AddAboutButton();

            StaticReferences.RibbonViewInstance = this;
            var dxEngineSettingsStorage = new DXEngineSettingsStorage();
            DXEngineSettings.Initialize(dxEngineSettingsStorage);
            this.MaxBackgroundThreadsCount = Environment.ProcessorCount - 1;


            //  _ribbon.BackStageButton. += BackStageButton_MouseDown;


        }



        protected override void OnViewModelChanged() => base.OnViewModelChanged();

#pragma warning disable WPF0041
        //backstageTabControl.DataContext = ViewModel;
#pragma warning restore WPF0041

        protected override void OnViewModelPropertyChanged(PropertyChangedEventArgs e)
        {
            base.OnViewModelPropertyChanged(e);

            if (e is not AdvancedPropertyChangedEventArgs property)
            {
                return;
            }

            switch (property.PropertyName)
            {
                case "SelectedTheme":
                    if (property.NewValue is Color themename)
                    {
                        //wtf is this even
                    }

                    break;

                default:
                    break;
            }
        }

        private void ShowStartScreen_OnClick(object sender, RoutedEventArgs e) // Convert me to MVVM
        {
            // Nope we dont do that here . And I am not removing this >:) lol
        }

        private void CBAssetBrowserItem_Selected(object sender, RoutedEventArgs e)
        {
        }

        private void CBCodeEditorItem_Selected(object sender, RoutedEventArgs e)
        {
            var codeeditor = new CodeEditorView();
        }

        private void CBPluginManager_Selected(object sender, RoutedEventArgs e)
        {
            var pluginmanager = new PluginManagerView();
        }

        private void CBVisualEditorItem_Selected(object sender, RoutedEventArgs e)
        {
            var visualeditor = new VisualEditorView();
        }

        private void CBAudioToolItem_Selected(object sender, RoutedEventArgs e)
        {
            var audiotool = new AudioToolView();
        }

        private void CBJournalEditorItem_Selected(object sender, RoutedEventArgs e)
        {
            //  JournalEditorView journaleditor = new JournalEditorView();
            //   journaleditor.Show();
        }

        private void Backstage_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //RibbonViewModel.GlobalRibbonVM.StartScreenShown = false;
            //RibbonViewModel.GlobalRibbonVM.BackstageIsOpen = true;

            base.OnMouseLeftButtonDown(e);
            StaticReferences.GlobalShell.DragMove();
        }

        private void Border_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            RibbonViewModel.GlobalRibbonVM.StartScreenShown = false;
            RibbonViewModel.GlobalRibbonVM.BackstageIsOpen = true;
        }

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible && IsLoaded)
            {
                DiscordHelper.SetDiscordRPCStatus("Ribbon/Backstage");
            }
        }

        private void Border_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var brush = (Brush)Application.Current.FindResource("MahApps.Brushes.Accent3");

            HomeHighLighter.SetCurrentValue(System.Windows.Controls.Panel.BackgroundProperty, brush);
        }

        private void Border_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var brush = (Brush)Application.Current.FindResource("MahApps.Brushes.AccentBase");

            HomeHighLighter.SetCurrentValue(System.Windows.Controls.Panel.BackgroundProperty, brush);
        }



        private void ColorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            // No
        }
        private double _selectedDpiScale = double.NaN;

        public int MaxBackgroundThreadsCount { get; set; }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dxEngineSettingsWindow = new DXEngineSettingsWindow();

            if (DXEngineSettings.Current.GraphicsProfiles != null && DXEngineSettings.Current.GraphicsProfiles.Length > 0)
                dxEngineSettingsWindow.SelectedGraphicsProfile = DXEngineSettings.Current.GraphicsProfiles[0];
            else
                dxEngineSettingsWindow.SelectedGraphicsProfile = null;

            dxEngineSettingsWindow.SelectedDpiScale = _selectedDpiScale;

            dxEngineSettingsWindow.SelectedMaxBackgroundThreadsCount = MaxBackgroundThreadsCount;

            dxEngineSettingsWindow.ShowDialog();


            GraphicsProfile selectedGraphicsProfile = dxEngineSettingsWindow.SelectedGraphicsProfile;


            // Save the selected GraphicsProfile to application settings
            DXEngineSettings.Current.SaveGraphicsProfile(selectedGraphicsProfile);

            _selectedDpiScale = dxEngineSettingsWindow.SelectedDpiScale;
            MaxBackgroundThreadsCount = dxEngineSettingsWindow.SelectedMaxBackgroundThreadsCount;


            // Now create an array of GraphicsProfile from selectedGraphicsProfiles
            // If selectedGraphicsProfiles is hardware GraphicProfile, than we will also add software and WPF 3D rendering as fallback to the array
            DXEngineSettings.Current.GraphicsProfiles = DXEngineSettings.Current.SystemCapabilities.CreateArrayOfRecommendedGraphicsProfiles(selectedGraphicsProfile);


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var z = new MaterialsRepositoryDialog();
            z.Show();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            //Application.Current.Resources["PrimaryLight"] = HandyControl.Tools.ResourceHelper.GetResource<Brush>("MahApps.Brushes.Accent3");




        }

        private void _ribbon_Loaded(object sender, RoutedEventArgs e)
        {



        }

        private void BackStageButton_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

