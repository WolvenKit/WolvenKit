using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BlindingLightControllerPS : BasicDistractionDeviceControllerPS
	{
		private ReflectorSFX _reflectorSFX;

		[Ordinal(109)] 
		[RED("reflectorSFX")] 
		public ReflectorSFX ReflectorSFX
		{
			get => GetProperty(ref _reflectorSFX);
			set => SetProperty(ref _reflectorSFX, value);
		}
	}
}
