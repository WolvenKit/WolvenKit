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
using WolvenKit.Views.Templates;
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
                Interactions.ShowSaveUnsavedChangesDialog = ShowSaveUnsavedChangesDialog;
                Interactions.ShowQuestionYesNo = ShowQuestionYesNo;
                Interactions.ShowQuestionYesNoCancel = ShowQuestionYesNoCancel;
                Interactions.ShowGenerateTranslationEntry = (_) =>
                {
                    var dialog = new LocalizationStringPopup();
                    if (dialog.ViewModel is not null && dialog.ShowDialog(this) == true)
                    {
                        return dialog.ViewModel;
                    }

                    return null;
                };

                Interactions.ShowErrorPopup = (args) =>
                {
                    ShowConfirmation((args.text, args.caption, WMessageBoxImage.Error, WMessageBoxButtons.Ok));
                    return true;
                };

                Interactions.ShowPopupWithWeblink = ShowConfirmationWithLink;
                Interactions.ShowDeleteOrDuplicateComponentDialogue = (args) =>
                {
                    var dialog = new DeleteOrDuplicateComponentDialog(args.componentNames, args.isDeleting);
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

                Interactions.ShowArchiveXlFilesView = currentProject =>
                {
                    AddArchiveXlFilesDialog dialog = new(currentProject);

                    if (dialog.ShowDialog(this) != true)
                    {
                        return null;
                    }

                    return dialog.ViewModel?.CollectItemInfo();
                };


                Interactions.ShowNewPlayerHeadView = () =>
                {
                    ShowNewPlayerHeadDialog dialog = new();

                    if (dialog.ShowDialog(this) != true)
                    {
                        return null;
                    }

                    return dialog.ViewModel;
                };

                Interactions.ShowNewSectorVariantView = args =>
                {
                    var dialog = new AddSectorVariantDialogView(args.block, args.project, args.sectorTools);
                    if (dialog.ShowDialog() != true)
                    {
                        return null;
                    }

                    return dialog.ViewModel;
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
                    if (input.availableItems is not null)
                    {
                        dialog.ViewModel?.SetAvailableItems(input.availableItems);
                    }

                    if (input.selectedItems is not null)
                    {
                        dialog.ViewModel?.SetSelectedItems(input.selectedItems);
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

                Interactions.ShowGeneratePropFileModel = (activeProject) =>
                {
                    var dialog = new AddPropFileDialog(activeProject);
                    if (dialog.ShowDialog() != true)
                    {
                        return null;
                    }

                    return dialog.ViewModel;
                };

                Interactions.ShowCopyMeshAppearancesDialogue = (options) =>
                {
                    var dialog = new CopyMeshAppearancesDialog(options);
                    if (dialog.ShowDialog() != true)
                    {
                        return null;
                    }

                    return dialog.ViewModel;
                };

                Interactions.ShowChecklistDialogue = (args) =>
                {
                    var dialog = new ShowChecklistDialog(
                        args.checklistOptions,
                        args.title,
                        args.text,
                        args.inputFieldLabel,
                        args.inputFieldDefaultValue);
                    if (dialog.ShowDialog() != true)
                    {
                        return null;
                    }

                    return dialog.ViewModel;
                };

                Interactions.AddItemsToStore = (project) =>
                {
                    var dialog = new AddItemsToStoreDialog(project);
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

        private static bool? ShowQuestionYesNoCancel((string, string) input)
        {
            var messageResult = ShowConfirmation((input.Item1, input.Item2, WMessageBoxImage.Question,
                WMessageBoxButtons.YesNoCancel));

            switch (messageResult)
            {
                case WMessageBoxResult.Yes:
                    return true;
                case WMessageBoxResult.Cancel:
                    return null;
                case WMessageBoxResult.No:
                default:
                    return false;
            }
        }

        // local methods
        private static AdonisUI.Controls.MessageBoxImage GetAdonisImage(WMessageBoxImage imageParam) =>
            (AdonisUI.Controls.MessageBoxImage)imageParam;

        private static WMessageBoxResult ShowConfirmation(
            (string text, string caption, WMessageBoxImage image, WMessageBoxButtons buttons) input)
        {
            MessageBoxModel messageBox = new()
            {
                Text = input.text,
                Caption = input.caption,
                Icon = GetAdonisImage(input.image),
                Buttons = GetAdonisButtons(input.buttons)
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
                    _ => throw new ArgumentOutOfRangeException(nameof(input.buttons)),
                };
            }
        }

        /// <inheritdoc cref="Interactions.ShowPopupWithWeblinkAsync"/>
        private static WMessageBoxResult ShowConfirmationWithLink(
            (string text, string title, string weblink, string buttonText, WMessageBoxImage icon) input)
        {
            MessageBoxModel messageBox = new()
            {
                Text = input.text,
                Caption = input.title,
                Buttons = [MessageBoxButtons.Custom(input.buttonText), MessageBoxButtons.Ok()],
                Icon = GetAdonisImage(input.icon),
            };

            var ret = AdonisUI.Controls.MessageBox.Show(Application.Current.MainWindow, messageBox);
            if (ret == MessageBoxResult.Custom && !string.IsNullOrEmpty(input.weblink))
            {
                Process.Start(new ProcessStartInfo { FileName = input.weblink, UseShellExecute = true });
            }

            return (WMessageBoxResult)ret;
        }

        private static readonly IMessageBoxButtonModel[] s_saveDialogButtons =
        [
            MessageBoxButtons.Cancel("Cancel"),
            MessageBoxButtons.Yes("Save and close"),
            MessageBoxButtons.No("Close without saving")
        ];

        private static WMessageBoxResult ShowSaveUnsavedChangesDialog(string fileName)
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
