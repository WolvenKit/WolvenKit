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
			get
			{
				if (_poseInputNode == null)
				{
					_poseInputNode = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "poseInputNode", cr2w, this);
				}
				return _poseInputNode;
			}
			set
			{
				if (_poseInputNode == value)
				{
					return;
				}
				_poseInputNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("additionalTracks")] 
		public animAdditionalFloatTrackContainer AdditionalTracks
		{
			get
			{
				if (_additionalTracks == null)
				{
					_additionalTracks = (animAdditionalFloatTrackContainer) CR2WTypeManager.Create("animAdditionalFloatTrackContainer", "additionalTracks", cr2w, this);
				}
				return _additionalTracks;
			}
			set
			{
				if (_additionalTracks == value)
				{
					return;
				}
				_additionalTracks = value;
				PropertySet(this);
			}
		}

		public animAnimNode_AdditionalFloatTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
