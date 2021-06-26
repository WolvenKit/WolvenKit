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
        public static ObservableCollection<string> ImageSources { get; set; }
        public static ObservableCollection<string> Folders { get; set; }
        public static string PreviousFolder { get; set; }
        public MaterialRepositoryDrawer()
        {
            InitializeComponent();





            // string rootPath = @"C:\Wolvenkit_Develop";
            // string rootPath = @"C:\Wolvenkit_Develop";
            Folders = new ObservableCollection<string>();
            ImageSources = new ObservableCollection<string>();

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
                    MaterialRepositoryDrawer.ImageSources.Add(z);

                }
            }
        }

        private void GetFolders(string dir)
        {
            Folders.Clear();
            var dirs = Directory.GetDirectories(dir, "*", SearchOption.TopDirectoryOnly);

            MaterialRepositoryDrawer.Folders.Add(PreviousFolder);
            foreach (var z in dirs)
            {

                MaterialRepositoryDrawer.Folders.Add(z);
            }

            GetDirFiles(dir);
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Henry.SelectedItem != null)
            {
                var b = Henry.SelectedItem.ToString();
                Trace.WriteLine(@"" + b);
                GetFolders(@"" + b);
            }

        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private async void x_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (x.SelectedItem != null)
            {

                try
                {
                    var q = await ImageDecoder.RenderToBitmapSource(x.SelectedItem.ToString());

                    var g = BitmapFrame.Create(q);
                    bold.SetCurrentValue(HandyControl.Controls.ImageViewer.ImageSourceProperty, g);

                }
                catch
                {

                }
            }

        }
    }
}
