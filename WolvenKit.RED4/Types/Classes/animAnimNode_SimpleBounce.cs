using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SimpleBounce : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("areChannelsResaved")] 
		public CBool AreChannelsResaved
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("outputDriverTrack")] 
		public animNamedTrackIndex OutputDriverTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(14)] 
		[RED("debug")] 
		public CBool Debug
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("startTransform")] 
		public animTransformIndex StartTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(16)] 
		[RED("endTransform")] 
		public animTransformIndex EndTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(17)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("negativeMultiplier")] 
		public CFloat NegativeMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("smoothStep")] 
		public CFloat SmoothStep
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("offset")] 
		public CFloat Offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("transformOutputs")] 
		public CArray<animSimpleBounceTransformOutput> TransformOutputs
		{
			get => GetPropertyValue<CArray<animSimpleBounceTransformOutput>>();
			set => SetPropertyValue<CArray<animSimpleBounceTransformOutput>>(value);
		}

		[Ordinal(23)] 
		[RED("trackOutputs")] 
		public CArray<animSimpleBounceTrackOutput> TrackOutputs
		{
			get => GetPropertyValue<CArray<animSimpleBounceTrackOutput>>();
			set => SetPropertyValue<CArray<animSimpleBounceTrackOutput>>(value);
		}

		public animAnimNode_SimpleBounce()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			OutputDriverTrack = new animNamedTrackIndex();
			StartTransform = new animTransformIndex();
			EndTransform = new animTransformIndex();
			Multiplier = 1.000000F;
			NegativeMultiplier = 1.000000F;
			SmoothStep = 1.000000F;
			TransformOutputs = new();
			TrackOutputs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
