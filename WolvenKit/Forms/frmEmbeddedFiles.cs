using System.IO;
using BrightIdeasSoftware;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.CR2W;
using WolvenKit.Services;
using System.Linq;
using WolvenKit.App.Model;
using System.Windows.Controls;
using WolvenKit.App.ViewModels;

namespace WolvenKit
{
    public partial class frmEmbeddedFiles : DockContent, IThemedContent
    {
        private CR2WFile file;

        public frmEmbeddedFiles()
        {
            InitializeComponent();
            ApplyCustomTheme();
            UpdateList();
        }

        public CR2WFile File
        {
            get { return file; }
            set
            {
                file = value;
                UpdateList();
            }
        }

        private void UpdateList()
        {
            if (File == null)
                return;

            listView.Objects = File.embedded;
        }

        private void listView_CellClick(object sender, CellClickEventArgs e)
        {
            if (e.Column == null || e.Item == null)
                return;

            if (e.ClickCount == 2)
            {
                var mem = new MemoryStream(((CR2WEmbeddedWrapper) e.Model).Data);

                var doc = UIController.Get().LoadDocument("Embedded file", mem);
                if (doc != null)
                {
                    var vm = doc.GetViewModel();
                    vm.OnFileSaved += OnFileSaved;
                    vm.SaveTarget = (CR2WEmbeddedWrapper) e.Model;
                }
            }
        }

        private void OnFileSaved(object sender, FileSavedEventArgs e)
        {
            var vm = (DocumentViewModel) sender;
            var editvar = (CR2WEmbeddedWrapper) vm.SaveTarget;
            editvar.Data = ((MemoryStream) e.Stream).ToArray();
        }

        public void ApplyCustomTheme()
        {
            this.listView.BackColor = UIController.GetBackColor();
            this.listView.AlternateRowBackColor = UIController.GetPalette().OverflowButtonHovered.Background;

            this.listView.ForeColor = UIController.GetForeColor();

            this.listView.HeaderFormatStyle = UIController.GetHeaderFormatStyle();
            listView.UnfocusedSelectedBackColor = UIController.GetPalette().CommandBarToolbarButtonPressed.Background;
        }
    }
}