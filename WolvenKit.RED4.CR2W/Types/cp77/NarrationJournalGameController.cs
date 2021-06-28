using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NarrationJournalGameController : gameuiHUDGameController
	{
		private inkCompoundWidgetReference _entriesContainer;
		private CUInt32 _narrationJournalBlackboardId;

		[Ordinal(9)] 
		[RED("entriesContainer")] 
		public inkCompoundWidgetReference EntriesContainer
		{
			get => GetProperty(ref _entriesContainer);
			set => SetProperty(ref _entriesContainer, value);
		}

		[Ordinal(10)] 
		[RED("narrationJournalBlackboardId")] 
		public CUInt32 NarrationJournalBlackboardId
		{
			get => GetProperty(ref _narrationJournalBlackboardId);
			set => SetProperty(ref _narrationJournalBlackboardId, value);
		}

		public NarrationJournalGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
