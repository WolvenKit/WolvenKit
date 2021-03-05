namespace WolvenKit.W3SavegameEditor.Core.Savegame.Variables
{
    /// <summary>
    /// A single variable
    /// </summary>
    public class VlVariable : TypedVariable
    {
        #region Methods

        public override string ToString()
        {
            return "VL " + base.ToString();
        }

        #endregion Methods
    }
}
