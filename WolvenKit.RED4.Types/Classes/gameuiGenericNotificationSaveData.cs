using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiGenericNotificationSaveData : gameuiBaseUIData
	{
		private CArray<gameuiGenericNotificationData> _notificationsData;

		[Ordinal(1)] 
		[RED("notificationsData")] 
		public CArray<gameuiGenericNotificationData> NotificationsData
		{
			get => GetProperty(ref _notificationsData);
			set => SetProperty(ref _notificationsData, value);
		}
	}
}
