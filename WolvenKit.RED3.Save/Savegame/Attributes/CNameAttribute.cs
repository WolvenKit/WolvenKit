using System;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class CNameAttribute : Attribute
    {
        #region Constructors

        public CNameAttribute(string name)
        {
            Name = name;
        }

        #endregion Constructors

        #region Properties

        public string Name { get; set; }

        #endregion Properties
    }
}
