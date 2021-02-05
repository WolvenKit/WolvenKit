using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ExplodingBullet : BaseBullet
	{
		[Ordinal(46)]  [RED("explosionTime")] public CFloat ExplosionTime { get; set; }
		[Ordinal(47)]  [RED("effectReference")] public gameEffectRef EffectReference { get; set; }
		[Ordinal(48)]  [RED("hasExploded")] public CBool HasExploded { get; set; }
		[Ordinal(49)]  [RED("initialPosition")] public Vector4 InitialPosition { get; set; }
		[Ordinal(50)]  [RED("trailStarted")] public CBool TrailStarted { get; set; }
		[Ordinal(51)]  [RED("weapon")] public wCHandle<gameweaponObject> Weapon { get; set; }
		[Ordinal(52)]  [RED("attack_record")] public CHandle<gamedataAttack_Record> Attack_record { get; set; }
		[Ordinal(53)]  [RED("attackID")] public TweakDBID AttackID { get; set; }
		[Ordinal(54)]  [RED("colliderBox")] public Vector4 ColliderBox { get; set; }
		[Ordinal(55)]  [RED("rotation")] public Quaternion Rotation { get; set; }
		[Ordinal(56)]  [RED("range")] public CFloat Range { get; set; }
		[Ordinal(57)]  [RED("explodeAfterRangeTravelled")] public CBool ExplodeAfterRangeTravelled { get; set; }
		[Ordinal(58)]  [RED("attack")] public CHandle<gameIAttack> Attack { get; set; }
		[Ordinal(59)]  [RED("BulletCollisionEvaluator")] public CHandle<BulletCollisionEvaluator> BulletCollisionEvaluator { get; set; }

		public ExplodingBullet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
