using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiAuthorisationNotificationViewData : gameuiGenericNotificationViewData
	{
		private CEnum<gameuiAuthorisationNotificationType> _authType;

		[Ordinal(5)] 
		[RED("authType")] 
		public CEnum<gameuiAuthorisationNotificationType> AuthType
		{
			get => GetProperty(ref _authType);
			set => SetProperty(ref _authType, value);
		}
	}
}
