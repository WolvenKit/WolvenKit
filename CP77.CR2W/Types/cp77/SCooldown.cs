using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SCooldown : CVariable
	{
		[Ordinal(0)]  [RED("abilityType")] public CEnum<gamedataStatType> AbilityType { get; set; }
		[Ordinal(1)]  [RED("affectedByTimeDilation")] public CBool AffectedByTimeDilation { get; set; }
		[Ordinal(2)]  [RED("cdName")] public CName CdName { get; set; }
		[Ordinal(3)]  [RED("cid")] public CInt32 Cid { get; set; }
		[Ordinal(4)]  [RED("delayId")] public gameDelayID DelayId { get; set; }
		[Ordinal(5)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(6)]  [RED("durationMultiplier")] public CFloat DurationMultiplier { get; set; }
		[Ordinal(7)]  [RED("modifiable")] public CBool Modifiable { get; set; }
		[Ordinal(8)]  [RED("owner")] public wCHandle<entEntity> Owner { get; set; }
		[Ordinal(9)]  [RED("ownerItemID")] public gameItemID OwnerItemID { get; set; }
		[Ordinal(10)]  [RED("ownerRecord")] public TweakDBID OwnerRecord { get; set; }
		[Ordinal(11)]  [RED("removeId")] public gameDelayID RemoveId { get; set; }
		[Ordinal(12)]  [RED("statMod")] public CHandle<gameStatModifierData> StatMod { get; set; }
		[Ordinal(13)]  [RED("type")] public CEnum<gamedataStatType> Type { get; set; }

		public SCooldown(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
