using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestContactLinkController : BaseCodexLinkController
	{
		[Ordinal(6)] 
		[RED("msgLabel")] 
		public inkTextWidgetReference MsgLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("msgContainer")] 
		public inkWidgetReference MsgContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("msgCounter")] 
		public CInt32 MsgCounter
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("contactEntry")] 
		public CHandle<gameJournalContact> ContactEntry
		{
			get => GetPropertyValue<CHandle<gameJournalContact>>();
			set => SetPropertyValue<CHandle<gameJournalContact>>(value);
		}

		[Ordinal(10)] 
		[RED("journalMgr")] 
		public CWeakHandle<gameJournalManager> JournalMgr
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(11)] 
		[RED("phoneSystem")] 
		public CWeakHandle<PhoneSystem> PhoneSystem
		{
			get => GetPropertyValue<CWeakHandle<PhoneSystem>>();
			set => SetPropertyValue<CWeakHandle<PhoneSystem>>(value);
		}

		[Ordinal(12)] 
		[RED("uiSystem")] 
		public CWeakHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetPropertyValue<CWeakHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CWeakHandle<gameuiGameSystemUI>>(value);
		}

		public QuestContactLinkController()
		{
			MsgLabel = new inkTextWidgetReference();
			MsgContainer = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
