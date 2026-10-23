using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace WolvenKit.Core.Helpers;

/// <summary>
/// A process-wide cache over "every type in every loaded assembly".
/// </summary>
public static class AssemblyTypeIndex
{
    // Deliberately lock-free.
    private static Type[]? s_allTypes;
    private static bool s_snapshotComplete;
    private static int s_snapshotAssemblyCount;
    private static Dictionary<string, Type>? s_byName;
    private static ConcurrentDictionary<string, IReadOnlyList<Type>> s_filtered = new();

    static AssemblyTypeIndex() => AppDomain.CurrentDomain.AssemblyLoad += (_, _) => Invalidate();

    /// <summary>Drops every cached result. Called automatically when an assembly is loaded.</summary>
    public static void Invalidate()
    {
        s_allTypes = null;
        s_snapshotComplete = false;
        s_snapshotAssemblyCount = 0;
        s_byName = null;
        s_filtered = new ConcurrentDictionary<string, IReadOnlyList<Type>>();
    }

    /// <summary>Every type in every currently loaded assembly. Materialized once per snapshot.</summary>
    public static Type[] AllTypes
    {
        get
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            if (s_allTypes is { } cached && s_snapshotComplete && s_snapshotAssemblyCount == assemblies.Length)
            {
                return cached;
            }

            // drop derived caches as well - they were computed from the stale snapshot
            Invalidate();

            var (types, complete) = BuildAllTypes(assemblies);

            if (complete)
            {
                s_allTypes = types;
                s_snapshotComplete = true;
                s_snapshotAssemblyCount = assemblies.Length;
            }

            return types;
        }
    }

    private static (Type[] Types, bool Complete) BuildAllTypes(Assembly[] assemblies)
    {
        var result = new List<Type>(32768);
        var complete = true;

        foreach (var assembly in assemblies)
        {
            Type[] types;
            try
            {
                types = assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException ex)
            {
                types = ex.Types.Where(t => t is not null).ToArray()!;
                complete = false;
            }
            catch (Exception)
            {
                complete = false;
                continue;
            }

            result.AddRange(types);
        }

        return (result.ToArray(), complete);
    }

    /// <summary>
    /// Simple-name to type map. Where several types share a name the first encountered wins, which
    /// matches the <c>GroupBy(t =&gt; t.Name).ToDictionary(g =&gt; g.Key, g =&gt; g.First())</c> this replaced.
    /// </summary>
    public static Dictionary<string, Type> ByName
    {
        get
        {
            if (s_byName is { } cached)
            {
                return cached;
            }

            var all = AllTypes;
            var map = new Dictionary<string, Type>(all.Length);
            foreach (var type in all)
            {
                map.TryAdd(type.Name, type);
            }

            return s_snapshotComplete ? s_byName = map : map;
        }
    }

    public static Type? FindByName(string typeName) => ByName.GetValueOrDefault(typeName);

    /// <summary>Concrete (non-abstract) types assignable to <paramref name="baseType"/>.</summary>
    public static IReadOnlyList<Type> GetConcreteTypesAssignableTo(Type baseType) =>
        GetFiltered($"concrete:{baseType.AssemblyQualifiedName}",
            t => baseType.IsAssignableFrom(t) && !t.IsAbstract);

    /// <summary>Concrete (non-abstract) <b>classes</b> assignable to <paramref name="baseType"/>.</summary>
    public static IReadOnlyList<Type> GetConcreteClassesAssignableTo(Type baseType) =>
        GetFiltered($"concreteClass:{baseType.AssemblyQualifiedName}",
            t => baseType.IsAssignableFrom(t) && t.IsClass && !t.IsAbstract);

    /// <summary>
    /// Caches an arbitrary type filter under <paramref name="cacheKey"/>. The key must uniquely
    /// identify the predicate, since the predicate itself cannot be compared.
    /// </summary>
    public static IReadOnlyList<Type> GetFiltered(string cacheKey, Func<Type, bool> predicate)
    {
        var all = AllTypes;

        var filtered = s_filtered;
        if (filtered.TryGetValue(cacheKey, out var cached))
        {
            return cached;
        }

        var result = new List<Type>();
        foreach (var type in all)
        {
            if (predicate(type))
            {
                result.Add(type);
            }
        }

        var array = result.ToArray();

        // never memoize a view derived from a partial scan
        if (s_snapshotComplete)
        {
            filtered.TryAdd(cacheKey, array);
        }

        return array;
    }
}
