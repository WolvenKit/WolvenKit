using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryTooltipData_QuickhackData : CVariable
	{
		[Ordinal(0)]  [RED("memorycost")] public CInt32 Memorycost { get; set; }
		[Ordinal(1)]  [RED("baseCost")] public CInt32 BaseCost { get; set; }
		[Ordinal(2)]  [RED("uploadTime")] public CFloat UploadTime { get; set; }
		[Ordinal(3)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(4)]  [RED("cooldown")] public CFloat Cooldown { get; set; }
		[Ordinal(5)]  [RED("attackEffects")] public CArray<CHandle<DamageEffectUIEntry>> AttackEffects { get; set; }
		[Ordinal(6)]  [RED("uploadTimeDiff")] public CFloat UploadTimeDiff { get; set; }
		[Ordinal(7)]  [RED("durationDiff")] public CFloat DurationDiff { get; set; }
		[Ordinal(8)]  [RED("cooldownDiff")] public CFloat CooldownDiff { get; set; }

		public InventoryTooltipData_QuickhackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
