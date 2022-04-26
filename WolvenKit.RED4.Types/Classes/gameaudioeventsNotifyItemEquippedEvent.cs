using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameaudioeventsNotifyItemEquippedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("itemName")] 
		public CName ItemName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameaudioeventsNotifyItemEquippedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
