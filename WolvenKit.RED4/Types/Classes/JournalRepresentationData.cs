using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class JournalRepresentationData : ListItemData
	{
		[Ordinal(1)] 
		[RED("Data")] 
		public CWeakHandle<gameJournalEntry> Data
		{
			get => GetPropertyValue<CWeakHandle<gameJournalEntry>>();
			set => SetPropertyValue<CWeakHandle<gameJournalEntry>>(value);
		}

		[Ordinal(2)] 
		[RED("OnscreenData")] 
		public CWeakHandle<gameJournalOnscreensStructuredGroup> OnscreenData
		{
			get => GetPropertyValue<CWeakHandle<gameJournalOnscreensStructuredGroup>>();
			set => SetPropertyValue<CWeakHandle<gameJournalOnscreensStructuredGroup>>(value);
		}

		[Ordinal(3)] 
		[RED("Reference")] 
		public CWeakHandle<inkWidget> Reference
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(4)] 
		[RED("IsNew")] 
		public CBool IsNew
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public JournalRepresentationData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
