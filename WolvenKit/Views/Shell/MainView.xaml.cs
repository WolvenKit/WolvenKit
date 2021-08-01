using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Input;
using AdonisUI.Controls;
using HandyControl.Tools.Extension;
using ReactiveUI;
using Splat;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Layout.MLib;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Interaction;
using WolvenKit.ViewModels.Shell;
using WolvenKit.ViewModels.Wizards;
using WolvenKit.Views.Dialogs;
using WolvenKit.Views.Wizards;

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
                Interactions.ShowFirstTimeSetup.RegisterHandler(interaction =>
                {
                    var dialog = new DialogHostView();
                    dialog.ViewModel.HostedViewModel = Locator.Current.GetService<FirstSetupWizardViewModel>();

                    return Observable.Start(() =>
                    {
                        var result = dialog.ShowDialog() == true;
                        interaction.SetOutput(result);
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
                            var location = Path.Combine(innerVm.ProjectPath, innerVm.ProjectName);
                            var type = innerVm.ProjectType.First();
                            switch (type)
                            {
                                case ProjectWizardViewModel.WitcherGameName:
                                    location += ".w3modproj";
                                    break;
                                case ProjectWizardViewModel.CyberpunkGameName:
                                    location += ".cpmodproj";
                                    break;
                            }

                            result = location;
                        }

                        interaction.SetOutput(result);
                    }, RxApp.MainThreadScheduler);
                });
            });
        }

        protected override void OnClosing(CancelEventArgs e) => Application.Current.Shutdown();
    }
}
