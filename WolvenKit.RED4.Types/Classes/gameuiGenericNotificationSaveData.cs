using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiGenericNotificationSaveData : gameuiBaseUIData
	{
		[Ordinal(1)] 
		[RED("notificationsData")] 
		public CArray<gameuiGenericNotificationData> NotificationsData
		{
			get => GetPropertyValue<CArray<gameuiGenericNotificationData>>();
			set => SetPropertyValue<CArray<gameuiGenericNotificationData>>(value);
		}

		public gameuiGenericNotificationSaveData()
		{
			NotificationsData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
