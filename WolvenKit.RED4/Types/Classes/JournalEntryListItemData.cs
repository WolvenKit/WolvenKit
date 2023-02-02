using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class JournalEntryListItemData : IScriptable
	{
		[Ordinal(0)] 
		[RED("entry")] 
		public CWeakHandle<gameJournalEntry> Entry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalEntry>>();
			set => SetPropertyValue<CWeakHandle<gameJournalEntry>>(value);
		}

		[Ordinal(1)] 
		[RED("extraData")] 
		public CHandle<IScriptable> ExtraData
		{
			get => GetPropertyValue<CHandle<IScriptable>>();
			set => SetPropertyValue<CHandle<IScriptable>>(value);
		}

		public JournalEntryListItemData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
