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
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            //this.DragMove();
        }

        private void DataWindow_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordRPCHelper.WhatAmIDoing("Asset Browser");
            }
        }

        private void TreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (DataContext is AssetBrowserViewModel vm)
            {
                vm.CurrentNode = e.NewValue as GameFileTreeNode;
                vm.CurrentNodeFiles = (e.NewValue as GameFileTreeNode)?.ToAssetBrowserData();
            }
        }
    }
}
