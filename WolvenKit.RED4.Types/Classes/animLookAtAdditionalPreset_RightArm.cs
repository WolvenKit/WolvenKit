using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animLookAtAdditionalPreset_RightArm : animLookAtAdditionalPreset
	{
		private CBool _isAiming;
		private CFloat _softLimitAngle;

		[Ordinal(0)] 
		[RED("isAiming")] 
		public CBool IsAiming
		{
			get => GetProperty(ref _isAiming);
			set => SetProperty(ref _isAiming, value);
		}

		[Ordinal(1)] 
		[RED("softLimitAngle")] 
		public CFloat SoftLimitAngle
		{
			get => GetProperty(ref _softLimitAngle);
			set => SetProperty(ref _softLimitAngle, value);
		}

		public animLookAtAdditionalPreset_RightArm()
		{
			_softLimitAngle = 360.000000F;
		}
	}
}
