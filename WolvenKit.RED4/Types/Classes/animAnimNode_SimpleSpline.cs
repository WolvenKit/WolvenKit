using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SimpleSpline : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("areSourceChannelsResaved")] 
		public CBool AreSourceChannelsResaved
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("startTransform")] 
		public animTransformIndex StartTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(4)] 
		[RED("middleTransform")] 
		public animTransformIndex MiddleTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(5)] 
		[RED("endTransform")] 
		public animTransformIndex EndTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(6)] 
		[RED("constrainedTransform")] 
		public animTransformIndex ConstrainedTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(7)] 
		[RED("progressMode")] 
		public CEnum<animConstraintWeightMode> ProgressMode
		{
			get => GetPropertyValue<CEnum<animConstraintWeightMode>>();
			set => SetPropertyValue<CEnum<animConstraintWeightMode>>(value);
		}

		[Ordinal(8)] 
		[RED("defaultProgress")] 
		public CFloat DefaultProgress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("progressTrack")] 
		public animNamedTrackIndex ProgressTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		public animAnimNode_SimpleSpline()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			StartTransform = new animTransformIndex();
			MiddleTransform = new animTransformIndex();
			EndTransform = new animTransformIndex();
			ConstrainedTransform = new animTransformIndex();
			DefaultProgress = 0.500000F;
			ProgressTrack = new animNamedTrackIndex();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
