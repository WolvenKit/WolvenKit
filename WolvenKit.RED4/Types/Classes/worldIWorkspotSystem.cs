
namespace WolvenKit.RED4.Types
{
	public abstract partial class worldIWorkspotSystem : worldIRuntimeSystem
	{
		public worldIWorkspotSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
