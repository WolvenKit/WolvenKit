
namespace WolvenKit.RED4.Types
{
	public abstract partial class AISmartSpotInstance : AISpotInstance
	{
		public AISmartSpotInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
