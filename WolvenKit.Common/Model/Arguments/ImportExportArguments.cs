using System.ComponentModel;
using WolvenKit.Core;

namespace WolvenKit.Common.Model.Arguments
{

    /// <summary>
    /// Import Export Arguments
    /// </summary>
    public abstract class ImportExportArgs : ObservableObject
    {
        [Browsable(false)] public static bool IsCLI { get; set; } = false;
    }


}
