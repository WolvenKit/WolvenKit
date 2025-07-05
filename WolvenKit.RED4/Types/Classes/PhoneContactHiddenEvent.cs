using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhoneContactHiddenEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("HiddenItem")] 
		public CWeakHandle<inkVirtualCompoundItemController> HiddenItem
		{
			get => GetPropertyValue<CWeakHandle<inkVirtualCompoundItemController>>();
			set => SetPropertyValue<CWeakHandle<inkVirtualCompoundItemController>>(value);
		}

		public PhoneContactHiddenEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
