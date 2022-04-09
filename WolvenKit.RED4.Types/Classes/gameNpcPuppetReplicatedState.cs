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
			InitialOrientation = new();
			InitialLocation = new();
			ActionsBuffer = new();
			Health = -1.000000F;
			Armor = -1.000000F;
			CPOMissionVotedHistory = new();
			AnimEventsState = new() { Items = new(), LastAppliedActionsTime = new() };
			EntityEventsState = new() { Items = new(), LastAppliedActionsTime = new() };
			WeaponStates = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
