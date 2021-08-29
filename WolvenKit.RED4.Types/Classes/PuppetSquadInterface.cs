using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PuppetSquadInterface : AICombatSquadScriptInterface
	{
		private CWeakHandle<gamedataAISquadParams_Record> _baseSquadRecord;
		private CArray<SquadTicketReceipt> _ticketHistory;
		private gameEnumNameToIndexCache _enumValueToNdx;
		private CBool _sectorsInitialized;

		[Ordinal(0)] 
		[RED("baseSquadRecord")] 
		public CWeakHandle<gamedataAISquadParams_Record> BaseSquadRecord
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
	}
}
