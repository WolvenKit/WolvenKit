using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiAuthorisationNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] 
		[RED("authType")] 
		public CEnum<gameuiAuthorisationNotificationType> AuthType
		{
			get => GetPropertyValue<CEnum<gameuiAuthorisationNotificationType>>();
			set => SetPropertyValue<CEnum<gameuiAuthorisationNotificationType>>(value);
		}
	}
}
