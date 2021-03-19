using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestGuidanceMarker : gameJournalEntry
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

		public gameJournalQuestGuidanceMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
