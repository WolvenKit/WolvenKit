using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Locomotion : animAnimFeature
	{
		private CInt32 _action;
		private CInt32 _style;
		private CFloat _pathCurvature;
		private CFloat _inclineAngle;
		private CFloat _groundAngle;
		private CFloat _animDeltaZ;
		private CFloat _animationPlaybackTime;
		private CFloat _footScaleFactor;
		private CFloat _directionalStartAngle;
		private CFloat _speedProgress;
		private CBool _isOnStairs;
		private CBool _areAnimWrappersUnlocked;

		[Ordinal(0)] 
		[RED("action")] 
		public CInt32 Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CInt32) CR2WTypeManager.Create("Int32", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("style")] 
		public CInt32 Style
		{
			get
			{
				if (_style == null)
				{
					_style = (CInt32) CR2WTypeManager.Create("Int32", "style", cr2w, this);
				}
				return _style;
			}
			set
			{
				if (_style == value)
				{
					return;
				}
				_style = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("pathCurvature")] 
		public CFloat PathCurvature
		{
			get
			{
				if (_pathCurvature == null)
				{
					_pathCurvature = (CFloat) CR2WTypeManager.Create("Float", "pathCurvature", cr2w, this);
				}
				return _pathCurvature;
			}
			set
			{
				if (_pathCurvature == value)
				{
					return;
				}
				_pathCurvature = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("inclineAngle")] 
		public CFloat InclineAngle
		{
			get
			{
				if (_inclineAngle == null)
				{
					_inclineAngle = (CFloat) CR2WTypeManager.Create("Float", "inclineAngle", cr2w, this);
				}
				return _inclineAngle;
			}
			set
			{
				if (_inclineAngle == value)
				{
					return;
				}
				_inclineAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("groundAngle")] 
		public CFloat GroundAngle
		{
			get
			{
				if (_groundAngle == null)
				{
					_groundAngle = (CFloat) CR2WTypeManager.Create("Float", "groundAngle", cr2w, this);
				}
				return _groundAngle;
			}
			set
			{
				if (_groundAngle == value)
				{
					return;
				}
				_groundAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("animDeltaZ")] 
		public CFloat AnimDeltaZ
		{
			get
			{
				if (_animDeltaZ == null)
				{
					_animDeltaZ = (CFloat) CR2WTypeManager.Create("Float", "animDeltaZ", cr2w, this);
				}
				return _animDeltaZ;
			}
			set
			{
				if (_animDeltaZ == value)
				{
					return;
				}
				_animDeltaZ = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("animationPlaybackTime")] 
		public CFloat AnimationPlaybackTime
		{
			get
			{
				if (_animationPlaybackTime == null)
				{
					_animationPlaybackTime = (CFloat) CR2WTypeManager.Create("Float", "animationPlaybackTime", cr2w, this);
				}
				return _animationPlaybackTime;
			}
			set
			{
				if (_animationPlaybackTime == value)
				{
					return;
				}
				_animationPlaybackTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("footScaleFactor")] 
		public CFloat FootScaleFactor
		{
			get
			{
				if (_footScaleFactor == null)
				{
					_footScaleFactor = (CFloat) CR2WTypeManager.Create("Float", "footScaleFactor", cr2w, this);
				}
				return _footScaleFactor;
			}
			set
			{
				if (_footScaleFactor == value)
				{
					return;
				}
				_footScaleFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("directionalStartAngle")] 
		public CFloat DirectionalStartAngle
		{
			get
			{
				if (_directionalStartAngle == null)
				{
					_directionalStartAngle = (CFloat) CR2WTypeManager.Create("Float", "directionalStartAngle", cr2w, this);
				}
				return _directionalStartAngle;
			}
			set
			{
				if (_directionalStartAngle == value)
				{
					return;
				}
				_directionalStartAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("speedProgress")] 
		public CFloat SpeedProgress
		{
			get
			{
				if (_speedProgress == null)
				{
					_speedProgress = (CFloat) CR2WTypeManager.Create("Float", "speedProgress", cr2w, this);
				}
				return _speedProgress;
			}
			set
			{
				if (_speedProgress == value)
				{
					return;
				}
				_speedProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isOnStairs")] 
		public CBool IsOnStairs
		{
			get
			{
				if (_isOnStairs == null)
				{
					_isOnStairs = (CBool) CR2WTypeManager.Create("Bool", "isOnStairs", cr2w, this);
				}
				return _isOnStairs;
			}
			set
			{
				if (_isOnStairs == value)
				{
					return;
				}
				_isOnStairs = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("areAnimWrappersUnlocked")] 
		public CBool AreAnimWrappersUnlocked
		{
			get
			{
				if (_areAnimWrappersUnlocked == null)
				{
					_areAnimWrappersUnlocked = (CBool) CR2WTypeManager.Create("Bool", "areAnimWrappersUnlocked", cr2w, this);
				}
				return _areAnimWrappersUnlocked;
			}
			set
			{
				if (_areAnimWrappersUnlocked == value)
				{
					return;
				}
				_areAnimWrappersUnlocked = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_Locomotion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
