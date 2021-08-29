using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityLockerControllerPS : ScriptableDeviceComponentPS
	{
		private SecurityLockerProperties _securityLockerProperties;
		private CBool _isStoringPlayerEquipement;

		[Ordinal(104)] 
		[RED("securityLockerProperties")] 
		public SecurityLockerProperties SecurityLockerProperties
		{
			get => GetProperty(ref _securityLockerProperties);
			set => SetProperty(ref _securityLockerProperties, value);
		}

		[Ordinal(105)] 
		[RED("isStoringPlayerEquipement")] 
		public CBool IsStoringPlayerEquipement
		{
			get => GetProperty(ref _isStoringPlayerEquipement);
			set => SetProperty(ref _isStoringPlayerEquipement, value);
		}
	}
}
