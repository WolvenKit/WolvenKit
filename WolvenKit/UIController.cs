using System;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.Common.Services;
using WolvenKit.Utility;
using WolvenKit.Common;
using WolvenKit.App;

namespace WolvenKit
{
    using Bundles;
    using Cache;
    using CR2W;
    using CR2W.Types;
    using W3Strings;
    using Common;
    using App;
    using BrightIdeasSoftware;
    using global::WolvenKit.Common.Model;
    using global::WolvenKit.Properties;

    public enum EColorThemes
    {
        VS2015Light = 0,
        VS2015Dark = 1,
        VS2015Blue = 2,
    }

    public enum EAppIcons
    {
        Wkit_dark,
        Wkit_light,
        Radish,
        Wcc
    }

    public enum EImageIcons
    {
        Wkit_dark,
        Wkit_light,

    }

    public class UIController : IVariableEditor, INotifyPropertyChanged
    {
        private static UIController uiController;

        public UIConfiguration Configuration { get; private set; }
        public IWindowFactory WindowFactory { get; private set; }

        

        // Color Themes
        #region Color Themes
        public VisualStudioToolStripExtender ToolStripExtender { get; set; }
        private readonly List<ThemeBase> _themesList = new List<ThemeBase>() { new VS2015LightTheme(), new VS2015DarkTheme(), new VS2015BlueTheme() };
        public static ThemeBase GetThemeBase() => Get()._themesList[(int)Get().Configuration.ColorTheme];
        public static EColorThemes GetColorTheme => Get().Configuration.ColorTheme;

        public static DockPanelColorPalette GetPalette() => GetThemeBase().ColorPalette;

        /// <summary>
        /// Light | Dark | Blue
        /// black | white | 27.41.62
        /// </summary>
        /// <returns></returns>
        public static Color GetForeColor() => GetPalette().CommandBarMenuDefault.Text;

        /// <summary>
        /// Light | Dark | Blue
        /// White Smoke | dark grey | faint blue
        /// </summary>
        /// <returns></returns>
        public static Color GetBackColor() => GetPalette().DockTarget.ButtonBackground;

        /// <summary>
        /// Light | Dark | Blue
        /// light blue | medium grey | yellow
        /// </summary>
        /// <returns></returns>
        public static Color GetHighlightColor()
        {
            return GetPalette().CommandBarMenuPopupHovered.ItemBackground;
            // boring but good
            //return GetPalette().CommandBarMenuDefault.Background;
        }

        public static HeaderFormatStyle GetHeaderFormatStyle()
        {
            HeaderFormatStyle hfs = new HeaderFormatStyle()
            {
                Normal = new HeaderStateStyle()
                {
                    BackColor = GetPalette().DockTarget.Background,
                    ForeColor = GetPalette().CommandBarMenuDefault.Text,
                },
                Hot = new HeaderStateStyle()
                {
                    BackColor = GetPalette().OverflowButtonHovered.Background,
                    ForeColor = GetPalette().CommandBarMenuDefault.Text,
                },
                Pressed = new HeaderStateStyle()
                {
                    BackColor = GetPalette().CommandBarToolbarButtonPressed.Background,
                    ForeColor = GetPalette().CommandBarMenuDefault.Text,
                }
            };
            return hfs;
        }
        #endregion

        // Icon library

        #region Icon Library
        // must be set to Copy in the resources!
        private readonly Dictionary<EAppIcons, string> iconDict = new Dictionary<EAppIcons, string>()
        {
            {EAppIcons.Wcc, @"Resources\WolvenKit\Icons\WCC_32x.ico"},
            {EAppIcons.Wkit_dark, @"Resources\WolvenKit\Icons\Wkit_dark_16x.ico"},
            {EAppIcons.Wkit_light, @"Resources\WolvenKit\Icons\Wkit_light_16x.ico"},
            {EAppIcons.Radish, @"Resources\WolvenKit\Icons\radish_icon.ico"},
        };
        // must be set to Copy in the resources!
        private readonly Dictionary<EImageIcons, string> imageDict = new Dictionary<EImageIcons, string>()
        {
            {EImageIcons.Wkit_dark, @"Resources\WolvenKit\wk_ribbon_dark_small.png"},
            {EImageIcons.Wkit_light, @"Resources\WolvenKit\wk_ribbon_light_small.png"},
        };

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        private UIController()  {  }

        /// <summary>
        /// Here we setup stuff we need in every form. Borders etc can be done here in the future.
        /// </summary>
        /// <param name="form">The form to initialize.</param>
        public static void InitForm(Form form)
        {
            Bitmap bmp = Resources.Wkit_logo_500x;
            form.Icon = Icon.FromHandle(bmp.GetHicon());
        }

        public static UIController Get()
        {
            if (uiController == null)
            {
                uiController = new UIController();
                uiController.Configuration = UIConfiguration.Load();
                uiController.WindowFactory = new ProductionWindowFactory();
                //uiController.Window = new frmMain();
                
            }
            return uiController;
        }

        public static string GetImageByKey(EImageIcons key) => Get().imageDict[key];
        public static string GetIconByKey(EAppIcons key) => Get().iconDict[key];

        public static Icon GetThemedWkitIcon()
        {
            switch (UIController.GetColorTheme)
            {
                case EColorThemes.VS2015Light:
                case EColorThemes.VS2015Blue:
                    return new Icon(UIController.GetIconByKey(EAppIcons.Wkit_dark), new Size(16, 16));
                case EColorThemes.VS2015Dark:
                    // disable for now until we get properly themed forms
                    //return new Icon(UIController.GetIconByKey(EAppIcons.Wkit_light), new Size(16, 16));
                    return new Icon(UIController.GetIconByKey(EAppIcons.Wkit_dark), new Size(16, 16));
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void ImportBytes(CVariable editvar)
        {
            var dlg = new OpenFileDialog() { InitialDirectory = MainController.Get().Configuration.InitialExportDirectory };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MainController.Get().Configuration.InitialExportDirectory = Path.GetDirectoryName(dlg.FileName);

                using (var fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(fs))
                    {
                        var bytes = ImportExportUtility.GetImportBytes(reader);
                        editvar.SetValue(bytes);

                        MainController.LogString(
                            $"{((CVariable) editvar).GetFullDependencyStringName()} succesfully imported from {dlg.FileName}",
                            Logtype.Success);
                    }
                }
            }
        }

        public void ExportBytes(IByteSource editvar)
        {
            var dlg = new SaveFileDialog();
            var bytes = editvar.GetBytes();

            dlg.Filter = string.Join("|", ImportExportUtility.GetPossibleExtensions(bytes, (CVariable)editvar));
            dlg.InitialDirectory = MainController.Get().Configuration.InitialExportDirectory;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MainController.Get().Configuration.InitialExportDirectory = Path.GetDirectoryName(dlg.FileName);

                using (var fs = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
                using (var writer = new BinaryWriter(fs))
                {
                    bytes = ImportExportUtility.GetExportBytes(bytes, Path.GetExtension(dlg.FileName), (CVariable)editvar);
                    writer.Write(bytes);

                    MainController.LogString(
                        $"{((CVariable) editvar).GetFullDependencyStringName()} succesfully exported to {dlg.FileName}",
                        Logtype.Success);
                }
            }
        }

        public static void OpenHexEditorFor(CVariable editvar)
        {
            var editor = new frmHexEditorView() { File = editvar.cr2w };

            if (editvar is IByteSource source)
            {
                editor.Bytes = source.GetBytes();
            }

            editor.Text = "Hex Viewer [" + editvar.GetFullName() + "]";
            editor.Show();
        }
    }
}
