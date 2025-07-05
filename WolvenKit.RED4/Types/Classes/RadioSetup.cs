using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadioSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("randomizeStartingStation")] 
		public CBool RandomizeStartingStation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("startingStation")] 
		public CEnum<ERadioStationList> StartingStation
		{
			get => GetPropertyValue<CEnum<ERadioStationList>>();
			set => SetPropertyValue<CEnum<ERadioStationList>>(value);
		}

		[Ordinal(2)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("glitchSFX")] 
		public CName GlitchSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("enableHighPitchNoiseQuickHack")] 
		public CBool EnableHighPitchNoiseQuickHack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("highPitchNoiseSFX")] 
		public CName HighPitchNoiseSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("hithPitchNoiseVFX")] 
		public gameFxResource HithPitchNoiseVFX
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(7)] 
		[RED("hithPitchNoiseRadius")] 
		public CFloat HithPitchNoiseRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("enableAoeDamageQuickHack")] 
		public CBool EnableAoeDamageQuickHack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("AoeDamageSFX")] 
		public CName AoeDamageSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("AoeDamageVFX")] 
		public gameFxResource AoeDamageVFX
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		public RadioSetup()
		{
			HithPitchNoiseVFX = new gameFxResource();
			HithPitchNoiseRadius = 5.000000F;
			AoeDamageVFX = new gameFxResource();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
