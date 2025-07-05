
namespace WolvenKit.RED4.Types
{
	public partial class gamePlayerPuppetReplicatedState : gamePuppetReplicatedState
	{
		public gamePlayerPuppetReplicatedState()
		{
			InitialOrientation = new EulerAngles();
			InitialLocation = new Vector3();
			ActionsBuffer = new gameActionsReplicationBuffer();
			Health = -1.000000F;
			Armor = -1.000000F;
			CPOMissionVotedHistory = new();
			AnimEventsState = new gameReplicatedAnimControllerEventsState { Items = new(), LastAppliedActionsTime = new netTime() };
			EntityEventsState = new gameReplicatedEntityEventsState { Items = new(), LastAppliedActionsTime = new netTime() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
