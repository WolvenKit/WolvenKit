using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_AdditionalFloatTrack : animAnimNode_Base
	{
		private animPoseLink _poseInputNode;
		private animAdditionalFloatTrackContainer _additionalTracks;

		[Ordinal(11)] 
		[RED("poseInputNode")] 
		public animPoseLink PoseInputNode
		{
			get => GetProperty(ref _poseInputNode);
			set => SetProperty(ref _poseInputNode, value);
		}

		[Ordinal(12)] 
		[RED("additionalTracks")] 
		public animAdditionalFloatTrackContainer AdditionalTracks
		{
			get => GetProperty(ref _additionalTracks);
			set => SetProperty(ref _additionalTracks, value);
		}
	}
}
