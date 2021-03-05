namespace WolvenKit.W3SavegameEditor.Core.Savegame.Variables
{
    public class SxapVariable : Variable
    {
        #region Properties

        public int TypeCode1 { get; set; }
        public int TypeCode2 { get; set; }
        public int TypeCode3 { get; set; }

        #endregion Properties

        #region Methods

        public override string ToString()
        {
            return "SXAP " + base.ToString();
        }

        #endregion Methods
    }
}
