using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SCooldown : CVariable
	{
		[Ordinal(0)]  [RED("delayId")] public gameDelayID DelayId { get; set; }
		[Ordinal(1)]  [RED("removeId")] public gameDelayID RemoveId { get; set; }
		[Ordinal(2)]  [RED("cid")] public CInt32 Cid { get; set; }
		[Ordinal(3)]  [RED("cdName")] public CName CdName { get; set; }
		[Ordinal(4)]  [RED("owner")] public wCHandle<entEntity> Owner { get; set; }
		[Ordinal(5)]  [RED("ownerItemID")] public gameItemID OwnerItemID { get; set; }
		[Ordinal(6)]  [RED("ownerRecord")] public TweakDBID OwnerRecord { get; set; }
		[Ordinal(7)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(8)]  [RED("type")] public CEnum<gamedataStatType> Type { get; set; }
		[Ordinal(9)]  [RED("durationMultiplier")] public CFloat DurationMultiplier { get; set; }
		[Ordinal(10)]  [RED("modifiable")] public CBool Modifiable { get; set; }
		[Ordinal(11)]  [RED("affectedByTimeDilation")] public CBool AffectedByTimeDilation { get; set; }
		[Ordinal(12)]  [RED("abilityType")] public CEnum<gamedataStatType> AbilityType { get; set; }
		[Ordinal(13)]  [RED("statMod")] public CHandle<gameStatModifierData> StatMod { get; set; }

		public SCooldown(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
