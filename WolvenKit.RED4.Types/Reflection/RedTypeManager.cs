using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types
{
    public class RedTypeManager
    {
        public static T Create<T>() where T : RedBaseClass => System.Activator.CreateInstance<T>();

        public static RedBaseClass Create(Type type) => (RedBaseClass)System.Activator.CreateInstance(type);

        public static RedBaseClass Create(string redTypeName)
        {
            var (type, _) = RedReflection.GetCSTypeFromRedType(redTypeName);
            if (type == null)
            {
                throw new TypeNotFoundException(redTypeName);
            }

            return Create(type);
        }

        public static IRedType CreateRedType(Type type, params object[] args) => (IRedType)System.Activator.CreateInstance(type, args);

        public static IRedType CreateRedType(string redTypeName)
        {
            var (type, _) = RedReflection.GetCSTypeFromRedType(redTypeName);
            if (type == null)
            {
                throw new TypeNotFoundException(redTypeName);
            }

            return CreateRedType(type);
        }
    }
}
