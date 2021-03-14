using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OutputValidationDataStruct : CVariable
	{
		private entEntityID _targetID;
		private gamePersistentID _agentID;
		private entEntityID _reprimenderID;
		private gamePersistentID _eventReportedFromArea;
		private CEnum<ESecurityNotificationType> _eventType;
		private CArray<gamePersistentID> _breachedAreas;

		[Ordinal(0)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get
			{
				if (_targetID == null)
				{
					_targetID = (entEntityID) CR2WTypeManager.Create("entEntityID", "targetID", cr2w, this);
				}
				return _targetID;
			}
			set
			{
				if (_targetID == value)
				{
					return;
				}
				_targetID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("agentID")] 
		public gamePersistentID AgentID
		{
			get
			{
				if (_agentID == null)
				{
					_agentID = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "agentID", cr2w, this);
				}
				return _agentID;
			}
			set
			{
				if (_agentID == value)
				{
					return;
				}
				_agentID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("reprimenderID")] 
		public entEntityID ReprimenderID
		{
			get
			{
				if (_reprimenderID == null)
				{
					_reprimenderID = (entEntityID) CR2WTypeManager.Create("entEntityID", "reprimenderID", cr2w, this);
				}
				return _reprimenderID;
			}
			set
			{
				if (_reprimenderID == value)
				{
					return;
				}
				_reprimenderID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("eventReportedFromArea")] 
		public gamePersistentID EventReportedFromArea
		{
			get
			{
				if (_eventReportedFromArea == null)
				{
					_eventReportedFromArea = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "eventReportedFromArea", cr2w, this);
				}
				return _eventReportedFromArea;
			}
			set
			{
				if (_eventReportedFromArea == value)
				{
					return;
				}
				_eventReportedFromArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("eventType")] 
		public CEnum<ESecurityNotificationType> EventType
		{
			get
			{
				if (_eventType == null)
				{
					_eventType = (CEnum<ESecurityNotificationType>) CR2WTypeManager.Create("ESecurityNotificationType", "eventType", cr2w, this);
				}
				return _eventType;
			}
			set
			{
				if (_eventType == value)
				{
					return;
				}
				_eventType = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("breachedAreas")] 
		public CArray<gamePersistentID> BreachedAreas
		{
			get
			{
				if (_breachedAreas == null)
				{
					_breachedAreas = (CArray<gamePersistentID>) CR2WTypeManager.Create("array:gamePersistentID", "breachedAreas", cr2w, this);
				}
				return _breachedAreas;
			}
			set
			{
				if (_breachedAreas == value)
				{
					return;
				}
				_breachedAreas = value;
				PropertySet(this);
			}
		}

		public OutputValidationDataStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
