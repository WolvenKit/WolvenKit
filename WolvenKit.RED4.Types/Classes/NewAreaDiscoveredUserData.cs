using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewAreaDiscoveredUserData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("data")] 
		public CString Data
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public NewAreaDiscoveredUserData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
