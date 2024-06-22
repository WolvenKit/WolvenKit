using System;
using System.Windows.Input;
using ReactiveUI;
using Syncfusion.Windows.Tools.Controls;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevels;

namespace WolvenKit.Views.Documents
{
    public partial class RedDocumentView : ReactiveUserControl<RedDocumentViewModel>
    {
        public RedDocumentView()
        {
            InitializeComponent();

            TabControl.SelectedItemChangedEvent += TabControl_OnSelectedItemChangedEvent;
            RedDocumentViewToolbar.EditorDifficultChanged += OnEditorDifficultyChanged;

            this.WhenActivated(disposables =>
            {
                if (DataContext is not RedDocumentViewModel vm)
                {
                    return;
                }

                SetCurrentValue(ViewModelProperty, vm);
                RedDocumentViewToolbar.CurrentTab = vm.SelectedTabItemViewModel;
            });
        }

        private void OnEditorDifficultyChanged(object sender, EditorDifficultyLevel level)
        {
            if (DataContext is not RedDocumentViewModel vm)
            {
                return;
            }

            vm.EditorDifficultyLevel = level;
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
