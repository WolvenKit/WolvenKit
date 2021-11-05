using System;
using System.ComponentModel;

namespace WolvenKit.Core.Services
{
    public interface IProgressService<T> : IProgress<T>, INotifyPropertyChanged
    {
        public event EventHandler<T> ProgressChanged;

        public bool IsIndeterminate { get; set; }
    }
}
