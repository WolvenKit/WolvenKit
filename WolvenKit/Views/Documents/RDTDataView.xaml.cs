using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using Microsoft.Extensions.Options;
using ReactiveUI;
using Splat;
using WolvenKit.App;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Events;
using WolvenKit.Views.Editors;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Tree view for RDTData
    /// Interaction logic for RDTDataView.xaml
    /// </summary>
    public partial class RDTDataView : ReactiveUserControl<RDTDataViewModel>
    {
        public RDTDataView()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                //    var globals = Locator.Current.GetService<IOptions<Globals>>();
                //    if (globals.Value.ENABLE_NODE_EDITOR)
                //    {
                //        AutomaticNodifyEditor.LayoutNodes();
                //    }


                // ValueChanged="RedTypeView_OnValueChanged"
                //Observable.FromEventPattern<EventHandler, EventArgs>(
                //  handler => CustomPG.ValueChanged += handler,
                //  handler => CustomPG.ValueChanged -= handler)
                //    .Subscribe(e => RedTypeView_OnValueChanged(e.Sender, e.EventArgs))
                //    .DisposeWith(disposables);
            });
        }

        //private void AutolayoutNodes_MenuItem(object sender, RoutedEventArgs e) => AutomaticNodifyEditor.LayoutNodes();

        private void RedTypeView_OnValueChanged(object sender, EventArgs e)
        {
            if (sender is not RedCNameEditor || e is not ValueChangedEventArgs args)
            {
                return;
            }

            ViewModel?.OnCNameValueChanged(args);
        }
    }
}
