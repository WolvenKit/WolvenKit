using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIBackgroundCombatCommandParams : questScriptedAICommandParams
	{
		[Ordinal(0)] 
		[RED("steps")] 
		public CArray<AIBackgroundCombatStep> Steps
		{
			get => GetPropertyValue<CArray<AIBackgroundCombatStep>>();
			set => SetPropertyValue<CArray<AIBackgroundCombatStep>>(value);
		}

		public AIBackgroundCombatCommandParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
