using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatTrackModifier : animAnimNode_Base
	{
		private animNamedTrackIndex _floatTrack;
		private CEnum<animFloatTrackOperationType> _operationType;
		private animNamedTrackIndex _inputFloatTrack;
		private animPoseLink _poseInputNode;
		private animFloatLink _floatInputNode;

		[Ordinal(11)] 
		[RED("floatTrack")] 
		public animNamedTrackIndex FloatTrack
		{
			get => GetProperty(ref _floatTrack);
			set => SetProperty(ref _floatTrack, value);
		}

		[Ordinal(12)] 
		[RED("operationType")] 
		public CEnum<animFloatTrackOperationType> OperationType
		{
			get => GetProperty(ref _operationType);
			set => SetProperty(ref _operationType, value);
		}

		[Ordinal(13)] 
		[RED("inputFloatTrack")] 
		public animNamedTrackIndex InputFloatTrack
		{
			get => GetProperty(ref _inputFloatTrack);
			set => SetProperty(ref _inputFloatTrack, value);
		}

		[Ordinal(14)] 
		[RED("poseInputNode")] 
		public animPoseLink PoseInputNode
		{
			get => GetProperty(ref _poseInputNode);
			set => SetProperty(ref _poseInputNode, value);
		}

		[Ordinal(15)] 
		[RED("floatInputNode")] 
		public animFloatLink FloatInputNode
		{
			get => GetProperty(ref _floatInputNode);
			set => SetProperty(ref _floatInputNode, value);
		}

		public animAnimNode_FloatTrackModifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
