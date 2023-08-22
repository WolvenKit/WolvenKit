
namespace WolvenKit.RED4.Types
{
	public abstract partial class worldINodeInstanceRegistry : worldIRuntimeSystem
	{
		public worldINodeInstanceRegistry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
