using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows;
using AdonisUI.Controls;
using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Interaction;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Shell;
using WolvenKit.ViewModels.Wizards;
using WolvenKit.Views.Dialogs;
using WolvenKit.Views.Dialogs.Windows;
using WolvenKit.Views.Wizards;

namespace WolvenKit.Views.Shell
{
    public class MyObservableCollection : ObservableCollection<object> { }

    public partial class MainView : IViewFor<AppViewModel>
    {
        public AppViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (AppViewModel)value;
        }

        public MainView(AppViewModel vm = null)
        {
            ViewModel = vm ?? Locator.Current.GetService<AppViewModel>();
            DataContext = ViewModel;

            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                Interactions.ShowConfirmation.RegisterHandler(interaction => interaction.SetOutput(ShowConfirmation(interaction.Input)));
                Interactions.ShowLaunchProfilesView.RegisterHandler(
                    interaction =>
                    {
                        LaunchProfilesView dialog = new();

                        return Observable.Start(() =>
                        {
                            if (dialog.ShowDialog(Application.Current.MainWindow) == true)
                            {
                                ViewModel.SetLaunchProfiles(dialog.ViewModel.LaunchProfiles);
                            }

                            interaction.SetOutput(true);
                        }, RxApp.MainThreadScheduler);
                    });
                Interactions.ShowMaterialRepositoryView.RegisterHandler(
                    interaction =>
                    {
                        MaterialsRepositoryView dialog = new();

                        return Observable.Start(() =>
                        {
                            if (dialog.ShowDialog(Application.Current.MainWindow) == true)
                            { }

                            interaction.SetOutput(true);
                        }, RxApp.MainThreadScheduler);
                    });

                this.Bind(ViewModel,
                    vm => vm.ActiveDocument,
                    v => v.dockingAdapter.ActiveDocument)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                    vm => vm.DockedViews,
                    v => v.dockingAdapter.ItemsSource)
                    .DisposeWith(disposables);

                this.WhenAnyValue(x => x.ViewModel.ActiveProject).Subscribe(_ => dockingAdapter.OnActiveProjectChanged());

                //set ready status
                ViewModel.SetStatusReady();
            });
        }

        private void FadeOut_Completed(object sender, EventArgs e) => ViewModel.FinishedClosingModal();

        #region interactions

        private static WMessageBoxResult ShowConfirmation((string, string, WMessageBoxImage, WMessageBoxButtons) input)
        {
            var text = input.Item1;
            var caption = input.Item2;
            var image = input.Item3;
            var buttons = input.Item4;

            MessageBoxModel messageBox = new()
            {
                Text = text,
                Caption = caption,
                Icon = GetAdonisImage(image),
                Buttons = GetAdonisButtons(buttons)
            };

            var result = WMessageBoxResult.None;
            DispatcherHelper.RunOnMainThread(() => result = (WMessageBoxResult)AdonisUI.Controls.MessageBox.Show(Application.Current.MainWindow, messageBox));

            return result;

            // local methods
            AdonisUI.Controls.MessageBoxImage GetAdonisImage(WMessageBoxImage image) => (AdonisUI.Controls.MessageBoxImage)image;

            IEnumerable<IMessageBoxButtonModel> GetAdonisButtons(WMessageBoxButtons buttons)
            {
                return buttons switch
                {
                    WMessageBoxButtons.Ok => new IMessageBoxButtonModel[1] { MessageBoxButtons.Ok() },
                    WMessageBoxButtons.OkCancel => MessageBoxButtons.OkCancel(),
                    WMessageBoxButtons.Yes => new IMessageBoxButtonModel[1] { MessageBoxButtons.Yes() },
                    WMessageBoxButtons.YesNo => MessageBoxButtons.YesNo(),
                    WMessageBoxButtons.YesNoCancel => MessageBoxButtons.YesNoCancel(),
                    WMessageBoxButtons.No => new IMessageBoxButtonModel[1] { MessageBoxButtons.No() },
                    _ => throw new ArgumentOutOfRangeException(nameof(buttons)),
                };
            }
        }

        #endregion

        private void Overlay_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            var mainWindow = (MainView)Locator.Current.GetService<IViewFor<AppViewModel>>();
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
            {
                mainWindow?.DragMove();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            dockingAdapter.SaveLayout();
            Application.Current.Shutdown();
        }

        // This is called before this.WhenActivated
        private void ChromelessWindow_Loaded(object sender, RoutedEventArgs e) { }
        // This is never called 
        private void ChromelessWindow_Closing(object sender, CancelEventArgs e) { }
    }
}
