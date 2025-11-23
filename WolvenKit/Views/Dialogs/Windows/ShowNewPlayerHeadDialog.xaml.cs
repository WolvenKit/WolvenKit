using System.Windows;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.App;
using WolvenKit.App.ViewModels.Dialogs;
using Window = System.Windows.Window;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class ShowNewPlayerHeadDialog : IViewFor<PlayerHeadDialogViewModel>
    {
        public ShowNewPlayerHeadDialog()
        {
            InitializeComponent();

            ViewModel = new PlayerHeadDialogViewModel();
            DataContext = ViewModel;
            Owner = Application.Current.MainWindow;
        }

        public PlayerHeadDialogViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (PlayerHeadDialogViewModel)value; }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            return ShowDialog();
        }

        private void CloseDialogue(bool result)
        {
            DialogResult = result;
            Close();
        }


        private void ShowNewPlayerHeadDialogView_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key is not (Key.Escape or Key.Enter))
            {
                return;
            }

            e.Handled = true;
            CloseDialogue(e.Key == Key.Enter);
        }

        private void BodyGenderFemale(object sender, RoutedEventArgs e) =>
            ViewModel?.SetBodyGender(PhotomodeBodyGender.Female);

        private void BodyGenderMale(object sender, RoutedEventArgs e) =>
            ViewModel?.SetBodyGender(PhotomodeBodyGender.Male);
    }
}
