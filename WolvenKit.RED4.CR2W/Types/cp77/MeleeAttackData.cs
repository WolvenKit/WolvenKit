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
			get => GetProperty(ref _attackName);
			set => SetProperty(ref _attackName, value);
		}

		[Ordinal(1)] 
		[RED("attackSpeed")] 
		public CFloat AttackSpeed
		{
			get => GetProperty(ref _attackSpeed);
			set => SetProperty(ref _attackSpeed, value);
		}

		[Ordinal(2)] 
		[RED("attackWindowOpen")] 
		public CFloat AttackWindowOpen
		{
			get => GetProperty(ref _attackWindowOpen);
			set => SetProperty(ref _attackWindowOpen, value);
		}

		[Ordinal(3)] 
		[RED("attackWindowClosed")] 
		public CFloat AttackWindowClosed
		{
			get => GetProperty(ref _attackWindowClosed);
			set => SetProperty(ref _attackWindowClosed, value);
		}

		[Ordinal(4)] 
		[RED("idleTransitionTime")] 
		public CFloat IdleTransitionTime
		{
			get => GetProperty(ref _idleTransitionTime);
			set => SetProperty(ref _idleTransitionTime, value);
		}

		[Ordinal(5)] 
		[RED("holdTransitionTime")] 
		public CFloat HoldTransitionTime
		{
			get => GetProperty(ref _holdTransitionTime);
			set => SetProperty(ref _holdTransitionTime, value);
		}

		[Ordinal(6)] 
		[RED("blockTransitionTime")] 
		public CFloat BlockTransitionTime
		{
			get => GetProperty(ref _blockTransitionTime);
			set => SetProperty(ref _blockTransitionTime, value);
		}

		[Ordinal(7)] 
		[RED("attackEffectDirection")] 
		public CName AttackEffectDirection
		{
			get => GetProperty(ref _attackEffectDirection);
			set => SetProperty(ref _attackEffectDirection, value);
		}

		[Ordinal(8)] 
		[RED("attackEffectDuration")] 
		public CFloat AttackEffectDuration
		{
			get => GetProperty(ref _attackEffectDuration);
			set => SetProperty(ref _attackEffectDuration, value);
		}

		[Ordinal(9)] 
		[RED("attackEffectDelay")] 
		public CFloat AttackEffectDelay
		{
			get => GetProperty(ref _attackEffectDelay);
			set => SetProperty(ref _attackEffectDelay, value);
		}

		[Ordinal(10)] 
		[RED("impactFxSlot")] 
		public CName ImpactFxSlot
		{
			get => GetProperty(ref _impactFxSlot);
			set => SetProperty(ref _impactFxSlot, value);
		}

		[Ordinal(11)] 
		[RED("impulseDelay")] 
		public CFloat ImpulseDelay
		{
			get => GetProperty(ref _impulseDelay);
			set => SetProperty(ref _impulseDelay, value);
		}

		[Ordinal(12)] 
		[RED("cameraSpaceImpulse")] 
		public CFloat CameraSpaceImpulse
		{
			get => GetProperty(ref _cameraSpaceImpulse);
			set => SetProperty(ref _cameraSpaceImpulse, value);
		}

		[Ordinal(13)] 
		[RED("forwardImpulse")] 
		public CFloat ForwardImpulse
		{
			get => GetProperty(ref _forwardImpulse);
			set => SetProperty(ref _forwardImpulse, value);
		}

		[Ordinal(14)] 
		[RED("upImpulse")] 
		public CFloat UpImpulse
		{
			get => GetProperty(ref _upImpulse);
			set => SetProperty(ref _upImpulse, value);
		}

		[Ordinal(15)] 
		[RED("useAdjustmentInsteadOfImpulse")] 
		public CBool UseAdjustmentInsteadOfImpulse
		{
			get => GetProperty(ref _useAdjustmentInsteadOfImpulse);
			set => SetProperty(ref _useAdjustmentInsteadOfImpulse, value);
		}

		[Ordinal(16)] 
		[RED("enableAdjustingPlayerPositionToTarget")] 
		public CBool EnableAdjustingPlayerPositionToTarget
		{
			get => GetProperty(ref _enableAdjustingPlayerPositionToTarget);
			set => SetProperty(ref _enableAdjustingPlayerPositionToTarget, value);
		}

		[Ordinal(17)] 
		[RED("startPosition")] 
		public Vector4 StartPosition
		{
			get => GetProperty(ref _startPosition);
			set => SetProperty(ref _startPosition, value);
		}

		[Ordinal(18)] 
		[RED("endPosition")] 
		public Vector4 EndPosition
		{
			get => GetProperty(ref _endPosition);
			set => SetProperty(ref _endPosition, value);
		}

		[Ordinal(19)] 
		[RED("staminaCost")] 
		public CFloat StaminaCost
		{
			get => GetProperty(ref _staminaCost);
			set => SetProperty(ref _staminaCost, value);
		}

		[Ordinal(20)] 
		[RED("chargeCost")] 
		public CFloat ChargeCost
		{
			get => GetProperty(ref _chargeCost);
			set => SetProperty(ref _chargeCost, value);
		}

		[Ordinal(21)] 
		[RED("hasDeflectAnim")] 
		public CBool HasDeflectAnim
		{
			get => GetProperty(ref _hasDeflectAnim);
			set => SetProperty(ref _hasDeflectAnim, value);
		}

		[Ordinal(22)] 
		[RED("hasHitAnim")] 
		public CBool HasHitAnim
		{
			get => GetProperty(ref _hasHitAnim);
			set => SetProperty(ref _hasHitAnim, value);
		}

		[Ordinal(23)] 
		[RED("trailStartDelay")] 
		public CFloat TrailStartDelay
		{
			get => GetProperty(ref _trailStartDelay);
			set => SetProperty(ref _trailStartDelay, value);
		}

		[Ordinal(24)] 
		[RED("trailStopDelay")] 
		public CFloat TrailStopDelay
		{
			get => GetProperty(ref _trailStopDelay);
			set => SetProperty(ref _trailStopDelay, value);
		}

		[Ordinal(25)] 
		[RED("trailAttackSide")] 
		public CString TrailAttackSide
		{
			get => GetProperty(ref _trailAttackSide);
			set => SetProperty(ref _trailAttackSide, value);
		}

		[Ordinal(26)] 
		[RED("incrementsCombo")] 
		public CBool IncrementsCombo
		{
			get => GetProperty(ref _incrementsCombo);
			set => SetProperty(ref _incrementsCombo, value);
		}

		[Ordinal(27)] 
		[RED("startupDuration")] 
		public CFloat StartupDuration
		{
			get => GetProperty(ref _startupDuration);
			set => SetProperty(ref _startupDuration, value);
		}

		[Ordinal(28)] 
		[RED("activeDuration")] 
		public CFloat ActiveDuration
		{
			get => GetProperty(ref _activeDuration);
			set => SetProperty(ref _activeDuration, value);
		}

		[Ordinal(29)] 
		[RED("recoverDuration")] 
		public CFloat RecoverDuration
		{
			get => GetProperty(ref _recoverDuration);
			set => SetProperty(ref _recoverDuration, value);
		}

		[Ordinal(30)] 
		[RED("activeHitDuration")] 
		public CFloat ActiveHitDuration
		{
			get => GetProperty(ref _activeHitDuration);
			set => SetProperty(ref _activeHitDuration, value);
		}

		[Ordinal(31)] 
		[RED("recoverHitDuration")] 
		public CFloat RecoverHitDuration
		{
			get => GetProperty(ref _recoverHitDuration);
			set => SetProperty(ref _recoverHitDuration, value);
		}

		[Ordinal(32)] 
		[RED("standUpDelay")] 
		public CFloat StandUpDelay
		{
			get => GetProperty(ref _standUpDelay);
			set => SetProperty(ref _standUpDelay, value);
		}

		[Ordinal(33)] 
		[RED("ikOffset")] 
		public Vector3 IkOffset
		{
			get => GetProperty(ref _ikOffset);
			set => SetProperty(ref _ikOffset, value);
		}

		public MeleeAttackData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
