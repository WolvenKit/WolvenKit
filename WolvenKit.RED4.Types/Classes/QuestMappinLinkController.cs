using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestMappinLinkController : BaseCodexLinkController
	{
		private CHandle<gameJournalQuestMapPinBase> _mappinEntry;
		private Vector3 _jumpTo;

		[Ordinal(5)] 
		[RED("mappinEntry")] 
		public CHandle<gameJournalQuestMapPinBase> MappinEntry
		{
			get => GetProperty(ref _mappinEntry);
			set => SetProperty(ref _mappinEntry, value);
		}

		[Ordinal(6)] 
		[RED("jumpTo")] 
		public Vector3 JumpTo
		{
			get => GetProperty(ref _jumpTo);
			set => SetProperty(ref _jumpTo, value);
		}
	}
}
