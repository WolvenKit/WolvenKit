using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HiddenModManagerPopupEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<HiddenModManagerPopupData> Data
		{
			get => GetPropertyValue<CHandle<HiddenModManagerPopupData>>();
			set => SetPropertyValue<CHandle<HiddenModManagerPopupData>>(value);
		}

		public HiddenModManagerPopupEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
