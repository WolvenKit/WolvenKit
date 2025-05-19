using System.Reflection;

namespace WolvenKit.RED4.Types;

public abstract class RedTypeHelper
{
    /// <summary>
    /// Caches a list of extending type names so that it's only generated once per run.
    /// </summary>
    private static readonly Dictionary<string, List<string>> s_extendingTypeNames = [];

    /// <summary>
    /// Gets the names of all classes extending the given class type. Results are cached based on FullName.
    /// </summary>
    public static List<string> GetExtendingClassNames(Type classType)
    {
        var typeName = classType.FullName ?? classType.Name;

        s_extendingTypeNames.TryGetValue(typeName, out var ret);
        ret ??= [];

        if (ret.Count > 0)
        {
            return ret;
        }

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

        s_extendingTypeNames.Add(typeName, ret);

        return ret;
    }
}