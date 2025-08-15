using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Reactive.Disposables;
using System.Windows;
using AdonisUI.Controls;
using ReactiveUI;
using Splat;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common.Services;
using WolvenKit.Views.Dialogs;
using WolvenKit.Views.Dialogs.Windows;
using MessageBoxResult = AdonisUI.Controls.MessageBoxResult;

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

        public MainView(ProjectResourceTools projectResourceTools, AppViewModel viewModel = null)
        {
            ViewModel = viewModel ?? Locator.Current.GetService<AppViewModel>();
            DataContext = ViewModel;

            InitializeComponent();
            
            this.WhenActivated(disposables =>
            {
                Disposable.Create(() => dockingAdapter.SaveLayout()).DisposeWith(disposables);

                Interactions.ShowConfirmation = ShowConfirmation;
                Interactions.ShowSaveDialog = ShowSaveDialog;
                Interactions.ShowQuestionYesNo = ShowQuestionYesNo;

                Interactions.ShowPopupWithWeblink = ShowConfirmationWithLink;
                Interactions.ShowDeleteOrDuplicateComponentDialogue = (args) =>
                {
                    var dialog = new DeleteOrDuplicateComponentDialog(args.Item1, args.Item2);
                    if (dialog.ViewModel is not null && dialog.ShowDialog(this) == true)
                    {
                        return dialog.ViewModel;
                    }

                    return null;
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

                Interactions.ShowSelectSaveView = currentSaveGame =>
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
                    if (input.Item1 is not null)
                    {
                        dialog.ViewModel?.SetAvailableItems(input.Item1);
                    }

                    if (input.Item2 is not null)
                    {
                        dialog.ViewModel?.SetSelectedItems(input.Item2);
                    }

                    IEnumerable<IDisplayable> result = null;
                    if (dialog.ShowDialog(this) == true && dialog.ViewModel is not null)
                    {
                        result = dialog.ViewModel.SelectedItems;
                    }

                    return result;
                };

                Interactions.ShowPhotoModeDialogue = (p) =>
                {
                    var dialog = new CreatePhotoModeAppDialog(p.activeProject, p.settingsManager, projectResourceTools);
                    if (dialog.ShowDialog() != true)
                    {
                        return null;
                    }

                    return dialog.ViewModel;
                };

                Interactions.ShowGenerateInkatlasDialogue = (activeProject) =>
                {
                    var dialog = new AddInkatlasDialog(activeProject);
                    if (dialog.ShowDialog() != true)
                    {
                        return null;
                    }

                    return dialog.ViewModel;
                };

                Interactions.ShowChecklistDialogue = (args) =>
                {
                    var dialog = new ShowChecklistDialog(args.checklistOptions, args.fileName, args.title, args.text);
                    if (dialog.ShowDialog() != true)
                    {
                        return null;
                    }

                    return dialog.ViewModel;
                };

                Interactions.ShowScriptSettingsView = settings =>
                {
                    var dialog = new ScriptSettingsWindow(settings);
                    return dialog.ShowDialog() == true;
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

        private void FadeOut_Completed(object sender, EventArgs e) => ViewModel?.FinishedClosingModal();

        #region interactions

        private static bool ShowQuestionYesNo((string, string) input)
        {
            var messageResult = ShowConfirmation((input.Item1, input.Item2, WMessageBoxImage.Question, WMessageBoxButtons.YesNo));
            return messageResult == WMessageBoxResult.Yes;
        }

        // local methods
        private static AdonisUI.Controls.MessageBoxImage GetAdonisImage(WMessageBoxImage imageParam) =>
            (AdonisUI.Controls.MessageBoxImage)imageParam;

        private static WMessageBoxResult ShowConfirmation((string, string, WMessageBoxImage, WMessageBoxButtons) input)
        {
            var text = input.Item1;
            var caption = input.Item2;
            var image = input.Item3;
            var buttons = input.Item4;

            MessageBoxModel messageBox = new()
            {
                Text = text, Caption = caption, Icon = GetAdonisImage(image), Buttons = GetAdonisButtons(buttons)
            };

            return (WMessageBoxResult)AdonisUI.Controls.MessageBox.Show(Application.Current.MainWindow, messageBox);


            static IEnumerable<IMessageBoxButtonModel> GetAdonisButtons(WMessageBoxButtons buttonsParam)
            {
                return buttonsParam switch
                {
                    WMessageBoxButtons.Ok => [MessageBoxButtons.Ok()],
                    WMessageBoxButtons.OkCancel => MessageBoxButtons.OkCancel(),
                    WMessageBoxButtons.Yes => [MessageBoxButtons.Yes()],
                    WMessageBoxButtons.YesNo => MessageBoxButtons.YesNo(),
                    WMessageBoxButtons.YesNoCancel => MessageBoxButtons.YesNoCancel(),
                    WMessageBoxButtons.No => [MessageBoxButtons.No()],
                    _ => throw new ArgumentOutOfRangeException(nameof(buttons)),
                };
            }
        }

        /// <inheritdoc cref="Interactions.ShowPopupWithWeblinkAsync"/>
        private static WMessageBoxResult ShowConfirmationWithLink(
            (string, string, string, string, WMessageBoxImage) input)
        {
            MessageBoxModel messageBox = new()
            {
                Text = input.Item1,
                Caption = input.Item2,
                Buttons = [MessageBoxButtons.Custom(input.Item4), MessageBoxButtons.Ok()],
                Icon = GetAdonisImage(input.Item5),
            };

            var ret = AdonisUI.Controls.MessageBox.Show(Application.Current.MainWindow, messageBox);
            if (ret == MessageBoxResult.Custom && input.Item3 is string link && !string.IsNullOrEmpty(link))
            {
                Process.Start(new ProcessStartInfo { FileName = link, UseShellExecute = true });
            }

            return (WMessageBoxResult)ret;
        }

        private static readonly IMessageBoxButtonModel[] s_saveDialogButtons =
        [
            MessageBoxButtons.Cancel("Cancel"),
            MessageBoxButtons.Yes("Save and close"),
            MessageBoxButtons.No("Close without saving")
        ];

        private static WMessageBoxResult ShowSaveDialog(string fileName)
        {
            MessageBoxModel messageBox = new()
            {
                Text = $"The File {fileName} has unsaved changes!",
                Caption = "Really close your file?",
                Icon = GetAdonisImage(WMessageBoxImage.Exclamation),
                Buttons = s_saveDialogButtons
            };

            return (WMessageBoxResult)AdonisUI.Controls.MessageBox.Show(Application.Current.MainWindow, messageBox);
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
            if (!dockingAdapter.CloseAll())
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

            if (ViewModel?.GetToolViewModel<PropertiesViewModel>() is { } p)
            {
                p.EffectsManager.Dispose();
            }

            if (Locator.Current.GetService<IProjectManager>() is ProjectManager pm)
            {
                pm.Save();
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
