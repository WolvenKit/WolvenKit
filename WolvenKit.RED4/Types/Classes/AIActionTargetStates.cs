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
			NpcStates = new AIActionNPCStates();
			PlayerStates = new AIActionPlayerStates();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
