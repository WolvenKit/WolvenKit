
namespace WolvenKit.RED4.Types
{
	public partial class NotReadyDecisions : WeaponReadyListenerTransition
	{
		public NotReadyDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
