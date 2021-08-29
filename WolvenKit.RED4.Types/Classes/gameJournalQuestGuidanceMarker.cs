using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalQuestGuidanceMarker : gameJournalEntry
	{
		private NodeRef _nodeRef;
		private CEnum<gameQuestGuidanceMarkerPathfindingType> _pathfindingType;
		private CBool _isPortal;

		[Ordinal(1)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		[Ordinal(2)] 
		[RED("pathfindingType")] 
		public CEnum<gameQuestGuidanceMarkerPathfindingType> PathfindingType
		{
			get => GetProperty(ref _pathfindingType);
			set => SetProperty(ref _pathfindingType, value);
		}

		[Ordinal(3)] 
		[RED("isPortal")] 
		public CBool IsPortal
		{
			get => GetProperty(ref _isPortal);
			set => SetProperty(ref _isPortal, value);
		}
	}
}
