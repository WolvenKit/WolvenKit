using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Types
{
    public class RedTypeManager
    {
        public static IRedClass Create(string redTypeName)
        {
            var type = RedReflection.GetType(redTypeName);
            if (type == null)
            {
                throw new TypeNotFoundException(redTypeName);
            }

            return (IRedClass)System.Activator.CreateInstance(type);
        }
    }
}
