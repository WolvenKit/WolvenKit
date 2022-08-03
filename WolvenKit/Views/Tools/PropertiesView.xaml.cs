using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using ReactiveUI;
using Splat;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.App.Helpers;
using WolvenKit.Common.Extensions;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Tools;
using WolvenKit.Views.Editor.AudioTool;
using WPFSoundVisualizationLib;

namespace WolvenKit.Views.Tools
{
    /// <summary>
    /// Interaction logic for PropertiesView.xaml
    /// </summary>
    public partial class PropertiesView : ReactiveUserControl<PropertiesViewModel>
    {
        public string _fileName;

        private readonly MediaPlayer mediaPlayer = new();

        public PropertiesView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<PropertiesViewModel>();
            DataContext = ViewModel;

            //var themeResources = Application.LoadComponent(new Uri("Resources/Styles/ExpressionDark.xaml", UriKind.Relative)) as ResourceDictionary;
            //Resources.MergedDictionaries.Add(themeResources);

            //appControl.ExeName = "binkpl64.exe";
            //appControl.Args = "test2.bk2 /J /I2 /P";
            //this.Unloaded += new RoutedEventHandler((s, e) => { appControl.Dispose(); });


            ViewModel.ModelGroup.CollectionChanged += (object sender, NotifyCollectionChangedEventArgs e) =>
            {
                if (e.Action != NotifyCollectionChangedAction.Reset)
                {
                    return;
                }

                if (ViewModel.ModelGroup.Count == 0)
                {
                    return;
                }

                if (!hxViewport.IsInitialized)
                {
                    return;
                }
            };

            this.WhenActivated(disposables => ViewModel.PreviewAudioCommand
                    .ObserveOn(RxApp.MainThreadScheduler)
                    .Subscribe(async path => await TempConvertToWemWavAsync(path)));
        }

        #region properties

        //public TimeSpan ChannelPosition { get; set; }

        //public string AudioPositionText { get; set; }

        //public string CurrentTrackName { get; set; }

        //public string ChannelLength { get; set; }

        #endregion

        private void PropertyGrid_OnAutoGeneratingPropertyGridItem(object sender, AutoGeneratingPropertyGridItemEventArgs e)
        {
            switch (e.DisplayName)
            {
                case nameof(ReactiveObject.Changed):
                case nameof(ReactiveObject.Changing):
                case nameof(ReactiveObject.ThrownExceptions):
                    e.Cancel = true;
                    break;
            }
            e.ReadOnly = true;
        }

        private Stream StreamFromBitmapSource(BitmapSource writeBmp)
        {
            Stream bmp = new MemoryStream();

            BitmapEncoder enc = new BmpBitmapEncoder();
            enc.Frames.Add(BitmapFrame.Create(writeBmp));
            enc.Save(bmp);

            return bmp;
        }

        private void ReloadModels(object sender, RoutedEventArgs e) => hxViewport.ZoomExtents();

        #region AudioPreview

        /// <summary>
        /// convert a file to wav to preview it.
        /// </summary>
        /// <param name="path"></param>
        private async Task TempConvertToWemWavAsync(AudioObject obj) => await Task.Run(() => TempConvertToWemWav(obj));

        private void TempConvertToWemWav(AudioObject obj)
        {
            DispatcherHelper.RunOnMainThread(() =>
            {
                AudioPlayer.OpenAudioObject(obj);
            });
        }

        #endregion AudioPreview

    }
}
