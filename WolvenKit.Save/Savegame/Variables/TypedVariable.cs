using System;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Variables
{
    public class TypedVariable : Variable
    {
        public string Type { get; set; }
        public Type ClrType { get; set; }
        public VariableValue Value { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Type, base.ToString(), Value);
        }
    }
}