using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_AdditionalFloatTrack : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("poseInputNode")] 
		public animPoseLink PoseInputNode
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(12)] 
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
			AdditionalTracks = new animAdditionalFloatTrackContainer { Entries = new(), OverwriteExistingValues = true };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
