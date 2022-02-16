using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NewAreaDiscoveredUserData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("data")] 
		public CString Data
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
