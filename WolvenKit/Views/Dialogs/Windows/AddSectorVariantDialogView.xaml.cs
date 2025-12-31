using System;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.RED4.Types;
using Window = System.Windows.Window;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class AddSectorVariantDialogView : IViewFor<AddSectorVariantDialogViewModel>
    {
        // private static string s_lastSearch = "";
        // private static string s_lastReplace = "";
        // private static bool s_lastWholeWord;
        // private static bool s_lastRegex;

        public static bool IsInstanceOpen { get; private set; }

        public AddSectorVariantDialogView(worldStreamingBlock block, Cp77Project project,
            StreamingSectorTools sectorTools)
        {
            InitializeComponent();

            ViewModel = new AddSectorVariantDialogViewModel(block, project, sectorTools);
            DataContext = ViewModel;

            LoadLastSelection();

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        x => x.NewVariantNameOrPrefix,
                        x => x.SectorNameTextBox.Text)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        x => x.ReplaceInAppearances,
                        x => x.ReplaceInMeshAppearanceTextBox.Text)
                    .DisposeWith(disposables);

                // select sector node appearance (search&replace)
                this.Bind(ViewModel,
                        x => x.SearchInAppearances,
                        x => x.SearchInMeshAppearanceTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.SectorNodeAppearances,
                        x => x.NodeAppearanceDropdown.Options)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.SearchInAppearances,
                        x => x.NodeAppearanceDropdown.SelectedOption)
                    .DisposeWith(disposables);

                // select template variant
                this.Bind(ViewModel,
                        x => x.TemplateVariant,
                        x => x.TemplateSectorTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.VariantNames,
                        x => x.TemplateVariantDropdownMenu.Options)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.TemplateVariant,
                        x => x.TemplateVariantDropdownMenu.SelectedOption)
                    .DisposeWith(disposables);

            });
        }

        public AddSectorVariantDialogViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (AddSectorVariantDialogViewModel)value; }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            IsInstanceOpen = true;
            return ShowDialog();
        }

        private void LoadLastSelection()
        {
            // if (ViewModel is null)
            // {
            //     return;
            // }
            //
            // ViewModel.IsRegex = s_lastRegex;
            // ViewModel.IsWholeWord = s_lastWholeWord;
            //
            // if (s_lastSearch != "")
            // {
            //     ViewModel.SearchText = s_lastSearch;
            //     ViewModel.RememberValues = true;
            // }
            //
            // if (s_lastReplace == "")
            // {
            //     return;
            // }
            //
            // ViewModel.ReplaceText = s_lastReplace;
            // ViewModel.RememberValues = true;
        }

        private void SaveLastSelection()
        {
            if (ViewModel is null)
            {
                return;
            }

            // if (!ViewModel.RememberValues)
            // {
            //     s_lastRegex = false;
            //     s_lastWholeWord = false;
            //     s_lastSearch = "";
            //     s_lastReplace = "";
            //     return;
            // }
            //
            // s_lastRegex = ViewModel.IsRegex;
            // s_lastWholeWord = ViewModel.IsWholeWord;
            // s_lastSearch = ViewModel.SearchText;
            // s_lastReplace = ViewModel.ReplaceText;
        }


        private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
            {
                return;
            }

            SaveLastSelection();
            e.Handled = true;
            DialogResult = true;
            Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            IsInstanceOpen = false;
            base.OnClosed(e);
        }

        private void WizardControl_OnFinish(object sender, RoutedEventArgs e) => SaveLastSelection();

        private void LoadSectorButton_OnClick(object sender, RoutedEventArgs e) => ViewModel?.ReadStreamingSector();
    }
}
