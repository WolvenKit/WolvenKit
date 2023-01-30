using ReactiveUI;
using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedTypeView.xaml
    /// </summary>
    public partial class RedTypeView : ReactiveUserControl<ChunkViewModel>
    {
        public RedTypeView()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                if (DataContext is ChunkViewModel vm)
                {
                    SetCurrentValue(ViewModelProperty, vm);
                }
            });
        }
    }
}
