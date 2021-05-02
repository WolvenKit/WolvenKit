using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FuseControllerPS : MasterControllerPS
	{
		private CHandle<DeviceTimeTableManager> _timeTableSetup;
		private CInt32 _maxLightsSwitchedAtOnce;
		private CFloat _timeToNextSwitch;
		private CEnum<ELightSwitchRandomizerType> _lightSwitchRandomizerType;
		private TweakDBID _alternativeNameForON;
		private TweakDBID _alternativeNameForOFF;
		private CBool _isCLSInitialized;

		[Ordinal(104)] 
		[RED("timeTableSetup")] 
		public CHandle<DeviceTimeTableManager> TimeTableSetup
		{
			get => GetProperty(ref _timeTableSetup);
			set => SetProperty(ref _timeTableSetup, value);
		}

		[Ordinal(105)] 
		[RED("maxLightsSwitchedAtOnce")] 
		public CInt32 MaxLightsSwitchedAtOnce
		{
			get => GetProperty(ref _maxLightsSwitchedAtOnce);
			set => SetProperty(ref _maxLightsSwitchedAtOnce, value);
		}

		[Ordinal(106)] 
		[RED("timeToNextSwitch")] 
		public CFloat TimeToNextSwitch
		{
			get => GetProperty(ref _timeToNextSwitch);
			set => SetProperty(ref _timeToNextSwitch, value);
		}

		[Ordinal(107)] 
		[RED("lightSwitchRandomizerType")] 
		public CEnum<ELightSwitchRandomizerType> LightSwitchRandomizerType
		{
			get => GetProperty(ref _lightSwitchRandomizerType);
			set => SetProperty(ref _lightSwitchRandomizerType, value);
		}

		[Ordinal(108)] 
		[RED("alternativeNameForON")] 
		public TweakDBID AlternativeNameForON
		{
			get => GetProperty(ref _alternativeNameForON);
			set => SetProperty(ref _alternativeNameForON, value);
		}

		[Ordinal(109)] 
		[RED("alternativeNameForOFF")] 
		public TweakDBID AlternativeNameForOFF
		{
			get => GetProperty(ref _alternativeNameForOFF);
			set => SetProperty(ref _alternativeNameForOFF, value);
		}

		[Ordinal(110)] 
		[RED("isCLSInitialized")] 
		public CBool IsCLSInitialized
		{
			get => GetProperty(ref _isCLSInitialized);
			set => SetProperty(ref _isCLSInitialized, value);
		}

		public FuseControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
