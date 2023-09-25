using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestMappinLinkController : BaseCodexLinkController
	{
		[Ordinal(6)] 
		[RED("mappinEntry")] 
		public CHandle<gameJournalQuestMapPinBase> MappinEntry
		{
			get => GetPropertyValue<CHandle<gameJournalQuestMapPinBase>>();
			set => SetPropertyValue<CHandle<gameJournalQuestMapPinBase>>(value);
		}

		[Ordinal(7)] 
		[RED("mappinEntryHash")] 
		public CHandle<gameJournalQuestMapPinBase> MappinEntryHash
		{
			get => GetPropertyValue<CHandle<gameJournalQuestMapPinBase>>();
			set => SetPropertyValue<CHandle<gameJournalQuestMapPinBase>>(value);
		}

		[Ordinal(8)] 
		[RED("jumpTo")] 
		public Vector3 JumpTo
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(9)] 
		[RED("hash")] 
		public CInt32 Hash
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("isTracked")] 
		public CBool IsTracked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuestMappinLinkController()
		{
			JumpTo = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
