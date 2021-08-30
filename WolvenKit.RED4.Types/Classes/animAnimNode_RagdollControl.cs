using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_RagdollControl : animAnimNode_Base
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

		public animAnimNode_RagdollControl()
		{
			_inertializationBlendDuration = 1.000000F;
		}
	}
}
