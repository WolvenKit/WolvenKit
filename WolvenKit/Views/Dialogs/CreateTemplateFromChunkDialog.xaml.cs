using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Core.Services;

namespace WolvenKit.Views.Dialogs;

public partial class CreateTemplateFromChunkDialog : ReactiveUserControl<CreateTemplateFromChunkDialogViewModel>
{
    private TextBlock TemplateNameErrorBlock => FindName("TemplateNameErrorTextBlock") as TextBlock;

    public CreateTemplateFromChunkDialog()
    {
        InitializeComponent();
    }

    private void CancelButton_OnClick(object sender, RoutedEventArgs e) => ViewModel?.Cancel();

    private void CreateButton_OnClick(object sender, RoutedEventArgs e) => ViewModel?.Create();

    private void TemplateNameTextBox_KeyUp(object sender, KeyEventArgs e)
    {
        if (sender is not TextBox tb)
        {
            return;
        }

        if (string.IsNullOrWhiteSpace(tb.Text))
        {
            TemplateNameErrorBlock.SetCurrentValue(TextBlock.TextProperty, "Template name cannot be empty");
            TemplateNameErrorBlock.SetCurrentValue(VisibilityProperty, Visibility.Visible);
            return;
        }

        if (!FilepathValidationTools.IsOsFileNameValid(tb.Text.TrimEnd()))
        {
            TemplateNameErrorBlock.SetCurrentValue(TextBlock.TextProperty, "Template name must be a valid operating system file name");
            TemplateNameErrorBlock.SetCurrentValue(VisibilityProperty, Visibility.Visible);
            return;
        }

        TemplateNameErrorBlock.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
    }
}

