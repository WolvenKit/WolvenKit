namespace WolvenKit.RED4.Types
{
    public interface IRedResourceReference : IRedType
    {
        public string DepotPath { get; set; }
        public InternalEnums.EImportFlags Flags { get; set; }
    }

    public interface IRedResourceReference<T> : IRedResourceReference, IRedType<T>, IRedGenericType<T>
    {

    }
}
