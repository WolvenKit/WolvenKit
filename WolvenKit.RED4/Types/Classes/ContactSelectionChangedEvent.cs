using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ContactSelectionChangedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("ContactData")] 
		public CWeakHandle<ContactData> ContactData
		{
			get => GetPropertyValue<CWeakHandle<ContactData>>();
			set => SetPropertyValue<CWeakHandle<ContactData>>(value);
		}

		public ContactSelectionChangedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
