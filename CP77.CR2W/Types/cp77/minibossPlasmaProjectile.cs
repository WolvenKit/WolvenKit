using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class minibossPlasmaProjectile : BaseProjectile
	{
		[Ordinal(0)]  [RED("alive")] public CBool Alive { get; set; }
		[Ordinal(1)]  [RED("attackRecordID")] public TweakDBID AttackRecordID { get; set; }
		[Ordinal(2)]  [RED("bendFactor")] public CFloat BendFactor { get; set; }
		[Ordinal(3)]  [RED("bendRatio")] public CFloat BendRatio { get; set; }
		[Ordinal(4)]  [RED("collisionAttackRecord")] public CHandle<gamedataAttack_Record> CollisionAttackRecord { get; set; }
		[Ordinal(5)]  [RED("countTime")] public CFloat CountTime { get; set; }
		[Ordinal(6)]  [RED("damage")] public CHandle<gameEffectInstance> Damage { get; set; }
		[Ordinal(7)]  [RED("effectName")] public CName EffectName { get; set; }
		[Ordinal(8)]  [RED("followTarget")] public CBool FollowTarget { get; set; }
		[Ordinal(9)]  [RED("hitEffectName")] public CName HitEffectName { get; set; }
		[Ordinal(10)]  [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }
		[Ordinal(11)]  [RED("lifetime")] public CFloat Lifetime { get; set; }
		[Ordinal(12)]  [RED("owner")] public wCHandle<ScriptedPuppet> Owner { get; set; }
		[Ordinal(13)]  [RED("shouldRotate")] public CBool ShouldRotate { get; set; }
		[Ordinal(14)]  [RED("spawnGameEffectOnCollision")] public CBool SpawnGameEffectOnCollision { get; set; }
		[Ordinal(15)]  [RED("startVelocity")] public CFloat StartVelocity { get; set; }
		[Ordinal(16)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }

		public minibossPlasmaProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
