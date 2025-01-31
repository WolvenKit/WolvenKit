using System;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Disposables;
using System.Windows;
using Microsoft.Extensions.Options;
using ReactiveUI;
using Splat;
using WolvenKit.App;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Events;
using WolvenKit.Views.Editors;
using WolvenKit.Views.Tools;

#nullable enable

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
                var globals = Locator.Current.GetService<IOptions<Globals>>();
                if (globals?.Value?.ENABLE_NODE_EDITOR == true)
                {
                    Editor.LayoutNodes();
                }

                RedTreeView.PropertyChanged += RedTreeView_OnPropertyChanged;
            });
        }

        /// <summary>
        /// We need to sync our view model's selection with the tree. For some reason,
        /// that doesn't happen automatically anymore.
        /// </summary>
        private void RedTreeView_OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (sender is not RedTreeView tree || e.PropertyName is not nameof(RedTreeView.SelectedItems) ||
                ViewModel is null)
            {
                return;
            }

            ViewModel.SelectedChunks ??= [];
            ViewModel.SelectedChunks.Clear();
            ViewModel.SelectedChunks.AddRange(tree.SelectedItems.ToList());
        }

        private void AutolayoutNodes_MenuItem(object sender, RoutedEventArgs e) => Editor.LayoutNodes();

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
