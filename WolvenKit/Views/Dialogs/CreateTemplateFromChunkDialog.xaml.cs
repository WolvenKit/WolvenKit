using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Core.Services;

namespace WolvenKit.Views.Dialogs;

public partial class CreateTemplateFromChunkDialog : ReactiveUserControl<CreateTemplateFromChunkDialogViewModel>
{
    private readonly TextBlock _templateNameErrorBlock;

    public CreateTemplateFromChunkDialog()
    {
        InitializeComponent();
        _templateNameErrorBlock = TemplateNameErrorTextBlock;
    }

    private void CancelButton_OnClick(object sender, RoutedEventArgs e) => ViewModel?.Cancel();

    private void CreateButton_OnClick(object sender, RoutedEventArgs e) => ViewModel?.Create();

    private void TemplateNameTextBox_KeyUp(object sender, KeyEventArgs e)
    {
        if (sender is not TextBox tb)
        {
            return;
        }

        tb.GetBindingExpression(TextBox.TextProperty)?.UpdateSource();

        if (string.IsNullOrWhiteSpace(tb.Text))
        {
            _templateNameErrorBlock.SetCurrentValue(TextBlock.TextProperty, "Template name cannot be empty");
            _templateNameErrorBlock.SetCurrentValue(VisibilityProperty, Visibility.Visible);
            return;
        }

        if (!FilepathValidationTools.IsOsFileNameValid(tb.Text.TrimEnd()))
        {
            _templateNameErrorBlock.SetCurrentValue(TextBlock.TextProperty, "Template name must be a valid operating system file name");
            _templateNameErrorBlock.SetCurrentValue(VisibilityProperty, Visibility.Visible);
            return;
        }

        _templateNameErrorBlock.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
    }
}

