using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalPointOfInterestMappin : gameJournalEntry
	{
		private NodeRef _staticNodeRef;
		private gameEntityReference _dynamicEntityRef;
		private NodeRef _securityAreaRef;
		private gamemappinsPointOfInterestMappinData _mappinData;
		private Vector3 _offset;
		private CHandle<gameJournalPath> _questPath;
		private TweakDBID _recommendedLevelID;
		private NodeRef _notificationTriggerAreaRef;

		[Ordinal(1)] 
		[RED("staticNodeRef")] 
		public NodeRef StaticNodeRef
		{
			get
			{
				if (_staticNodeRef == null)
				{
					_staticNodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "staticNodeRef", cr2w, this);
				}
				return _staticNodeRef;
			}
			set
			{
				if (_staticNodeRef == value)
				{
					return;
				}
				_staticNodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("dynamicEntityRef")] 
		public gameEntityReference DynamicEntityRef
		{
			get
			{
				if (_dynamicEntityRef == null)
				{
					_dynamicEntityRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "dynamicEntityRef", cr2w, this);
				}
				return _dynamicEntityRef;
			}
			set
			{
				if (_dynamicEntityRef == value)
				{
					return;
				}
				_dynamicEntityRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("securityAreaRef")] 
		public NodeRef SecurityAreaRef
		{
			get
			{
				if (_securityAreaRef == null)
				{
					_securityAreaRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "securityAreaRef", cr2w, this);
				}
				return _securityAreaRef;
			}
			set
			{
				if (_securityAreaRef == value)
				{
					return;
				}
				_securityAreaRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("mappinData")] 
		public gamemappinsPointOfInterestMappinData MappinData
		{
			get
			{
				if (_mappinData == null)
				{
					_mappinData = (gamemappinsPointOfInterestMappinData) CR2WTypeManager.Create("gamemappinsPointOfInterestMappinData", "mappinData", cr2w, this);
				}
				return _mappinData;
			}
			set
			{
				if (_mappinData == value)
				{
					return;
				}
				_mappinData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Vector3) CR2WTypeManager.Create("Vector3", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("questPath")] 
		public CHandle<gameJournalPath> QuestPath
		{
			get
			{
				if (_questPath == null)
				{
					_questPath = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "questPath", cr2w, this);
				}
				return _questPath;
			}
			set
			{
				if (_questPath == value)
				{
					return;
				}
				_questPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("recommendedLevelID")] 
		public TweakDBID RecommendedLevelID
		{
			get
			{
				if (_recommendedLevelID == null)
				{
					_recommendedLevelID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "recommendedLevelID", cr2w, this);
				}
				return _recommendedLevelID;
			}
			set
			{
				if (_recommendedLevelID == value)
				{
					return;
				}
				_recommendedLevelID = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("notificationTriggerAreaRef")] 
		public NodeRef NotificationTriggerAreaRef
		{
			get
			{
				if (_notificationTriggerAreaRef == null)
				{
					_notificationTriggerAreaRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "notificationTriggerAreaRef", cr2w, this);
				}
				return _notificationTriggerAreaRef;
			}
			set
			{
				if (_notificationTriggerAreaRef == value)
				{
					return;
				}
				_notificationTriggerAreaRef = value;
				PropertySet(this);
			}
		}

		public gameJournalPointOfInterestMappin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
