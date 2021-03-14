using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_SweepMelee_Box : gameEffectObjectProvider_SweepOverTime
	{
		private CFloat _playerStaticDetectionConeDistance;
		private CFloat _playerStaticDetectionConeStartAngle;
		private CFloat _playerStaticDetectionConeEndAngle;
		private CBool _checkMeleeInvulnerability;

		[Ordinal(1)] 
		[RED("playerStaticDetectionConeDistance")] 
		public CFloat PlayerStaticDetectionConeDistance
		{
			get
			{
				if (_playerStaticDetectionConeDistance == null)
				{
					_playerStaticDetectionConeDistance = (CFloat) CR2WTypeManager.Create("Float", "playerStaticDetectionConeDistance", cr2w, this);
				}
				return _playerStaticDetectionConeDistance;
			}
			set
			{
				if (_playerStaticDetectionConeDistance == value)
				{
					return;
				}
				_playerStaticDetectionConeDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("playerStaticDetectionConeStartAngle")] 
		public CFloat PlayerStaticDetectionConeStartAngle
		{
			get
			{
				if (_playerStaticDetectionConeStartAngle == null)
				{
					_playerStaticDetectionConeStartAngle = (CFloat) CR2WTypeManager.Create("Float", "playerStaticDetectionConeStartAngle", cr2w, this);
				}
				return _playerStaticDetectionConeStartAngle;
			}
			set
			{
				if (_playerStaticDetectionConeStartAngle == value)
				{
					return;
				}
				_playerStaticDetectionConeStartAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("playerStaticDetectionConeEndAngle")] 
		public CFloat PlayerStaticDetectionConeEndAngle
		{
			get
			{
				if (_playerStaticDetectionConeEndAngle == null)
				{
					_playerStaticDetectionConeEndAngle = (CFloat) CR2WTypeManager.Create("Float", "playerStaticDetectionConeEndAngle", cr2w, this);
				}
				return _playerStaticDetectionConeEndAngle;
			}
			set
			{
				if (_playerStaticDetectionConeEndAngle == value)
				{
					return;
				}
				_playerStaticDetectionConeEndAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("checkMeleeInvulnerability")] 
		public CBool CheckMeleeInvulnerability
		{
			get
			{
				if (_checkMeleeInvulnerability == null)
				{
					_checkMeleeInvulnerability = (CBool) CR2WTypeManager.Create("Bool", "checkMeleeInvulnerability", cr2w, this);
				}
				return _checkMeleeInvulnerability;
			}
			set
			{
				if (_checkMeleeInvulnerability == value)
				{
					return;
				}
				_checkMeleeInvulnerability = value;
				PropertySet(this);
			}
		}

		public gameEffectObjectProvider_SweepMelee_Box(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
