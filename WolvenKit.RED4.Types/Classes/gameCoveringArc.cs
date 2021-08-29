using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCoveringArc : RedBaseClass
	{
		private CFloat _leftAngle;
		private CFloat _rightAngle;
		private CFloat _verticalAngle;

		[Ordinal(0)] 
		[RED("leftAngle")] 
		public CFloat LeftAngle
		{
			get => GetProperty(ref _leftAngle);
			set => SetProperty(ref _leftAngle, value);
		}

		[Ordinal(1)] 
		[RED("rightAngle")] 
		public CFloat RightAngle
		{
			get => GetProperty(ref _rightAngle);
			set => SetProperty(ref _rightAngle, value);
		}

		[Ordinal(2)] 
		[RED("verticalAngle")] 
		public CFloat VerticalAngle
		{
			get => GetProperty(ref _verticalAngle);
			set => SetProperty(ref _verticalAngle, value);
		}
	}
}
