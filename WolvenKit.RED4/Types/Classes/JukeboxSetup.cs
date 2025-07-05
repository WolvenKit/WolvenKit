using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class JukeboxSetup : RedBaseClass
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
		[RED("glitchSFX")] 
		public CName GlitchSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("paymentRecordID")] 
		public TweakDBID PaymentRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public JukeboxSetup()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
