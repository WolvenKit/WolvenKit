using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Interaction;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class CreateTemplateFromChunkDialogViewModel : DialogViewModel
{
    private readonly RedTypeTemplateService _templateService;
    private readonly AppViewModel _appViewModel;

    [ObservableProperty]
    private RedTypeTemplate _template;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsTemplateNameValid))]
    private string _templateName = "";

    public bool IsTemplateNameValid => !string.IsNullOrWhiteSpace(TemplateName) && FilepathValidationTools.IsOsFileNameValid(TemplateName.TrimEnd());

    public CreateTemplateFromChunkDialogViewModel(IRedType templateData, RedTypeTemplateService templateService, AppViewModel appViewModel)
    {
        _templateService = templateService;
        _appViewModel = appViewModel;

        Template = new RedTypeTemplate() { Data = templateData };
    }

    public async Task Create()
    {
        if (_templateService.TemplateExists(Template.Data!.GetType(), TemplateName))
        {
            var response = await Interactions.ShowMessageBoxAsync(
                "A template with this name and type already exists, do you want to overwrite it?",
                "Template already exists",
                WMessageBoxButtons.YesNo);

            if (response == WMessageBoxResult.No)
            {
                return;
            }
        }

        _templateService.WriteTemplate(Template, TemplateName);
        _appViewModel.CloseModalCommand.Execute(null);
    }

    public void Cancel() => _appViewModel.CloseModalCommand.Execute(null);
}
