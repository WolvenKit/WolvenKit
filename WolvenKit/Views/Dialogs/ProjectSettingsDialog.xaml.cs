using System;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs;
/// <summary>
/// Interaktionslogik für ProjectSettingsDialog.xaml
/// </summary>
public partial class ProjectSettingsDialog : ReactiveUserControl<ProjectSettingsDialogViewModel>
{
    public ProjectSettingsDialog()
    {
        InitializeComponent();

        this.WhenActivated(disposables =>
        {
            this.OneWayBind(ViewModel, x => x.Project.Name, x => x.ProjectNameTextBox.Text)
                .DisposeWith(disposables);

            this.Bind(ViewModel, x => x.Project.ModName, x => x.ModNameTextBox.Text)
                .DisposeWith(disposables);

            this.Bind(ViewModel, x => x.Project.Author, x => x.AuthorTextBox.Text)
                .DisposeWith(disposables);

            this.Bind(ViewModel, x => x.Project.Email, x => x.EmailTextBox.Text)
                .DisposeWith(disposables);

            this.Bind(ViewModel, x => x.Project.Version, x => x.VersionTextBox.Text)
                .DisposeWith(disposables);

            this.Bind(ViewModel, x => x.Project.ProjectColor, x => x.ProjectColorButton.Color)
                .DisposeWith(disposables);

            this.BindCommand(ViewModel, x => x.OkCommand, x => x.OkButton)
                .DisposeWith(disposables);

            this.BindCommand(ViewModel, x => x.CancelCommand, x => x.CancelButton)
                .DisposeWith(disposables);
        });

        this.WhenAnyValue(x => x.MenuListBox.SelectedItem)
            .Subscribe(selectedItem =>
            {
                if (selectedItem is ListBoxItem { Content: string name })
                {
                    if (name == "General")
                    {
                        GeneralPanel.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    }
                }
            });

        if (ViewModel is not null)
        {
            ProjectColorButton.Color = ViewModel.Project.ProjectColor;
        }
    }
}
