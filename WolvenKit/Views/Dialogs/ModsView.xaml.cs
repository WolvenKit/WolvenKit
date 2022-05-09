using System.Linq;
using ReactiveUI;
using Syncfusion.UI.Xaml.Grid;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs
{
    /// <summary>
    /// Interaction logic for NewFileView.xaml
    /// </summary>
    public partial class ModsView : ReactiveUserControl<ModsViewModel>
    {
        public ModsView()
        {
            InitializeComponent();

            DataGridEvents.RowDragDropController.Dropped += RowDragDropController_Dropped;
        }

        private void RowDragDropController_Dropped(object sender, GridRowDroppedEventArgs e)
        {
            if (e.IsFromOutSideSource)
            {
                // install mod



            }
            else
            {
                // adjust load order
                var records = DataGridEvents.View.Records.ToList();
                for (var i = 0; i < records.Count; i++)
                {
                    var r = records[i];
                    var idx = GridIndexResolver.ResolveToRowIndex(DataGridEvents, r) - 1;
                    if (r.Data is ModInfoViewModel m)
                    {
                        m.LoadOrder = idx;
                    }
                }
            }
        }

        private void RowDragDropController_Drop(object sender, GridRowDropEventArgs e)
        {

        }

        private void DataGridEvents_Drop(object sender, System.Windows.DragEventArgs e)
        {

        }
    }
}
