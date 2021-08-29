using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NarrationJournalGameController : gameuiHUDGameController
	{
		private inkCompoundWidgetReference _entriesContainer;
		private CHandle<redCallbackObject> _narrationJournalBlackboardId;

		[Ordinal(9)] 
		[RED("entriesContainer")] 
		public inkCompoundWidgetReference EntriesContainer
		{
			get => GetProperty(ref _entriesContainer);
			set => SetProperty(ref _entriesContainer, value);
		}

		[Ordinal(10)] 
		[RED("narrationJournalBlackboardId")] 
		public CHandle<redCallbackObject> NarrationJournalBlackboardId
		{
			get => GetProperty(ref _narrationJournalBlackboardId);
			set => SetProperty(ref _narrationJournalBlackboardId, value);
		}
	}
}
