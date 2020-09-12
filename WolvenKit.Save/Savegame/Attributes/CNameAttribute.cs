using System;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class CNameAttribute : Attribute
    {
        public string Name { get; set; }

        public CNameAttribute(string name)
        {
            Name = name;
        }
    }
}
