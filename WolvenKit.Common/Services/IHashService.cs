namespace WolvenKit.Common.Services
{
    public interface IHashService
    {
        #region Methods

        bool Contains(ulong key);

        string Get(ulong key);


        void Serialize(string path);

        void Add(string path);

        #endregion Methods
    }
}
