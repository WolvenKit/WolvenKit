using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ZoneAlertNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] 
		[RED("canBeMerged")] 
		public CBool CanBeMerged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("securityZoneData")] 
		public CEnum<ESecurityAreaType> SecurityZoneData
		{
			get => GetPropertyValue<CEnum<ESecurityAreaType>>();
			set => SetPropertyValue<CEnum<ESecurityAreaType>>(value);
		}

		public ZoneAlertNotificationViewData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
