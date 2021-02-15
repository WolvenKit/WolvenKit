using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamedamageHitDebugData : IScriptable
	{
		[Ordinal(0)] [RED("sourceHitPosition")] public Vector4 SourceHitPosition { get; set; }
		[Ordinal(1)] [RED("targetHitPosition")] public Vector4 TargetHitPosition { get; set; }
		[Ordinal(2)] [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }
		[Ordinal(3)] [RED("source")] public wCHandle<gameObject> Source { get; set; }
		[Ordinal(4)] [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(5)] [RED("instigatorName")] public CName InstigatorName { get; set; }
		[Ordinal(6)] [RED("sourceName")] public CName SourceName { get; set; }
		[Ordinal(7)] [RED("targetName")] public CName TargetName { get; set; }
		[Ordinal(8)] [RED("sourceAttackDebugData")] public gameAttackDebugData SourceAttackDebugData { get; set; }
		[Ordinal(9)] [RED("sourceWeaponName")] public CName SourceWeaponName { get; set; }
		[Ordinal(10)] [RED("sourceAttackName")] public CName SourceAttackName { get; set; }
		[Ordinal(11)] [RED("calculatedDamages")] public CArray<CHandle<gamedamageDamageDebugData>> CalculatedDamages { get; set; }
		[Ordinal(12)] [RED("appliedDamages")] public CArray<CHandle<gamedamageDamageDebugData>> AppliedDamages { get; set; }
		[Ordinal(13)] [RED("hitType")] public CName HitType { get; set; }
		[Ordinal(14)] [RED("hitFlags")] public CName HitFlags { get; set; }

		public gamedamageHitDebugData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
