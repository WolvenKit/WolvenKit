using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityGateDetectionProperties : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("performWeaponCheck")] 
		public CBool PerformWeaponCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("performCyberwareCheck")] 
		public CBool PerformCyberwareCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("scannerEntranceType")] 
		public CEnum<ESecurityGateEntranceType> ScannerEntranceType
		{
			get => GetPropertyValue<CEnum<ESecurityGateEntranceType>>();
			set => SetPropertyValue<CEnum<ESecurityGateEntranceType>>(value);
		}

		[Ordinal(3)] 
		[RED("performCheckOnPlayerOnly")] 
		public CBool PerformCheckOnPlayerOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SecurityGateDetectionProperties()
		{
			PerformWeaponCheck = true;
			PerformCheckOnPlayerOnly = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
