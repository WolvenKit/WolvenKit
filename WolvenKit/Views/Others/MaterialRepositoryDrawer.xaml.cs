using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Catel.IoC;
using WolvenKit.Functionality.Ab4d;
using WolvenKit.Functionality.Services;

namespace WolvenKit.Views.Others
{
    /// <summary>
    /// Interaction logic for MaterialRepositoryDrawer.xaml
    /// </summary>
    public partial class MaterialRepositoryDrawer : UserControl
    {
        public static ObservableCollection<MatDepoItem> ImageSources { get; set; }
        public static ObservableCollection<MatDepoItem> Folders { get; set; }
        public static string PreviousFolder { get; set; }

        public MaterialRepositoryDrawer()
        {
            InitializeComponent();

            // string rootPath = @"C:\Wolvenkit_Develop";
            // string rootPath = @"C:\Wolvenkit_Develop";
            Folders = new ObservableCollection<MatDepoItem>();
            ImageSources = new ObservableCollection<MatDepoItem>();

            var settings = ServiceLocator.Default.ResolveType<ISettingsManager>();
            if (!string.IsNullOrEmpty(settings.MaterialRepositoryPath))
            {
                PreviousFolder = settings.MaterialRepositoryPath;
                GetFolders(PreviousFolder);
            }

            // ImageSources = GetDirFiles(rootPath);
            DataContext = this;
        }

        private static void GetDirFiles(string dir)
        {
            ImageSources.Clear();
            var allfiles = Directory.GetFiles(dir, "*.*", SearchOption.TopDirectoryOnly);

            foreach (var z in allfiles)
            {
                if (z.Contains(".dds") || z.Contains(".xbm"))
                {
                    MatDepoItem newitem = new MatDepoItem();
                    newitem.FullName = z;
                    MaterialRepositoryDrawer.ImageSources.Add(newitem);
                }
            }
        }

        private void GetFolders(string dir)
        {
            Folders.Clear();
            var dirs = Directory.GetDirectories(dir, "*", SearchOption.TopDirectoryOnly);
            MatDepoItem newitem = new MatDepoItem();
            newitem.FullName = PreviousFolder;
            MaterialRepositoryDrawer.Folders.Add(newitem);
            foreach (var z in dirs)
            {
                MatDepoItem newitem2 = new MatDepoItem();
                newitem2.FullName = z;
                MaterialRepositoryDrawer.Folders.Add(newitem2);
            }

            GetDirFiles(dir);
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Henry.SelectedItem != null)
            {
                var qa = Henry.SelectedItem as MatDepoItem;

                GetFolders(@"" + qa.FullName);
            }
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private async void x_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (x.SelectedItem != null)
            {
                var qa = x.SelectedItem as MatDepoItem;
                try
                {
                    var q = await ImageDecoder.RenderToBitmapSource(qa.FullName);

                    var g = BitmapFrame.Create(q);
                    bold.SetCurrentValue(HandyControl.Controls.ImageViewer.ImageSourceProperty, g);
                }
                catch
                {
                }
            }
        }

        public class MatDepoItem
        {
            public string FullName { get; set; }

            public string SafeName
            {
                get
                {
                    return Path.GetFileName(FullName);
                }
            }

            public string Extension
            {
                get
                {
                    return Path.GetExtension(FullName);
                }
            }
        }
    }
}
