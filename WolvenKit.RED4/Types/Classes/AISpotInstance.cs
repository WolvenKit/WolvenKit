
namespace WolvenKit.RED4.Types
{
	public abstract partial class AISpotInstance : RedBaseClass
	{
		public AISpotInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
