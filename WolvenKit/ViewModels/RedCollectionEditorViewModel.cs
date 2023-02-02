using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.Common.Annotations;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels
{
    internal partial class RedCollectionEditorViewModel : INotifyPropertyChanged
    {
        private RedCollectionItemViewModel _selectedElement;
        //private IEditableVariable _selectedElement;

        private IRedArray _redArray;

        #region properties

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public ObservableCollection<RedCollectionItemViewModel> Elements { get; set; } = new();
        //public ObservableCollection<IEditableVariable> Elements { get; set; } = new();

        public RedCollectionItemViewModel SelectedElement
        //public IEditableVariable SelectedElement
        {
            get => _selectedElement;
            set
            {
                if (value == _selectedElement)
                {
                    return;
                }

                _selectedElement = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region methods

        private Type _innerType;

        public void SetElements<T>(IRedArray redarray) where T : IRedType
        {
            _redArray = redarray;
            _innerType = typeof(T);

            Elements.Clear();

            var array = redarray as CArray<T>;

            foreach (var item in array)
            {
                if (item is IRedType editableVariable)
                {
                    Elements.Add(new RedCollectionItemViewModel(editableVariable));
                    //Elements.Add(editableVariable);
                }
            }
        }

        [RelayCommand]
        private void AddElement()
        {
            var method = typeof(RedCollectionEditorViewModel)
                    .GetMethod(nameof(AddElement));
            var generic = method.MakeGenericMethod(_innerType);

            generic.Invoke(this, new object[] { });
        }

        public void AddElement<T>() where T : IRedType
        {
            var array = _redArray as CArray<T>;

            var instance = RedTypeManager.Create(_innerType);
            if (instance is T element)
            {
                array.Add(element);

                Elements.Clear();
                foreach (var item in array)
                {
                    if (item is IRedType editableVariable)
                    {
                        Elements.Add(new RedCollectionItemViewModel(editableVariable));
                        //Elements.Add(editableVariable);
                    }
                }
            }

        }

        [RelayCommand]
        private void RemoveElement()
        {
            var method = typeof(RedCollectionEditorViewModel)
                    .GetMethod(nameof(RemoveElement));
            var generic = method.MakeGenericMethod(_innerType);

            generic.Invoke(this, new object[] { });
        }

        public void RemoveElement<T>() where T : IRedType
        {
            if (SelectedElement != null && SelectedElement.Element is IRedType variable && variable is T tvar)
            //if (SelectedElement != null && SelectedElement is IEditableVariable variable)
            {
                var array = _redArray as CArray<T>;

                array.Remove(tvar);

                Elements.Clear();
                foreach (var item in array)
                {
                    if (item is IRedType editableVariable)
                    {
                        Elements.Add(new RedCollectionItemViewModel(editableVariable));
                        //Elements.Add(editableVariable);
                    }
                }
            }
        }

        #endregion
    }
}
