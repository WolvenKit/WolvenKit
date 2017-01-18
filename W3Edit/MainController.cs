using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3Edit.Bundles;
using W3Edit.CR2W;
using W3Edit.CR2W.Editors;
using W3Edit.CR2W.Types;
using W3Edit.W3Strings;

namespace W3Edit
{
    public class MainController : IVariableEditor, ILocalizedStringSource
    {
        private static MainController mainController;
        private W3StringManager w3StringManager;
        private Configuration configuration;
        private BundleManager bundleManager;
        private frmMain window;

        public static MainController Get()
        {
            if (mainController == null)
            {
                mainController = new MainController();
                mainController.Initialize();
            }

            return mainController;
        }

        public W3StringManager W3StringManager 
        {
            get {
                if (w3StringManager == null)
                {
                    w3StringManager = new W3StringManager();
                    w3StringManager.Load(configuration.TextLanguage, Path.GetDirectoryName(configuration.ExecutablePath));
                }

                return w3StringManager;
            }
        }

        public BundleManager BundleManager
        {
            get
            {
                if (bundleManager == null)
                {
                    bundleManager = new BundleManager();
                    bundleManager.LoadAll(Path.GetDirectoryName(configuration.ExecutablePath));
                }
                return bundleManager;
            }
        }

        public Configuration Configuration
        {
            get
            {
                return configuration;
            }
        }

        public frmMain Window { get { return window; } }

        MainController()
        {

        }

        public void Initialize()
        {
            configuration = Configuration.Load();

            window = new frmMain();
        }

        public frmCR2WDocument LoadDocument(string filename, bool suppressErrors = false)
        {
            return Window.LoadDocument(filename, null, suppressErrors);
        }

        public frmCR2WDocument LoadDocument(string filename, MemoryStream memoryStream, bool suppressErrors = false)
        {
            return Window.LoadDocument(filename, memoryStream, suppressErrors);
        }

        public void ReloadStringManager()
        {
            W3StringManager.Load(configuration.TextLanguage, Path.GetDirectoryName(configuration.ExecutablePath), true);
        }

        public void CreateVariableEditor(CVariable editvar, EVariableEditorAction action)
        {
            switch(action)
            {
                case EVariableEditorAction.Export:
                    exportBytes(editvar);
                    break;
                case EVariableEditorAction.Import:
                    importBytes(editvar);
                    break;
                case EVariableEditorAction.Open:
                    openEditorFor(editvar);
                    break;
            }
        }


        private void importBytes(CVariable editvar)
        {
            var dlg = new OpenFileDialog();
            dlg.InitialDirectory = MainController.Get().Configuration.InitialExportDirectory;

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
                    fs.Close();
                }
            }
        }

        private void exportBytes(CVariable editvar)
        {
            var dlg = new SaveFileDialog();
            byte[] bytes = null;

            if (editvar is IByteSource)
            {
                bytes = ((IByteSource)editvar).Bytes;
            }

            dlg.Filter = string.Join("|", ImportExportUtility.GetPossibleExtensions(bytes));
            dlg.InitialDirectory = MainController.Get().Configuration.InitialExportDirectory;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MainController.Get().Configuration.InitialExportDirectory = Path.GetDirectoryName(dlg.FileName);

                using (var fs = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write))
                {
                    using (var writer = new BinaryWriter(fs))
                    {


                        bytes = ImportExportUtility.GetExportBytes(bytes, Path.GetExtension(dlg.FileName));
                        writer.Write(bytes);
                    }
                    fs.Close();
                }
            }
        }

        private void openHexEditorFor(CVariable editvar)
        {
            var editor = new frmHexEditorView();
            editor.File = editvar.cr2w;

            if (editvar is IByteSource)
            {
                editor.Bytes = ((IByteSource)editvar).Bytes;
            }

            editor.Text = "Hex Viewer [" + editvar.FullName + "]";
            editor.Show();
        }

        private void openEditorFor(CVariable editvar)
        {
            byte[] bytes = null;

            if(editvar is IByteSource)
            {
                bytes = ((IByteSource)editvar).Bytes;
            }

            if (bytes != null)
            {
                var doc = LoadDocument(editvar.cr2w.FileName + ":" + editvar.FullName, new MemoryStream(bytes), true);
                if (doc != null)
                {
                    doc.OnFileSaved += onVariableEditorSave;
                    doc.SaveTarget = editvar;
                }
                else
                {
                    openHexEditorFor(editvar);
                }
            }
        }

        private void onVariableEditorSave(object sender, FileSavedEventArgs args)
        {
            if (args.Stream is MemoryStream)
            {
                var doc = (frmCR2WDocument)sender;
                var editvar = (CVariable)doc.SaveTarget;
                editvar.SetValue(((MemoryStream)args.Stream).ToArray());
            }
        }

        public string GetLocalizedString(uint val)
        {
            return W3StringManager.GetString(val);
        }
    }
}
