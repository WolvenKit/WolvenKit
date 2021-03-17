using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AdditionalFloatTrack : animAnimNode_Base
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

		public animAnimNode_AdditionalFloatTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
