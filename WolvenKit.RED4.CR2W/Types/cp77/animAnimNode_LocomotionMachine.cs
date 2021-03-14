using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LocomotionMachine : animAnimNode_StateMachine
	{
		private CBool _usePlanner;
		private CName _group;
		private CName _logic;
		private CName _requestId;
		private CName _distance;
		private CName _duration;
		private CName _motion;
		private CName _state;
		private CFloat _transitionTime;
		private CUInt32 _numVariants;

		[Ordinal(19)] 
		[RED("usePlanner")] 
		public CBool UsePlanner
		{
			get
			{
				if (_usePlanner == null)
				{
					_usePlanner = (CBool) CR2WTypeManager.Create("Bool", "usePlanner", cr2w, this);
				}
				return _usePlanner;
			}
			set
			{
				if (_usePlanner == value)
				{
					return;
				}
				_usePlanner = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("group")] 
		public CName Group
		{
			get
			{
				if (_group == null)
				{
					_group = (CName) CR2WTypeManager.Create("CName", "group", cr2w, this);
				}
				return _group;
			}
			set
			{
				if (_group == value)
				{
					return;
				}
				_group = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("logic")] 
		public CName Logic
		{
			get
			{
				if (_logic == null)
				{
					_logic = (CName) CR2WTypeManager.Create("CName", "logic", cr2w, this);
				}
				return _logic;
			}
			set
			{
				if (_logic == value)
				{
					return;
				}
				_logic = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("requestId")] 
		public CName RequestId
		{
			get
			{
				if (_requestId == null)
				{
					_requestId = (CName) CR2WTypeManager.Create("CName", "requestId", cr2w, this);
				}
				return _requestId;
			}
			set
			{
				if (_requestId == value)
				{
					return;
				}
				_requestId = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("distance")] 
		public CName Distance
		{
			get
			{
				if (_distance == null)
				{
					_distance = (CName) CR2WTypeManager.Create("CName", "distance", cr2w, this);
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

		[Ordinal(24)] 
		[RED("duration")] 
		public CName Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CName) CR2WTypeManager.Create("CName", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("motion")] 
		public CName Motion
		{
			get
			{
				if (_motion == null)
				{
					_motion = (CName) CR2WTypeManager.Create("CName", "motion", cr2w, this);
				}
				return _motion;
			}
			set
			{
				if (_motion == value)
				{
					return;
				}
				_motion = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("state")] 
		public CName State
		{
			get
			{
				if (_state == null)
				{
					_state = (CName) CR2WTypeManager.Create("CName", "state", cr2w, this);
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

		[Ordinal(27)] 
		[RED("transitionTime")] 
		public CFloat TransitionTime
		{
			get
			{
				if (_transitionTime == null)
				{
					_transitionTime = (CFloat) CR2WTypeManager.Create("Float", "transitionTime", cr2w, this);
				}
				return _transitionTime;
			}
			set
			{
				if (_transitionTime == value)
				{
					return;
				}
				_transitionTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("numVariants")] 
		public CUInt32 NumVariants
		{
			get
			{
				if (_numVariants == null)
				{
					_numVariants = (CUInt32) CR2WTypeManager.Create("Uint32", "numVariants", cr2w, this);
				}
				return _numVariants;
			}
			set
			{
				if (_numVariants == value)
				{
					return;
				}
				_numVariants = value;
				PropertySet(this);
			}
		}

		public animAnimNode_LocomotionMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
