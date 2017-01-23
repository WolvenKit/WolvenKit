using System.IO;
using System.Windows.Forms;
using BrightIdeasSoftware;
using W3Edit.CR2W;
using WeifenLuo.WinFormsUI.Docking;

namespace W3Edit
{
    public partial class frmEmbeddedFiles : DockContent
    {
        private CR2WFile file;

        public frmEmbeddedFiles()
        {
            InitializeComponent();

            listView.ItemSelectionChanged += chunkListView_ItemSelectionChanged;
        }

        public CR2WFile File
        {
            get { return file; }
            set
            {
                file = value;
                updateList();
            }
        }

        private void chunkListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
        }

        private void updateList()
        {
            if (File == null)
                return;

            listView.Objects = File.block7;
        }

        private void listView_CellClick(object sender, CellClickEventArgs e)
        {
            if (e.Column == null || e.Item == null)
                return;

            if (e.ClickCount == 2)
            {
                var mem = new MemoryStream(((CR2WHeaderBlock7) e.Model).unknowndata);

                var doc = MainController.Get().LoadDocument("Embedded file", mem);
                if (doc != null)
                {
                    doc.OnFileSaved += OnFileSaved;
                    doc.SaveTarget = (CR2WHeaderBlock7) e.Model;
                }
            }
        }

        private void OnFileSaved(object sender, FileSavedEventArgs e)
        {
            var doc = (frmCR2WDocument) sender;
            var editvar = (CR2WHeaderBlock7) doc.SaveTarget;
            editvar.unknowndata = ((MemoryStream) e.Stream).ToArray();
        }
    }
}