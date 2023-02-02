using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCustomQuestNotificationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("header")] 
		public CString Header
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("desc")] 
		public CString Desc
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public CName Icon
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("fluffHeader")] 
		public CString FluffHeader
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public questCustomQuestNotificationData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
