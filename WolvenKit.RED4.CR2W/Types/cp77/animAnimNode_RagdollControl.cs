using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_RagdollControl : animAnimNode_Base
	{
		private CBool _canRequestInertialization;
		private CFloat _inertializationBlendDuration;
		private animPoseLink _inputPoseNode;

		[Ordinal(11)] 
		[RED("canRequestInertialization")] 
		public CBool CanRequestInertialization
		{
			get => GetProperty(ref _canRequestInertialization);
			set => SetProperty(ref _canRequestInertialization, value);
		}

		[Ordinal(12)] 
		[RED("inertializationBlendDuration")] 
		public CFloat InertializationBlendDuration
		{
			get => GetProperty(ref _inertializationBlendDuration);
			set => SetProperty(ref _inertializationBlendDuration, value);
		}

		[Ordinal(13)] 
		[RED("inputPoseNode")] 
		public animPoseLink InputPoseNode
		{
			get => GetProperty(ref _inputPoseNode);
			set => SetProperty(ref _inputPoseNode, value);
		}

		public animAnimNode_RagdollControl(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
