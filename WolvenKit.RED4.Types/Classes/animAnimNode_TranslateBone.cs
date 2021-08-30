using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_TranslateBone : animAnimNode_Base
	{
		private animPoseLink _inputNode;
		private animVectorLink _inputTranslation;
		private Vector4 _scale;
		private Vector4 _biasValue;
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
		[RED("inputTranslation")] 
		public animVectorLink InputTranslation
		{
			get => GetProperty(ref _inputTranslation);
			set => SetProperty(ref _inputTranslation, value);
		}

		[Ordinal(13)] 
		[RED("scale")] 
		public Vector4 Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(14)] 
		[RED("biasValue")] 
		public Vector4 BiasValue
		{
			get => GetProperty(ref _biasValue);
			set => SetProperty(ref _biasValue, value);
		}

		[Ordinal(15)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetProperty(ref _bone);
			set => SetProperty(ref _bone, value);
		}

		[Ordinal(16)] 
		[RED("useIncrementalMode")] 
		public CBool UseIncrementalMode
		{
			get => GetProperty(ref _useIncrementalMode);
			set => SetProperty(ref _useIncrementalMode, value);
		}

		[Ordinal(17)] 
		[RED("resetOnActivation")] 
		public CBool ResetOnActivation
		{
			get => GetProperty(ref _resetOnActivation);
			set => SetProperty(ref _resetOnActivation, value);
		}

		public animAnimNode_TranslateBone()
		{
			_resetOnActivation = true;
		}
	}
}
