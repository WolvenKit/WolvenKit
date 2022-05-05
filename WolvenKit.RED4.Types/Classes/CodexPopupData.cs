using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CodexPopupData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("entry")] 
		public CWeakHandle<gameJournalEntry> Entry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalEntry>>();
			set => SetPropertyValue<CWeakHandle<gameJournalEntry>>(value);
		}

		public CodexPopupData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
