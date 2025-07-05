
namespace WolvenKit.RED4.Types
{
	public partial class UsingCoverPSMPrereq : PlayerStateMachinePrereq
	{
		public UsingCoverPSMPrereq()
		{
			SkipWhenApplied = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
