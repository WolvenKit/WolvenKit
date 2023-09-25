using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HackingRewardNotificationEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("text")] 
		public CString Text
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("icons")] 
		public CArray<CString> Icons
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		public HackingRewardNotificationEvent()
		{
			Icons = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
