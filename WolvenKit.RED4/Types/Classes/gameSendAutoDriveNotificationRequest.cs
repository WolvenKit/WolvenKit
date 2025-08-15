using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSendAutoDriveNotificationRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("locKey")] 
		public CString LocKey
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("isDelamain")] 
		public CBool IsDelamain
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameSendAutoDriveNotificationRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
