namespace WolvenKit.W3SavegameEditor.Core.Savegame.Variables
{
    public abstract class Variable
    {
        #region Constructors

        public Variable()
        {
            Name = "None";
        }

        #endregion Constructors

        #region Properties

        public string Name { get; set; }

        public int Size { get; set; }

        public int TokenSize { get; set; }

        #endregion Properties

        #region Methods

        public override string ToString()
        {
            return Name;
        }

        #endregion Methods
    }
}
