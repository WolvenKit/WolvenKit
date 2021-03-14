using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiQuadRacerGameState : gameuiMinigameState
	{
		private CFloat _timeLeft;
		private CFloat _boostTime;
		private CFloat _pointsBonusTime;
		private CFloat _maxSpeed;
		private CFloat _speed;
		private CBool _hasPassedCheckpoint;
		private CBool _shouldPushBackPlayer;
		private CInt32 _lapsPassed;

		[Ordinal(2)] 
		[RED("timeLeft")] 
		public CFloat TimeLeft
		{
			get
			{
				if (_timeLeft == null)
				{
					_timeLeft = (CFloat) CR2WTypeManager.Create("Float", "timeLeft", cr2w, this);
				}
				return _timeLeft;
			}
			set
			{
				if (_timeLeft == value)
				{
					return;
				}
				_timeLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("boostTime")] 
		public CFloat BoostTime
		{
			get
			{
				if (_boostTime == null)
				{
					_boostTime = (CFloat) CR2WTypeManager.Create("Float", "boostTime", cr2w, this);
				}
				return _boostTime;
			}
			set
			{
				if (_boostTime == value)
				{
					return;
				}
				_boostTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("pointsBonusTime")] 
		public CFloat PointsBonusTime
		{
			get
			{
				if (_pointsBonusTime == null)
				{
					_pointsBonusTime = (CFloat) CR2WTypeManager.Create("Float", "pointsBonusTime", cr2w, this);
				}
				return _pointsBonusTime;
			}
			set
			{
				if (_pointsBonusTime == value)
				{
					return;
				}
				_pointsBonusTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("maxSpeed")] 
		public CFloat MaxSpeed
		{
			get
			{
				if (_maxSpeed == null)
				{
					_maxSpeed = (CFloat) CR2WTypeManager.Create("Float", "maxSpeed", cr2w, this);
				}
				return _maxSpeed;
			}
			set
			{
				if (_maxSpeed == value)
				{
					return;
				}
				_maxSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get
			{
				if (_speed == null)
				{
					_speed = (CFloat) CR2WTypeManager.Create("Float", "speed", cr2w, this);
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

		[Ordinal(7)] 
		[RED("hasPassedCheckpoint")] 
		public CBool HasPassedCheckpoint
		{
			get
			{
				if (_hasPassedCheckpoint == null)
				{
					_hasPassedCheckpoint = (CBool) CR2WTypeManager.Create("Bool", "hasPassedCheckpoint", cr2w, this);
				}
				return _hasPassedCheckpoint;
			}
			set
			{
				if (_hasPassedCheckpoint == value)
				{
					return;
				}
				_hasPassedCheckpoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("shouldPushBackPlayer")] 
		public CBool ShouldPushBackPlayer
		{
			get
			{
				if (_shouldPushBackPlayer == null)
				{
					_shouldPushBackPlayer = (CBool) CR2WTypeManager.Create("Bool", "shouldPushBackPlayer", cr2w, this);
				}
				return _shouldPushBackPlayer;
			}
			set
			{
				if (_shouldPushBackPlayer == value)
				{
					return;
				}
				_shouldPushBackPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("lapsPassed")] 
		public CInt32 LapsPassed
		{
			get
			{
				if (_lapsPassed == null)
				{
					_lapsPassed = (CInt32) CR2WTypeManager.Create("Int32", "lapsPassed", cr2w, this);
				}
				return _lapsPassed;
			}
			set
			{
				if (_lapsPassed == value)
				{
					return;
				}
				_lapsPassed = value;
				PropertySet(this);
			}
		}

		public gameuiQuadRacerGameState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
