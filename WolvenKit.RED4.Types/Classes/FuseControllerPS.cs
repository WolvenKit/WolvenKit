using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FuseControllerPS : MasterControllerPS
	{
		[Ordinal(105)] 
		[RED("timeTableSetup")] 
		public CHandle<DeviceTimeTableManager> TimeTableSetup
		{
			get => GetPropertyValue<CHandle<DeviceTimeTableManager>>();
			set => SetPropertyValue<CHandle<DeviceTimeTableManager>>(value);
		}

		[Ordinal(106)] 
		[RED("maxLightsSwitchedAtOnce")] 
		public CInt32 MaxLightsSwitchedAtOnce
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(107)] 
		[RED("timeToNextSwitch")] 
		public CFloat TimeToNextSwitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(108)] 
		[RED("lightSwitchRandomizerType")] 
		public CEnum<ELightSwitchRandomizerType> LightSwitchRandomizerType
		{
			get => GetPropertyValue<CEnum<ELightSwitchRandomizerType>>();
			set => SetPropertyValue<CEnum<ELightSwitchRandomizerType>>(value);
		}

		[Ordinal(109)] 
		[RED("alternativeNameForON")] 
		public TweakDBID AlternativeNameForON
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(110)] 
		[RED("alternativeNameForOFF")] 
		public TweakDBID AlternativeNameForOFF
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(111)] 
		[RED("alternativeNameForPower")] 
		public TweakDBID AlternativeNameForPower
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(112)] 
		[RED("alternativeNameForUnpower")] 
		public TweakDBID AlternativeNameForUnpower
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(113)] 
		[RED("isCLSInitialized")] 
		public CBool IsCLSInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public FuseControllerPS()
		{
			RevealDevicesGrid = false;
			DeviceName = "LocKey#116";
			TweakDBRecord = new() { Value = 54819981842 };
			TweakDBDescriptionRecord = new() { Value = 106150556616 };
			MaxLightsSwitchedAtOnce = 5;
			TimeToNextSwitch = 1.000000F;
			LightSwitchRandomizerType = Enums.ELightSwitchRandomizerType.RANDOM_PROGRESSIVE;
		}
	}
}
