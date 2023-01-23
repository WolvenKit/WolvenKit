
namespace WolvenKit.RED4.Types
{
	public partial class worldRuntimeEntityRegistry : worldIRuntimeSystem
	{
		public worldRuntimeEntityRegistry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
