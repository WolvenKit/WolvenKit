using System;

namespace WolvenKit.Core.Services
{
    public interface IProgressService<T> : IProgress<T>
    {
        public event EventHandler<T> ProgressChanged;


    }
}
