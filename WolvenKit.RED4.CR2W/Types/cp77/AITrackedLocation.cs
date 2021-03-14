using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AITrackedLocation : CVariable
	{
		private AILocationInformation _lastKnown;
		private AILocationInformation _location;
		private AILocationInformation _sharedLocation;
		private wCHandle<entEntity> _entity;
		private CFloat _accuracy;
		private CFloat _sharedAccuracy;
		private CFloat _sharedTimeDelay;
		private CFloat _threat;
		private Vector4 _speed;
		private CBool _visible;
		private CBool _invalidExpectation;
		private CEnum<AITrackedStatusType> _status;
		private AILocationInformation _sharedLastKnown;

		[Ordinal(0)] 
		[RED("lastKnown")] 
		public AILocationInformation LastKnown
		{
			get
			{
				if (_lastKnown == null)
				{
					_lastKnown = (AILocationInformation) CR2WTypeManager.Create("AILocationInformation", "lastKnown", cr2w, this);
				}
				return _lastKnown;
			}
			set
			{
				if (_lastKnown == value)
				{
					return;
				}
				_lastKnown = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("location")] 
		public AILocationInformation Location
		{
			get
			{
				if (_location == null)
				{
					_location = (AILocationInformation) CR2WTypeManager.Create("AILocationInformation", "location", cr2w, this);
				}
				return _location;
			}
			set
			{
				if (_location == value)
				{
					return;
				}
				_location = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("sharedLocation")] 
		public AILocationInformation SharedLocation
		{
			get
			{
				if (_sharedLocation == null)
				{
					_sharedLocation = (AILocationInformation) CR2WTypeManager.Create("AILocationInformation", "sharedLocation", cr2w, this);
				}
				return _sharedLocation;
			}
			set
			{
				if (_sharedLocation == value)
				{
					return;
				}
				_sharedLocation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("entity")] 
		public wCHandle<entEntity> Entity
		{
			get
			{
				if (_entity == null)
				{
					_entity = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "entity", cr2w, this);
				}
				return _entity;
			}
			set
			{
				if (_entity == value)
				{
					return;
				}
				_entity = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("accuracy")] 
		public CFloat Accuracy
		{
			get
			{
				if (_accuracy == null)
				{
					_accuracy = (CFloat) CR2WTypeManager.Create("Float", "accuracy", cr2w, this);
				}
				return _accuracy;
			}
			set
			{
				if (_accuracy == value)
				{
					return;
				}
				_accuracy = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("sharedAccuracy")] 
		public CFloat SharedAccuracy
		{
			get
			{
				if (_sharedAccuracy == null)
				{
					_sharedAccuracy = (CFloat) CR2WTypeManager.Create("Float", "sharedAccuracy", cr2w, this);
				}
				return _sharedAccuracy;
			}
			set
			{
				if (_sharedAccuracy == value)
				{
					return;
				}
				_sharedAccuracy = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("sharedTimeDelay")] 
		public CFloat SharedTimeDelay
		{
			get
			{
				if (_sharedTimeDelay == null)
				{
					_sharedTimeDelay = (CFloat) CR2WTypeManager.Create("Float", "sharedTimeDelay", cr2w, this);
				}
				return _sharedTimeDelay;
			}
			set
			{
				if (_sharedTimeDelay == value)
				{
					return;
				}
				_sharedTimeDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("threat")] 
		public CFloat Threat
		{
			get
			{
				if (_threat == null)
				{
					_threat = (CFloat) CR2WTypeManager.Create("Float", "threat", cr2w, this);
				}
				return _threat;
			}
			set
			{
				if (_threat == value)
				{
					return;
				}
				_threat = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("speed")] 
		public Vector4 Speed
		{
			get
			{
				if (_speed == null)
				{
					_speed = (Vector4) CR2WTypeManager.Create("Vector4", "speed", cr2w, this);
				}
				return _speed;
			}
			set
			{
				if (_speed == value)
				{
					return;
				}
				_speed = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("visible")] 
		public CBool Visible
		{
			get
			{
				if (_visible == null)
				{
					_visible = (CBool) CR2WTypeManager.Create("Bool", "visible", cr2w, this);
				}
				return _visible;
			}
			set
			{
				if (_visible == value)
				{
					return;
				}
				_visible = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("invalidExpectation")] 
		public CBool InvalidExpectation
		{
			get
			{
				if (_invalidExpectation == null)
				{
					_invalidExpectation = (CBool) CR2WTypeManager.Create("Bool", "invalidExpectation", cr2w, this);
				}
				return _invalidExpectation;
			}
			set
			{
				if (_invalidExpectation == value)
				{
					return;
				}
				_invalidExpectation = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("status")] 
		public CEnum<AITrackedStatusType> Status
		{
			get
			{
				if (_status == null)
				{
					_status = (CEnum<AITrackedStatusType>) CR2WTypeManager.Create("AITrackedStatusType", "status", cr2w, this);
				}
				return _status;
			}
			set
			{
				if (_status == value)
				{
					return;
				}
				_status = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("sharedLastKnown")] 
		public AILocationInformation SharedLastKnown
		{
			get
			{
				if (_sharedLastKnown == null)
				{
					_sharedLastKnown = (AILocationInformation) CR2WTypeManager.Create("AILocationInformation", "sharedLastKnown", cr2w, this);
				}
				return _sharedLastKnown;
			}
			set
			{
				if (_sharedLastKnown == value)
				{
					return;
				}
				_sharedLastKnown = value;
				PropertySet(this);
			}
		}

		public AITrackedLocation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
