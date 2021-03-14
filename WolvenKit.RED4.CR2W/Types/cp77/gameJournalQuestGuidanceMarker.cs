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
			get
			{
				if (_nodeRef == null)
				{
					_nodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "nodeRef", cr2w, this);
				}
				return _nodeRef;
			}
			set
			{
				if (_nodeRef == value)
				{
					return;
				}
				_nodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("pathfindingType")] 
		public CEnum<gameQuestGuidanceMarkerPathfindingType> PathfindingType
		{
			get
			{
				if (_pathfindingType == null)
				{
					_pathfindingType = (CEnum<gameQuestGuidanceMarkerPathfindingType>) CR2WTypeManager.Create("gameQuestGuidanceMarkerPathfindingType", "pathfindingType", cr2w, this);
				}
				return _pathfindingType;
			}
			set
			{
				if (_pathfindingType == value)
				{
					return;
				}
				_pathfindingType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isPortal")] 
		public CBool IsPortal
		{
			get
			{
				if (_isPortal == null)
				{
					_isPortal = (CBool) CR2WTypeManager.Create("Bool", "isPortal", cr2w, this);
				}
				return _isPortal;
			}
			set
			{
				if (_isPortal == value)
				{
					return;
				}
				_isPortal = value;
				PropertySet(this);
			}
		}

		public gameJournalQuestGuidanceMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
