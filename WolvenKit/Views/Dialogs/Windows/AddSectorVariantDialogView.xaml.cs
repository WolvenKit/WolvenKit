using System;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
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

        private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            // Only send dialog result enter is pressed - if textbox is focused, require ctrl+shift+enter
            if (e.Key != Key.Enter || (ReplaceInMeshAppearanceTextBox.IsFocused &&
                                       !(ModifierViewStateService.IsCtrlBeingHeld &&
                                         ModifierViewStateService.IsShiftBeingHeld)))
            {
                return;
            }

            e.Handled = true;
            DialogResult = true;
            Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            IsInstanceOpen = false;
            base.OnClosed(e);
        }
    }
}
