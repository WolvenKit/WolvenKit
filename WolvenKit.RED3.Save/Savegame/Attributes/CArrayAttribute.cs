using System;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CArrayAttribute : Attribute
    {
        #region Fields

        private const string DefaultCountName = "count";

        #endregion Fields

        #region Constructors

        public CArrayAttribute() : this(DefaultCountName)
        {
        }

        public CArrayAttribute(string countName)
        {
            CountName = countName;
        }

        #endregion Constructors

        #region Properties

        public string CountName { get; set; }
        public string ElementName { get; set; }

        #endregion Properties
    }
}
