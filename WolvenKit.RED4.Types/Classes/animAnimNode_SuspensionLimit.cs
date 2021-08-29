using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SuspensionLimit : animAnimNode_OnePoseInput
	{
		private animTransformIndex _constrainedTransform;
		private animNamedTrackIndex _radiusTrack;
		private animNamedTrackIndex _deviationTrack;
		private CEnum<animAxis> _axis;

		[Ordinal(12)] 
		[RED("constrainedTransform")] 
		public animTransformIndex ConstrainedTransform
		{
			get => GetProperty(ref _constrainedTransform);
			set => SetProperty(ref _constrainedTransform, value);
		}

		[Ordinal(13)] 
		[RED("radiusTrack")] 
		public animNamedTrackIndex RadiusTrack
		{
			get => GetProperty(ref _radiusTrack);
			set => SetProperty(ref _radiusTrack, value);
		}

		[Ordinal(14)] 
		[RED("deviationTrack")] 
		public animNamedTrackIndex DeviationTrack
		{
			get => GetProperty(ref _deviationTrack);
			set => SetProperty(ref _deviationTrack, value);
		}

		[Ordinal(15)] 
		[RED("axis")] 
		public CEnum<animAxis> Axis
		{
			get => GetProperty(ref _axis);
			set => SetProperty(ref _axis, value);
		}
	}
}
