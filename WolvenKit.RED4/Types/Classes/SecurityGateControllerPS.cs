using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityGateControllerPS : MasterControllerPS
	{
		[Ordinal(108)] 
		[RED("securityGateDetectionProperties")] 
		public SecurityGateDetectionProperties SecurityGateDetectionProperties
		{
			get => GetPropertyValue<SecurityGateDetectionProperties>();
			set => SetPropertyValue<SecurityGateDetectionProperties>(value);
		}

		[Ordinal(109)] 
		[RED("securityGateResponseProperties")] 
		public SecurityGateResponseProperties SecurityGateResponseProperties
		{
			get => GetPropertyValue<SecurityGateResponseProperties>();
			set => SetPropertyValue<SecurityGateResponseProperties>(value);
		}

		[Ordinal(110)] 
		[RED("securityGateStatus")] 
		public CEnum<ESecurityGateStatus> SecurityGateStatus
		{
			get => GetPropertyValue<CEnum<ESecurityGateStatus>>();
			set => SetPropertyValue<CEnum<ESecurityGateStatus>>(value);
		}

		[Ordinal(111)] 
		[RED("trespassersDataList")] 
		public CArray<TrespasserEntry> TrespassersDataList
		{
			get => GetPropertyValue<CArray<TrespasserEntry>>();
			set => SetPropertyValue<CArray<TrespasserEntry>>(value);
		}

		public SecurityGateControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
