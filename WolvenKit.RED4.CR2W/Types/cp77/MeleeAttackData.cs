using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeAttackData : IScriptable
	{
		[Ordinal(0)] [RED("attackName")] public CString AttackName { get; set; }
		[Ordinal(1)] [RED("attackSpeed")] public CFloat AttackSpeed { get; set; }
		[Ordinal(2)] [RED("attackWindowOpen")] public CFloat AttackWindowOpen { get; set; }
		[Ordinal(3)] [RED("attackWindowClosed")] public CFloat AttackWindowClosed { get; set; }
		[Ordinal(4)] [RED("idleTransitionTime")] public CFloat IdleTransitionTime { get; set; }
		[Ordinal(5)] [RED("holdTransitionTime")] public CFloat HoldTransitionTime { get; set; }
		[Ordinal(6)] [RED("blockTransitionTime")] public CFloat BlockTransitionTime { get; set; }
		[Ordinal(7)] [RED("attackEffectDirection")] public CName AttackEffectDirection { get; set; }
		[Ordinal(8)] [RED("attackEffectDuration")] public CFloat AttackEffectDuration { get; set; }
		[Ordinal(9)] [RED("attackEffectDelay")] public CFloat AttackEffectDelay { get; set; }
		[Ordinal(10)] [RED("impactFxSlot")] public CName ImpactFxSlot { get; set; }
		[Ordinal(11)] [RED("impulseDelay")] public CFloat ImpulseDelay { get; set; }
		[Ordinal(12)] [RED("cameraSpaceImpulse")] public CFloat CameraSpaceImpulse { get; set; }
		[Ordinal(13)] [RED("forwardImpulse")] public CFloat ForwardImpulse { get; set; }
		[Ordinal(14)] [RED("upImpulse")] public CFloat UpImpulse { get; set; }
		[Ordinal(15)] [RED("useAdjustmentInsteadOfImpulse")] public CBool UseAdjustmentInsteadOfImpulse { get; set; }
		[Ordinal(16)] [RED("enableAdjustingPlayerPositionToTarget")] public CBool EnableAdjustingPlayerPositionToTarget { get; set; }
		[Ordinal(17)] [RED("startPosition")] public Vector4 StartPosition { get; set; }
		[Ordinal(18)] [RED("endPosition")] public Vector4 EndPosition { get; set; }
		[Ordinal(19)] [RED("staminaCost")] public CFloat StaminaCost { get; set; }
		[Ordinal(20)] [RED("chargeCost")] public CFloat ChargeCost { get; set; }
		[Ordinal(21)] [RED("hasDeflectAnim")] public CBool HasDeflectAnim { get; set; }
		[Ordinal(22)] [RED("hasHitAnim")] public CBool HasHitAnim { get; set; }
		[Ordinal(23)] [RED("trailStartDelay")] public CFloat TrailStartDelay { get; set; }
		[Ordinal(24)] [RED("trailStopDelay")] public CFloat TrailStopDelay { get; set; }
		[Ordinal(25)] [RED("trailAttackSide")] public CString TrailAttackSide { get; set; }
		[Ordinal(26)] [RED("incrementsCombo")] public CBool IncrementsCombo { get; set; }
		[Ordinal(27)] [RED("startupDuration")] public CFloat StartupDuration { get; set; }
		[Ordinal(28)] [RED("activeDuration")] public CFloat ActiveDuration { get; set; }
		[Ordinal(29)] [RED("recoverDuration")] public CFloat RecoverDuration { get; set; }
		[Ordinal(30)] [RED("activeHitDuration")] public CFloat ActiveHitDuration { get; set; }
		[Ordinal(31)] [RED("recoverHitDuration")] public CFloat RecoverHitDuration { get; set; }
		[Ordinal(32)] [RED("standUpDelay")] public CFloat StandUpDelay { get; set; }
		[Ordinal(33)] [RED("ikOffset")] public Vector3 IkOffset { get; set; }

		public MeleeAttackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
