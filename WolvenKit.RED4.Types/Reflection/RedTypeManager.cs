using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types
{
    public class RedTypeManager
    {

        public static IRedClass Create(Type type)
        {
            var instance = (IRedClass)System.Activator.CreateInstance(type);
            if (instance is IRedOverload tCls)
            {
                tCls.ConstructorOverload();
            }

            instance?.InternalInitClass();

            return instance;
        }

        public static IRedClass Create(string redTypeName)
        {
            var (type, _) = RedReflection.GetCSTypeFromRedType(redTypeName);
            if (type == null)
            {
                throw new TypeNotFoundException(redTypeName);
            }

            return Create(type);
        }

        public static IRedType CreateRedType(Type type)
        {
            var instance = (IRedType)System.Activator.CreateInstance(type);
            if (instance is IRedOverload tCls)
            {
                tCls.ConstructorOverload();
            }

            return instance;
        }

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
