using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			Id = 4294967295;
			PoseInputNode = new();
			AdditionalTracks = new() { Entries = new(), OverwriteExistingValues = true };
		}
	}
}
