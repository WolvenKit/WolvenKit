using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
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

        private async void GetDirFiles(string dir)
        {
            HoneyCombPanelAccess.Children.Clear();
            ImageSources.Clear();
            var allfiles = Directory.GetFiles(dir, "*.*", SearchOption.TopDirectoryOnly);

            foreach (var z in allfiles)
            {
                if (z.Contains(".dds"))
                {
                    var q = await ImageDecoder.RenderToBitmapSource(z);
                    Image image = new Image();
                    image.Width = 50;
                    image.Height = 50;
                    image.Margin = new System.Windows.Thickness(5);
                    image.Source = q;

                    HoneyCombPanelAccess.Children.Add(image);

                    // MaterialRepositoryDrawer.ImageSources.Add(newitem);
                }
            }
        }

        private void GetFolders(string dir)
        {
            if (!Directory.Exists(dir))
            {
                return;
            }

            Folders.Clear();
            var dirs = Directory.GetDirectories(dir, "*", SearchOption.TopDirectoryOnly);
            MatDepoItem newitem = new MatDepoItem(PreviousFolder);
            MaterialRepositoryDrawer.Folders.Add(newitem);
            foreach (var z in dirs)
            {
                MatDepoItem newitem2 = new MatDepoItem(z);
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
                    LoadImage(q);
                }
                catch
                {
                }
            }
        }

        private Stream StreamFromBitmapSource(BitmapSource writeBmp)
        {
            Stream bmp = new MemoryStream();

            BitmapEncoder enc = new BmpBitmapEncoder();
            enc.Frames.Add(BitmapFrame.Create(writeBmp));
            enc.Save(bmp);

            return bmp;
        }

        public void LoadImage(BitmapSource qa) => bold.SetCurrentValue(Syncfusion.UI.Xaml.ImageEditor.SfImageEditor.ImageProperty, (System.IO.Stream)StreamFromBitmapSource(qa));

        public class MatDepoItem
        {
            public MatDepoItem(string fullname)

            {
                FullName = fullname;
                SetlocalBMP();
            }

            public BitmapSource localBmp;

            private async void SetlocalBMP()
            {
                localBmp = await ImageDecoder.RenderToBitmapSource(FullName);
                //if (localBmp == null)
                //{
                //    return;
                //}
                //Stream bmp = new MemoryStream();

                //BitmapEncoder enc = new BmpBitmapEncoder();
                //enc.Frames.Add(BitmapFrame.Create(localBmp));
                //enc.Save(bmp);
                //FileStream = bmp;
            }

            public Stream FileStream { get; set; }

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
