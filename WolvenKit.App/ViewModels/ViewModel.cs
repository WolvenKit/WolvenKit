using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using WolvenKit.Common;
//using Ninject;
//using Ninject.Activation;
//using Ninject.Syntax;

namespace WolvenKit.App.ViewModels
{
    /// <summary>
    /// Base abstract class for all viewmodels.
    /// </summary>
    public abstract class ViewModel : ObservableObject, IViewModel
    {
        public ViewModel()
        {
            
        }

        public virtual void Initialize()
        {
            
        }
    }
}