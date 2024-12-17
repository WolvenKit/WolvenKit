using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Input;
using ReactiveUI;
using Syncfusion.Windows.Tools.Controls;
using WolvenKit.App.Interaction;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevel;

namespace WolvenKit.Views.Documents
{
    public partial class RedDocumentView : ReactiveUserControl<RedDocumentViewModel>
    {
        public RedDocumentView()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                if (DataContext is not RedDocumentViewModel vm)
                {
                    return;
                }

                SetCurrentValue(ViewModelProperty, vm);
                RedDocumentViewToolbar.CurrentTab = vm.SelectedTabItemViewModel;

                Observable.FromEventPattern<SelectedItemChangedEventHandler, SelectedItemChangedEventArgs>(
                    handler => TabControl.SelectedItemChangedEvent += handler,
                    handler => TabControl.SelectedItemChangedEvent -= handler)
                    .Subscribe(e => TabControl_OnSelectedItemChangedEvent(e.Sender, e.EventArgs))
                    .DisposeWith(disposables);

                Observable.FromEventPattern<EventHandler<EditorDifficultyLevel>, EditorDifficultyLevel>(
                    handler => RedDocumentViewToolbar.EditorDifficultChanged += handler,
                    handler => RedDocumentViewToolbar.EditorDifficultChanged -= handler)
                    .Subscribe(e => OnEditorDifficultyChanged(e.Sender, e.EventArgs))
                    .DisposeWith(disposables);
            });
        }

        private void OnEditorDifficultyChanged(object sender, EditorDifficultyLevel level)
        {
            if (DataContext is not RedDocumentViewModel vm)
            {
                return;
            }

            if (vm.IsDirty)
            {
                var result = Interactions.ShowConfirmation((
                    $"The file {vm.FilePath} has unsaved changes. Do you want to save it before reloading?",
                    "File Modified",
                    WMessageBoxImage.Question,
                    WMessageBoxButtons.YesNo));

                if (result == WMessageBoxResult.No)
                {
                    return;
                }

                vm.SaveSync(null);
            }

            vm.EditorDifficultyLevel = level;
            
            vm.Reload(false);
        }

        private void TabControl_OnSelectedItemChangedEvent(object sender, SelectedItemChangedEventArgs e)
        {
            
            if (e?.NewSelectedItem?.DataContext is RedDocumentTabViewModel newTab)
            {
                RedDocumentViewToolbar.CurrentTab = newTab;
                newTab.Load();
            }
            else
            {
                RedDocumentViewToolbar.CurrentTab = null;
            }

            if (e?.OldSelectedItem?.DataContext is RedDocumentTabViewModel oldTab)
            {
                oldTab.Unload();
            }
        }

        private void OnToggleNoobFilter(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount <= 1 || DataContext is not RedDocumentViewModel vm)
            {
                return;
            }


            var newEditorLevel = vm.EditorDifficultyLevel switch
            {
                EditorDifficultyLevel.Easy => EditorDifficultyLevel.Default,
                EditorDifficultyLevel.Default => EditorDifficultyLevel.Advanced,
                EditorDifficultyLevel.Advanced => EditorDifficultyLevel.Easy,
                _ => throw new ArgumentOutOfRangeException()
            };

            OnEditorDifficultyChanged(this, newEditorLevel);
            
            // Send a message to update filtered items source
            // MessageBus.Current.SendMessage("UpdateFilteredItemsSource", "Command");


            // var mainWindow = Locator.Current.GetService<AppViewModel>();
            // mainWindow?.ReloadFile();
        }
    }
}
