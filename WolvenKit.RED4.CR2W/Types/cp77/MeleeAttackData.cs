using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeAttackData : IScriptable
	{
		private CString _attackName;
		private CFloat _attackSpeed;
		private CFloat _attackWindowOpen;
		private CFloat _attackWindowClosed;
		private CFloat _idleTransitionTime;
		private CFloat _holdTransitionTime;
		private CFloat _blockTransitionTime;
		private CName _attackEffectDirection;
		private CFloat _attackEffectDuration;
		private CFloat _attackEffectDelay;
		private CName _impactFxSlot;
		private CFloat _impulseDelay;
		private CFloat _cameraSpaceImpulse;
		private CFloat _forwardImpulse;
		private CFloat _upImpulse;
		private CBool _useAdjustmentInsteadOfImpulse;
		private CBool _enableAdjustingPlayerPositionToTarget;
		private Vector4 _startPosition;
		private Vector4 _endPosition;
		private CFloat _staminaCost;
		private CFloat _chargeCost;
		private CBool _hasDeflectAnim;
		private CBool _hasHitAnim;
		private CFloat _trailStartDelay;
		private CFloat _trailStopDelay;
		private CString _trailAttackSide;
		private CBool _incrementsCombo;
		private CFloat _startupDuration;
		private CFloat _activeDuration;
		private CFloat _recoverDuration;
		private CFloat _activeHitDuration;
		private CFloat _recoverHitDuration;
		private CFloat _standUpDelay;
		private Vector3 _ikOffset;

		[Ordinal(0)] 
		[RED("attackName")] 
		public CString AttackName
		{
			get
			{
				if (_attackName == null)
				{
					_attackName = (CString) CR2WTypeManager.Create("String", "attackName", cr2w, this);
				}
				return _attackName;
			}
			set
			{
				if (_attackName == value)
				{
					return;
				}
				_attackName = value;
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
		[RED("attackWindowOpen")] 
		public CFloat AttackWindowOpen
		{
			get
			{
				if (_attackWindowOpen == null)
				{
					_attackWindowOpen = (CFloat) CR2WTypeManager.Create("Float", "attackWindowOpen", cr2w, this);
				}
				return _attackWindowOpen;
			}
			set
			{
				if (_attackWindowOpen == value)
				{
					return;
				}
				_attackWindowOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("attackWindowClosed")] 
		public CFloat AttackWindowClosed
		{
			get
			{
				if (_attackWindowClosed == null)
				{
					_attackWindowClosed = (CFloat) CR2WTypeManager.Create("Float", "attackWindowClosed", cr2w, this);
				}
				return _attackWindowClosed;
			}
			set
			{
				if (_attackWindowClosed == value)
				{
					return;
				}
				_attackWindowClosed = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("idleTransitionTime")] 
		public CFloat IdleTransitionTime
		{
			get
			{
				if (_idleTransitionTime == null)
				{
					_idleTransitionTime = (CFloat) CR2WTypeManager.Create("Float", "idleTransitionTime", cr2w, this);
				}
				return _idleTransitionTime;
			}
			set
			{
				if (_idleTransitionTime == value)
				{
					return;
				}
				_idleTransitionTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("holdTransitionTime")] 
		public CFloat HoldTransitionTime
		{
			get
			{
				if (_holdTransitionTime == null)
				{
					_holdTransitionTime = (CFloat) CR2WTypeManager.Create("Float", "holdTransitionTime", cr2w, this);
				}
				return _holdTransitionTime;
			}
			set
			{
				if (_holdTransitionTime == value)
				{
					return;
				}
				_holdTransitionTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("blockTransitionTime")] 
		public CFloat BlockTransitionTime
		{
			get
			{
				if (_blockTransitionTime == null)
				{
					_blockTransitionTime = (CFloat) CR2WTypeManager.Create("Float", "blockTransitionTime", cr2w, this);
				}
				return _blockTransitionTime;
			}
			set
			{
				if (_blockTransitionTime == value)
				{
					return;
				}
				_blockTransitionTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("attackEffectDirection")] 
		public CName AttackEffectDirection
		{
			get
			{
				if (_attackEffectDirection == null)
				{
					_attackEffectDirection = (CName) CR2WTypeManager.Create("CName", "attackEffectDirection", cr2w, this);
				}
				return _attackEffectDirection;
			}
			set
			{
				if (_attackEffectDirection == value)
				{
					return;
				}
				_attackEffectDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("attackEffectDuration")] 
		public CFloat AttackEffectDuration
		{
			get
			{
				if (_attackEffectDuration == null)
				{
					_attackEffectDuration = (CFloat) CR2WTypeManager.Create("Float", "attackEffectDuration", cr2w, this);
				}
				return _attackEffectDuration;
			}
			set
			{
				if (_attackEffectDuration == value)
				{
					return;
				}
				_attackEffectDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("attackEffectDelay")] 
		public CFloat AttackEffectDelay
		{
			get
			{
				if (_attackEffectDelay == null)
				{
					_attackEffectDelay = (CFloat) CR2WTypeManager.Create("Float", "attackEffectDelay", cr2w, this);
				}
				return _attackEffectDelay;
			}
			set
			{
				if (_attackEffectDelay == value)
				{
					return;
				}
				_attackEffectDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("impactFxSlot")] 
		public CName ImpactFxSlot
		{
			get
			{
				if (_impactFxSlot == null)
				{
					_impactFxSlot = (CName) CR2WTypeManager.Create("CName", "impactFxSlot", cr2w, this);
				}
				return _impactFxSlot;
			}
			set
			{
				if (_impactFxSlot == value)
				{
					return;
				}
				_impactFxSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("impulseDelay")] 
		public CFloat ImpulseDelay
		{
			get
			{
				if (_impulseDelay == null)
				{
					_impulseDelay = (CFloat) CR2WTypeManager.Create("Float", "impulseDelay", cr2w, this);
				}
				return _impulseDelay;
			}
			set
			{
				if (_impulseDelay == value)
				{
					return;
				}
				_impulseDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("cameraSpaceImpulse")] 
		public CFloat CameraSpaceImpulse
		{
			get
			{
				if (_cameraSpaceImpulse == null)
				{
					_cameraSpaceImpulse = (CFloat) CR2WTypeManager.Create("Float", "cameraSpaceImpulse", cr2w, this);
				}
				return _cameraSpaceImpulse;
			}
			set
			{
				if (_cameraSpaceImpulse == value)
				{
					return;
				}
				_cameraSpaceImpulse = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("forwardImpulse")] 
		public CFloat ForwardImpulse
		{
			get
			{
				if (_forwardImpulse == null)
				{
					_forwardImpulse = (CFloat) CR2WTypeManager.Create("Float", "forwardImpulse", cr2w, this);
				}
				return _forwardImpulse;
			}
			set
			{
				if (_forwardImpulse == value)
				{
					return;
				}
				_forwardImpulse = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("upImpulse")] 
		public CFloat UpImpulse
		{
			get
			{
				if (_upImpulse == null)
				{
					_upImpulse = (CFloat) CR2WTypeManager.Create("Float", "upImpulse", cr2w, this);
				}
				return _upImpulse;
			}
			set
			{
				if (_upImpulse == value)
				{
					return;
				}
				_upImpulse = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("useAdjustmentInsteadOfImpulse")] 
		public CBool UseAdjustmentInsteadOfImpulse
		{
			get
			{
				if (_useAdjustmentInsteadOfImpulse == null)
				{
					_useAdjustmentInsteadOfImpulse = (CBool) CR2WTypeManager.Create("Bool", "useAdjustmentInsteadOfImpulse", cr2w, this);
				}
				return _useAdjustmentInsteadOfImpulse;
			}
			set
			{
				if (_useAdjustmentInsteadOfImpulse == value)
				{
					return;
				}
				_useAdjustmentInsteadOfImpulse = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("enableAdjustingPlayerPositionToTarget")] 
		public CBool EnableAdjustingPlayerPositionToTarget
		{
			get
			{
				if (_enableAdjustingPlayerPositionToTarget == null)
				{
					_enableAdjustingPlayerPositionToTarget = (CBool) CR2WTypeManager.Create("Bool", "enableAdjustingPlayerPositionToTarget", cr2w, this);
				}
				return _enableAdjustingPlayerPositionToTarget;
			}
			set
			{
				if (_enableAdjustingPlayerPositionToTarget == value)
				{
					return;
				}
				_enableAdjustingPlayerPositionToTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("startPosition")] 
		public Vector4 StartPosition
		{
			get
			{
				if (_startPosition == null)
				{
					_startPosition = (Vector4) CR2WTypeManager.Create("Vector4", "startPosition", cr2w, this);
				}
				return _startPosition;
			}
			set
			{
				if (_startPosition == value)
				{
					return;
				}
				_startPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("endPosition")] 
		public Vector4 EndPosition
		{
			get
			{
				if (_endPosition == null)
				{
					_endPosition = (Vector4) CR2WTypeManager.Create("Vector4", "endPosition", cr2w, this);
				}
				return _endPosition;
			}
			set
			{
				if (_endPosition == value)
				{
					return;
				}
				_endPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("staminaCost")] 
		public CFloat StaminaCost
		{
			get
			{
				if (_staminaCost == null)
				{
					_staminaCost = (CFloat) CR2WTypeManager.Create("Float", "staminaCost", cr2w, this);
				}
				return _staminaCost;
			}
			set
			{
				if (_staminaCost == value)
				{
					return;
				}
				_staminaCost = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("chargeCost")] 
		public CFloat ChargeCost
		{
			get
			{
				if (_chargeCost == null)
				{
					_chargeCost = (CFloat) CR2WTypeManager.Create("Float", "chargeCost", cr2w, this);
				}
				return _chargeCost;
			}
			set
			{
				if (_chargeCost == value)
				{
					return;
				}
				_chargeCost = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
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

		[Ordinal(22)] 
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

		[Ordinal(23)] 
		[RED("trailStartDelay")] 
		public CFloat TrailStartDelay
		{
			get
			{
				if (_trailStartDelay == null)
				{
					_trailStartDelay = (CFloat) CR2WTypeManager.Create("Float", "trailStartDelay", cr2w, this);
				}
				return _trailStartDelay;
			}
			set
			{
				if (_trailStartDelay == value)
				{
					return;
				}
				_trailStartDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("trailStopDelay")] 
		public CFloat TrailStopDelay
		{
			get
			{
				if (_trailStopDelay == null)
				{
					_trailStopDelay = (CFloat) CR2WTypeManager.Create("Float", "trailStopDelay", cr2w, this);
				}
				return _trailStopDelay;
			}
			set
			{
				if (_trailStopDelay == value)
				{
					return;
				}
				_trailStopDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("trailAttackSide")] 
		public CString TrailAttackSide
		{
			get
			{
				if (_trailAttackSide == null)
				{
					_trailAttackSide = (CString) CR2WTypeManager.Create("String", "trailAttackSide", cr2w, this);
				}
				return _trailAttackSide;
			}
			set
			{
				if (_trailAttackSide == value)
				{
					return;
				}
				_trailAttackSide = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("incrementsCombo")] 
		public CBool IncrementsCombo
		{
			get
			{
				if (_incrementsCombo == null)
				{
					_incrementsCombo = (CBool) CR2WTypeManager.Create("Bool", "incrementsCombo", cr2w, this);
				}
				return _incrementsCombo;
			}
			set
			{
				if (_incrementsCombo == value)
				{
					return;
				}
				_incrementsCombo = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("startupDuration")] 
		public CFloat StartupDuration
		{
			get
			{
				if (_startupDuration == null)
				{
					_startupDuration = (CFloat) CR2WTypeManager.Create("Float", "startupDuration", cr2w, this);
				}
				return _startupDuration;
			}
			set
			{
				if (_startupDuration == value)
				{
					return;
				}
				_startupDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("activeDuration")] 
		public CFloat ActiveDuration
		{
			get
			{
				if (_activeDuration == null)
				{
					_activeDuration = (CFloat) CR2WTypeManager.Create("Float", "activeDuration", cr2w, this);
				}
				return _activeDuration;
			}
			set
			{
				if (_activeDuration == value)
				{
					return;
				}
				_activeDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("recoverDuration")] 
		public CFloat RecoverDuration
		{
			get
			{
				if (_recoverDuration == null)
				{
					_recoverDuration = (CFloat) CR2WTypeManager.Create("Float", "recoverDuration", cr2w, this);
				}
				return _recoverDuration;
			}
			set
			{
				if (_recoverDuration == value)
				{
					return;
				}
				_recoverDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("activeHitDuration")] 
		public CFloat ActiveHitDuration
		{
			get
			{
				if (_activeHitDuration == null)
				{
					_activeHitDuration = (CFloat) CR2WTypeManager.Create("Float", "activeHitDuration", cr2w, this);
				}
				return _activeHitDuration;
			}
			set
			{
				if (_activeHitDuration == value)
				{
					return;
				}
				_activeHitDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("recoverHitDuration")] 
		public CFloat RecoverHitDuration
		{
			get
			{
				if (_recoverHitDuration == null)
				{
					_recoverHitDuration = (CFloat) CR2WTypeManager.Create("Float", "recoverHitDuration", cr2w, this);
				}
				return _recoverHitDuration;
			}
			set
			{
				if (_recoverHitDuration == value)
				{
					return;
				}
				_recoverHitDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("standUpDelay")] 
		public CFloat StandUpDelay
		{
			get
			{
				if (_standUpDelay == null)
				{
					_standUpDelay = (CFloat) CR2WTypeManager.Create("Float", "standUpDelay", cr2w, this);
				}
				return _standUpDelay;
			}
			set
			{
				if (_standUpDelay == value)
				{
					return;
				}
				_standUpDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("ikOffset")] 
		public Vector3 IkOffset
		{
			get
			{
				if (_ikOffset == null)
				{
					_ikOffset = (Vector3) CR2WTypeManager.Create("Vector3", "ikOffset", cr2w, this);
				}
				return _ikOffset;
			}
			set
			{
				if (_ikOffset == value)
				{
					return;
				}
				_ikOffset = value;
				PropertySet(this);
			}
		}

		public MeleeAttackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
