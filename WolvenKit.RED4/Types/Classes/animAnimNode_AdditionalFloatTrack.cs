using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_AdditionalFloatTrack : animAnimNode_Base
	{
		[Ordinal(1)] 
		[RED("poseInputNode")] 
		public animPoseLink PoseInputNode
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(2)] 
		[RED("additionalTracks")] 
		public animAdditionalFloatTrackContainer AdditionalTracks
		{
			get => GetPropertyValue<animAdditionalFloatTrackContainer>();
			set => SetPropertyValue<animAdditionalFloatTrackContainer>(value);
		}

		public animAnimNode_AdditionalFloatTrack()
		{
			Id = uint.MaxValue;
			PoseInputNode = new animPoseLink();
			AdditionalTracks = new animAdditionalFloatTrackContainer();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
