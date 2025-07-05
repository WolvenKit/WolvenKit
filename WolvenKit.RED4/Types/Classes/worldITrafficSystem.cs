
namespace WolvenKit.RED4.Types
{
	public abstract partial class worldITrafficSystem : worldIRuntimeSystem
	{
		public worldITrafficSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
