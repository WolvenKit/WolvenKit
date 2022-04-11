using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestMappinLinkController : BaseCodexLinkController
	{
		[Ordinal(5)] 
		[RED("mappinEntry")] 
		public CHandle<gameJournalQuestMapPinBase> MappinEntry
		{
			get => GetPropertyValue<CHandle<gameJournalQuestMapPinBase>>();
			set => SetPropertyValue<CHandle<gameJournalQuestMapPinBase>>(value);
		}

		[Ordinal(6)] 
		[RED("jumpTo")] 
		public Vector3 JumpTo
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public QuestMappinLinkController()
		{
			JumpTo = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
