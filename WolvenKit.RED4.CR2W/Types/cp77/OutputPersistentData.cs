using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OutputPersistentData : CVariable
	{
		private CEnum<ESecuritySystemState> _currentSecurityState;
		private CEnum<EBreachOrigin> _breachOrigin;
		private CBool _securityStateChanged;
		private Vector4 _lastKnownPosition;
		private CEnum<ESecurityNotificationType> _type;
		private CEnum<ESecurityAreaType> _areaType;
		private entEntityID _objectOfInterest;
		private entEntityID _whoBreached;
		private gamePersistentID _reporter;
		private CInt32 _id;

		[Ordinal(0)] 
		[RED("currentSecurityState")] 
		public CEnum<ESecuritySystemState> CurrentSecurityState
		{
			get
			{
				if (_currentSecurityState == null)
				{
					_currentSecurityState = (CEnum<ESecuritySystemState>) CR2WTypeManager.Create("ESecuritySystemState", "currentSecurityState", cr2w, this);
				}
				return _currentSecurityState;
			}
			set
			{
				if (_currentSecurityState == value)
				{
					return;
				}
				_currentSecurityState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("breachOrigin")] 
		public CEnum<EBreachOrigin> BreachOrigin
		{
			get
			{
				if (_breachOrigin == null)
				{
					_breachOrigin = (CEnum<EBreachOrigin>) CR2WTypeManager.Create("EBreachOrigin", "breachOrigin", cr2w, this);
				}
				return _breachOrigin;
			}
			set
			{
				if (_breachOrigin == value)
				{
					return;
				}
				_breachOrigin = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("securityStateChanged")] 
		public CBool SecurityStateChanged
		{
			get
			{
				if (_securityStateChanged == null)
				{
					_securityStateChanged = (CBool) CR2WTypeManager.Create("Bool", "securityStateChanged", cr2w, this);
				}
				return _securityStateChanged;
			}
			set
			{
				if (_securityStateChanged == value)
				{
					return;
				}
				_securityStateChanged = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("areaType")] 
		public CEnum<ESecurityAreaType> AreaType
		{
			get
			{
				if (_areaType == null)
				{
					_areaType = (CEnum<ESecurityAreaType>) CR2WTypeManager.Create("ESecurityAreaType", "areaType", cr2w, this);
				}
				return _areaType;
			}
			set
			{
				if (_areaType == value)
				{
					return;
				}
				_areaType = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("objectOfInterest")] 
		public entEntityID ObjectOfInterest
		{
			get
			{
				if (_objectOfInterest == null)
				{
					_objectOfInterest = (entEntityID) CR2WTypeManager.Create("entEntityID", "objectOfInterest", cr2w, this);
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

		[Ordinal(7)] 
		[RED("whoBreached")] 
		public entEntityID WhoBreached
		{
			get
			{
				if (_whoBreached == null)
				{
					_whoBreached = (entEntityID) CR2WTypeManager.Create("entEntityID", "whoBreached", cr2w, this);
				}
				return _whoBreached;
			}
			set
			{
				if (_whoBreached == value)
				{
					return;
				}
				_whoBreached = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("reporter")] 
		public gamePersistentID Reporter
		{
			get
			{
				if (_reporter == null)
				{
					_reporter = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "reporter", cr2w, this);
				}
				return _reporter;
			}
			set
			{
				if (_reporter == value)
				{
					return;
				}
				_reporter = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
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

		public OutputPersistentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
