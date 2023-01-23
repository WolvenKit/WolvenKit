using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioNpcGunChoirVoice : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("fireSound")] 
		public CName FireSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("burstFireSound")] 
		public CName BurstFireSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("chargedSound")] 
		public CName ChargedSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("autoFireSound")] 
		public CName AutoFireSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("autoFireStop")] 
		public CName AutoFireStop
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("shutdown")] 
		public CName Shutdown
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("init")] 
		public CName Init
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioNpcGunChoirVoice()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
