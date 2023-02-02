
namespace WolvenKit.RED4.Types
{
	public partial class ReadyDecisions : WeaponReadyListenerTransition
	{
		public ReadyDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
