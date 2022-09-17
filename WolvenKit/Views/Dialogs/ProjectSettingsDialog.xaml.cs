using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using HandyControl.Tools.Command;
using Prism.Commands;
using ReactiveUI;
using Splat;
using WolvenKit.Functionality.Services;
using WolvenKit.ProjectManagement.Project;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.Views.Dialogs;
/// <summary>
/// Interaktionslogik für ProjectSettingsDialog.xaml
/// </summary>
public partial class ProjectSettingsDialog : ReactiveUserControl<ProjectSettingsDialogViewModel>
{
    public ProjectSettingsDialog()
    {
        InitializeComponent();

        CancelCommand = new Prism.Commands.DelegateCommand(ExecuteCancel);
        SaveCommand = new Prism.Commands.DelegateCommand(ExecuteSave);

        this.WhenActivated(disposables =>
        {
            LoadSettings();
        });

        this.WhenAnyValue(x => x.SelectedMenuItem)
            .Subscribe(item =>
            {
                if (item is ListBoxItem { Content: string str })
                {
                    if (str == "General")
                    {
                        GeneralPanel.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                        DeploymentPanel.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                    }

                    if (str == "Deployment")
                    {
                        GeneralPanel.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                        DeploymentPanel.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    }
                }
            });
    }

    #region DependencyProperties

    public static readonly DependencyProperty SelectedMenuItemProperty = DependencyProperty.Register(
        nameof(SelectedMenuItem), typeof(object), typeof(ProjectSettingsDialog),
        new PropertyMetadata());

    public object SelectedMenuItem
    {
        get => (object)GetValue(SelectedMenuItemProperty);
        set => SetValue(SelectedMenuItemProperty, value);
    }

    public static readonly DependencyProperty ProjectNameProperty = DependencyProperty.Register(
        nameof(ProjectName), typeof(string), typeof(ProjectSettingsDialog),
        new PropertyMetadata(""));

    public string ProjectName
    {
        get => (string)GetValue(ProjectNameProperty);
    }

    public static readonly DependencyProperty AuthorProperty = DependencyProperty.Register(
        nameof(Author), typeof(string), typeof(ProjectSettingsDialog),
        new PropertyMetadata(""));

    public string Author
    {
        get => (string)GetValue(AuthorProperty);
        set => SetValue(AuthorProperty, value);
    }

    public static readonly DependencyProperty EMailProperty = DependencyProperty.Register(
        nameof(EMail), typeof(string), typeof(ProjectSettingsDialog),
        new PropertyMetadata(""));

    public string EMail
    {
        get => (string)GetValue(EMailProperty);
        set => SetValue(EMailProperty, value);
    }

    public static readonly DependencyProperty VersionProperty = DependencyProperty.Register(
        nameof(Version), typeof(string), typeof(ProjectSettingsDialog),
        new PropertyMetadata(""));

    public string Version
    {
        get => (string)GetValue(VersionProperty);
        set => SetValue(VersionProperty, value);
    }

    public static readonly DependencyProperty IsRedModProperty = DependencyProperty.Register(
        nameof(IsRedMod), typeof(bool), typeof(ProjectSettingsDialog),
        new PropertyMetadata());

    public bool IsRedMod
    {
        get => (bool)GetValue(IsRedModProperty);
        set => SetValue(IsRedModProperty, value);
    }

    public static readonly DependencyProperty ExecuteDeployProperty = DependencyProperty.Register(
        nameof(ExecuteDeploy), typeof(bool), typeof(ProjectSettingsDialog),
        new PropertyMetadata());

    public bool ExecuteDeploy
    {
        get => (bool)GetValue(ExecuteDeployProperty);
        set => SetValue(ExecuteDeployProperty, value);
    }

    #endregion DependencyProperties

    #region Commands

    public ICommand CancelCommand { get; set; }

    private void ExecuteCancel()
    {
        Locator.Current.GetService<AppViewModel>().CloseModalCommand.Execute(null);
    }

    public ICommand SaveCommand { get; set; }

    private async void ExecuteSave()
    {
        if (Locator.Current.GetService<IProjectManager>() is not ProjectManager { ActiveProject: Cp77Project project } projectManager)
        {
            throw new Exception();
        }

        project.Author = Author;
        project.Email = EMail;
        project.Version = Version;

        project.IsRedMod = IsRedMod;
        project.ExecuteDeploy = ExecuteDeploy;


        await projectManager.SaveAsync();

        Locator.Current.GetService<AppViewModel>().CloseModalCommand.Execute(null);
    }

    #endregion Commands

    #region Methods

    private void LoadSettings()
    {
        if (Locator.Current.GetService<IProjectManager>() is not ProjectManager { ActiveProject: Cp77Project project })
        {
            throw new Exception();
        }

        SetCurrentValue(ProjectNameProperty, project.Name);
        SetCurrentValue(AuthorProperty, project.Author);
        SetCurrentValue(EMailProperty, project.Email);
        SetCurrentValue(VersionProperty, project.Version);

        SetCurrentValue(IsRedModProperty, project.IsRedMod);
        SetCurrentValue(ExecuteDeployProperty, project.ExecuteDeploy);
    }

    #endregion Methods
}
