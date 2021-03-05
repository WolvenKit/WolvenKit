using System;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CSerializableAttribute : Attribute
    {
        #region Constructors

        public CSerializableAttribute(string typeName)
        {
            TypeName = typeName;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Flag that symbolizes that the name of the type is guessed.
        /// </summary>
        public bool Custom { get; set; }

        public string TypeName { get; set; }

        #endregion Properties
    }
}
