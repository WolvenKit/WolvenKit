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
        [Description("Use this to select to what format you want to export your file.")]
        public EConvertableOutput EConvertableOutput { get; set; }
        public override string ToString() => EConvertableOutput.ToString();

    }

}
