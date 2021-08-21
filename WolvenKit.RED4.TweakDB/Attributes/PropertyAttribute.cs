using System;
using System.Runtime.CompilerServices;

namespace WolvenKit.RED4.TweakDB.Attributes
{
    /// <summary>
    /// An attribute representing native properties.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class PropertyAttribute : Attribute
    {
        /// <summary>
        /// The native name.
        /// </summary>
        public string Name { get; init; }

        /// <summary>
        /// The native order.
        /// </summary>
        public int Ordinal { get; init; }

        public PropertyAttribute([CallerMemberName] string propertyName = null)
        {
            Name = propertyName;
        }
    }
}
