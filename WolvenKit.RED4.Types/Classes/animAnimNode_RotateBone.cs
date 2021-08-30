using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_RotateBone : animAnimNode_Base
	{
		private animPoseLink _inputNode;
		private animFloatLink _angleNode;
		private animFloatLink _minValueNode;
		private animFloatLink _maxValueNode;
		private animTransformIndex _bone;
		private CEnum<animETransformAxis> _axis;
		private CFloat _scale;
		private CFloat _biasAngle;
		private CFloat _minAngle;
		private CFloat _maxAngle;
		private CBool _clampRotation;
		private CBool _useIncrementalMode;
		private CBool _resetOnActivation;
		private CBool _inModelSpace;

		[Ordinal(11)] 
		[RED("inputNode")] 
		public animPoseLink InputNode
		{
			get => GetProperty(ref _inputNode);
			set => SetProperty(ref _inputNode, value);
		}

		[Ordinal(12)] 
		[RED("angleNode")] 
		public animFloatLink AngleNode
		{
			get => GetProperty(ref _angleNode);
			set => SetProperty(ref _angleNode, value);
		}

		[Ordinal(13)] 
		[RED("minValueNode")] 
		public animFloatLink MinValueNode
		{
			get => GetProperty(ref _minValueNode);
			set => SetProperty(ref _minValueNode, value);
		}

		[Ordinal(14)] 
		[RED("maxValueNode")] 
		public animFloatLink MaxValueNode
		{
			get => GetProperty(ref _maxValueNode);
			set => SetProperty(ref _maxValueNode, value);
		}

		[Ordinal(15)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetProperty(ref _bone);
			set => SetProperty(ref _bone, value);
		}

		[Ordinal(16)] 
		[RED("axis")] 
		public CEnum<animETransformAxis> Axis
		{
			get => GetProperty(ref _axis);
			set => SetProperty(ref _axis, value);
		}

		[Ordinal(17)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(18)] 
		[RED("biasAngle")] 
		public CFloat BiasAngle
		{
			get => GetProperty(ref _biasAngle);
			set => SetProperty(ref _biasAngle, value);
		}

		[Ordinal(19)] 
		[RED("minAngle")] 
		public CFloat MinAngle
		{
			get => GetProperty(ref _minAngle);
			set => SetProperty(ref _minAngle, value);
		}

		[Ordinal(20)] 
		[RED("maxAngle")] 
		public CFloat MaxAngle
		{
			get => GetProperty(ref _maxAngle);
			set => SetProperty(ref _maxAngle, value);
		}

		[Ordinal(21)] 
		[RED("clampRotation")] 
		public CBool ClampRotation
		{
			get => GetProperty(ref _clampRotation);
			set => SetProperty(ref _clampRotation, value);
		}

		[Ordinal(22)] 
		[RED("useIncrementalMode")] 
		public CBool UseIncrementalMode
		{
			get => GetProperty(ref _useIncrementalMode);
			set => SetProperty(ref _useIncrementalMode, value);
		}

		[Ordinal(23)] 
		[RED("resetOnActivation")] 
		public CBool ResetOnActivation
		{
			get => GetProperty(ref _resetOnActivation);
			set => SetProperty(ref _resetOnActivation, value);
		}

		[Ordinal(24)] 
		[RED("inModelSpace")] 
		public CBool InModelSpace
		{
			get => GetProperty(ref _inModelSpace);
			set => SetProperty(ref _inModelSpace, value);
		}

		public animAnimNode_RotateBone()
		{
			_axis = new() { Value = Enums.animETransformAxis.X_Axis };
			_scale = 1.000000F;
			_minAngle = -90.000000F;
			_maxAngle = 90.000000F;
			_resetOnActivation = true;
		}
	}
}
