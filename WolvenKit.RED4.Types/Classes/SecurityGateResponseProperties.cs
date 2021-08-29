using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityGateResponseProperties : RedBaseClass
	{
		private CEnum<ESecurityGateResponseType> _securityGateResponseType;
		private CEnum<ESecurityAccessLevel> _securityLevelAccessGranted;

		[Ordinal(0)] 
		[RED("securityGateResponseType")] 
		public CEnum<ESecurityGateResponseType> SecurityGateResponseType
		{
			get => GetProperty(ref _securityGateResponseType);
			set => SetProperty(ref _securityGateResponseType, value);
		}

		[Ordinal(1)] 
		[RED("securityLevelAccessGranted")] 
		public CEnum<ESecurityAccessLevel> SecurityLevelAccessGranted
		{
			get => GetProperty(ref _securityLevelAccessGranted);
			set => SetProperty(ref _securityLevelAccessGranted, value);
		}
	}
}
