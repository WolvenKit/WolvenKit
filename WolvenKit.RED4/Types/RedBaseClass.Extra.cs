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
        if (xPath.Length == 0)
        {
            return (true, this);
        }
        
        IRedType? result = this;
        var currentProps = _properties;

        foreach (var partial in xPath)
        {
            // after the loop, we should have currentProps from a base class, and a result
            if (result == null || currentProps == null)
            {
                return (false, null);
            }

            // In case of (nested) lists, we need to process the index structure below
            var arrPath = partial.Split(':');

            if (!currentProps.TryGetValue(arrPath[0], out var child))
            {
                return (false, null);
            }

            result = child;


            // we'll look in the child's properties next

            currentProps = result switch
            {
                IRedHandle ira => ira.GetValue()?._properties,
                RedBaseClass rbc => rbc._properties,
                _ => null
            };

            if (arrPath.Length == 1)
            {
                continue;
            }

            // We have leftover array indices and need to go down
            arrPath = arrPath.Skip(1).ToArray();

            foreach (var arrayProp in arrPath)
            {
                if (currentProps?.TryGetValue(arrayProp, out var grandChild) == true)
                {
                    result = grandChild;
                    currentProps = result switch
                    {
                        IRedHandle handle => handle.GetValue()?._properties,
                        RedBaseClass rbc2 => rbc2._properties,
                        _ => currentProps
                    };

                    continue;
                }

                if (!int.TryParse(arrayProp, out var index) || index < 0)
                {
                    return (false, null);
                }

                // also covers IRedArray
                if (result is IList lst)
                {
                    if (index >= lst.Count)
                    {
                        return (false, null);
                    }

                    result = (IRedType?)lst[index];
                }

                switch (result)
                {
                    case IRedBaseHandle handle:
                        currentProps = handle.GetValue()?._properties;
                        continue;
                    case RedBaseClass subCls:
                        currentProps = subCls._properties;
                        continue;
                    case IRedBufferWrapper { Data: RedPackage redPackage }:
                    {
                        if (index >= redPackage.Chunks.Count)
                        {
                            return (false, null);
                        }

                        result = redPackage.Chunks[index];
                        currentProps = ((RedBaseClass)result)._properties;
                        break;
                    }
                    default:
                        break;
                }
            }
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

            if (value is CKeyValuePair cKeyValuePair)
            {
                yield return ($"{propPath}.Value", cKeyValuePair.Value);
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
