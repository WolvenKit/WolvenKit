using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OpenPhoneMessageAction : GenericNotificationBaseAction
	{
		[Ordinal(0)] 
		[RED("phoneSystem")] 
		public CWeakHandle<PhoneSystem> PhoneSystem
		{
			get => GetPropertyValue<CWeakHandle<PhoneSystem>>();
			set => SetPropertyValue<CWeakHandle<PhoneSystem>>(value);
		}

		[Ordinal(1)] 
		[RED("journalEntry")] 
		public CWeakHandle<gameJournalEntry> JournalEntry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalEntry>>();
			set => SetPropertyValue<CWeakHandle<gameJournalEntry>>(value);
		}

		public OpenPhoneMessageAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
