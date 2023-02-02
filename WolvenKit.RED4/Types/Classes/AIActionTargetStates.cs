using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIActionTargetStates : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("npcStates")] 
		public AIActionNPCStates NpcStates
		{
			get => GetPropertyValue<AIActionNPCStates>();
			set => SetPropertyValue<AIActionNPCStates>(value);
		}

		[Ordinal(1)] 
		[RED("playerStates")] 
		public AIActionPlayerStates PlayerStates
		{
			get => GetPropertyValue<AIActionPlayerStates>();
			set => SetPropertyValue<AIActionPlayerStates>(value);
		}

		public AIActionTargetStates()
		{
			NpcStates = new() { HighLevelStates = new(), UpperBodyStates = new(), StanceStates = new(), BehaviorStates = new(), DefenseMode = new(), LocomotionMode = new() };
			PlayerStates = new() { LocomotionStates = new(), UpperBodyStates = new(), MeleeStates = new(), ZoneStates = new(), BodyCarryStates = new(), CombatStates = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
