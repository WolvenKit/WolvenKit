using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CustomNotificationEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("header")] 
		public CString Header
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("description")] 
		public CString Description
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
		[RED("fluff_header")] 
		public CString Fluff_header
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public CustomNotificationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
