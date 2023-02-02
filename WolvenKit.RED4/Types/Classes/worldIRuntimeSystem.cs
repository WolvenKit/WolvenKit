
namespace WolvenKit.RED4.Types
{
	public partial class worldIRuntimeSystem : IUpdatableSystem
	{
		public worldIRuntimeSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
