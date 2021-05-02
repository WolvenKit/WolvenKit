using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PuppetSquadInterface : AICombatSquadScriptInterface
	{
		private wCHandle<gamedataAISquadParams_Record> _baseSquadRecord;
		private CArray<SquadTicketReceipt> _ticketHistory;
		private gameEnumNameToIndexCache _enumValueToNdx;
		private CBool _sectorsInitialized;

		[Ordinal(0)] 
		[RED("baseSquadRecord")] 
		public wCHandle<gamedataAISquadParams_Record> BaseSquadRecord
		{
			get => GetProperty(ref _baseSquadRecord);
			set => SetProperty(ref _baseSquadRecord, value);
		}

		[Ordinal(1)] 
		[RED("ticketHistory")] 
		public CArray<SquadTicketReceipt> TicketHistory
		{
			get => GetProperty(ref _ticketHistory);
			set => SetProperty(ref _ticketHistory, value);
		}

		[Ordinal(2)] 
		[RED("enumValueToNdx")] 
		public gameEnumNameToIndexCache EnumValueToNdx
		{
			get => GetProperty(ref _enumValueToNdx);
			set => SetProperty(ref _enumValueToNdx, value);
		}

		[Ordinal(3)] 
		[RED("sectorsInitialized")] 
		public CBool SectorsInitialized
		{
			get => GetProperty(ref _sectorsInitialized);
			set => SetProperty(ref _sectorsInitialized, value);
		}

		public PuppetSquadInterface(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
