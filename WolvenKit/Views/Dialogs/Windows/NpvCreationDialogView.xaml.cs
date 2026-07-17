using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using ReactiveUI;
using Splat;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Core;

namespace WolvenKit.Views.Dialogs.Windows;

/// <summary>
/// Interaction logic für NpvCreationDialog.xaml
/// </summary>
public partial class NpvCreationDialogView : IViewFor<NpvCreationDialogViewModel>
{
    object IViewFor.ViewModel
    {
        get => ViewModel;
        set => ViewModel = (NpvCreationDialogViewModel)value;
    }


    public NpvCreationDialogView(Cp77Project activeProject)
    {
        InitializeComponent();

        ViewModel = new NpvCreationDialogViewModel()
        {
            ProjectFolders = activeProject.GetAllFolders(activeProject.ModDirectory).ToDictionary<string, string>(x => x)
        };
        DataContext = ViewModel;

        this.WhenActivated(disposables =>
        {
            this.Bind(ViewModel,
                    x => x.Eyes,
                    x => x.ComboboxEyes.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.Nose,
                    x => x.ComboboxNose.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.Mouth,
                    x => x.ComboboxMouth.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.Jaw,
                    x => x.ComboboxJaw.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.Ears,
                    x => x.ComboboxEars.SelectedIndex)
                .DisposeWith(disposables);

            this.Bind(ViewModel,
                    x => x.Beard,
                    x => x.ComboboxBeard.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.BeardStyle,
                    x => x.ComboboxBeardStyle.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.Cyberware,
                    x => x.ComboboxCyberware.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.EyeMakeup,
                    x => x.ComboboxEyeMakeUp.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.LipMakeup,
                    x => x.ComboboxLipMakeUp.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.CheekMakeup,
                    x => x.ComboboxCheekMakeUp.SelectedIndex)
                .DisposeWith(disposables);

            this.Bind(ViewModel,
                    x => x.Blemishes,
                    x => x.ComboboxBlemishes.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.Nails,
                    x => x.ComboboxNails.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.Genitals,
                    x => x.ComboboxGenitals.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.GenitalSize,
                    x => x.ComboboxGenitals2.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.FacialTattoos,
                    x => x.ComboboxFacialTattoos.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.FacialScars,
                    x => x.ComboboxFacialScars.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.Piercings,
                    x => x.ComboboxPiercings.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.Nipples,
                    x => x.ComboboxNipples.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.BodyScars,
                    x => x.ComboboxBodyScars.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.PubicHair,
                    x => x.ComboboxPubicHair.SelectedIndex)
                .DisposeWith(disposables);

            this.Bind(ViewModel,
                    x => x.ProjectFolders,
                    x => x.FilterableDropdownMenu.Options)
                .DisposeWith(disposables);
        });
    }

    public bool? ShowDialog(Window owner)
    {
        Owner = owner;
        return ShowDialog();
    }

    public NpvCreationDialogViewModel ViewModel { get; set; }

    private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        var psi = new System.Diagnostics.ProcessStartInfo { FileName = e.Uri.AbsoluteUri, UseShellExecute = true };
        System.Diagnostics.Process.Start(psi);
        e.Handled = true;
    }

    private void OnKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key != Key.Escape)
        {
            return;
        }

        Close();
    }

    private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
    {
        // throw new System.NotImplementedException();
    }
    private void WizardControl_OnHelpButtonClicked(object sender, RoutedEventArgs e)
    {
        var ps = new ProcessStartInfo(WikiLinks.NPVs) { UseShellExecute = true, Verb = "open" };
        Process.Start(ps);
    }
}
