
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsPlayerMovingPrereq : PlayerStateMachinePrereq
	{

		public IsPlayerMovingPrereq()
		{
			SkipWhenApplied = true;
		}
	}
}
