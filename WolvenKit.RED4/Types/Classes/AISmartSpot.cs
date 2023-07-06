
namespace WolvenKit.RED4.Types
{
	public abstract partial class AISmartSpot : AISpot
	{
		public AISmartSpot()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
