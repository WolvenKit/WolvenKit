
using Catel.Windows;
using System.Windows;

namespace WolvenKit.Views.CodeEditor
{
    public partial class CodeEditorView
    {
        public CodeEditorView() : base(DataWindowMode.Custom)
        {
            InitializeComponent();
            ControlzEx.Theming.ThemeManager.Current.ChangeTheme(this, "Dark.Red"); //This aint needed was just for testing remove me.

        }

        
    }
}
