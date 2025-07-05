using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSimpleBounce_JsonProperties : ISerializable
	{
		[Ordinal(0)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("negativeMultiplier")] 
		public CFloat NegativeMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("smoothStep")] 
		public CFloat SmoothStep
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("offset")] 
		public CFloat Offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("startTransform")] 
		public animTransformIndex StartTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(6)] 
		[RED("endTransform")] 
		public animTransformIndex EndTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(7)] 
		[RED("transformOutputs")] 
		public CArray<animSimpleBounceTransformOutput> TransformOutputs
		{
			get => GetPropertyValue<CArray<animSimpleBounceTransformOutput>>();
			set => SetPropertyValue<CArray<animSimpleBounceTransformOutput>>(value);
		}

		[Ordinal(8)] 
		[RED("trackOutputs")] 
		public CArray<animSimpleBounceTrackOutput> TrackOutputs
		{
			get => GetPropertyValue<CArray<animSimpleBounceTrackOutput>>();
			set => SetPropertyValue<CArray<animSimpleBounceTrackOutput>>(value);
		}

		[Ordinal(9)] 
		[RED("outputDriverTrack")] 
		public animNamedTrackIndex OutputDriverTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		public animSimpleBounce_JsonProperties()
		{
			StartTransform = new animTransformIndex();
			EndTransform = new animTransformIndex();
			TransformOutputs = new();
			TrackOutputs = new();
			OutputDriverTrack = new animNamedTrackIndex();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
