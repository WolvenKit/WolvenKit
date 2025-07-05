using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WolvenKit.Common.Model.Arguments
{
    /// <summary>
    /// Convert Arguments
    /// </summary>
    public abstract class ConvertArgs : ImportExportArgs
    {
    }


    public class CommonConvertArgs : ConvertArgs
    {
        [Category("Convert Settings")]
        [Display(Name = "Output format")]
        [Description("Select file output format")]
        public EConvertableOutput EConvertableOutput { get; set; }
        public override string ToString() => EConvertableOutput.ToString();

    }

}
