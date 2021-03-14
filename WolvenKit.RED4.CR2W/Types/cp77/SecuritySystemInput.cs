using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemInput : SecurityAreaEvent
	{
		private Vector4 _lastKnownPosition;
		private CHandle<SharedGameplayPS> _notifier;
		private CEnum<ESecurityNotificationType> _type;
		private wCHandle<gameObject> _objectOfInterest;
		private CBool _canPerformReprimand;
		private CBool _shouldLeadReprimend;
		private CInt32 _id;
		private CArray<entEntityID> _customRecipientsList;
		private CBool _isSharingRestricted;
		private CHandle<gamedataCharacter_Record> _debugReporterCharRecord;
		private CEnum<gamedataStimType> _stimTypeTriggeredAlarm;

		[Ordinal(27)] 
		[RED("lastKnownPosition")] 
		public Vector4 LastKnownPosition
		{
			get
			{
				if (_lastKnownPosition == null)
				{
					_lastKnownPosition = (Vector4) CR2WTypeManager.Create("Vector4", "lastKnownPosition", cr2w, this);
				}
				return _lastKnownPosition;
			}
			set
			{
				if (_lastKnownPosition == value)
				{
					return;
				}
				_lastKnownPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("notifier")] 
		public CHandle<SharedGameplayPS> Notifier
		{
			get
			{
				if (_notifier == null)
				{
					_notifier = (CHandle<SharedGameplayPS>) CR2WTypeManager.Create("handle:SharedGameplayPS", "notifier", cr2w, this);
				}
				return _notifier;
			}
			set
			{
				if (_notifier == value)
				{
					return;
				}
				_notifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("type")] 
		public CEnum<ESecurityNotificationType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<ESecurityNotificationType>) CR2WTypeManager.Create("ESecurityNotificationType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("objectOfInterest")] 
		public wCHandle<gameObject> ObjectOfInterest
		{
			get
			{
				if (_objectOfInterest == null)
				{
					_objectOfInterest = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "objectOfInterest", cr2w, this);
				}
				return _objectOfInterest;
			}
			set
			{
				if (_objectOfInterest == value)
				{
					return;
				}
				_objectOfInterest = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("canPerformReprimand")] 
		public CBool CanPerformReprimand
		{
			get
			{
				if (_canPerformReprimand == null)
				{
					_canPerformReprimand = (CBool) CR2WTypeManager.Create("Bool", "canPerformReprimand", cr2w, this);
				}
				return _canPerformReprimand;
			}
			set
			{
				if (_canPerformReprimand == value)
				{
					return;
				}
				_canPerformReprimand = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("shouldLeadReprimend")] 
		public CBool ShouldLeadReprimend
		{
			get
			{
				if (_shouldLeadReprimend == null)
				{
					_shouldLeadReprimend = (CBool) CR2WTypeManager.Create("Bool", "shouldLeadReprimend", cr2w, this);
				}
				return _shouldLeadReprimend;
			}
			set
			{
				if (_shouldLeadReprimend == value)
				{
					return;
				}
				_shouldLeadReprimend = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("id")] 
		public CInt32 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CInt32) CR2WTypeManager.Create("Int32", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("customRecipientsList")] 
		public CArray<entEntityID> CustomRecipientsList
		{
			get
			{
				if (_customRecipientsList == null)
				{
					_customRecipientsList = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "customRecipientsList", cr2w, this);
				}
				return _customRecipientsList;
			}
			set
			{
				if (_customRecipientsList == value)
				{
					return;
				}
				_customRecipientsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("isSharingRestricted")] 
		public CBool IsSharingRestricted
		{
			get
			{
				if (_isSharingRestricted == null)
				{
					_isSharingRestricted = (CBool) CR2WTypeManager.Create("Bool", "isSharingRestricted", cr2w, this);
				}
				return _isSharingRestricted;
			}
			set
			{
				if (_isSharingRestricted == value)
				{
					return;
				}
				_isSharingRestricted = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("debugReporterCharRecord")] 
		public CHandle<gamedataCharacter_Record> DebugReporterCharRecord
		{
			get
			{
				if (_debugReporterCharRecord == null)
				{
					_debugReporterCharRecord = (CHandle<gamedataCharacter_Record>) CR2WTypeManager.Create("handle:gamedataCharacter_Record", "debugReporterCharRecord", cr2w, this);
				}
				return _debugReporterCharRecord;
			}
			set
			{
				if (_debugReporterCharRecord == value)
				{
					return;
				}
				_debugReporterCharRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("stimTypeTriggeredAlarm")] 
		public CEnum<gamedataStimType> StimTypeTriggeredAlarm
		{
			get
			{
				if (_stimTypeTriggeredAlarm == null)
				{
					_stimTypeTriggeredAlarm = (CEnum<gamedataStimType>) CR2WTypeManager.Create("gamedataStimType", "stimTypeTriggeredAlarm", cr2w, this);
				}
				return _stimTypeTriggeredAlarm;
			}
			set
			{
				if (_stimTypeTriggeredAlarm == value)
				{
					return;
				}
				_stimTypeTriggeredAlarm = value;
				PropertySet(this);
			}
		}

		public SecuritySystemInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
