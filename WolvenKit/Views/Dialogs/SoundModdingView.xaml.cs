using System.Collections.Generic;
using System.Reactive.Disposables;
using ReactiveUI;
using WolvenKit.Modkit.RED4.Sounds;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs
{
    /// <summary>
    /// Interaction logic for NewFileView.xaml
    /// </summary>
    public partial class SoundModdingView : ReactiveUserControl<SoundModdingViewModel>
    {
        public SoundModdingView()
        {
            InitializeComponent();


            this.WhenActivated(disposables =>
            {
                //this.Bind(ViewModel,
                //    vm => vm.Plugins,
                //    v => v.PluginList.ItemsSource)
                //    .DisposeWith(disposables);
                
            });

        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var selectedtems = new List<SoundEvent>();
            foreach (var item in DataGridEvents.SelectedItems)
            {
                if (item is SoundEvent soundEvent)
                {
                    selectedtems.Add(soundEvent);
                }
            }

            ViewModel.SelectedEvents = selectedtems;
            ViewModel.AddCommand.Execute(null);
        }
    }
}
