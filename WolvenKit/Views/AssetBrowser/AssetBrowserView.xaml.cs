using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Catel.Windows;
using WolvenKit.Bundles;
using WolvenKit.Common;
using WolvenKit.Common.Model;

namespace WolvenKit.Views.AssetBrowser
{
    public partial class AssetBrowserView : DataWindow, INotifyPropertyChanged
    {
        public ObservableCollection<AssetBrowserData> CurrentNodeFiles { get; set; }

        public List<IGameFile> SelectedFiles { get; set; }

        public List<IGameArchiveManager> Managers { get; set; }

        public AssetBrowserView(List<IGameArchiveManager> managers) : base(DataWindowMode.Custom)
        {
            InitializeComponent();
            this.DataContext = this;
            ControlzEx.Theming.ThemeManager.Current.ChangeTheme(this, "Dark.Red"); //This aint needed was just for testing remove me.
            CurrentNodeFiles = new ObservableCollection<AssetBrowserData>();
            SelectedFiles = new List<IGameFile>();
            Managers = managers;

            CurrentNodeFiles.Add(new AssetBrowserData()
            {
                Name = "Hello",
                Size = 1000
            });
            NotifyPropertyChanged();
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
    }
}
