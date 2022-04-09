using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityGateResponseProperties : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("securityGateResponseType")] 
		public CEnum<ESecurityGateResponseType> SecurityGateResponseType
		{
			get => GetPropertyValue<CEnum<ESecurityGateResponseType>>();
			set => SetPropertyValue<CEnum<ESecurityGateResponseType>>(value);
		}

		[Ordinal(1)] 
		[RED("securityLevelAccessGranted")] 
		public CEnum<ESecurityAccessLevel> SecurityLevelAccessGranted
		{
			get => GetPropertyValue<CEnum<ESecurityAccessLevel>>();
			set => SetPropertyValue<CEnum<ESecurityAccessLevel>>(value);
		}

		public SecurityGateResponseProperties()
		{
			SecurityGateResponseType = Enums.ESecurityGateResponseType.SEC_SYS_REPRIMAND;
			SecurityLevelAccessGranted = Enums.ESecurityAccessLevel.ESL_3;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
