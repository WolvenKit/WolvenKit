using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimStateTransitionDescription : ISerializable
	{
		[Ordinal(0)] 
		[RED("targetStateIndex")] 
		public CUInt32 TargetStateIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("condition")] 
		public CHandle<animIAnimStateTransitionCondition> Condition
		{
			get => GetPropertyValue<CHandle<animIAnimStateTransitionCondition>>();
			set => SetPropertyValue<CHandle<animIAnimStateTransitionCondition>>(value);
		}

		[Ordinal(2)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("interpolator")] 
		public CHandle<animIAnimStateTransitionInterpolator> Interpolator
		{
			get => GetPropertyValue<CHandle<animIAnimStateTransitionInterpolator>>();
			set => SetPropertyValue<CHandle<animIAnimStateTransitionInterpolator>>(value);
		}

		[Ordinal(4)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("syncMethod")] 
		public CHandle<animISyncMethod> SyncMethod
		{
			get => GetPropertyValue<CHandle<animISyncMethod>>();
			set => SetPropertyValue<CHandle<animISyncMethod>>(value);
		}

		[Ordinal(7)] 
		[RED("isForcedToTrue")] 
		public CBool IsForcedToTrue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("supportBlendFromPose")] 
		public CBool SupportBlendFromPose
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("canRequestInertialization")] 
		public CBool CanRequestInertialization
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("actionAnimDatabaseRef")] 
		public CResourceReference<animActionAnimDatabase> ActionAnimDatabaseRef
		{
			get => GetPropertyValue<CResourceReference<animActionAnimDatabase>>();
			set => SetPropertyValue<CResourceReference<animActionAnimDatabase>>(value);
		}

		[Ordinal(12)] 
		[RED("isOutTransitionFromAction")] 
		public CBool IsOutTransitionFromAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimStateTransitionDescription()
		{
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
