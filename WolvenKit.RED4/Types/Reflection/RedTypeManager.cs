using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types;

public class RedTypeManager
{
    public static RedBaseClass Create(Type type)
    {
        if (System.Activator.CreateInstance(type) is not RedBaseClass result)
        {
            throw new Exception();
        }

        return result;
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
        if (System.Activator.CreateInstance(type, args) is not IRedType result)
        {
            throw new Exception();
        }

        return result;
    }

    public static IRedType CreateRedType(string redTypeName, params object[] args)
    {
        var (type, _) = RedReflection.GetCSTypeFromRedType(redTypeName);
        if (type == null)
        {
            throw new TypeNotFoundException(redTypeName);
        }

        return CreateRedType(type, args);
    }
}