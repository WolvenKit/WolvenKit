using System;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.ViewModels.Dialogs;

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

            this.Bind(ViewModel, x => x.Project.Author, x => x.AuthorTextBox.Text)
                .DisposeWith(disposables);

            this.Bind(ViewModel, x => x.Project.Email, x => x.EmailTextBox.Text)
                .DisposeWith(disposables);

            this.Bind(ViewModel, x => x.Project.Version, x => x.VersionTextBox.Text)
                .DisposeWith(disposables);


            this.Bind(ViewModel, x => x.IsRedModInstalled, x => x.IsRedModCheckBox.IsEnabled)
                .DisposeWith(disposables);

            this.Bind(ViewModel, x => x.Project.IsRedMod, x => x.IsRedModCheckBox.IsChecked)
                .DisposeWith(disposables);

            this.Bind(ViewModel, x => x.Project.ExecuteDeploy, x => x.ExecuteDeployCheckBox.IsChecked)
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
                        DeploymentPanel.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                    }

                    if (name == "Deployment")
                    {
                        GeneralPanel.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                        DeploymentPanel.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    }
                }
            });

        this.WhenAnyValue(x => x.IsRedModCheckBox.IsChecked)
            .Subscribe(isChecked => ExecuteDeployCheckBox.SetCurrentValue(IsEnabledProperty, isChecked == true));
    }
}
