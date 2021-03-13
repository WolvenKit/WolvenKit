namespace WolvenKit.W3SavegameEditor.Core.Common
{
    public interface IReadSavegameProgress
    {
        #region Methods

        void Report(bool running, bool indeterministic, int value, int max);

        #endregion Methods
    }
}
