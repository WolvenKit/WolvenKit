using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalQuestGuidanceMarker : gameJournalEntry
	{
		[Ordinal(1)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(2)] 
		[RED("pathfindingType")] 
		public CEnum<gameQuestGuidanceMarkerPathfindingType> PathfindingType
		{
			get => GetPropertyValue<CEnum<gameQuestGuidanceMarkerPathfindingType>>();
			set => SetPropertyValue<CEnum<gameQuestGuidanceMarkerPathfindingType>>(value);
		}

		[Ordinal(3)] 
		[RED("isPortal")] 
		public CBool IsPortal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameJournalQuestGuidanceMarker()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
