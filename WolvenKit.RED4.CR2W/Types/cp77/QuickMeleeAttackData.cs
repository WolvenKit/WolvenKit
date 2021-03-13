using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickMeleeAttackData : CVariable
	{
		[Ordinal(0)] [RED("attackGameEffectDelay")] public CFloat AttackGameEffectDelay { get; set; }
		[Ordinal(1)] [RED("attackGameEffectDuration")] public CFloat AttackGameEffectDuration { get; set; }
		[Ordinal(2)] [RED("attackRange")] public CFloat AttackRange { get; set; }
		[Ordinal(3)] [RED("forcePlayerToStand")] public CBool ForcePlayerToStand { get; set; }
		[Ordinal(4)] [RED("shouldAdjust")] public CBool ShouldAdjust { get; set; }
		[Ordinal(5)] [RED("adjustmentRange")] public CFloat AdjustmentRange { get; set; }
		[Ordinal(6)] [RED("adjustmentDuration")] public CFloat AdjustmentDuration { get; set; }
		[Ordinal(7)] [RED("adjustmentRadius")] public CFloat AdjustmentRadius { get; set; }
		[Ordinal(8)] [RED("adjustmentCurve")] public CName AdjustmentCurve { get; set; }
		[Ordinal(9)] [RED("cooldown")] public CFloat Cooldown { get; set; }
		[Ordinal(10)] [RED("duration")] public CFloat Duration { get; set; }

		public QuickMeleeAttackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
