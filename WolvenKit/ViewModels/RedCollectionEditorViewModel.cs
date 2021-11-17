using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using WinCopies.Util;
using WolvenKit.Common;
using WolvenKit.Common.Annotations;
using WolvenKit.Functionality.Commands;
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

    internal class RedCollectionEditorViewModel : INotifyPropertyChanged
    {
        private RedCollectionItemViewModel _selectedElement;
        //private IEditableVariable _selectedElement;

        private IRedArray _redArray;

        public RedCollectionEditorViewModel()
        {
            AddElementCommand = new RelayCommand(AddElement);

            RemoveElementCommand = new RelayCommand(RemoveElement);
        }

        #region properties

        public ICommand AddElementCommand { get; private set; }

        public ICommand RemoveElementCommand { get; private set; }

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

        internal void SetElements(IRedArray redarray)
        {
            _redArray = redarray;

            Elements.Clear();

            throw new WolvenKit.RED4.Types.Exceptions.TodoException("RedArray");

            //foreach (var item in _redArray)
            //{
            //    if (item is IRedType editableVariable)
            //    {
            //        Elements.Add(new RedCollectionItemViewModel(editableVariable));
            //        //Elements.Add(editableVariable);
            //    }
            //}
        }

        private void AddElement()
        {
            throw new WolvenKit.RED4.Types.Exceptions.TodoException("RedArray");

            //var count = _redArray.Count;
            //var element = _redArray.GetElementInstance(count.ToString());
            //if (element != null)
            //{
            //    if (_redArray.CanAddVariable(element))
            //    {
            //        _redArray.AddVariable(element);

            //        Elements.Clear();
            //        foreach (var item in _redArray)
            //        {
            //            if (item is IRedType editableVariable)
            //            {
            //                Elements.Add(new RedCollectionItemViewModel(editableVariable));
            //                //Elements.Add(editableVariable);
            //            }
            //        }
            //    }
            //}
        }

        private void RemoveElement()
        {
            throw new WolvenKit.RED4.Types.Exceptions.TodoException("RedArray");

            //if (SelectedElement != null && SelectedElement.Element is IRedType variable)
            ////if (SelectedElement != null && SelectedElement is IEditableVariable variable)
            //{
            //    if (_redArray.CanRemoveVariable(variable) && _redArray.RemoveVariable(variable))
            //    {
            //        Elements.Clear();
            //        foreach (var item in _redArray)
            //        {
            //            if (item is IRedType editableVariable)
            //            {
            //                Elements.Add(new RedCollectionItemViewModel(editableVariable));
            //                //Elements.Add(editableVariable);
            //            }
            //        }
            //    }
            //}
        }

        #endregion
    }
}
