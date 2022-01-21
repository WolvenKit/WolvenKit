using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types
{
    public class RedTypeManager
    {
        public static T Create<T>() where T : RedBaseClass
        {
            var instance = (RedBaseClass)System.Activator.CreateInstance<T>();
            if (instance is IRedOverload tCls)
            {
                tCls.ConstructorOverload();
            }

            instance?.InternalInitClass();

            return (T)instance;
        }

        public static RedBaseClass Create(Type type)
        {
            var instance = (RedBaseClass)System.Activator.CreateInstance(type);
            if (instance is IRedOverload tCls)
            {
                tCls.ConstructorOverload();
            }

            instance?.InternalInitClass();

            return instance;
        }

        public static RedBaseClass Create(string redTypeName)
        {
            var (type, _) = RedReflection.GetCSTypeFromRedType(redTypeName);
            if (type == null)
            {
                throw new TypeNotFoundException(redTypeName);
            }

            return Create(type);
        }

        public static IRedType CreateRedType(Type type, params object[] args)
        {
            var instance = (IRedType)System.Activator.CreateInstance(type, args);
            if (instance is IRedOverload tCls)
            {
                tCls.ConstructorOverload();
            }

            if (instance is RedBaseClass irc)
            {
                irc.InternalInitClass();
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
