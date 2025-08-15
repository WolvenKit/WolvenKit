using System;
using System.Windows.Input;
using ReactiveUI;
using Splat;
using Syncfusion.Windows.Tools.Controls;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevel;

namespace WolvenKit.Views.Documents
{
    public partial class RedDocumentView : ReactiveUserControl<RedDocumentViewModel>
    {
        public RedDocumentView()
        {
            InitializeComponent();

            TabControl.SelectedItemChangedEvent += TabControl_OnSelectedItemChangedEvent;

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
            var settingsManager = Locator.Current.GetService<ISettingsManager>();
            var newEditorLevel = settingsManager.DefaultEditorDifficultyLevel switch
            {
                EditorDifficultyLevel.None => EditorDifficultyLevel.Easy,
                EditorDifficultyLevel.Easy => EditorDifficultyLevel.Default,
                EditorDifficultyLevel.Default => EditorDifficultyLevel.Advanced,
                EditorDifficultyLevel.Advanced => EditorDifficultyLevel.Easy,
                _ => EditorDifficultyLevel.None
            };

            settingsManager.DefaultEditorDifficultyLevel = newEditorLevel;
        }
    }
}
