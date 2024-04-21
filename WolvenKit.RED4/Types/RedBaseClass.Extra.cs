using System.Collections;
using WolvenKit.RED4.Archive.Buffer;

namespace WolvenKit.RED4.Types;

public partial class RedBaseClass
{
    public Dictionary<string, object?> ToDictionary(bool clone = true)
    {
        if (clone)
        {
            var copy = (RedBaseClass)DeepCopy();
            return copy.ToDictionary(false);
        }

        var dict = new Dictionary<string, object?>();
        foreach (var property in _properties)
        {
            if (property.Value is RedBaseClass rbc)
            {
                dict.Add(property.Key, rbc.ToDictionary(false));
            }
            else
            {
                dict.Add(property.Key, property.Value);
            }
        }

        return dict;
    }

    #region XPath

    public (bool, object?) GetFromXPath(string xPath) => GetFromXPath(xPath.Split('.'));

    public (bool, IRedType?) GetFromXPath(string[] xPath)
    {
        IRedType? result = null;
        var currentProps = _properties;
        foreach (var part in xPath)
        {
            if (currentProps == null)
            {
                return (false, null);
            }

            var arrPath = part.Split(':');
            if (currentProps.ContainsKey(arrPath[0]))
            {
                result = currentProps[arrPath[0]];

                currentProps = null;

                if (result is IList lst)
                {
                    if (arrPath.Length == 2 && int.TryParse(arrPath[1], out var index))
                    {
                        if (index >= lst.Count)
                        {
                            return (false, null);
                        }

                        result = (IRedType?)lst[index];
                    }
                }

                if (result is RedBaseClass subCls)
                {
                    currentProps = subCls._properties;
                }

                if (result is IRedBaseHandle handle)
                {
                    var cCls = handle.GetValue();
                    currentProps = cCls?._properties;
                }

                continue;
            }

            return (false, null);
        }

        return (true, result);
    }

    #endregion XPath

    #region Enumerator

    public IEnumerable<(string propPath, IRedType value)> GetEnumerator(string rootName = "root")
    {
        var queue = new Queue<(RedBaseClass, string)>();
        var visited = new Dictionary<RedBaseClass, byte>(ReferenceEqualityComparer.Instance);

        foreach (var tuple in InternalFindType(this))
        {
            yield return tuple;
        }

        IEnumerable<(string propPath, IRedType value)> InternalFindType(RedBaseClass cls)
        {
            queue.Enqueue((cls, rootName));
            while (queue.Count != 0)
            {
                var (cls1, path) = queue.Dequeue();

                if (!visited.TryAdd(cls1, 0))
                {
                    continue;
                }

                foreach (var entry in cls1._properties)
                {
                    var propPath = $"{path}.{entry.Key}";

                    foreach (var tuple in ProcessValue(propPath, entry.Value))
                    {
                        yield return tuple;
                    }
                }
            }
        }

        IEnumerable<(string propPath, IRedType value)> ProcessValue(string propPath, IRedType? value)
        {
            if (value == null)
            {
                yield break;
            }

            yield return (propPath, value);

            if (value is IList lst)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    var arrPath = $"{propPath}:{i}";
                    foreach (var tuple in ProcessValue(arrPath, (IRedType?)lst[i]))
                    {
                        yield return tuple;
                    }
                }
            }

            if (value is RedBaseClass subCls)
            {
                queue.Enqueue((subCls, propPath));
            }

            if (value is IRedBaseHandle handle)
            {
                if (handle.GetValue() != null)
                {
                    queue.Enqueue((handle.GetValue()!, propPath));
                }
            }

            if (value is IRedBufferWrapper { Data: RedPackage redPackage })
            {
                for (var i = 0; i < redPackage.Chunks.Count; i++)
                {
                    queue.Enqueue((redPackage.Chunks[i], $"{propPath}:{i}"));
                }
            }
        }
    }

    public List<FindResult> FindType(Type targetType, string rootName = "root")
    {
        var result = new List<FindResult>();
        foreach (var tuple in GetEnumerator(rootName))
        {
            if (targetType.IsInstanceOfType(tuple.value))
            {
                result.Add(new FindResult(tuple.propPath, tuple.value));
            }
        }

        return result;
    }

    public class FindResult
    {
        public string Path { get; }
        public string Name => Path.Split('.')[^1];
        public IRedType Value { get; }

        internal FindResult(string path, IRedType value)
        {
            Path = path;
            Value = value;
        }
    }

    #endregion Enumerator

    public object ShallowCopy()
    {
        return MemberwiseClone();
    }

    public object DeepCopy()
    {
        var other = RedTypeManager.Create(GetType());

        foreach (var property in _properties)
        {
            if (property.Value is IRedCloneable cl)
            {
                var copy = (IRedType)cl.DeepCopy();

                // TODO do we need to set more parents like this?
                if (copy is IRedBufferWrapper buffer)
                {
                    buffer.Buffer.Parent = other;
                }

                other._properties[property.Key] = copy;
            }
            else
            {
                other._properties[property.Key] = property.Value;
            }
        }

        return other;
    }
}
