using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_LookAtPose360 : animAnimNode_Base
	{
		private CFloat _speedInDegreesPerSecond;
		private animFloatLink _angleOffsetNode;
		private animFloatLink _targetAngleOffsetNode;
		private CName _animation;
		private CFloat _durationCut;

		[Ordinal(11)] 
		[RED("speedInDegreesPerSecond")] 
		public CFloat SpeedInDegreesPerSecond
		{
			get => GetProperty(ref _speedInDegreesPerSecond);
			set => SetProperty(ref _speedInDegreesPerSecond, value);
		}

		[Ordinal(12)] 
		[RED("angleOffsetNode")] 
		public animFloatLink AngleOffsetNode
		{
			get => GetProperty(ref _angleOffsetNode);
			set => SetProperty(ref _angleOffsetNode, value);
		}

		[Ordinal(13)] 
		[RED("targetAngleOffsetNode")] 
		public animFloatLink TargetAngleOffsetNode
		{
			get => GetProperty(ref _targetAngleOffsetNode);
			set => SetProperty(ref _targetAngleOffsetNode, value);
		}

		[Ordinal(14)] 
		[RED("animation")] 
		public CName Animation
		{
			get => GetProperty(ref _animation);
			set => SetProperty(ref _animation, value);
		}

		[Ordinal(15)] 
		[RED("durationCut")] 
		public CFloat DurationCut
		{
			get => GetProperty(ref _durationCut);
			set => SetProperty(ref _durationCut, value);
		}
	}
}
