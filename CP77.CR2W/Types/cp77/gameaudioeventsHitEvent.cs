using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsHitEvent : redEvent
	{
		[Ordinal(0)]  [RED("attackType")] public CEnum<gamedataAttackType> AttackType { get; set; }
		[Ordinal(1)]  [RED("damage")] public CFloat Damage { get; set; }
		[Ordinal(2)]  [RED("hitPosition")] public Vector4 HitPosition { get; set; }
		[Ordinal(3)]  [RED("isTargetPuppet")] public CBool IsTargetPuppet { get; set; }
		[Ordinal(4)]  [RED("physicsMaterial")] public CName PhysicsMaterial { get; set; }
		[Ordinal(5)]  [RED("targetPuppetMeleeMaterial")] public CName TargetPuppetMeleeMaterial { get; set; }

		public gameaudioeventsHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
