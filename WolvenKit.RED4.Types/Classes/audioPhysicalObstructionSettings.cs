using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioPhysicalObstructionSettings : audioAudioMetadata
	{
		private CFloat _initialAbsorbtion;
		private CFloat _absorptionPerMeter;

		[Ordinal(1)] 
		[RED("initialAbsorbtion")] 
		public CFloat InitialAbsorbtion
		{
			get => GetProperty(ref _initialAbsorbtion);
			set => SetProperty(ref _initialAbsorbtion, value);
		}

		[Ordinal(2)] 
		[RED("absorptionPerMeter")] 
		public CFloat AbsorptionPerMeter
		{
			get => GetProperty(ref _absorptionPerMeter);
			set => SetProperty(ref _absorptionPerMeter, value);
		}
	}
}
