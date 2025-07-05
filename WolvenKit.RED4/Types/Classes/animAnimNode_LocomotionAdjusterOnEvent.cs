using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_LocomotionAdjusterOnEvent : animAnimNode_LocomotionAdjuster
	{
		[Ordinal(19)] 
		[RED("locomotionFeatureName")] 
		public CName LocomotionFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("targetAnimationName")] 
		public CName TargetAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("startAdjustmentAfterAnimEvent")] 
		public CName StartAdjustmentAfterAnimEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimNode_LocomotionAdjusterOnEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
