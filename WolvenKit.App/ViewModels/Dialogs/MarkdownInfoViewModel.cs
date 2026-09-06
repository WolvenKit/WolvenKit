using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class MarkdownInfoViewModel : DialogViewModel
{
    public AppViewModel AppViewModel { get; }

    public string Title { get; set; }
    public string Markdown { get; set; }

    public MarkdownInfoViewModel(AppViewModel appViewModel, string title, string markdown)
    {
        AppViewModel = appViewModel;

        Title = title;
        Markdown = markdown;
    }
}
