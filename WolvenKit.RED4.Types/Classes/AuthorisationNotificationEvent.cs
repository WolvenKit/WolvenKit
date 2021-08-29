using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AuthorisationNotificationEvent : redEvent
	{
		private CEnum<gameuiAuthorisationNotificationType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameuiAuthorisationNotificationType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
