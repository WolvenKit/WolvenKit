using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FuseControllerPS : MasterControllerPS
	{
		private CHandle<DeviceTimeTableManager> _timeTableSetup;
		private CInt32 _maxLightsSwitchedAtOnce;
		private CFloat _timeToNextSwitch;
		private CEnum<ELightSwitchRandomizerType> _lightSwitchRandomizerType;
		private TweakDBID _alternativeNameForON;
		private TweakDBID _alternativeNameForOFF;
		private CBool _isCLSInitialized;

		[Ordinal(105)] 
		[RED("timeTableSetup")] 
		public CHandle<DeviceTimeTableManager> TimeTableSetup
		{
			get => GetProperty(ref _timeTableSetup);
			set => SetProperty(ref _timeTableSetup, value);
		}

		[Ordinal(106)] 
		[RED("maxLightsSwitchedAtOnce")] 
		public CInt32 MaxLightsSwitchedAtOnce
		{
			get => GetProperty(ref _maxLightsSwitchedAtOnce);
			set => SetProperty(ref _maxLightsSwitchedAtOnce, value);
		}

		[Ordinal(107)] 
		[RED("timeToNextSwitch")] 
		public CFloat TimeToNextSwitch
		{
			get => GetProperty(ref _timeToNextSwitch);
			set => SetProperty(ref _timeToNextSwitch, value);
		}

		[Ordinal(108)] 
		[RED("lightSwitchRandomizerType")] 
		public CEnum<ELightSwitchRandomizerType> LightSwitchRandomizerType
		{
			get => GetProperty(ref _lightSwitchRandomizerType);
			set => SetProperty(ref _lightSwitchRandomizerType, value);
		}

		[Ordinal(109)] 
		[RED("alternativeNameForON")] 
		public TweakDBID AlternativeNameForON
		{
			get => GetProperty(ref _alternativeNameForON);
			set => SetProperty(ref _alternativeNameForON, value);
		}

		[Ordinal(110)] 
		[RED("alternativeNameForOFF")] 
		public TweakDBID AlternativeNameForOFF
		{
			get => GetProperty(ref _alternativeNameForOFF);
			set => SetProperty(ref _alternativeNameForOFF, value);
		}

		[Ordinal(111)] 
		[RED("isCLSInitialized")] 
		public CBool IsCLSInitialized
		{
			get => GetProperty(ref _isCLSInitialized);
			set => SetProperty(ref _isCLSInitialized, value);
		}

		public FuseControllerPS()
		{
			_maxLightsSwitchedAtOnce = 5;
			_timeToNextSwitch = 1.000000F;
			_lightSwitchRandomizerType = new() { Value = Enums.ELightSwitchRandomizerType.RANDOM_PROGRESSIVE };
		}
	}
}
