using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Core;

namespace WolvenKit.Views.Templates
{

    public partial class LocalizationStringPopup : Window
    {

        public LocalizationStringPopup()
        {
            InitializeComponent();

            ViewModel = new LocalizationStringViewModel();
            DataContext = ViewModel;
        }

        public LocalizationStringViewModel ViewModel { get; set; }


        /// <summary>
        /// Close dialogue on enter or escape
        /// </summary>
        private void Wizard_OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Escape:
                    DialogResult = false;
                    e.Handled = true;
                    Close();
                    break;
                case Key.Enter when ViewModel.IsValid:
                    DialogResult = true;
                    e.Handled = true;
                    Close();
                    break;
                default:
                    break;
            }
        }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            return ShowDialog();
        }

        private void OnHelpClicked(object sender, RoutedEventArgs e) =>
            Process.Start(new ProcessStartInfo { FileName = WikiLinks.JsonFiles, UseShellExecute = true });
    }
}
