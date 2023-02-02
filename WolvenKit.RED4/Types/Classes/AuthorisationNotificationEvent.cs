using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AuthorisationNotificationEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameuiAuthorisationNotificationType> Type
		{
			get => GetPropertyValue<CEnum<gameuiAuthorisationNotificationType>>();
			set => SetPropertyValue<CEnum<gameuiAuthorisationNotificationType>>(value);
		}

		public AuthorisationNotificationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
