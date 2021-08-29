using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SimpleSpline : animAnimNode_OnePoseInput
	{
		private CBool _areSourceChannelsResaved;
		private animTransformIndex _startTransform;
		private animTransformIndex _middleTransform;
		private animTransformIndex _endTransform;
		private animTransformIndex _constrainedTransform;
		private CEnum<animConstraintWeightMode> _progressMode;
		private CFloat _defaultProgress;
		private animNamedTrackIndex _progressTrack;

		[Ordinal(12)] 
		[RED("areSourceChannelsResaved")] 
		public CBool AreSourceChannelsResaved
		{
			get => GetProperty(ref _areSourceChannelsResaved);
			set => SetProperty(ref _areSourceChannelsResaved, value);
		}

		[Ordinal(13)] 
		[RED("startTransform")] 
		public animTransformIndex StartTransform
		{
			get => GetProperty(ref _startTransform);
			set => SetProperty(ref _startTransform, value);
		}

		[Ordinal(14)] 
		[RED("middleTransform")] 
		public animTransformIndex MiddleTransform
		{
			get => GetProperty(ref _middleTransform);
			set => SetProperty(ref _middleTransform, value);
		}

		[Ordinal(15)] 
		[RED("endTransform")] 
		public animTransformIndex EndTransform
		{
			get => GetProperty(ref _endTransform);
			set => SetProperty(ref _endTransform, value);
		}

		[Ordinal(16)] 
		[RED("constrainedTransform")] 
		public animTransformIndex ConstrainedTransform
		{
			get => GetProperty(ref _constrainedTransform);
			set => SetProperty(ref _constrainedTransform, value);
		}

		[Ordinal(17)] 
		[RED("progressMode")] 
		public CEnum<animConstraintWeightMode> ProgressMode
		{
			get => GetProperty(ref _progressMode);
			set => SetProperty(ref _progressMode, value);
		}

		[Ordinal(18)] 
		[RED("defaultProgress")] 
		public CFloat DefaultProgress
		{
			get => GetProperty(ref _defaultProgress);
			set => SetProperty(ref _defaultProgress, value);
		}

		[Ordinal(19)] 
		[RED("progressTrack")] 
		public animNamedTrackIndex ProgressTrack
		{
			get => GetProperty(ref _progressTrack);
			set => SetProperty(ref _progressTrack, value);
		}
	}
}
