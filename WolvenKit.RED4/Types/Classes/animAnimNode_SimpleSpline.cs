using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SimpleSpline : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("areSourceChannelsResaved")] 
		public CBool AreSourceChannelsResaved
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("startTransform")] 
		public animTransformIndex StartTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(14)] 
		[RED("middleTransform")] 
		public animTransformIndex MiddleTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(15)] 
		[RED("endTransform")] 
		public animTransformIndex EndTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(16)] 
		[RED("constrainedTransform")] 
		public animTransformIndex ConstrainedTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(17)] 
		[RED("progressMode")] 
		public CEnum<animConstraintWeightMode> ProgressMode
		{
			get => GetPropertyValue<CEnum<animConstraintWeightMode>>();
			set => SetPropertyValue<CEnum<animConstraintWeightMode>>(value);
		}

		[Ordinal(18)] 
		[RED("defaultProgress")] 
		public CFloat DefaultProgress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("progressTrack")] 
		public animNamedTrackIndex ProgressTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		public animAnimNode_SimpleSpline()
		{
			Id = 4294967295;
			InputLink = new();
			StartTransform = new();
			MiddleTransform = new();
			EndTransform = new();
			ConstrainedTransform = new();
			DefaultProgress = 0.500000F;
			ProgressTrack = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
