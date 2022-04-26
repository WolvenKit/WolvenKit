using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PuppetSquadInterface : AICombatSquadScriptInterface
	{
		[Ordinal(0)] 
		[RED("baseSquadRecord")] 
		public CWeakHandle<gamedataAISquadParams_Record> BaseSquadRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataAISquadParams_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAISquadParams_Record>>(value);
		}

		[Ordinal(1)] 
		[RED("ticketHistory")] 
		public CArray<SquadTicketReceipt> TicketHistory
		{
			get => GetPropertyValue<CArray<SquadTicketReceipt>>();
			set => SetPropertyValue<CArray<SquadTicketReceipt>>(value);
		}

		[Ordinal(2)] 
		[RED("enumValueToNdx")] 
		public gameEnumNameToIndexCache EnumValueToNdx
		{
			get => GetPropertyValue<gameEnumNameToIndexCache>();
			set => SetPropertyValue<gameEnumNameToIndexCache>(value);
		}

		[Ordinal(3)] 
		[RED("sectorsInitialized")] 
		public CBool SectorsInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PuppetSquadInterface()
		{
			TicketHistory = new();
			EnumValueToNdx = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
