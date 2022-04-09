using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewCodexEntryUserData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("data")] 
		public CString Data
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public NewCodexEntryUserData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
