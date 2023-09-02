
namespace WolvenKit.RED4.Types
{
	public abstract partial class worldIRuntimeSystem : IUpdatableSystem
	{
		public worldIRuntimeSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
