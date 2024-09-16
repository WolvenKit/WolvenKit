using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Input;
using AdonisUI.Controls;
using ReactiveUI;
using Splat;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common.Services;
using WolvenKit.Core.Services;
using WolvenKit.Views.Dialogs.Windows;

namespace WolvenKit.Views.Shell
{
    public class MyObservableCollection : ObservableCollection<object> { }

    public partial class MainView : IViewFor<AppViewModel>
    {
        private readonly IModifierViewStateService _modifierViewStateService;
        public AppViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (AppViewModel)value;
        }

        public MainView(
            IModifierViewStateService modifierViewStateService,
            AppViewModel vm = null
        )
        {
            _modifierViewStateService = modifierViewStateService;
            ViewModel = vm ?? Locator.Current.GetService<AppViewModel>();
            DataContext = ViewModel;

            InitializeComponent();
            
            this.WhenActivated(disposables =>
            {
                Disposable.Create(dockingAdapter.SaveLayout).DisposeWith(disposables);

                Interactions.ShowConfirmation = input =>
                {
                    return ShowConfirmation(input);
                };

                Interactions.ShowLaunchProfilesView = () =>
                {
                    LaunchProfilesView dialog = new();

                    if (dialog.ViewModel is not null && dialog.ShowDialog(this) == true)
                    {
                        ViewModel.SetLaunchProfiles(dialog.ViewModel.LaunchProfiles);
                    }

                    return true;
                };

                Interactions.ShowSelectSaveView = (string currentSaveGame) =>
                {
                    SaveGameSelectionDialog dialog = new(currentSaveGame);

                    if (dialog.ShowDialog(this) == true)
                    {
                        return dialog.ViewModel?.SelectedEntry?.DirName;
                    }

                    return null;
                };

                Interactions.ShowMaterialRepositoryView = () =>
                {
                    MaterialsRepositoryView dialog = new();

                    if (dialog.ShowDialog(this) == true)
                    {
                    }

                    return true;
                };

                Interactions.ShowCollectionView = input =>
                {
                    ChooseCollectionView dialog = new();
                    dialog.ViewModel.SetAvailableItems(input.Item1);
                    dialog.ViewModel.SetSelectedItems(input.Item2);

                    IEnumerable<IDisplayable> result = null;
                    if (dialog.ShowDialog(this) == true)
                    {
                        result = dialog.ViewModel.SelectedItems;
                    }

                    return result;
                };


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

            return (WMessageBoxResult)AdonisUI.Controls.MessageBox.Show(Application.Current.MainWindow, messageBox);

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

        protected override async void OnClosing(CancelEventArgs e)
        {
            if (!await dockingAdapter.CloseAll())
            {
                e.Cancel = true;
                return;
            }

            dockingAdapter.SaveLayout();
            if (ViewModel?.GetToolViewModel<ProjectExplorerViewModel>() is { } pe)
            {
                pe.SaveProjectExplorerTabIfDirty();
                pe.StopWatcher();
            }

            if (Locator.Current.GetService<IProjectManager>() is ProjectManager pm)
            {
                await pm.SaveAsync();
            }

            if (Locator.Current.GetService<IHashService>() is HashServiceExt hashServiceExt)
            {
                hashServiceExt.SaveGlobalCache();
            }

            if (Locator.Current.GetService<CRUIDService>() is { } cs)
            {
                cs.SaveUserCRUIDS();
            }
            Application.Current.Shutdown();
        }

        // This is called before this.WhenActivated
        private void ChromelessWindow_Loaded(object sender, RoutedEventArgs e) { }
        // This is never called 
        private void ChromelessWindow_Closing(object sender, CancelEventArgs e) { }
    }
}
