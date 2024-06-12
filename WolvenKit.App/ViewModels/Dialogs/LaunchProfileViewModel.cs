using System.ComponentModel;
using System.Runtime.CompilerServices;
using WolvenKit.App.Models;

namespace WolvenKit.App.ViewModels.Dialogs
{
    public class LaunchProfileViewModel : INotifyPropertyChanged
    {
        public LaunchProfileViewModel(string name, LaunchProfile profile)
        {
            _profile = profile;
            Name = name;

            profile.PropertyChanged += OnProfilePropertyChanged;
        }


        public string Name { get; set; }

        private LaunchProfile _profile;

        public LaunchProfile Profile
        {
            get => _profile;
            set
            {
                if (_profile == value)
                {
                    return;
                }

                _profile = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        private void OnProfilePropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName is not nameof(LaunchProfile.LoadSpecificSave))
            {
                return;
            }

            PropertyChanged?.Invoke(sender, e);
        }
    }
}