using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Windows;
using ReactiveUI;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs.Windows;

public partial class GenerateRefitMeshesDialog : IViewFor<GenerateRefitMeshesDialogViewModel>
{
    public GenerateRefitMeshesDialog(Cp77Project activeProject)
    {
        InitializeComponent();
        ViewModel = new GenerateRefitMeshesDialogViewModel(activeProject);
        DataContext = ViewModel;

        Owner = Application.Current.MainWindow;

        this.WhenActivated(disposables =>
        {
            this.Bind(ViewModel,
                    x => x.MaleBaseMeshOptions,
                    x => x.MaleBaseMeshDropdown.Options)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.FemaleBaseMeshOptions,
                    x => x.FemaleBaseMeshDropdown.Options)
                .DisposeWith(disposables);

            this.Bind(ViewModel,
                    x => x.MaleBaseMesh,
                    x => x.MaleBaseMeshDropdown.dropdown.Text)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.MaleBaseMesh,
                    x => x.MaleBaseMeshTextBox.Text)
                .DisposeWith(disposables);

            this.Bind(ViewModel,
                    x => x.FemaleBaseMesh,
                    x => x.FemaleBaseMeshDropdown.dropdown.Text)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.FemaleBaseMesh,
                    x => x.FemaleBaseMeshTextBox.Text)
                .DisposeWith(disposables);

            this.Bind(ViewModel,
                    x => x.MaleRefits,
                    x => x.MaleRefitsTextBox.Text)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.FemaleRefits,
                    x => x.FemaleRefitsTextBox.Text)
                .DisposeWith(disposables);
        });
    }

    public GenerateRefitMeshesDialogViewModel ViewModel { get; set; }

    object IViewFor.ViewModel
    {
        get => ViewModel;
        set => ViewModel = (GenerateRefitMeshesDialogViewModel)value;
    }

    public bool? ShowDialog(Window owner)
    {
        Owner = owner;
        return ShowDialog();
    }
}
