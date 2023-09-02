using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMeleeAttackData : IScriptable
	{
		[Ordinal(0)] 
		[RED("trailAttackSide")] 
		public CString TrailAttackSide
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("startPosition")] 
		public Vector4 StartPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("endPosition")] 
		public Vector4 EndPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("ikOffset")] 
		public Vector3 IkOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(4)] 
		[RED("attackName")] 
		public CName AttackName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("attackEffectDirection")] 
		public CName AttackEffectDirection
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("impactFxSlot")] 
		public CName ImpactFxSlot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("attackSpeed")] 
		public CFloat AttackSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("attackWindowOpen")] 
		public CFloat AttackWindowOpen
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("attackWindowClosed")] 
		public CFloat AttackWindowClosed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("idleTransitionTime")] 
		public CFloat IdleTransitionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("holdTransitionTime")] 
		public CFloat HoldTransitionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("blockTransitionTime")] 
		public CFloat BlockTransitionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("attackEffectDuration")] 
		public CFloat AttackEffectDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("attackEffectDelay")] 
		public CFloat AttackEffectDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("impulseDelay")] 
		public CFloat ImpulseDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("cameraSpaceImpulse")] 
		public CFloat CameraSpaceImpulse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("forwardImpulse")] 
		public CFloat ForwardImpulse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("upImpulse")] 
		public CFloat UpImpulse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("staminaCost")] 
		public CFloat StaminaCost
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("weaponChargeCost")] 
		public CFloat WeaponChargeCost
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("trailStartDelay")] 
		public CFloat TrailStartDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("trailStopDelay")] 
		public CFloat TrailStopDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("startupDuration")] 
		public CFloat StartupDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("activeDuration")] 
		public CFloat ActiveDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("recoverDuration")] 
		public CFloat RecoverDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("activeHitDuration")] 
		public CFloat ActiveHitDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("recoverHitDuration")] 
		public CFloat RecoverHitDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(28)] 
		[RED("standUpDelay")] 
		public CFloat StandUpDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(29)] 
		[RED("incrementsCombo")] 
		public CBool IncrementsCombo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("hasDeflectAnim")] 
		public CBool HasDeflectAnim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("hasHitAnim")] 
		public CBool HasHitAnim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("useAdjustmentInsteadOfImpulse")] 
		public CBool UseAdjustmentInsteadOfImpulse
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("enableAdjustingPlayerPositionToTarget")] 
		public CBool EnableAdjustingPlayerPositionToTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameMeleeAttackData()
		{
			StartPosition = new Vector4();
			EndPosition = new Vector4();
			IkOffset = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
