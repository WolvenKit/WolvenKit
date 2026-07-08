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
    /// <param name="fallbackType">type to be used for the Raw option</param>
    /// <returns></returns>
    public static IRedType CreateTypeInstanceFromSelectionOption(this RedTypeTemplateService templateService,
        RedTypeTemplateSelectionOption templateOption, Type fallbackType)
        => templateOption.Source switch
        {
            RedTypeTemplateSelectionOptionSource.Raw => RedTypeManager.CreateAndInitRedType(fallbackType),
            RedTypeTemplateSelectionOptionSource.User => templateService.CreateTypeInstance(templateOption, TemplateSource.User),
            RedTypeTemplateSelectionOptionSource.System => templateService.CreateTypeInstance(templateOption, TemplateSource.System),
            _ => throw new ArgumentOutOfRangeException(nameof(templateOption), templateOption.Source.ToString())
        };
}
