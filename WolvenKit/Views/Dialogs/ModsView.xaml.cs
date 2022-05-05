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
    public partial class ModsView : ReactiveUserControl<ModsViewModel>
    {
        public ModsView()
        {
            InitializeComponent();
        }
    }
}
