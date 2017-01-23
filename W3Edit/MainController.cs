using System.IO;
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
        private BundleManager bundleManager;
        private W3StringManager w3StringManager;

        private MainController()
        {
        }

        public W3StringManager W3StringManager
        {
            get
            {
                if (w3StringManager == null)
                {
                    w3StringManager = new W3StringManager();
                    w3StringManager.Load(Configuration.TextLanguage, Path.GetDirectoryName(Configuration.ExecutablePath));
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
                    bundleManager.LoadAll(Path.GetDirectoryName(Configuration.ExecutablePath));
                }
                return bundleManager;
            }
        }

        public Configuration Configuration { get; private set; }
        public frmMain Window { get; private set; }

        public string GetLocalizedString(uint val)
        {
            return W3StringManager.GetString(val);
        }

        public void CreateVariableEditor(CVariable editvar, EVariableEditorAction action)
        {
            switch (action)
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

        public static MainController Get()
        {
            if (mainController == null)
            {
                mainController = new MainController();
                mainController.Initialize();
            }

            return mainController;
        }

        public void Initialize()
        {
            Configuration = Configuration.Load();

            Window = new frmMain();
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
            W3StringManager.Load(Configuration.TextLanguage, Path.GetDirectoryName(Configuration.ExecutablePath), true);
        }

        private void importBytes(CVariable editvar)
        {
            var dlg = new OpenFileDialog();
            dlg.InitialDirectory = Get().Configuration.InitialExportDirectory;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Get().Configuration.InitialExportDirectory = Path.GetDirectoryName(dlg.FileName);

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
                bytes = ((IByteSource) editvar).Bytes;
            }

            dlg.Filter = string.Join("|", ImportExportUtility.GetPossibleExtensions(bytes));
            dlg.InitialDirectory = Get().Configuration.InitialExportDirectory;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Get().Configuration.InitialExportDirectory = Path.GetDirectoryName(dlg.FileName);

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
                editor.Bytes = ((IByteSource) editvar).Bytes;
            }

            editor.Text = "Hex Viewer [" + editvar.FullName + "]";
            editor.Show();
        }

        private void openEditorFor(CVariable editvar)
        {
            byte[] bytes = null;

            if (editvar is IByteSource)
            {
                bytes = ((IByteSource) editvar).Bytes;
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
                var doc = (frmCR2WDocument) sender;
                var editvar = (CVariable) doc.SaveTarget;
                editvar.SetValue(((MemoryStream) args.Stream).ToArray());
            }
        }
    }
}