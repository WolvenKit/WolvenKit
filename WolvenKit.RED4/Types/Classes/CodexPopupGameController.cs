using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CodexPopupGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("entryViewRef")] 
		public inkCompoundWidgetReference EntryViewRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("characterEntryViewRef")] 
		public inkCompoundWidgetReference CharacterEntryViewRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("imageViewRef")] 
		public inkImageWidgetReference ImageViewRef
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("entryViewController")] 
		public CWeakHandle<CodexEntryViewController> EntryViewController
		{
			get => GetPropertyValue<CWeakHandle<CodexEntryViewController>>();
			set => SetPropertyValue<CWeakHandle<CodexEntryViewController>>(value);
		}

		[Ordinal(6)] 
		[RED("characterEntryViewController")] 
		public CWeakHandle<CodexEntryViewController> CharacterEntryViewController
		{
			get => GetPropertyValue<CWeakHandle<CodexEntryViewController>>();
			set => SetPropertyValue<CWeakHandle<CodexEntryViewController>>(value);
		}

		[Ordinal(7)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(8)] 
		[RED("journalMgr")] 
		public CWeakHandle<gameJournalManager> JournalMgr
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(9)] 
		[RED("data")] 
		public CHandle<CodexPopupData> Data
		{
			get => GetPropertyValue<CHandle<CodexPopupData>>();
			set => SetPropertyValue<CHandle<CodexPopupData>>(value);
		}

		public CodexPopupGameController()
		{
			EntryViewRef = new inkCompoundWidgetReference();
			CharacterEntryViewRef = new inkCompoundWidgetReference();
			ImageViewRef = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
