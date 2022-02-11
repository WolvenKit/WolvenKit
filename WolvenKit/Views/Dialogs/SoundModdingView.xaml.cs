using System;
using System.Linq;
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
                this.Bind(ViewModel,
                    vm => vm.SoundEvents,
                    v => v.DataGridEvents.ItemsSource)
                    .DisposeWith(disposables);
            });
        }

        private void ButtonAddAll_Click(object sender, System.Windows.RoutedEventArgs e)
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

        private List<string> _selectedtems = new();
        private void ComboBoxAdv_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            _selectedtems = new List<string>();
            foreach (var item in ComboBoxTags.SelectedItems)
            {
                if (item is string tag)
                {
                    _selectedtems.Add(tag);
                }
            }

            DataGridEvents.View.Filter = FilterRecords;
            DataGridEvents.View.RefreshFilter();
        }

        public bool FilterRecords(object o)
        {
            if (o is SoundEvent item)
            {
                if (_selectedtems.Count == 0)
                {
                    return true;
                }
                if (item.Tags.Any(x => _selectedtems.Contains(x)))
                {
                    return true;
                }
            }
            return false;
        }

        private void ButtonAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            
            var item = DataGridEvents.SelectedItem as SoundEvent;
            var selectedtems = new List<SoundEvent>();
            selectedtems.Add(item);
            ViewModel.SelectedEvents = selectedtems;
            ViewModel.AddCommand.Execute(null);
        }

        private void ButtonDel_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var item = PluginList.SelectedItem as CustomSoundsModel;
            ViewModel.CustomEvents.Remove(item);
        }
    }
}
