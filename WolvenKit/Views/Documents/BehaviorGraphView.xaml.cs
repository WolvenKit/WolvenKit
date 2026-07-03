using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.Views.Documents;

public partial class BehaviorGraphView : UserControl
{
    public BehaviorGraphView()
    {
        InitializeComponent();
        DataContextChanged += OnDataContextChanged;
    }

    private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
        if (e.NewValue is not BehaviorGraphViewModel viewModel)
        {
            return;
        }

        Dispatcher.BeginInvoke(new Action(() =>
        {
            Dispatcher.BeginInvoke(new Action(viewModel.SetGraphLoaded), DispatcherPriority.Background);
        }), DispatcherPriority.Loaded);
    }
}
