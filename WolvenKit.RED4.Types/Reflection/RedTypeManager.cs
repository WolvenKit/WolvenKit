using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types
{
    public class RedTypeManager
    {
        public static readonly ConcurrentDictionary<string, byte> UnknownClassList = new();
        public static readonly ConcurrentDictionary<IRedClass, byte> ClassReferences = new();

        public static IRedClass Create(Type type)
        {
            var instance = (IRedClass)System.Activator.CreateInstance(type);
            if (instance is IRedOverload tCls)
            {
                tCls.ConstructorOverload();
            }

            return instance;
        }

        public static IRedClass Create(string redTypeName)
        {
            var (type, _) = RedReflection.GetCSTypeFromRedType(redTypeName);
            if (type == null)
            {
                throw new TypeNotFoundException(redTypeName);
            }

            var instance = Create(type);
            if (instance.GetType() == typeof(RedBaseClass))
            {
                ((RedBaseClass)instance).RedTypeName = redTypeName;
            }

            return instance;
        }
    }
}
