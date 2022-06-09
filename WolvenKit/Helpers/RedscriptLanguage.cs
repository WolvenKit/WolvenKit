using Syncfusion.Windows.Edit;

namespace WolvenKit.Views.Documents
{
    public class RedscriptLanguage : ProceduralLanguageBase
    {
        public RedscriptLanguage(EditControl control) : base(control)
        {
            Name = "Redscript";
            FileExtension = "reds";
            ApplyColoring = true;
            SupportsIntellisense = false;
            SupportsOutlining = true;
            //TextForeground = Brushes.Black;
        }
    }
}
