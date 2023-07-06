using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameActionAnimationState : gameActionReplicatedState
	{
		[Ordinal(5)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("animFeature")] 
		public CHandle<animAnimFeature_AIAction> AnimFeature
		{
			get => GetPropertyValue<CHandle<animAnimFeature_AIAction>>();
			set => SetPropertyValue<CHandle<animAnimFeature_AIAction>>(value);
		}

		[Ordinal(7)] 
		[RED("useRootMotion")] 
		public CBool UseRootMotion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("usePoseMatching")] 
		public CBool UsePoseMatching
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("motionDynamicObjectsCheck")] 
		public CBool MotionDynamicObjectsCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("slideParams")] 
		public gameActionAnimationSlideParams SlideParams
		{
			get => GetPropertyValue<gameActionAnimationSlideParams>();
			set => SetPropertyValue<gameActionAnimationSlideParams>(value);
		}

		[Ordinal(11)] 
		[RED("targetObject")] 
		public CWeakHandle<gameObject> TargetObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(12)] 
		[RED("sendLoopEvent")] 
		public CBool SendLoopEvent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameActionAnimationState()
		{
			SlideParams = new gameActionAnimationSlideParams { UsePositionSlide = true, UseRotationSlide = true };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
