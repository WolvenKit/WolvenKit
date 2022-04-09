using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityAlarmControllerPS : MasterControllerPS
	{
		[Ordinal(105)] 
		[RED("securityAlarmSetup")] 
		public SecurityAlarmSetup SecurityAlarmSetup
		{
			get => GetPropertyValue<SecurityAlarmSetup>();
			set => SetPropertyValue<SecurityAlarmSetup>(value);
		}

		[Ordinal(106)] 
		[RED("securityAlarmState")] 
		public CEnum<ESecuritySystemState> SecurityAlarmState
		{
			get => GetPropertyValue<CEnum<ESecuritySystemState>>();
			set => SetPropertyValue<CEnum<ESecuritySystemState>>(value);
		}

		public SecurityAlarmControllerPS()
		{
			DeviceName = "LocKey#109";
			TweakDBRecord = 92888207289;
			TweakDBDescriptionRecord = 144117121652;
			SecurityAlarmSetup = new();
			SecurityAlarmState = Enums.ESecuritySystemState.SAFE;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
