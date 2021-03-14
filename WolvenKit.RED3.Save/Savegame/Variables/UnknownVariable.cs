namespace WolvenKit.W3SavegameEditor.Core.Savegame.Variables
{
    public class UnknownVariable : Variable
    {
        #region Fields

        public static readonly UnknownVariable None = new UnknownVariable { Name = "None" };

        #endregion Fields

        #region Properties

        public byte[] Data { get; set; }

        #endregion Properties

        #region Methods

        public override string ToString()
        {
            return string.Format("Unknown[{0}] {1}", (Data == null ? "null" : Data.Length.ToString()), base.ToString());
        }

        #endregion Methods
    }
}
