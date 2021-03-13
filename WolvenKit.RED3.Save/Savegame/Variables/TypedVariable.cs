using System;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Variables
{
    public class TypedVariable : Variable
    {
        #region Properties

        public Type ClrType { get; set; }
        public string Type { get; set; }
        public VariableValue Value { get; set; }

        #endregion Properties

        #region Methods

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Type, base.ToString(), Value);
        }

        #endregion Methods
    }
}
