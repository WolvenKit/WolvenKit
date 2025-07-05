using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ForceMoveInCombatEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("aiComponent")] 
		public CHandle<AIHumanComponent> AiComponent
		{
			get => GetPropertyValue<CHandle<AIHumanComponent>>();
			set => SetPropertyValue<CHandle<AIHumanComponent>>(value);
		}

		[Ordinal(1)] 
		[RED("commandStarted")] 
		public CBool CommandStarted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ForceMoveInCombatEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
