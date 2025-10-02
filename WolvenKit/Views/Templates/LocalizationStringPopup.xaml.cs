using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace WolvenKit.Views.Templates
{
    public class LocalizationStringViewModel : INotifyPropertyChanged
    {
        private string _femaleVariant = "";
        private string _maleVariant = "";
        private string _secondaryKey = "";

        public string FemaleVariant
        {
            get => _femaleVariant;
            set
            {
                if (_femaleVariant != value)
                {
                    _femaleVariant = value;
                    OnPropertyChanged();
                }
            }
        }

        public string MaleVariant
        {
            get => _maleVariant;
            set
            {
                if (_maleVariant != value)
                {
                    _maleVariant = value;
                    OnPropertyChanged();
                }
            }
        }

        public string SecondaryKey
        {
            get => _secondaryKey;
            set
            {
                if (_secondaryKey != value)
                {
                    _secondaryKey = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public partial class LocalizationStringPopup : Window
    {
        private readonly LocalizationStringViewModel _viewModel;

        public LocalizationStringPopup()
        {
            InitializeComponent();
            Owner = Application.Current.MainWindow;
            
            _viewModel = new LocalizationStringViewModel();
            DataContext = _viewModel;
        }

        public string FemaleVariant
        {
            get => _viewModel.FemaleVariant;
            set => _viewModel.FemaleVariant = value;
        }

        public string MaleVariant
        {
            get => _viewModel.MaleVariant;
            set => _viewModel.MaleVariant = value;
        }

        public string SecondaryKey
        {
            get => _viewModel.SecondaryKey;
            set => _viewModel.SecondaryKey = value;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
