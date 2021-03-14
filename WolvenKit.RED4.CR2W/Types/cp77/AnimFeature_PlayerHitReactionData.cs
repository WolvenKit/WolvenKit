using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PlayerHitReactionData : animAnimFeature
	{
		private CFloat _hitDirection;
		private CFloat _hitStrength;
		private CBool _isMeleeHit;
		private CBool _isLightMeleeHit;
		private CBool _isStrongMeleeHit;
		private CBool _isQuickMeleeHit;
		private CBool _isExplosion;
		private CBool _isPressureWave;
		private CInt32 _meleeAttackDirection;

		[Ordinal(0)] 
		[RED("hitDirection")] 
		public CFloat HitDirection
		{
			get
			{
				if (_hitDirection == null)
				{
					_hitDirection = (CFloat) CR2WTypeManager.Create("Float", "hitDirection", cr2w, this);
				}
				return _hitDirection;
			}
			set
			{
				if (_hitDirection == value)
				{
					return;
				}
				_hitDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hitStrength")] 
		public CFloat HitStrength
		{
			get
			{
				if (_hitStrength == null)
				{
					_hitStrength = (CFloat) CR2WTypeManager.Create("Float", "hitStrength", cr2w, this);
				}
				return _hitStrength;
			}
			set
			{
				if (_hitStrength == value)
				{
					return;
				}
				_hitStrength = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isMeleeHit")] 
		public CBool IsMeleeHit
		{
			get
			{
				if (_isMeleeHit == null)
				{
					_isMeleeHit = (CBool) CR2WTypeManager.Create("Bool", "isMeleeHit", cr2w, this);
				}
				return _isMeleeHit;
			}
			set
			{
				if (_isMeleeHit == value)
				{
					return;
				}
				_isMeleeHit = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isLightMeleeHit")] 
		public CBool IsLightMeleeHit
		{
			get
			{
				if (_isLightMeleeHit == null)
				{
					_isLightMeleeHit = (CBool) CR2WTypeManager.Create("Bool", "isLightMeleeHit", cr2w, this);
				}
				return _isLightMeleeHit;
			}
			set
			{
				if (_isLightMeleeHit == value)
				{
					return;
				}
				_isLightMeleeHit = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isStrongMeleeHit")] 
		public CBool IsStrongMeleeHit
		{
			get
			{
				if (_isStrongMeleeHit == null)
				{
					_isStrongMeleeHit = (CBool) CR2WTypeManager.Create("Bool", "isStrongMeleeHit", cr2w, this);
				}
				return _isStrongMeleeHit;
			}
			set
			{
				if (_isStrongMeleeHit == value)
				{
					return;
				}
				_isStrongMeleeHit = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isQuickMeleeHit")] 
		public CBool IsQuickMeleeHit
		{
			get
			{
				if (_isQuickMeleeHit == null)
				{
					_isQuickMeleeHit = (CBool) CR2WTypeManager.Create("Bool", "isQuickMeleeHit", cr2w, this);
				}
				return _isQuickMeleeHit;
			}
			set
			{
				if (_isQuickMeleeHit == value)
				{
					return;
				}
				_isQuickMeleeHit = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isExplosion")] 
		public CBool IsExplosion
		{
			get
			{
				if (_isExplosion == null)
				{
					_isExplosion = (CBool) CR2WTypeManager.Create("Bool", "isExplosion", cr2w, this);
				}
				return _isExplosion;
			}
			set
			{
				if (_isExplosion == value)
				{
					return;
				}
				_isExplosion = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isPressureWave")] 
		public CBool IsPressureWave
		{
			get
			{
				if (_isPressureWave == null)
				{
					_isPressureWave = (CBool) CR2WTypeManager.Create("Bool", "isPressureWave", cr2w, this);
				}
				return _isPressureWave;
			}
			set
			{
				if (_isPressureWave == value)
				{
					return;
				}
				_isPressureWave = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("meleeAttackDirection")] 
		public CInt32 MeleeAttackDirection
		{
			get
			{
				if (_meleeAttackDirection == null)
				{
					_meleeAttackDirection = (CInt32) CR2WTypeManager.Create("Int32", "meleeAttackDirection", cr2w, this);
				}
				return _meleeAttackDirection;
			}
			set
			{
				if (_meleeAttackDirection == value)
				{
					return;
				}
				_meleeAttackDirection = value;
				PropertySet(this);
			}
		}

		public AnimFeature_PlayerHitReactionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
