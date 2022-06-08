using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using AdonisUI.Controls;
using ReactiveUI;
using Splat;
using WolvenKit.App.Interaction;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Wizards;
using WolvenKit.Views.Dialogs;

namespace WolvenKit.Views.Shell
{
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
                // interactions

                Interactions.AddNewFile.RegisterHandler(interaction =>
                {
                    var dialog = new DialogHostView();
                    dialog.ViewModel.HostedViewModel = Locator.Current.GetService<NewFileViewModel>();
                    //dialog.Height = 600;
                    //dialog.Width = 700;

                    return Observable.Start(() =>
                    {
                        var result = dialog.ShowDialog() == true;
                        if (result)
                        {
                            var innerVm = (NewFileViewModel)dialog.ViewModel.HostedViewModel;
                            var model = innerVm.SelectedFile;
                            var filename = innerVm.FileName;

                            interaction.SetOutput((model, filename));
                        }
                        else
                        {
                            interaction.SetOutput((null, null));
                        }
                    }, RxApp.MainThreadScheduler);
                });

                Interactions.NewProjectInteraction.RegisterHandler(interaction =>
                {
                    var dialog = new DialogHostView();
                    dialog.ViewModel.HostedViewModel = Locator.Current.GetService<ProjectWizardViewModel>();

                    return Observable.Start(() =>
                    {
                        var result = "";
                        if (dialog.ShowDialog() == true)
                        {
                            var innerVm = (ProjectWizardViewModel)dialog.ViewModel.HostedViewModel;
                            var projectLocation = Path.Combine(innerVm.ProjectPath, innerVm.ProjectName);
                            var projectFile = Path.Combine(projectLocation, innerVm.ProjectName);
                            var type = innerVm.ProjectType.First();
                            switch (type)
                            {
                                case ProjectWizardViewModel.WitcherGameName:
                                    projectFile += ".w3modproj";
                                    break;
                                case ProjectWizardViewModel.CyberpunkGameName:
                                    projectFile += ".cpmodproj";
                                    break;
                            }

                            result = projectFile;
                        }

                        interaction.SetOutput(result);
                    }, RxApp.MainThreadScheduler);
                });

                Interactions.ShowConfirmation.RegisterHandler(interaction => interaction.SetOutput(ShowConfirmation(interaction.Input)));




                this.Bind(ViewModel,
                    vm => vm.ActiveDocument,
                    v => v.dockingAdapter.ActiveDocument)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                    vm => vm.DockedViews,
                    v => v.dockingAdapter.ItemsSource)
                    .DisposeWith(disposables);

                this.WhenAnyValue(x => x.ViewModel.ActiveProject).Subscribe(_ => dockingAdapter.OnActiveProjectChanged());
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

            var messageBox = new MessageBoxModel
            {
                Text = text,
                Caption = caption,
                Icon = GetAdonisImage(image),
                Buttons = GetAdonisButtons(buttons)
            };

            return (WMessageBoxResult)AdonisUI.Controls.MessageBox.Show(messageBox);


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

        protected override void OnClosing(CancelEventArgs e) => Application.Current.Shutdown();
    }
}
