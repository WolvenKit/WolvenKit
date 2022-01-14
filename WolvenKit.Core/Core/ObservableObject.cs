using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WolvenKit.Common
{
    /// <summary>
    /// Represents an abstract object that provides notifications when properties are changed or are changing.
    /// Implements <see cref="INotifyPropertyChanged"/> and <see cref="INotifyPropertyChanging"/>
    /// </summary>
    [Serializable]
    public abstract class ObservableObject : INotifyPropertyChanged, INotifyPropertyChanging
    {
        #region NotifyPropertyChanged

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invoke the PropertyChanged event using the caller property name with <see cref="CallerMemberNameAttribute"/>.
        /// </summary>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        #endregion NotifyPropertyChanged

        #region NotifyPropertyChanging

        public event PropertyChangingEventHandler PropertyChanging;

        /// <summary>
        /// Invoke the PropertyChanging event using the caller property name with <see cref="CallerMemberNameAttribute"/>.
        /// </summary>
        /// <param name="propertyName">The name of the property that is changing.</param>
        protected virtual void OnPropertyChanging([CallerMemberName] string propertyName = null) => PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));

        #endregion NotifyPropertyChanging

        #region Explicit Methods

        // Not a fan of this style
        protected virtual bool ChangeProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return false;
            }
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion Explicit Methods
    }
}
