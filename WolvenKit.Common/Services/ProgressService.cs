// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


// Modified by rfuzzo


using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using WolvenKit.Core.Services;

namespace System
{
    /// <summary>
    /// Provides an IProgress{T} that invokes callbacks for each reported progress value.
    /// </summary>
    /// <typeparam name="T">Specifies the type of the progress report value.</typeparam>
    /// <remarks>
    /// Any handler provided to the constructor or event handlers registered with
    /// the <see cref="ProgressChanged"/> event are invoked through a
    /// <see cref="System.Threading.SynchronizationContext"/> instance captured
    /// when the instance is constructed.  If there is no current SynchronizationContext
    /// at the time of construction, the callbacks will be invoked on the ThreadPool.
    /// </remarks>
    public class ProgressService<T> : IProgressService<T>
    {
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.


        /// <summary>The synchronization context captured upon construction.  This will never be null.</summary>
        private readonly SynchronizationContext _synchronizationContext;
        /// <summary>The handler specified to the constructor.  This may be null.</summary>
        private readonly Action<T>? _handler;
        /// <summary>A cached delegate used to post invocation to the synchronization context.</summary>
        private readonly SendOrPostCallback _invokeHandlers;

        /// <summary>Initializes the <see cref="Progress{T}"/>.</summary>
        public ProgressService()
        {
            // Capture the current synchronization context.
            // If there is no current context, we use a default instance targeting the ThreadPool.
            _synchronizationContext = SynchronizationContext.Current ?? ProgressStatics.DefaultContext;
            Debug.Assert(_synchronizationContext != null);
            _invokeHandlers = new SendOrPostCallback(InvokeHandlers);
        }

        /// <summary>Initializes the <see cref="Progress{T}"/> with the specified callback.</summary>
        /// <param name="handler">
        /// A handler to invoke for each reported progress value.  This handler will be invoked
        /// in addition to any delegates registered with the <see cref="ProgressChanged"/> event.
        /// Depending on the <see cref="System.Threading.SynchronizationContext"/> instance captured by
        /// the <see cref="Progress{T}"/> at construction, it's possible that this handler instance
        /// could be invoked concurrently with itself.
        /// </param>
        /// <exception cref="System.ArgumentNullException">The <paramref name="handler"/> is null (Nothing in Visual Basic).</exception>
        public ProgressService(Action<T> handler) : this() => _handler = handler ?? throw new ArgumentNullException(nameof(handler));

        /// <summary>Raised for each reported progress value.</summary>
        /// <remarks>
        /// Handlers registered with this event will be invoked on the
        /// <see cref="System.Threading.SynchronizationContext"/> captured when the instance was constructed.
        /// </remarks>
        public event EventHandler<T>? ProgressChanged;

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        /// <summary>Reports a progress change.</summary>
        /// <param name="value">The value of the updated progress.</param>
        protected virtual void OnReport(T value)
        {
            // If there's no handler, don't bother going through the sync context.
            // Inside the callback, we'll need to check again, in case
            // an event handler is removed between now and then.
            var handler = _handler;
            var changedEvent = ProgressChanged;
            if (handler != null || changedEvent != null)
            {
                if (value is double dbl)
                {
                    Status = dbl < 1.0 ? EStatus.Running : EStatus.Ready;
                }

                // Post the processing to the sync context.
                // (If T is a value type, it will get boxed here.)
                _synchronizationContext.Post(_invokeHandlers, value);
            }
        }

        /// <summary>Reports a progress change.</summary>
        /// <param name="value">The value of the updated progress.</param>
        void IProgress<T>.Report(T value) => OnReport(value);

        /// <summary>Invokes the action and event callbacks.</summary>
        /// <param name="state">The progress value.</param>
        private void InvokeHandlers(object? state)
        {
            var value = (T)state!;

            var handler = _handler;
            var changedEvent = ProgressChanged;

            handler?.Invoke(value);
            changedEvent?.Invoke(this, value);
        }

        public void Completed()
        {
            if (typeof(T) == typeof(double) && 1.0 is T tt)
            {
                OnReport(tt);
            }

            IsIndeterminate = false;
            Status = EStatus.Ready;
        }

        private bool _isIndeterminate;
        public bool IsIndeterminate
        {
            get => _isIndeterminate;

            set
            {
                if (value != _isIndeterminate)
                {
                    _isIndeterminate = value;
                    Status = _isIndeterminate ? EStatus.Running : EStatus.Ready;
                    NotifyPropertyChanged();
                }
            }
        }

        private EStatus _status;
        public EStatus Status
        {
            get => _status;

            set
            {
                if (value != _status)
                {
                    _status = value;
                    NotifyPropertyChanged();
                }
            }
        }

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

    }

    /// <summary>Holds static values for <see cref="Progress{T}"/>.</summary>
    /// <remarks>This avoids one static instance per type T.</remarks>
    internal static class ProgressStatics
    {
        /// <summary>A default synchronization context that targets the ThreadPool.</summary>
        internal static readonly SynchronizationContext DefaultContext = new();
    }

}


