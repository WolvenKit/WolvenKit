using System;
using System.Collections.Generic;

namespace WolvenKit.RED4.Types
{
    internal static class Patches
    {
        internal static readonly Dictionary<string, List<Attribute>> AttributePatches = new();

        internal static void AddAttributePatch(string propName, Attribute attribute)
        {
            if (!AttributePatches.ContainsKey(propName))
            {
                AttributePatches.Add(propName, new List<Attribute>());
            }

            AttributePatches[propName].Add(attribute);
        }

        static Patches()
        {
            //AddAttributePatch(nameof(gameLightComponent.IsEnabled), new REDPropertyAttribute { SerializeDefault = true });
        }
    }
}
