using System;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Attributes
{
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Property)]
    public class EnumNameAttribute : Attribute
    {
        #region Constructors

        public EnumNameAttribute(string name)
        {
            Name = name;
        }

        #endregion Constructors

        #region Properties

        private string Name { get; set; }

        #endregion Properties
    }
}
