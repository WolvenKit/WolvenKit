using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CraftingNotificationEvent : redEvent
	{
		private CEnum<CraftingNotificationType> _notificationType;
		private CString _perkName;

		[Ordinal(0)] 
		[RED("notificationType")] 
		public CEnum<CraftingNotificationType> NotificationType
		{
			get => GetProperty(ref _notificationType);
			set => SetProperty(ref _notificationType, value);
		}

		[Ordinal(1)] 
		[RED("perkName")] 
		public CString PerkName
		{
			get => GetProperty(ref _perkName);
			set => SetProperty(ref _perkName, value);
		}
	}
}
