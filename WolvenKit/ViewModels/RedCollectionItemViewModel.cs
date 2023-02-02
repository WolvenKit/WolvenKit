using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.Common;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels
{
    internal class RedCollectionItemViewModel : ObservableObject
    {
        private object _element;

        public RedCollectionItemViewModel(object element)
        {
            _element = element;
        }

        public object Element
        {
            get => _element;
            set
            {
                if (value == _element)
                {
                    return;
                }

                _element = value;
                OnPropertyChanged();
            }
        }

        public override string ToString() => _element is IRedType variable
                ? $"[{variable.GetType().Name}] {variable.ToString()}"
                : _element.ToString();
    }
}
