using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalQuestGuidanceMarker : gameJournalEntry
	{
		[Ordinal(2)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(3)] 
		[RED("pathfindingType")] 
		public CEnum<gameQuestGuidanceMarkerPathfindingType> PathfindingType
		{
			get => GetPropertyValue<CEnum<gameQuestGuidanceMarkerPathfindingType>>();
			set => SetPropertyValue<CEnum<gameQuestGuidanceMarkerPathfindingType>>(value);
		}

		[Ordinal(4)] 
		[RED("isPortal")] 
		public CBool IsPortal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameJournalQuestGuidanceMarker()
		{
			JournalEntryOverrideDataList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
