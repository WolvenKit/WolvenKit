using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class minibossPlasmaProjectile : BaseProjectile
	{
		[Ordinal(41)]  [RED("countTime")] public CFloat CountTime { get; set; }
		[Ordinal(42)]  [RED("startVelocity")] public CFloat StartVelocity { get; set; }
		[Ordinal(43)]  [RED("lifetime")] public CFloat Lifetime { get; set; }
		[Ordinal(44)]  [RED("effectName")] public CName EffectName { get; set; }
		[Ordinal(45)]  [RED("hitEffectName")] public CName HitEffectName { get; set; }
		[Ordinal(46)]  [RED("followTarget")] public CBool FollowTarget { get; set; }
		[Ordinal(47)]  [RED("bendFactor")] public CFloat BendFactor { get; set; }
		[Ordinal(48)]  [RED("bendRatio")] public CFloat BendRatio { get; set; }
		[Ordinal(49)]  [RED("shouldRotate")] public CBool ShouldRotate { get; set; }
		[Ordinal(50)]  [RED("attackRecordID")] public TweakDBID AttackRecordID { get; set; }
		[Ordinal(51)]  [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }
		[Ordinal(52)]  [RED("spawnGameEffectOnCollision")] public CBool SpawnGameEffectOnCollision { get; set; }
		[Ordinal(53)]  [RED("collisionAttackRecord")] public CHandle<gamedataAttack_Record> CollisionAttackRecord { get; set; }
		[Ordinal(54)]  [RED("alive")] public CBool Alive { get; set; }
		[Ordinal(55)]  [RED("owner")] public wCHandle<ScriptedPuppet> Owner { get; set; }
		[Ordinal(56)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }

		public minibossPlasmaProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
