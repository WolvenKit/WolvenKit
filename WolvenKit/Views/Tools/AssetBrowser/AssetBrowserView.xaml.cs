using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Catel.MVVM.Views;
using Catel.Services;
using Catel.Windows;
using HandyControl.Data;
using Orc.ProjectManagement;
using WolvenKit.Bundles;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.ViewModels.AssetBrowser;

namespace WolvenKit.Views.AssetBrowser
{
    public partial class AssetBrowserView : INotifyPropertyChanged
    {
      
      
        public AssetBrowserView()
        {
            InitializeComponent();
            ControlzEx.Theming.ThemeManager.Current.ChangeTheme(this, "Dark.Red"); //This aint needed was just for testing remove me.
            NotifyPropertyChanged();
        }

        public new event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            //this.DragMove();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
           // this.Close();
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
           // SetCurrentValue(WindowStateProperty, System.Windows.WindowState.Minimized);
        }

        void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var vm = this.DataContext as AssetBrowserViewModel;
            var item = ((FrameworkElement)e.OriginalSource).DataContext as AssetBrowserData;
            if (item != null)
            {
                vm.ImportFile(item);
            }
        }

        private void SearchBar_OnSearchStarted(object sender, FunctionEventArgs<string> e)
        {
            var vm = this.DataContext as AssetBrowserViewModel;

            vm.PerformSearch(e.Info);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var vm = this.DataContext as AssetBrowserViewModel;

            vm.CurrentNode = vm.RootNode;
            vm.CurrentNodeFiles = vm.RootNode.ToAssetBrowserData();
        }

        private void DataWindow_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordRPCHelper.WhatAmIDoing("Asset Browser");
            }
        }

        private void ShowPreviewButton_Click(object sender, RoutedEventArgs e)
        {
            var vm = this.DataContext as AssetBrowserViewModel;

            if (vm.PreviewWidth.GridUnitType != GridUnitType.Pixel)
            {
                vm.PreviewWidth = new GridLength(0, GridUnitType.Pixel);
                vm.PreviewVisible = true;
            }
            else
            {
                vm.PreviewWidth = new GridLength(1, GridUnitType.Star);
                vm.PreviewVisible = false;
            }
        }

        private void TreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var vm = this.DataContext as AssetBrowserViewModel;

            vm.CurrentNode = e.NewValue as GameFileTreeNode;
            vm.CurrentNodeFiles = (e.NewValue as GameFileTreeNode)?.ToAssetBrowserData();
        }
    }
}
