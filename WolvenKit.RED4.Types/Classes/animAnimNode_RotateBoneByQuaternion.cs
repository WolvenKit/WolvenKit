using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_RotateBoneByQuaternion : animAnimNode_Base
	{
		private animPoseLink _inputNode;
		private animQuaternionLink _quaternionNode;
		private animTransformIndex _bone;
		private CBool _useIncrementalMode;
		private CBool _resetOnActivation;

		[Ordinal(11)] 
		[RED("inputNode")] 
		public animPoseLink InputNode
		{
			get => GetProperty(ref _inputNode);
			set => SetProperty(ref _inputNode, value);
		}

		[Ordinal(12)] 
		[RED("quaternionNode")] 
		public animQuaternionLink QuaternionNode
		{
			get => GetProperty(ref _quaternionNode);
			set => SetProperty(ref _quaternionNode, value);
		}

		[Ordinal(13)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetProperty(ref _bone);
			set => SetProperty(ref _bone, value);
		}

		[Ordinal(14)] 
		[RED("useIncrementalMode")] 
		public CBool UseIncrementalMode
		{
			get => GetProperty(ref _useIncrementalMode);
			set => SetProperty(ref _useIncrementalMode, value);
		}

		[Ordinal(15)] 
		[RED("resetOnActivation")] 
		public CBool ResetOnActivation
		{
			get => GetProperty(ref _resetOnActivation);
			set => SetProperty(ref _resetOnActivation, value);
		}

		public animAnimNode_RotateBoneByQuaternion()
		{
			_resetOnActivation = true;
		}
	}
}
