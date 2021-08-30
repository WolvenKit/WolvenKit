using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animLookAtAdditionalPreset_BothArms : animLookAtAdditionalPreset
	{
		private CBool _rightHanded;
		private CFloat _softLimitAngle;

		[Ordinal(0)] 
		[RED("rightHanded")] 
		public CBool RightHanded
		{
			get => GetProperty(ref _rightHanded);
			set => SetProperty(ref _rightHanded, value);
		}

		[Ordinal(1)] 
		[RED("softLimitAngle")] 
		public CFloat SoftLimitAngle
		{
			get => GetProperty(ref _softLimitAngle);
			set => SetProperty(ref _softLimitAngle, value);
		}

		public animLookAtAdditionalPreset_BothArms()
		{
			_rightHanded = true;
			_softLimitAngle = 360.000000F;
		}
	}
}
