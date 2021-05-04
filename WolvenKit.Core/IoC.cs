using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;

namespace WolvenKit.Common
{
    public static class WolvenServiceLocator
    {
        public static class Default
        {
            public static T ResolveType<T>() => ServiceLocator.Default.ResolveType<T>();
        }
    }
}
