using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ReactiveUI;
using WolvenKit.ViewModels.Tools;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using HandyControl.Data;
using Splat;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.ScrollAxis;
using Syncfusion.UI.Xaml.TreeGrid;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Services;
using WolvenKit.Interaction;
using WolvenKit.Models;
using WolvenKit.ProjectManagement.Project;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.Views.Dialogs;

namespace WolvenKit.Views.Tools
{
    /// <summary>
    /// Interaction logic for TweakBrowserView.xaml
    /// </summary>
    public partial class TweakBrowserView : ReactiveUserControl<TweakBrowserViewModel>
    {
        public TweakBrowserView()
        {
            InitializeComponent();
            //this.WhenActivated(disposables =>
            //{
            //    this.OneWayBind(ViewModel,
            //            viewModel => viewModel.SelectedRecord,
            //            view => view.redTreeView.ItemsSource)
            //        .DisposeWith(disposables);
            //});
        }
        private void TextBox_KeyEnterUpdate(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBox tBox = (TextBox)sender;
                DependencyProperty prop = TextBox.TextProperty;

                BindingExpression binding = BindingOperations.GetBindingExpression(tBox, prop);
                if (binding != null)
                { binding.UpdateSource(); }
            }
        }
    }
}
