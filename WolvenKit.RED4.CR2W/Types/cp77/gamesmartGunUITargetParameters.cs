using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamesmartGunUITargetParameters : CVariable
	{
		private Vector2 _pos;
		private CEnum<gamesmartGunTargetState> _state;
		private CFloat _distance;
		private CFloat _accuracy;
		private CBool _isLocked;
		private CFloat _timeLocking;
		private CFloat _timeUnlocking;
		private CFloat _timeOccluded;
		private entEntityID _entityID;

		[Ordinal(0)] 
		[RED("pos")] 
		public Vector2 Pos
		{
			get
			{
				if (_pos == null)
				{
					_pos = (Vector2) CR2WTypeManager.Create("Vector2", "pos", cr2w, this);
				}
				return _pos;
			}
			set
			{
				if (_pos == value)
				{
					return;
				}
				_pos = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<gamesmartGunTargetState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<gamesmartGunTargetState>) CR2WTypeManager.Create("gamesmartGunTargetState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get
			{
				if (_distance == null)
				{
					_distance = (CFloat) CR2WTypeManager.Create("Float", "distance", cr2w, this);
				}
				return _distance;
			}
			set
			{
				if (_distance == value)
				{
					return;
				}
				_distance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get
			{
				if (_isLocked == null)
				{
					_isLocked = (CBool) CR2WTypeManager.Create("Bool", "isLocked", cr2w, this);
				}
				return _isLocked;
			}
			set
			{
				if (_isLocked == value)
				{
					return;
				}
				_isLocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("timeLocking")] 
		public CFloat TimeLocking
		{
			get
			{
				if (_timeLocking == null)
				{
					_timeLocking = (CFloat) CR2WTypeManager.Create("Float", "timeLocking", cr2w, this);
				}
				return _timeLocking;
			}
			set
			{
				if (_timeLocking == value)
				{
					return;
				}
				_timeLocking = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("timeUnlocking")] 
		public CFloat TimeUnlocking
		{
			get
			{
				if (_timeUnlocking == null)
				{
					_timeUnlocking = (CFloat) CR2WTypeManager.Create("Float", "timeUnlocking", cr2w, this);
				}
				return _timeUnlocking;
			}
			set
			{
				if (_timeUnlocking == value)
				{
					return;
				}
				_timeUnlocking = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("timeOccluded")] 
		public CFloat TimeOccluded
		{
			get
			{
				if (_timeOccluded == null)
				{
					_timeOccluded = (CFloat) CR2WTypeManager.Create("Float", "timeOccluded", cr2w, this);
				}
				return _timeOccluded;
			}
			set
			{
				if (_timeOccluded == value)
				{
					return;
				}
				_timeOccluded = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get
			{
				if (_entityID == null)
				{
					_entityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "entityID", cr2w, this);
				}
				return _entityID;
			}
			set
			{
				if (_entityID == value)
				{
					return;
				}
				_entityID = value;
				PropertySet(this);
			}
		}

		public gamesmartGunUITargetParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
