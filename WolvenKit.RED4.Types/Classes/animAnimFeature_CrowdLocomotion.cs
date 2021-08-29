using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_CrowdLocomotion : animAnimFeature
	{
		private CFloat _speed;
		private CFloat _slopeAngle;
		private CBool _isCrowd;

		[Ordinal(0)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(1)] 
		[RED("slopeAngle")] 
		public CFloat SlopeAngle
		{
			get => GetProperty(ref _slopeAngle);
			set => SetProperty(ref _slopeAngle, value);
		}

		[Ordinal(2)] 
		[RED("isCrowd")] 
		public CBool IsCrowd
		{
			get => GetProperty(ref _isCrowd);
			set => SetProperty(ref _isCrowd, value);
		}
	}
}
