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
using WolvenKit.Bundles;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.ViewModels.AssetBrowser;

namespace WolvenKit.Views.AssetBrowser
{
    public partial class AssetBrowserView : DataWindow, INotifyPropertyChanged
    {

        public List<IGameFile> SelectedFiles { get; set; }

        public List<IGameArchiveManager> Managers { get; set; }

        public AssetBrowserView(List<IGameArchiveManager> managers) : base(DataWindowMode.Custom)
        {
            InitializeComponent();
            ControlzEx.Theming.ThemeManager.Current.ChangeTheme(this, "Dark.Red"); //This aint needed was just for testing remove me.
            var vm = new AssetBrowserViewModel();
            SelectedFiles = new List<IGameFile>();
            Managers = managers;

            vm.CurrentNode = new GameFileTreeNode(EArchiveType.ANY);
            foreach(var mngr in managers)
            {
                vm.CurrentNode.Directories.Add(mngr.TypeName.ToString(), mngr.RootNode);
            }
            vm.CurrentNodeFiles = vm.CurrentNode.ToAssetBrowserData();
            vm.RootNode = vm.CurrentNode;
            NotifyPropertyChanged();
            this.DataContext = vm;
        }

        public event PropertyChangedEventHandler PropertyChanged;
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
    }
}
