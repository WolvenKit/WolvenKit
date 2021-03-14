using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_MeleeData : animAnimFeature
	{
		private CBool _isMeleeWeaponEquipped;
		private CFloat _attackSpeed;
		private CBool _isEquippingThrowable;
		private CBool _isTargeting;
		private CBool _isBlocking;
		private CBool _isHolding;
		private CBool _isAttacking;
		private CInt32 _attackNumber;
		private CBool _shouldHandsDisappear;
		private CBool _isSliding;
		private CFloat _deflectDuration;
		private CBool _isSafe;
		private CBool _keepRenderPlane;
		private CBool _hasDeflectAnim;
		private CBool _hasHitAnim;
		private CInt32 _attackType;
		private CBool _isParried;

		[Ordinal(0)] 
		[RED("isMeleeWeaponEquipped")] 
		public CBool IsMeleeWeaponEquipped
		{
			get
			{
				if (_isMeleeWeaponEquipped == null)
				{
					_isMeleeWeaponEquipped = (CBool) CR2WTypeManager.Create("Bool", "isMeleeWeaponEquipped", cr2w, this);
				}
				return _isMeleeWeaponEquipped;
			}
			set
			{
				if (_isMeleeWeaponEquipped == value)
				{
					return;
				}
				_isMeleeWeaponEquipped = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("attackSpeed")] 
		public CFloat AttackSpeed
		{
			get
			{
				if (_attackSpeed == null)
				{
					_attackSpeed = (CFloat) CR2WTypeManager.Create("Float", "attackSpeed", cr2w, this);
				}
				return _attackSpeed;
			}
			set
			{
				if (_attackSpeed == value)
				{
					return;
				}
				_attackSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isEquippingThrowable")] 
		public CBool IsEquippingThrowable
		{
			get
			{
				if (_isEquippingThrowable == null)
				{
					_isEquippingThrowable = (CBool) CR2WTypeManager.Create("Bool", "isEquippingThrowable", cr2w, this);
				}
				return _isEquippingThrowable;
			}
			set
			{
				if (_isEquippingThrowable == value)
				{
					return;
				}
				_isEquippingThrowable = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isTargeting")] 
		public CBool IsTargeting
		{
			get
			{
				if (_isTargeting == null)
				{
					_isTargeting = (CBool) CR2WTypeManager.Create("Bool", "isTargeting", cr2w, this);
				}
				return _isTargeting;
			}
			set
			{
				if (_isTargeting == value)
				{
					return;
				}
				_isTargeting = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isBlocking")] 
		public CBool IsBlocking
		{
			get
			{
				if (_isBlocking == null)
				{
					_isBlocking = (CBool) CR2WTypeManager.Create("Bool", "isBlocking", cr2w, this);
				}
				return _isBlocking;
			}
			set
			{
				if (_isBlocking == value)
				{
					return;
				}
				_isBlocking = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isHolding")] 
		public CBool IsHolding
		{
			get
			{
				if (_isHolding == null)
				{
					_isHolding = (CBool) CR2WTypeManager.Create("Bool", "isHolding", cr2w, this);
				}
				return _isHolding;
			}
			set
			{
				if (_isHolding == value)
				{
					return;
				}
				_isHolding = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isAttacking")] 
		public CBool IsAttacking
		{
			get
			{
				if (_isAttacking == null)
				{
					_isAttacking = (CBool) CR2WTypeManager.Create("Bool", "isAttacking", cr2w, this);
				}
				return _isAttacking;
			}
			set
			{
				if (_isAttacking == value)
				{
					return;
				}
				_isAttacking = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("attackNumber")] 
		public CInt32 AttackNumber
		{
			get
			{
				if (_attackNumber == null)
				{
					_attackNumber = (CInt32) CR2WTypeManager.Create("Int32", "attackNumber", cr2w, this);
				}
				return _attackNumber;
			}
			set
			{
				if (_attackNumber == value)
				{
					return;
				}
				_attackNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("shouldHandsDisappear")] 
		public CBool ShouldHandsDisappear
		{
			get
			{
				if (_shouldHandsDisappear == null)
				{
					_shouldHandsDisappear = (CBool) CR2WTypeManager.Create("Bool", "shouldHandsDisappear", cr2w, this);
				}
				return _shouldHandsDisappear;
			}
			set
			{
				if (_shouldHandsDisappear == value)
				{
					return;
				}
				_shouldHandsDisappear = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isSliding")] 
		public CBool IsSliding
		{
			get
			{
				if (_isSliding == null)
				{
					_isSliding = (CBool) CR2WTypeManager.Create("Bool", "isSliding", cr2w, this);
				}
				return _isSliding;
			}
			set
			{
				if (_isSliding == value)
				{
					return;
				}
				_isSliding = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("deflectDuration")] 
		public CFloat DeflectDuration
		{
			get
			{
				if (_deflectDuration == null)
				{
					_deflectDuration = (CFloat) CR2WTypeManager.Create("Float", "deflectDuration", cr2w, this);
				}
				return _deflectDuration;
			}
			set
			{
				if (_deflectDuration == value)
				{
					return;
				}
				_deflectDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("isSafe")] 
		public CBool IsSafe
		{
			get
			{
				if (_isSafe == null)
				{
					_isSafe = (CBool) CR2WTypeManager.Create("Bool", "isSafe", cr2w, this);
				}
				return _isSafe;
			}
			set
			{
				if (_isSafe == value)
				{
					return;
				}
				_isSafe = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("keepRenderPlane")] 
		public CBool KeepRenderPlane
		{
			get
			{
				if (_keepRenderPlane == null)
				{
					_keepRenderPlane = (CBool) CR2WTypeManager.Create("Bool", "keepRenderPlane", cr2w, this);
				}
				return _keepRenderPlane;
			}
			set
			{
				if (_keepRenderPlane == value)
				{
					return;
				}
				_keepRenderPlane = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("hasDeflectAnim")] 
		public CBool HasDeflectAnim
		{
			get
			{
				if (_hasDeflectAnim == null)
				{
					_hasDeflectAnim = (CBool) CR2WTypeManager.Create("Bool", "hasDeflectAnim", cr2w, this);
				}
				return _hasDeflectAnim;
			}
			set
			{
				if (_hasDeflectAnim == value)
				{
					return;
				}
				_hasDeflectAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("hasHitAnim")] 
		public CBool HasHitAnim
		{
			get
			{
				if (_hasHitAnim == null)
				{
					_hasHitAnim = (CBool) CR2WTypeManager.Create("Bool", "hasHitAnim", cr2w, this);
				}
				return _hasHitAnim;
			}
			set
			{
				if (_hasHitAnim == value)
				{
					return;
				}
				_hasHitAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("attackType")] 
		public CInt32 AttackType
		{
			get
			{
				if (_attackType == null)
				{
					_attackType = (CInt32) CR2WTypeManager.Create("Int32", "attackType", cr2w, this);
				}
				return _attackType;
			}
			set
			{
				if (_attackType == value)
				{
					return;
				}
				_attackType = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("isParried")] 
		public CBool IsParried
		{
			get
			{
				if (_isParried == null)
				{
					_isParried = (CBool) CR2WTypeManager.Create("Bool", "isParried", cr2w, this);
				}
				return _isParried;
			}
			set
			{
				if (_isParried == value)
				{
					return;
				}
				_isParried = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_MeleeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
