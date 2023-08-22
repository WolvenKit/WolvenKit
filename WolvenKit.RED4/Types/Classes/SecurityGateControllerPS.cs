using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityGateControllerPS : MasterControllerPS
	{
		[Ordinal(105)] 
		[RED("securityGateDetectionProperties")] 
		public SecurityGateDetectionProperties SecurityGateDetectionProperties
		{
			get => GetPropertyValue<SecurityGateDetectionProperties>();
			set => SetPropertyValue<SecurityGateDetectionProperties>(value);
		}

		[Ordinal(106)] 
		[RED("securityGateResponseProperties")] 
		public SecurityGateResponseProperties SecurityGateResponseProperties
		{
			get => GetPropertyValue<SecurityGateResponseProperties>();
			set => SetPropertyValue<SecurityGateResponseProperties>(value);
		}

		[Ordinal(107)] 
		[RED("securityGateStatus")] 
		public CEnum<ESecurityGateStatus> SecurityGateStatus
		{
			get => GetPropertyValue<CEnum<ESecurityGateStatus>>();
			set => SetPropertyValue<CEnum<ESecurityGateStatus>>(value);
		}

		[Ordinal(108)] 
		[RED("trespassersDataList")] 
		public CArray<TrespasserEntry> TrespassersDataList
		{
			get => GetPropertyValue<CArray<TrespasserEntry>>();
			set => SetPropertyValue<CArray<TrespasserEntry>>(value);
		}

		public SecurityGateControllerPS()
		{
			DeviceName = "Gameplay-Devices-DisplayNames-Terminal";
			SecurityGateDetectionProperties = new SecurityGateDetectionProperties { PerformWeaponCheck = true, PerformCheckOnPlayerOnly = true };
			SecurityGateResponseProperties = new SecurityGateResponseProperties { SecurityGateResponseType = Enums.ESecurityGateResponseType.SEC_SYS_REPRIMAND, SecurityLevelAccessGranted = Enums.ESecurityAccessLevel.ESL_3 };
			TrespassersDataList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
