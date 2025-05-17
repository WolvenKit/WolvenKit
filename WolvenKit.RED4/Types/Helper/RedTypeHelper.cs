using System.Reflection;

namespace WolvenKit.RED4.Types;

public abstract class RedTypeHelper
{
    public static string[] GetExtendedClassNames(Type classType)
    {
        List<string> ret = [];

        foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
        {
            foreach (var m in a.GetModules())
            {
                try
                {
                    foreach (var t in m.GetTypes())
                    {
                        try
                        {
                            if (t == classType || t.IsSubclassOf(classType))
                            {
                                ret.Add(t.Name);
                            }
                        }
                        catch (ReflectionTypeLoadException) { }
                    }
                }
                catch (NullReferenceException) { }
            }
        }

        return ret.ToArray();
    }
}