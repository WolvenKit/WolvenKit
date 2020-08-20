namespace W3SavegameEditor.Core.Common
{
    public interface IReadSavegameProgress
    {
        void Report(bool running, bool indeterministic, int value, int max);
    }
}