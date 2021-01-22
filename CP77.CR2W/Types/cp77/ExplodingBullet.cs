using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ExplodingBullet : BaseBullet
	{
		[Ordinal(0)]  [RED("BulletCollisionEvaluator")] public CHandle<BulletCollisionEvaluator> BulletCollisionEvaluator { get; set; }
		[Ordinal(1)]  [RED("attack")] public CHandle<gameIAttack> Attack { get; set; }
		[Ordinal(2)]  [RED("attackID")] public TweakDBID AttackID { get; set; }
		[Ordinal(3)]  [RED("attack_record")] public CHandle<gamedataAttack_Record> Attack_record { get; set; }
		[Ordinal(4)]  [RED("colliderBox")] public Vector4 ColliderBox { get; set; }
		[Ordinal(5)]  [RED("effect")] public CHandle<gameEffectInstance> Effect { get; set; }
		[Ordinal(6)]  [RED("effectReference")] public gameEffectRef EffectReference { get; set; }
		[Ordinal(7)]  [RED("explodeAfterRangeTravelled")] public CBool ExplodeAfterRangeTravelled { get; set; }
		[Ordinal(8)]  [RED("explosionTime")] public CFloat ExplosionTime { get; set; }
		[Ordinal(9)]  [RED("hasExploded")] public CBool HasExploded { get; set; }
		[Ordinal(10)]  [RED("initialPosition")] public Vector4 InitialPosition { get; set; }
		[Ordinal(11)]  [RED("range")] public CFloat Range { get; set; }
		[Ordinal(12)]  [RED("rotation")] public Quaternion Rotation { get; set; }
		[Ordinal(13)]  [RED("trailStarted")] public CBool TrailStarted { get; set; }
		[Ordinal(14)]  [RED("weapon")] public wCHandle<gameweaponObject> Weapon { get; set; }

		public ExplodingBullet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
