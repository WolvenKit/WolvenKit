using System;
using System.Collections.Generic;
using System.IO;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Newtonsoft.Json;
using ReactiveUI;
using Syncfusion.UI.Xaml.TreeView;
using WolvenKit.Common.Conversion;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Documents;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaction logic for RDTGraphView.xaml
    /// </summary>
    public partial class RDTGraphView : ReactiveUserControl<RDTGraphViewModel>
    {
        public RDTGraphView()
        {
            InitializeComponent();
        }
    }
}
