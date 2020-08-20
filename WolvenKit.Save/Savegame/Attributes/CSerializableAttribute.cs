using System;

namespace W3SavegameEditor.Core.Savegame.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CSerializableAttribute : Attribute
    {
        public string TypeName { get; set; }

        /// <summary>
        /// Flag that symbolizes that the name of the type is guessed.
        /// </summary>
        public bool Custom { get; set; }

        public CSerializableAttribute(string typeName)
        {
            TypeName = typeName;
        }
    }
}