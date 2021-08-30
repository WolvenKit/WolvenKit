using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityGateDetectionProperties : RedBaseClass
	{
		private CBool _performWeaponCheck;
		private CBool _performCyberwareCheck;
		private CEnum<ESecurityGateEntranceType> _scannerEntranceType;
		private CBool _performCheckOnPlayerOnly;

		[Ordinal(0)] 
		[RED("performWeaponCheck")] 
		public CBool PerformWeaponCheck
		{
			get => GetProperty(ref _performWeaponCheck);
			set => SetProperty(ref _performWeaponCheck, value);
		}

		[Ordinal(1)] 
		[RED("performCyberwareCheck")] 
		public CBool PerformCyberwareCheck
		{
			get => GetProperty(ref _performCyberwareCheck);
			set => SetProperty(ref _performCyberwareCheck, value);
		}

		[Ordinal(2)] 
		[RED("scannerEntranceType")] 
		public CEnum<ESecurityGateEntranceType> ScannerEntranceType
		{
			get => GetProperty(ref _scannerEntranceType);
			set => SetProperty(ref _scannerEntranceType, value);
		}

		[Ordinal(3)] 
		[RED("performCheckOnPlayerOnly")] 
		public CBool PerformCheckOnPlayerOnly
		{
			get => GetProperty(ref _performCheckOnPlayerOnly);
			set => SetProperty(ref _performCheckOnPlayerOnly, value);
		}

		public SecurityGateDetectionProperties()
		{
			_performWeaponCheck = true;
			_performCheckOnPlayerOnly = true;
		}
	}
}
