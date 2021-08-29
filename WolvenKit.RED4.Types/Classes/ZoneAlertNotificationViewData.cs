using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ZoneAlertNotificationViewData : gameuiGenericNotificationViewData
	{
		private CBool _canBeMerged;
		private CEnum<ESecurityAreaType> _securityZoneData;

		[Ordinal(5)] 
		[RED("canBeMerged")] 
		public CBool CanBeMerged
		{
			get => GetProperty(ref _canBeMerged);
			set => SetProperty(ref _canBeMerged, value);
		}

		[Ordinal(6)] 
		[RED("securityZoneData")] 
		public CEnum<ESecurityAreaType> SecurityZoneData
		{
			get => GetProperty(ref _securityZoneData);
			set => SetProperty(ref _securityZoneData, value);
		}
	}
}
