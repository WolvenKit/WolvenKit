using System.ComponentModel;
using Catel.IoC;
using Fluent;
using Orchestra;
using Orchestra.Services;
using System.Windows;
using Catel;
using Catel.Data;
using WolvenKit.Views.AssetBrowser;
using WolvenKit.Views.CodeEditor;
using WolvenKit.Views.PluginManager;
using WolvenKit.Views.VisualEditor;
using WolvenKit.Views.AudioTool;
using WolvenKit.Views.JournalEditor;
using Orchestra.Views;

namespace WolvenKit.Views
{
    public partial class RibbonView
    {
        public RibbonView()
        {
            InitializeComponent();

            ribbon.AddAboutButton();
            


        }

        protected override void OnViewModelChanged()
        {
            base.OnViewModelChanged();
#pragma warning disable WPF0041
            backstageTabControl.DataContext = ViewModel;
#pragma warning restore WPF0041
        }

        protected override void OnViewModelPropertyChanged(PropertyChangedEventArgs e)
        {
            base.OnViewModelPropertyChanged(e);

            if (!(e is AdvancedPropertyChangedEventArgs property))
                return;

            switch (property.PropertyName)
            {
                case "SelectedTheme":
                    if (property.NewValue is string themename)
                        ControlzEx.Theming.ThemeManager.Current.ChangeTheme(Application.Current, themename);
                    break;
                default:
                    break;
            }
        }

        private void ShowStartScreen_OnClick(object sender, RoutedEventArgs e) // Convert me to MVVM
        {        
 
            this.startScreen.SetCurrentValue(StartScreen.ShownProperty, false);
                this.startScreen.SetCurrentValue(Backstage.IsOpenProperty, true);
        }

       

     

        private void CBAssetBrowserItem_Selected(object sender, RoutedEventArgs e)
        {
            AssetBrowserView assetBrowser = new AssetBrowserView(
                MainController.Get().GetManagers(true),
                MainController.Get().GetGame().GetAvaliableClasses());
            assetBrowser.Show();
        }

        private void CBCodeEditorItem_Selected(object sender, RoutedEventArgs e)
        {
            CodeEditorView codeeditor = new CodeEditorView();
            codeeditor.Show();
        }

        private void CBPluginManager_Selected(object sender, RoutedEventArgs e)
        {
            PluginManagerView pluginmanager = new PluginManagerView();
            pluginmanager.Show();
        }

        private void CBVisualEditorItem_Selected(object sender, RoutedEventArgs e)
        {
            VisualEditorView visualeditor = new VisualEditorView();
            visualeditor.Show();
        }

        private void CBAudioToolItem_Selected(object sender, RoutedEventArgs e)
        {
            AudioToolView audiotool = new AudioToolView();
            audiotool.Show();
        }

        private void CBJournalEditorItem_Selected(object sender, RoutedEventArgs e)
        {
            JournalEditorView journaleditor = new JournalEditorView();
            journaleditor.Show();
        }

        private void Backstage_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            var serviceLocator = ServiceLocator.Default;

            var shellService = serviceLocator.ResolveType<IShellService>();

            ShellWindow sh = (ShellWindow)shellService.Shell;

            sh.DragMove();
        }

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible && IsLoaded)
            {
                DiscordRPCHelper.WhatAmIDoing("Ribbon/Backstage");
            }
        }
    }
}