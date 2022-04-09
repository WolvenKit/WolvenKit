using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CraftingNotificationEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("notificationType")] 
		public CEnum<CraftingNotificationType> NotificationType
		{
			get => GetPropertyValue<CEnum<CraftingNotificationType>>();
			set => SetPropertyValue<CEnum<CraftingNotificationType>>(value);
		}

		[Ordinal(1)] 
		[RED("perkName")] 
		public CString PerkName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public CraftingNotificationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
