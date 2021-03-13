namespace WolvenKit.W3SavegameEditor.Core.Savegame.Variables
{
    public class VariableSet : Variable
    {
        #region Properties

        public Variable[] Variables { get; set; }

        #endregion Properties

        #region Methods

        public override string ToString()
        {
            return string.Format("{0}[{1}]", base.ToString(), Variables.Length);
        }

        #endregion Methods
    }
}
