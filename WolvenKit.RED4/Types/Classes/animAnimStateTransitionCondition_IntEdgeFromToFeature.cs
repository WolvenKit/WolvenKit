using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimStateTransitionCondition_IntEdgeFromToFeature : animAnimStateTransitionCondition_IntEdgeFeature
	{
		[Ordinal(2)] 
		[RED("fromValue")] 
		public CInt32 FromValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("toValue")] 
		public CInt32 ToValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public animAnimStateTransitionCondition_IntEdgeFromToFeature()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
