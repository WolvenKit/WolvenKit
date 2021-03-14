namespace WolvenKit.W3SavegameEditor.Core.Savegame
{
    public class VariableTableEntry
    {
        #region Properties

        public int Offset { get; set; }
        public int Size { get; set; }

        #endregion Properties

        #region Methods

        public override string ToString()
        {
            return string.Format("Offset: {0}, Size: {1}", Offset, Size);
        }

        #endregion Methods
    }
}
