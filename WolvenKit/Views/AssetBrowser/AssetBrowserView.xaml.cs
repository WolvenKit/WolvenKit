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
using Catel.Windows;
using HandyControl.Data;
using WolvenKit.Bundles;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.ViewModels.AssetBrowser;

namespace WolvenKit.Views.AssetBrowser
{
    public partial class AssetBrowserView : DataWindow, INotifyPropertyChanged
    {
        private AssetBrowserViewModel viewmodel;

        public AssetBrowserView(List<IGameArchiveManager> managers, List<string> AvaliableClasses) : base(DataWindowMode.Custom)
        {
            InitializeComponent();
            ControlzEx.Theming.ThemeManager.Current.ChangeTheme(this, "Dark.Red"); //This aint needed was just for testing remove me.
            var vm = new AssetBrowserViewModel(managers, AvaliableClasses);
            NotifyPropertyChanged();
            this.DataContext = vm;
            viewmodel = vm;
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
            this.DragMove();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            SetCurrentValue(WindowStateProperty, System.Windows.WindowState.Minimized);
        }

        void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var vm = this.DataContext as AssetBrowserViewModel;
            var item = ((FrameworkElement)e.OriginalSource).DataContext as AssetBrowserData;
            if (item != null)
            {
                switch (item.Type)
                {
                    case EntryType.Directory:
                    {
                        vm.CurrentNode = item.Children;
                        vm.CurrentNode.Parent = item.This;
                        vm.CurrentNodeFiles = item.Children.ToAssetBrowserData();
                        break;
                    }
                    case EntryType.File:
                    {
                        MessageBox.Show(this, "Importing file: " + item.Name, "File import", MessageBoxButton.OK,
                            MessageBoxImage.Information);
                        break;
                    }
                    case EntryType.MoveUP:
                    {
                        if(item.Parent != null)
                        {
                            vm.CurrentNode = item.Parent;
                            vm.CurrentNodeFiles = item.Parent.ToAssetBrowserData();
                        }
                        break;
                    }
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private void SearchBar_OnSearchStarted(object sender, FunctionEventArgs<string> e)
        {
            viewmodel.PerformSearch(e.Info);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            viewmodel.CurrentNode = viewmodel.RootNode;
            viewmodel.CurrentNodeFiles = viewmodel.RootNode.ToAssetBrowserData();
        }
    }
}
