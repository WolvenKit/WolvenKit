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
using Catel;
using Catel.IoC;
using Catel.MVVM.Views;
using Catel.Services;
using Feather.Controls;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Editor.Tools;

namespace WolvenKit.Controls
{
    /// <summary>
    /// Interaction logic for AddPathDialogView.xaml
    /// </summary>
    public partial class AddPathDialogView
    {
        public AddPathDialogView()
        {
            InitializeComponent();
        }

        [ViewToViewModel(MappingType = ViewToViewModelMappingType.TwoWayViewWins)]
        public string Path
        {
            get { return (string)GetValue(PathProperty); }
            set { SetValue(PathProperty, value); }
        }

        public static readonly DependencyProperty PathProperty =
            DependencyProperty.Register(nameof(Path), typeof(string), typeof(AddPathDialogView));

        private HandyControl.Data.OperationResult<bool> VerifyFile(string str)
        {
            if (System.IO.File.Exists(str))
            {
                notification.IsOpen = false;
                return HandyControl.Data.OperationResult.Success();
            }
            else
            {
                return HandyControl.Data.OperationResult.Failed();
            }
        }
    }
}
