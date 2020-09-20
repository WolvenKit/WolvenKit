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

namespace WolvenKit
{
    using Bundles;
    using Cache;
    using CR2W;
    using CR2W.Types;
    using W3Strings;
    using Common;
    using App;
    using WolvenKit.App.Model;
    using WolvenKit.App.ViewModels;
    using BrightIdeasSoftware;
    using WolvenKit.Forms.Editors;
    using WolvenKit.Common.Model;

    public enum EColorThemes
    {
        VS2015Light = 0,
        VS2015Dark = 1,
        VS2015Blue = 2,
    }

    public class UIController : IVariableEditor, INotifyPropertyChanged
    {
        private static UIController mainController;
        public UIConfiguration Configuration { get; private set; }
        public frmMain Window { get; private set; }

        public const string ManagerCacheDir = "ManagerCache";
        public string VLCLibDir = "C:\\Program Files\\VideoLAN\\VLC";
        public string InitialModProject = "";
        public string InitialWKP = "";

        // Color Themes
        public VisualStudioToolStripExtender ToolStripExtender { get; set; }
        private readonly List<ThemeBase> _themesList = new List<ThemeBase>() { new VS2015LightTheme(), new VS2015DarkTheme(), new VS2015BlueTheme() };
        public static ThemeBase GetTheme()
        {
            return Get()._themesList[(int)Get().Configuration.ColorTheme];
        }

        public static DockPanelColorPalette GetPalette() => GetTheme().ColorPalette;

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


        public event PropertyChangedEventHandler PropertyChanged;

        private UIController()  {  }

        /// <summary>
        /// Here we setup stuff we need in every form. Borders etc can be done here in the future.
        /// </summary>
        /// <param name="form">The form to initialize.</param>
        public static void InitForm(Form form)
        {
            Bitmap bmp = WolvenKit.Properties.Resources.Wkit_logo_500x;
            form.Icon = Icon.FromHandle(bmp.GetHicon());
        }

        public void CreateVariableEditor(CVariable editvar, EVariableEditorAction action)
        {
            switch (action)
            {
                case EVariableEditorAction.Export:
                    ExportBytes(editvar);
                    break;
                case EVariableEditorAction.Import:
                    ImportBytes(editvar);
                    break;
                case EVariableEditorAction.Open:
                    OpenEditorFor(editvar);
                    break;
            }
        }

        public static UIController Get()
        {
            if (mainController == null)
            {
                mainController = new UIController();
                mainController.Configuration = UIConfiguration.Load();
                mainController.Window = new frmMain();
            }
            return mainController;
        }

        

        //public frmCR2WDocument LoadDocument(string filename, bool suppressErrors = false)
        //{
        //    return Window.LoadDocument(filename, null, suppressErrors);
        //}

        //public frmCR2WDocument LoadDocument(string filename, MemoryStream memoryStream, bool suppressErrors = false)
        //{
        //    return Window.LoadDocument(filename, memoryStream, suppressErrors) as frmCR2WDocument;
        //}


        private void ImportBytes(CVariable editvar)
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
                    }
                }
            }
        }

        private void ExportBytes(CVariable editvar)
        {
            var dlg = new SaveFileDialog();
            byte[] bytes = null;

            if (editvar is IByteSource)
            {
                bytes = ((IByteSource)editvar).Bytes.ToArray();
            }

            dlg.Filter = string.Join("|", ImportExportUtility.GetPossibleExtensions(bytes, (CVariable)editvar.ParentVar));
            dlg.InitialDirectory = MainController.Get().Configuration.InitialExportDirectory;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MainController.Get().Configuration.InitialExportDirectory = Path.GetDirectoryName(dlg.FileName);

                using (var fs = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
                {
                    using (var writer = new BinaryWriter(fs))
                    {
                        bytes = ImportExportUtility.GetExportBytes(bytes, Path.GetExtension(dlg.FileName), (CVariable)editvar.ParentVar);
                        writer.Write(bytes);
                    }
                }
            }
        }

        private void OpenHexEditorFor(CVariable editvar)
        {
            var editor = new frmHexEditorView() { File = editvar.cr2w };

            if (editvar is IByteSource)
            {
                editor.Bytes = ((IByteSource)editvar).Bytes;
            }

            editor.Text = "Hex Viewer [" + editvar.GetFullName() + "]";
            editor.Show();
        }

        private void OpenEditorFor(CVariable editvar)
        {
            byte[] bytes = null;

            if (editvar is IByteSource)
            {
                bytes = ((IByteSource)editvar).Bytes;
            }

            if (bytes != null)
            {
                var doc = Window.LoadDocument(editvar.cr2w.Cr2wFileName + ":" + editvar.GetFullName(), new MemoryStream(bytes), true);
                if (doc != null)
                {
                    var vm = doc.GetViewModel();
                    vm.OnFileSaved += OnVariableEditorSave;
                    vm.SaveTarget = editvar;
                }
                else
                {
                    OpenHexEditorFor(editvar);
                }
            }
        }

        private void OnVariableEditorSave(object sender, FileSavedEventArgs args)
        {
            if (args.Stream is MemoryStream stream)
            {
                var vm = (DocumentViewModel)sender;
                var editvar = (CVariable)vm.SaveTarget;
                editvar.SetValue(stream.ToArray());
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
