using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioPhysicalObstructionSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("initialAbsorbtion")] 
		public CFloat InitialAbsorbtion
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("absorptionPerMeter")] 
		public CFloat AbsorptionPerMeter
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioPhysicalObstructionSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
