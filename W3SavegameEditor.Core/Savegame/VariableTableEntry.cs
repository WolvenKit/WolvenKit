namespace W3SavegameEditor.Core.Savegame
{
    public class VariableTableEntry
    {
        public int Offset { get; set; }
        public int Size { get; set; }

        public override string ToString()
        {
            return string.Format("Offset: {0}, Size: {1}", Offset, Size);
        }
    }
}