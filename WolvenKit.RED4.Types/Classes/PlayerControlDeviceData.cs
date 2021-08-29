using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerControlDeviceData : RedBaseClass
	{
		private CFloat _currentYawModifier;
		private CFloat _currentPitchModifier;

		[Ordinal(0)] 
		[RED("currentYawModifier")] 
		public CFloat CurrentYawModifier
		{
			get => GetProperty(ref _currentYawModifier);
			set => SetProperty(ref _currentYawModifier, value);
		}

		[Ordinal(1)] 
		[RED("currentPitchModifier")] 
		public CFloat CurrentPitchModifier
		{
			get => GetProperty(ref _currentPitchModifier);
			set => SetProperty(ref _currentPitchModifier, value);
		}
	}
}
