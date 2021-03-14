using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRaceGameState : gameuiMinigameState
	{
		private CFloat _invincibleTime;
		private CFloat _pointsBonusTime;
		private CFloat _speedMultiplicator;

		[Ordinal(2)] 
		[RED("invincibleTime")] 
		public CFloat InvincibleTime
		{
			get
			{
				if (_invincibleTime == null)
				{
					_invincibleTime = (CFloat) CR2WTypeManager.Create("Float", "invincibleTime", cr2w, this);
				}
				return _invincibleTime;
			}
			set
			{
				if (_invincibleTime == value)
				{
					return;
				}
				_invincibleTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("speedMultiplicator")] 
		public CFloat SpeedMultiplicator
		{
			get
			{
				if (_speedMultiplicator == null)
				{
					_speedMultiplicator = (CFloat) CR2WTypeManager.Create("Float", "speedMultiplicator", cr2w, this);
				}
				return _speedMultiplicator;
			}
			set
			{
				if (_speedMultiplicator == value)
				{
					return;
				}
				_speedMultiplicator = value;
				PropertySet(this);
			}
		}

		public gameuiRoachRaceGameState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
