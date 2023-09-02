using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SuspensionLimit : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("constrainedTransform")] 
		public animTransformIndex ConstrainedTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(13)] 
		[RED("radiusTrack")] 
		public animNamedTrackIndex RadiusTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(14)] 
		[RED("deviationTrack")] 
		public animNamedTrackIndex DeviationTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(15)] 
		[RED("axis")] 
		public CEnum<animAxis> Axis
		{
			get => GetPropertyValue<CEnum<animAxis>>();
			set => SetPropertyValue<CEnum<animAxis>>(value);
		}

		public animAnimNode_SuspensionLimit()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			ConstrainedTransform = new animTransformIndex();
			RadiusTrack = new animNamedTrackIndex();
			DeviationTrack = new animNamedTrackIndex();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
