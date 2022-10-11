using System.ComponentModel;
using ReactiveUI;

namespace WolvenKit.Common.Model.Arguments
{

    /// <summary>
    /// Import Export Arguments
    /// </summary>
    public abstract class ImportExportArgs : ReactiveObject
    {
        [Browsable(false)] public static bool IsCLI { get; set; } = false;
    }


}
