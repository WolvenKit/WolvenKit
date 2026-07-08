using System;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers;

public static class RedTypeTemplateServiceHelper
{
    /// <summary>
    /// This is a helper method to correctly handle the Raw option when using RedTypeTemplateSelectionOption
    /// </summary>
    /// <param name="templateService"></param>
    /// <param name="templateOption"></param>
    /// <returns></returns>
    public static IRedType CreateTypeInstanceFromSelectionOption(this RedTypeTemplateService templateService,
        RedTypeTemplateSelectionOption templateOption)
        => templateOption.Source switch
        {
            RedTypeTemplateSelectionOptionSource.Raw => RedTypeManager.CreateAndInitRedType(templateOption.Type),
            RedTypeTemplateSelectionOptionSource.User => templateService.CreateTypeInstance(templateOption, TemplateSource.User),
            RedTypeTemplateSelectionOptionSource.System => templateService.CreateTypeInstance(templateOption, TemplateSource.System),
            _ => throw new ArgumentOutOfRangeException(nameof(templateOption), templateOption.Source.ToString())
        };
}
