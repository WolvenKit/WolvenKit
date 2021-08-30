using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_LookAt : animAnimNode_OnePoseInput
	{
		private animTransformIndex _transform;
		private CEnum<animAxis> _forwardAxis;
		private CBool _useLimits;
		private CEnum<animAxis> _limitAxis;
		private CFloat _limitAngle;
		private animVectorLink _targetNode;
		private animFloatLink _weightNode;

		[Ordinal(12)] 
		[RED("transform")] 
		public animTransformIndex Transform
		{
			get => GetProperty(ref _transform);
			set => SetProperty(ref _transform, value);
		}

		[Ordinal(13)] 
		[RED("forwardAxis")] 
		public CEnum<animAxis> ForwardAxis
		{
			get => GetProperty(ref _forwardAxis);
			set => SetProperty(ref _forwardAxis, value);
		}

		[Ordinal(14)] 
		[RED("useLimits")] 
		public CBool UseLimits
		{
			get => GetProperty(ref _useLimits);
			set => SetProperty(ref _useLimits, value);
		}

		[Ordinal(15)] 
		[RED("limitAxis")] 
		public CEnum<animAxis> LimitAxis
		{
			get => GetProperty(ref _limitAxis);
			set => SetProperty(ref _limitAxis, value);
		}

		[Ordinal(16)] 
		[RED("limitAngle")] 
		public CFloat LimitAngle
		{
			get => GetProperty(ref _limitAngle);
			set => SetProperty(ref _limitAngle, value);
		}

		[Ordinal(17)] 
		[RED("targetNode")] 
		public animVectorLink TargetNode
		{
			get => GetProperty(ref _targetNode);
			set => SetProperty(ref _targetNode, value);
		}

		[Ordinal(18)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetProperty(ref _weightNode);
			set => SetProperty(ref _weightNode, value);
		}

		public animAnimNode_LookAt()
		{
			_limitAngle = 90.000000F;
		}
	}
}
