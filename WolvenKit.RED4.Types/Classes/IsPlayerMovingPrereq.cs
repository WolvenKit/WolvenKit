
namespace WolvenKit.RED4.Types
{
	public partial class IsPlayerMovingPrereq : PlayerStateMachinePrereq
	{
		public IsPlayerMovingPrereq()
		{
			SkipWhenApplied = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
