
namespace WolvenKit.RED4.Types
{
	public partial class worldCompiledNodeInstanceSetupInfoBuffer : CArray<worldCompiledNodeInstanceSetupInfo>, IParseableBuffer, IRedType
    {
		public IRedType? Data => null;

        public Dictionary<int, List<worldCompiledNodeInstanceSetupInfo>> Lookup = new();

        public worldCompiledNodeInstanceSetupInfoBuffer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
