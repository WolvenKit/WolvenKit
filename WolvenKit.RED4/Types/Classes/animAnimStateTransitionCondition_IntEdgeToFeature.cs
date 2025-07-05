using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimStateTransitionCondition_IntEdgeToFeature : animAnimStateTransitionCondition_IntEdgeFeature
	{
		[Ordinal(2)] 
		[RED("toValue")] 
		public CInt32 ToValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public animAnimStateTransitionCondition_IntEdgeToFeature()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
