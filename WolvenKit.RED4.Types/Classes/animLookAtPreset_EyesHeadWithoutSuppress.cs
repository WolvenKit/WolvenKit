using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animLookAtPreset_EyesHeadWithoutSuppress : animLookAtPreset
	{
		private CFloat _headMobility;
		private CFloat _softLimitAngle;

		[Ordinal(0)] 
		[RED("headMobility")] 
		public CFloat HeadMobility
		{
			get => GetProperty(ref _headMobility);
			set => SetProperty(ref _headMobility, value);
		}

		[Ordinal(1)] 
		[RED("softLimitAngle")] 
		public CFloat SoftLimitAngle
		{
			get => GetProperty(ref _softLimitAngle);
			set => SetProperty(ref _softLimitAngle, value);
		}
	}
}
