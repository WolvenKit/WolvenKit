using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorRandomConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] 
		[RED("chance")] 
		public CFloat Chance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AIbehaviorRandomConditionDefinition()
		{
			Chance = 0.500000F;
		}
	}
}
