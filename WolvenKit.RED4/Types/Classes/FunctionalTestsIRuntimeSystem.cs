
namespace WolvenKit.RED4.Types
{
	public abstract partial class FunctionalTestsIRuntimeSystem : worldIRuntimeSystem
	{
		public FunctionalTestsIRuntimeSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
