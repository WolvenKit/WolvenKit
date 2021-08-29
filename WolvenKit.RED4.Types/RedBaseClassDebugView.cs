using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace WolvenKit.RED4.Types
{
    public class RedBaseClassDebugView
    {
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public SimpleProperty[] Properties { get; }

        public RedBaseClassDebugView(object input)
        {
            this.Properties = input.GetType()
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Select(prop => new SimpleProperty(prop, input))
                .OrderBy(p => p.Ordinal)
                .ToArray();
        }

        [DebuggerDisplay("{Value}", Name = "{PropertyName,nq}", Type = "{TypeName,nq}")]
        public class SimpleProperty
        {
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            public int Ordinal { get; internal set; }

            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            public string PropertyName { get; internal set; }

            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            public string TypeName { get; internal set; }

            [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
            public IRedType Value { get; internal set; }

            public SimpleProperty(PropertyInfo property, object input)
            {
                Ordinal = GetOrdinal(property);
                PropertyName = property.Name;
                TypeName = property.PropertyType.Name;
                Value = GetValue(property, input);
            }

            private IRedType GetValue(PropertyInfo property, object input) => (IRedType)property.GetValue(input);

            private int GetOrdinal(PropertyInfo property)
            {
                var attr = property.GetCustomAttribute<OrdinalAttribute>();
                if (attr != null)
                {
                    return attr.Ordinal;
                }

                return -1;
            }
        }
    }
}
