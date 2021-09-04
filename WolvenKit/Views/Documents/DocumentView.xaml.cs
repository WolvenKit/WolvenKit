using System.Linq;
using System.Windows;
using ReactiveUI;
using Syncfusion.UI.Xaml.Grid;
using WolvenKit.ViewModels.Documents;

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

        private void NavigationItem_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SetCollapsedAll();
            CHUNKSVISIBILITY.SetCurrentValue(VisibilityProperty, Visibility.Visible);

        }

        private void NavigationItem_MouseLeftButtonDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SetCollapsedAll();
            IMPORTSVISISBILITY.SetCurrentValue(VisibilityProperty, Visibility.Visible);
        }

        private void NavigationItem_MouseLeftButtonDown_2(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SetCollapsedAll();
            BUFFERSVISIBILITY.SetCurrentValue(VisibilityProperty, Visibility.Visible);
        }

        private void SetCollapsedAll()
        {
            CHUNKSVISIBILITY.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
            BUFFERSVISIBILITY.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
            IMPORTSVISISBILITY.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
            //EDITORSVISIBILITY.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);

        }

        //        private void NavigationItem_MouseLeftButtonDown_3(object sender, System.Windows.Input.MouseButtonEventArgs e)
        //        {
        //            SetCollapsedAll();
        //            //EDITORSVISIBILITY.SetCurrentValue(VisibilityProperty, Visibility.Visible);
        //        }

        //        private void PropertyGrid_AutoGeneratingPropertyGridItem(object sender, Syncfusion.Windows.PropertyGrid.AutoGeneratingPropertyGridItemEventArgs e)
        //        {
        //            switch (e.DisplayName)
        //            {
        //                case nameof(IEditableVariable.accessor):
        //                case nameof(IEditableVariable.ChildrEditableVariables):
        //                case nameof(IEditableVariable.Cr2wFile):
        //                case nameof(IEditableVariable.IsSerialized):
        //                case nameof(IEditableVariable.ParentVar):
        //                case nameof(IEditableVariable.REDFlags):
        //                case nameof(IEditableVariable.REDName):
        //                case nameof(IEditableVariable.REDType):
        //                case nameof(IEditableVariable.REDValue):
        //                case nameof(IEditableVariable.SerializedProperties):
        //                case nameof(IEditableVariable.UniqueIdentifier):
        //                case nameof(IEditableVariable.VarChunkIndex):
        //                case nameof(CVariable.IsNulled):
        //                case nameof(CVariable.cr2w):
        //                case nameof(CVariable.UnknownCVariables):
        //#if DEBUG
        //                case nameof(CVariable.GottenVarChunkIndex):
        //#endif
        //                    e.Cancel = true;
        //                    break;
        //            }
        //        }
        private void TreeView_OnSelectionChanged(object sender, GridSelectionChangedEventArgs e)
        {
            if (DataContext is not RedDocumentViewModel vm)
            {
                return;
            }

            if (!e.AddedItems.Any())
            {
                return;
            }


        }
    }
}
