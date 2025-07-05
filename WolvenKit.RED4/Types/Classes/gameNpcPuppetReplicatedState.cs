using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameNpcPuppetReplicatedState : gamePuppetReplicatedState
	{
		[Ordinal(12)] 
		[RED("weaponStates")] 
		public gameWeaponsReplicatedState WeaponStates
		{
			get => GetPropertyValue<gameWeaponsReplicatedState>();
			set => SetPropertyValue<gameWeaponsReplicatedState>(value);
		}

		public gameNpcPuppetReplicatedState()
		{
			InitialOrientation = new EulerAngles();
			InitialLocation = new Vector3();
			ActionsBuffer = new gameActionsReplicationBuffer();
			Health = -1.000000F;
			Armor = -1.000000F;
			CPOMissionVotedHistory = new();
			AnimEventsState = new gameReplicatedAnimControllerEventsState { Items = new(), LastAppliedActionsTime = new netTime() };
			EntityEventsState = new gameReplicatedEntityEventsState { Items = new(), LastAppliedActionsTime = new netTime() };
			WeaponStates = new gameWeaponsReplicatedState();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
