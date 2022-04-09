using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PassiveGlobalDeathCondition : AIbehaviorexpressionScript
	{
		[Ordinal(0)] 
		[RED("onDeathCbId")] 
		public CUInt32 OnDeathCbId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public PassiveGlobalDeathCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
