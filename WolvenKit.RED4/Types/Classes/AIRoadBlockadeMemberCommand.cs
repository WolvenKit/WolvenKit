using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIRoadBlockadeMemberCommand : AICombatRelatedCommand
	{
		[Ordinal(5)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AIRoadBlockadeMemberCommand()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
