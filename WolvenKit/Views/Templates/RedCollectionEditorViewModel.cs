using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using WinCopies.Util;
using WolvenKit.Common;
using WolvenKit.Common.Annotations;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.Views.Templates
{
    internal class RedCollectionEditorViewModel : INotifyPropertyChanged
    {
        private object _selectedElement;

        public RedCollectionEditorViewModel()
        {


        }

        #region properties

        public event PropertyChangedEventHandler PropertyChanged;




        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public IList Elements { get; set; }

        public object SelectedElement
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


        internal void SetElements(IREDArray redarray)
        {
            Elements = redarray;
            OnPropertyChanged(nameof(Elements));
        }



        #endregion



    }
}
