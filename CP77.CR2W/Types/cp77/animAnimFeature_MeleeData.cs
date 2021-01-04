using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_MeleeData : animAnimFeature
	{
		[Ordinal(0)]  [RED("attackNumber")] public CInt32 AttackNumber { get; set; }
		[Ordinal(1)]  [RED("attackSpeed")] public CFloat AttackSpeed { get; set; }
		[Ordinal(2)]  [RED("attackType")] public CInt32 AttackType { get; set; }
		[Ordinal(3)]  [RED("deflectDuration")] public CFloat DeflectDuration { get; set; }
		[Ordinal(4)]  [RED("hasDeflectAnim")] public CBool HasDeflectAnim { get; set; }
		[Ordinal(5)]  [RED("hasHitAnim")] public CBool HasHitAnim { get; set; }
		[Ordinal(6)]  [RED("isAttacking")] public CBool IsAttacking { get; set; }
		[Ordinal(7)]  [RED("isBlocking")] public CBool IsBlocking { get; set; }
		[Ordinal(8)]  [RED("isEquippingThrowable")] public CBool IsEquippingThrowable { get; set; }
		[Ordinal(9)]  [RED("isHolding")] public CBool IsHolding { get; set; }
		[Ordinal(10)]  [RED("isMeleeWeaponEquipped")] public CBool IsMeleeWeaponEquipped { get; set; }
		[Ordinal(11)]  [RED("isParried")] public CBool IsParried { get; set; }
		[Ordinal(12)]  [RED("isSafe")] public CBool IsSafe { get; set; }
		[Ordinal(13)]  [RED("isSliding")] public CBool IsSliding { get; set; }
		[Ordinal(14)]  [RED("isTargeting")] public CBool IsTargeting { get; set; }
		[Ordinal(15)]  [RED("keepRenderPlane")] public CBool KeepRenderPlane { get; set; }
		[Ordinal(16)]  [RED("shouldHandsDisappear")] public CBool ShouldHandsDisappear { get; set; }

		public animAnimFeature_MeleeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
