using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.ViewModels.Documents;
using WolvenKit.Views.Editors;
using WolvenKit.Views.Templates;

namespace WolvenKit.Views.Documents
{
    public partial class DocumentView : ReactiveUserControl<RedDocumentViewModel>
    {
        #region Constructors

        public DocumentView()
        {

            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                if (DataContext is RedDocumentViewModel vm)
                {
                    SetCurrentValue(ViewModelProperty, vm);
                }
            });
        }

        #endregion Constructors

        private void SetCollapsedAll()
        {
            //CHUNKSVISIBILITY.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
            //IMPORTSVISISBILITY.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);

        }

        private void HandleTemplateView_OnGoToChunkRequested(object sender, GoToChunkRequestedEventArgs e)
        {
            var target = e.Export;

            if (ViewModel == null || target == null)
            {
                return;
            }

            //var chunk = ViewModel.Chunks.FirstOrDefault(x => x.Name.Equals(target.REDName));
            //chunk.IsSelected = true;
            //ViewModel.SelectedChunk = chunk;
        }

        private void CurveEditorButton_OnClick(object sender, RoutedEventArgs e)
        {
            var tag = ((Button)sender).Tag;
            if (tag is ICurveDataAccessor redcurve)
            {
                var curveEditorWindow = new CurveEditorWindow(redcurve);
                var r = curveEditorWindow.ShowDialog();
                if (r ?? true)
                {
                    var c = curveEditorWindow.GetCurve();
                    if (c is not null)
                    {
                        // set tag data
                        redcurve.SetInterpolationType(c.Type);
                        redcurve.SetCurvePoints(c.Points);
                    }
                }
            }
        }

        private void ChunksButton_OnClick(object sender, RoutedEventArgs e)
        {
            SetCollapsedAll();
            //CHUNKSVISIBILITY.SetCurrentValue(VisibilityProperty, Visibility.Visible);
        }

        private void ImportsButton_OnClick(object sender, RoutedEventArgs e)
        {
            SetCollapsedAll();
            //IMPORTSVISISBILITY.SetCurrentValue(VisibilityProperty, Visibility.Visible);
        }
    }
}
