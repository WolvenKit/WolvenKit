
namespace WolvenKit.RED4.Types
{
	public abstract partial class worldIRuntimeSystemNavigation : worldIRuntimeSystem
	{
		public worldIRuntimeSystemNavigation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
