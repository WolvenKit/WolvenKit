namespace W3SavegameEditor.Core.Savegame.Variables
{
    /// <summary>
    /// A set of strings.
    /// </summary>
    public class ManuVariable : Variable
    {
        public string[] Strings { get; set; }
        public override string ToString()
        {
            return string.Format("MANU[{0}] {1}", (Strings == null ? "null" : Strings.Length.ToString()), base.ToString());
        }
    }
}