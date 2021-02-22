namespace WolvenKit.Common.Services
{
    public interface IHashService
    {
        bool Contains(ulong key);
        string Get(ulong key);
    }
}
