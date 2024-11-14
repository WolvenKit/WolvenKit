using System;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using ReactiveUI;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs.Windows;

/// <summary>
/// Interaction logic für NpvCreationDialog.xaml
/// </summary>
public partial class NpvCreationDialogView : IViewFor<NpvCreationDialogViewModel>
{
    object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (NpvCreationDialogViewModel)value; }

    private readonly INpvCreationService _npvCreationService;

    public NpvCreationDialogView()
    {
        InitializeComponent();

        _npvCreationService = Locator.Current.GetService<INpvCreationService>();
        
        ViewModel = new NpvCreationDialogViewModel();
        DataContext = ViewModel;

        this.WhenActivated(disposables =>
        {
            this.Bind(ViewModel,
                    x => x.Eyes,
                    x => x.Combobox_Eyes.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.Nose,
                    x => x.Combobox_Nose.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.Mouth,
                    x => x.Combobox_Mouth.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.Jaw,
                    x => x.Combobox_Jaw.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.Ears,
                    x => x.Combobox_Ears.SelectedIndex)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.BodyGender,
                    x => x.Combobox_BodyGender.SelectedItem)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.DestFolderPath,
                    x => x.TextBox_FilePath.Text)
                .DisposeWith(disposables);

            Combobox_BodyGender.SelectionChanged += RefreshSaveButtonState;
            TextBox_FilePath.LostFocus += RefreshSaveButtonState;
        });
    }

    protected override void OnDeactivated(EventArgs e)
    {
        Combobox_BodyGender.SelectionChanged -= RefreshSaveButtonState;
        TextBox_FilePath.LostFocus -= RefreshSaveButtonState;
        base.OnDeactivated(e);
    }


    private void RefreshSaveButtonState(object sender, RoutedEventArgs e) => ViewModel?.RefreshVisibility();


    public bool ShowDialog(Window owner)
    {
        Owner = owner;
        return ShowDialog() ?? false;
    }

    public NpvCreationDialogViewModel ViewModel { get; set; }

    private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        var psi = new System.Diagnostics.ProcessStartInfo { FileName = e.Uri.AbsoluteUri, UseShellExecute = true };
        System.Diagnostics.Process.Start(psi);
        e.Handled = true;
    }

    private void OnCancelButtonClick(object sender, RoutedEventArgs e)
    {
        DialogResult = null;
        Close();
    }

    private void OnKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            OnOkButtonClick(null, null);
            return;
        }

        if (e.Key != Key.Escape)
        {
            return;
        }

        OnCancelButtonClick(null, null);
    }

    private void OnOkButtonClick(object sender, RoutedEventArgs e)
    {
        DialogResult = true;
        Close();
        _npvCreationService.CreateNpv(ViewModel!);
    }
}