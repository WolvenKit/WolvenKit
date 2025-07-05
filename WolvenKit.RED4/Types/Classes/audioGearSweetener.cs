using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioGearSweetener : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("gear")] 
		public CUInt32 Gear
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("rpmThreshold")] 
		public CFloat RpmThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("soundEvent")] 
		public CName SoundEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("burnoutFactor")] 
		public CFloat BurnoutFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioGearSweetener()
		{
			BurnoutFactor = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
