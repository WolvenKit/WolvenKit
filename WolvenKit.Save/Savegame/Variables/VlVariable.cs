namespace W3SavegameEditor.Core.Savegame.Variables
{
    /// <summary>
    /// A single variable
    /// </summary>
    public class VlVariable : TypedVariable
    {
        public override string ToString()
        {
            return "VL " +  base.ToString();
        }
    }
}