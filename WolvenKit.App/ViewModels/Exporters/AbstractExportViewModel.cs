using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Common.Services;

namespace WolvenKit.App.ViewModels.Exporters;

public abstract partial class AbstractExportViewModel : ImportExportViewModel
{
    protected AbstractExportViewModel(IAppArchiveManager archiveManager, INotificationService notificationService, ISettingsManager settingsManager, string header, string contentId)
        : base(archiveManager, notificationService, settingsManager, header, contentId)
    {
    }
}
