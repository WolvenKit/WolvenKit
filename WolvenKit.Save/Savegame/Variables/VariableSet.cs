namespace WolvenKit.W3SavegameEditor.Core.Savegame.Variables
{
    public class VariableSet : Variable
    {
        public Variable[] Variables { get; set; }

        public override string ToString()
        {
            return string.Format("{0}[{1}]", base.ToString(), Variables.Length);
        }
    }
}
