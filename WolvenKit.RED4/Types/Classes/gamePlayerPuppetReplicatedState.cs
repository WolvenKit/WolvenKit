
namespace WolvenKit.RED4.Types
{
	public partial class gamePlayerPuppetReplicatedState : gamePuppetReplicatedState
	{
		public gamePlayerPuppetReplicatedState()
		{
			InitialOrientation = new();
			InitialLocation = new();
			ActionsBuffer = new();
			Health = -1.000000F;
			Armor = -1.000000F;
			CPOMissionVotedHistory = new();
			AnimEventsState = new() { Items = new(), LastAppliedActionsTime = new() };
			EntityEventsState = new() { Items = new(), LastAppliedActionsTime = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
