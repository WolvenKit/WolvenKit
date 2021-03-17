using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SimpleBounce : animAnimNode_OnePoseInput
	{
		private CBool _areChannelsResaved;
		private animNamedTrackIndex _outputDriverTrack;
		private CBool _debug;
		private animTransformIndex _startTransform;
		private animTransformIndex _endTransform;
		private CFloat _multiplier;
		private CFloat _negativeMultiplier;
		private CFloat _smoothStep;
		private CFloat _offset;
		private CFloat _delay;
		private CArray<animSimpleBounceTransformOutput> _transformOutputs;
		private CArray<animSimpleBounceTrackOutput> _trackOutputs;

		[Ordinal(12)] 
		[RED("areChannelsResaved")] 
		public CBool AreChannelsResaved
		{
			get => GetProperty(ref _areChannelsResaved);
			set => SetProperty(ref _areChannelsResaved, value);
		}

		[Ordinal(13)] 
		[RED("outputDriverTrack")] 
		public animNamedTrackIndex OutputDriverTrack
		{
			get => GetProperty(ref _outputDriverTrack);
			set => SetProperty(ref _outputDriverTrack, value);
		}

		[Ordinal(14)] 
		[RED("debug")] 
		public CBool Debug
		{
			get => GetProperty(ref _debug);
			set => SetProperty(ref _debug, value);
		}

		[Ordinal(15)] 
		[RED("startTransform")] 
		public animTransformIndex StartTransform
		{
			get => GetProperty(ref _startTransform);
			set => SetProperty(ref _startTransform, value);
		}

		[Ordinal(16)] 
		[RED("endTransform")] 
		public animTransformIndex EndTransform
		{
			get => GetProperty(ref _endTransform);
			set => SetProperty(ref _endTransform, value);
		}

		[Ordinal(17)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get => GetProperty(ref _multiplier);
			set => SetProperty(ref _multiplier, value);
		}

		[Ordinal(18)] 
		[RED("negativeMultiplier")] 
		public CFloat NegativeMultiplier
		{
			get => GetProperty(ref _negativeMultiplier);
			set => SetProperty(ref _negativeMultiplier, value);
		}

		[Ordinal(19)] 
		[RED("smoothStep")] 
		public CFloat SmoothStep
		{
			get => GetProperty(ref _smoothStep);
			set => SetProperty(ref _smoothStep, value);
		}

		[Ordinal(20)] 
		[RED("offset")] 
		public CFloat Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(21)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		[Ordinal(22)] 
		[RED("transformOutputs")] 
		public CArray<animSimpleBounceTransformOutput> TransformOutputs
		{
			get => GetProperty(ref _transformOutputs);
			set => SetProperty(ref _transformOutputs, value);
		}

		[Ordinal(23)] 
		[RED("trackOutputs")] 
		public CArray<animSimpleBounceTrackOutput> TrackOutputs
		{
			get => GetProperty(ref _trackOutputs);
			set => SetProperty(ref _trackOutputs, value);
		}

		public animAnimNode_SimpleBounce(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
