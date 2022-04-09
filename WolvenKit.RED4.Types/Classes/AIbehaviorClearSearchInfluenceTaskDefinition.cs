using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorClearSearchInfluenceTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("clearedAreaRadius")] 
		public CHandle<AIArgumentMapping> ClearedAreaRadius
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("clearedAreaDistance")] 
		public CHandle<AIArgumentMapping> ClearedAreaDistance
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("clearedAreaAngle")] 
		public CHandle<AIArgumentMapping> ClearedAreaAngle
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorClearSearchInfluenceTaskDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
