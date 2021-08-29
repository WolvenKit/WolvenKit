using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_TransformRotator : animAnimNode_OnePoseInput
	{
		private animTransformIndex _transform;
		private Vector3 _axis;
		private CFloat _valueScale;
		private CBool _clamp;
		private CFloat _angleMin;
		private CFloat _angleMax;
		private animFloatLink _angleValueNode;
		private animFloatLink _angleSpeedNode;

		[Ordinal(12)] 
		[RED("transform")] 
		public animTransformIndex Transform
		{
			get => GetProperty(ref _transform);
			set => SetProperty(ref _transform, value);
		}

		[Ordinal(13)] 
		[RED("axis")] 
		public Vector3 Axis
		{
			get => GetProperty(ref _axis);
			set => SetProperty(ref _axis, value);
		}

		[Ordinal(14)] 
		[RED("valueScale")] 
		public CFloat ValueScale
		{
			get => GetProperty(ref _valueScale);
			set => SetProperty(ref _valueScale, value);
		}

		[Ordinal(15)] 
		[RED("clamp")] 
		public CBool Clamp
		{
			get => GetProperty(ref _clamp);
			set => SetProperty(ref _clamp, value);
		}

		[Ordinal(16)] 
		[RED("angleMin")] 
		public CFloat AngleMin
		{
			get => GetProperty(ref _angleMin);
			set => SetProperty(ref _angleMin, value);
		}

		[Ordinal(17)] 
		[RED("angleMax")] 
		public CFloat AngleMax
		{
			get => GetProperty(ref _angleMax);
			set => SetProperty(ref _angleMax, value);
		}

		[Ordinal(18)] 
		[RED("angleValueNode")] 
		public animFloatLink AngleValueNode
		{
			get => GetProperty(ref _angleValueNode);
			set => SetProperty(ref _angleValueNode, value);
		}

		[Ordinal(19)] 
		[RED("angleSpeedNode")] 
		public animFloatLink AngleSpeedNode
		{
			get => GetProperty(ref _angleSpeedNode);
			set => SetProperty(ref _angleSpeedNode, value);
		}
	}
}
