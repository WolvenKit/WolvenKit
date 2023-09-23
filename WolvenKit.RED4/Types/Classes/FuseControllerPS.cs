using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FuseControllerPS : MasterControllerPS
	{
		[Ordinal(108)] 
		[RED("timeTableSetup")] 
		public CHandle<DeviceTimeTableManager> TimeTableSetup
		{
			get => GetPropertyValue<CHandle<DeviceTimeTableManager>>();
			set => SetPropertyValue<CHandle<DeviceTimeTableManager>>(value);
		}

		[Ordinal(109)] 
		[RED("maxLightsSwitchedAtOnce")] 
		public CInt32 MaxLightsSwitchedAtOnce
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(110)] 
		[RED("timeToNextSwitch")] 
		public CFloat TimeToNextSwitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(111)] 
		[RED("lightSwitchRandomizerType")] 
		public CEnum<ELightSwitchRandomizerType> LightSwitchRandomizerType
		{
			get => GetPropertyValue<CEnum<ELightSwitchRandomizerType>>();
			set => SetPropertyValue<CEnum<ELightSwitchRandomizerType>>(value);
		}

		[Ordinal(112)] 
		[RED("alternativeNameForON")] 
		public TweakDBID AlternativeNameForON
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(113)] 
		[RED("alternativeNameForOFF")] 
		public TweakDBID AlternativeNameForOFF
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(114)] 
		[RED("alternativeNameForPower")] 
		public TweakDBID AlternativeNameForPower
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(115)] 
		[RED("alternativeNameForUnpower")] 
		public TweakDBID AlternativeNameForUnpower
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(116)] 
		[RED("isCLSInitialized")] 
		public CBool IsCLSInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public FuseControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
