using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using HelixToolkit.Wpf.SharpDX;
using ReactiveUI;
using Splat;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.App.ViewModels.Tools;

namespace WolvenKit.Views.Tools
{
    /// <summary>
    /// Interaction logic for PropertiesView.xaml
    /// </summary>
    public partial class PropertiesView : ReactiveUserControl<PropertiesViewModel>
    {
        public string _fileName;

        public PropertiesView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<PropertiesViewModel>();
            DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                Observable.FromEventPattern<PropertyChangedEventHandler, PropertyChangedEventArgs>(
                  handler => ViewModel.PropertyChanged += handler,
                  handler => ViewModel.PropertyChanged -= handler)
                    .Subscribe(e => ViewModel_PropertyChanged(e.Sender, e.EventArgs))
                    .DisposeWith(disposables);

                Observable.FromEventPattern<NotifyCollectionChangedEventHandler, NotifyCollectionChangedEventArgs>(
                  handler => ViewModel.ModelGroup.CollectionChanged += handler,
                  handler => ViewModel.ModelGroup.CollectionChanged -= handler)
                    .Subscribe(e => ModelGroup_CollectionChanged(e.Sender, e.EventArgs))
                    .DisposeWith(disposables);

                Observable.FromEventPattern<SizeChangedEventHandler, SizeChangedEventArgs>(
                  handler => hxViewport.SizeChanged += handler,
                  handler => hxViewport.SizeChanged -= handler)
                    .Subscribe(e => HxViewport_SizeChanged(e.Sender, e.EventArgs))
                    .DisposeWith(disposables);
            });
        }

        private void HxViewport_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var size = e.NewSize;
            var showGizmos = size.Width > 250 && size.Height > 100;
            var scale = size.Width < size.Height ? size.Width : size.Height;

            scale = (scale < 250.0) ? scale / 250.0 : 1.0;
            hxViewport.SetCurrentValue(Viewport3DX.CoordinateSystemSizeProperty, scale);
            hxViewport.SetCurrentValue(Viewport3DX.ViewCubeSizeProperty, scale);
            hxViewport.SetCurrentValue(Viewport3DX.ShowCoordinateSystemProperty, showGizmos);
            hxViewport.SetCurrentValue(Viewport3DX.ShowViewCubeProperty, showGizmos);
        }

        private void ModelGroup_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
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
        }

        private void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(PropertiesViewModel.AudioObject))
            {
                // play in viewmodel
                AudioPlayer.ViewModel.LoadOggFile(ViewModel.AudioObject);
            }
        }

        private void PropertyGrid_OnAutoGeneratingPropertyGridItem(object sender, AutoGeneratingPropertyGridItemEventArgs e)
        {
            switch (e.DisplayName)
            {
                case nameof(ReactiveObject.Changed):
                case nameof(ReactiveObject.Changing):
                case nameof(ReactiveObject.ThrownExceptions):
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
            e.ReadOnly = true;
        }

        private void ReloadModels(object sender, RoutedEventArgs e) => hxViewport.ZoomExtents();
    }
}
