using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class minibossPlasmaProjectile : BaseProjectile
	{
		[Ordinal(51)] [RED("countTime")] public CFloat CountTime { get; set; }
		[Ordinal(52)] [RED("startVelocity")] public CFloat StartVelocity { get; set; }
		[Ordinal(53)] [RED("lifetime")] public CFloat Lifetime_440 { get; set; }
		[Ordinal(54)] [RED("effectName")] public CName EffectName { get; set; }
		[Ordinal(55)] [RED("hitEffectName")] public CName HitEffectName { get; set; }
		[Ordinal(56)] [RED("followTarget")] public CBool FollowTarget { get; set; }
		[Ordinal(57)] [RED("bendFactor")] public CFloat BendFactor { get; set; }
		[Ordinal(58)] [RED("bendRatio")] public CFloat BendRatio { get; set; }
		[Ordinal(59)] [RED("shouldRotate")] public CBool ShouldRotate { get; set; }
		[Ordinal(60)] [RED("attackRecordID")] public TweakDBID AttackRecordID { get; set; }
		[Ordinal(61)] [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }
		[Ordinal(62)] [RED("spawnGameEffectOnCollision")] public CBool SpawnGameEffectOnCollision { get; set; }
		[Ordinal(63)] [RED("collisionAttackRecord")] public CHandle<gamedataAttack_Record> CollisionAttackRecord { get; set; }
		[Ordinal(64)] [RED("alive")] public CBool Alive { get; set; }
		[Ordinal(65)] [RED("owner")] public wCHandle<ScriptedPuppet> Owner { get; set; }
		[Ordinal(66)] [RED("target")] public wCHandle<gameObject> Target { get; set; }

		public minibossPlasmaProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
