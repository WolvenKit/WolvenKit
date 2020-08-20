using System;

namespace W3SavegameEditor.Core.Savegame.Attributes
{

    [AttributeUsage(AttributeTargets.Property)]
    public class CArrayAttribute : Attribute
    {
        private const string DefaultCountName = "count";
        public string CountName { get; set; }
        public string ElementName { get; set; }

        public CArrayAttribute() : this(DefaultCountName)
        {

        }


        public CArrayAttribute(string countName)
        {
            CountName = countName;
        }
    }
}