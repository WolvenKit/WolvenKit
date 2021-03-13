using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExplodingBullet : BaseBullet
	{
		[Ordinal(56)] [RED("explosionTime")] public CFloat ExplosionTime { get; set; }
		[Ordinal(57)] [RED("effectReference")] public gameEffectRef EffectReference { get; set; }
		[Ordinal(58)] [RED("hasExploded")] public CBool HasExploded { get; set; }
		[Ordinal(59)] [RED("initialPosition")] public Vector4 InitialPosition { get; set; }
		[Ordinal(60)] [RED("trailStarted")] public CBool TrailStarted { get; set; }
		[Ordinal(61)] [RED("weapon")] public wCHandle<gameweaponObject> Weapon { get; set; }
		[Ordinal(62)] [RED("attack_record")] public CHandle<gamedataAttack_Record> Attack_record { get; set; }
		[Ordinal(63)] [RED("attackID")] public TweakDBID AttackID { get; set; }
		[Ordinal(64)] [RED("colliderBox")] public Vector4 ColliderBox { get; set; }
		[Ordinal(65)] [RED("rotation")] public Quaternion Rotation { get; set; }
		[Ordinal(66)] [RED("range")] public CFloat Range { get; set; }
		[Ordinal(67)] [RED("explodeAfterRangeTravelled")] public CBool ExplodeAfterRangeTravelled { get; set; }
		[Ordinal(68)] [RED("attack")] public CHandle<gameIAttack> Attack { get; set; }
		[Ordinal(69)] [RED("BulletCollisionEvaluator")] public CHandle<BulletCollisionEvaluator> BulletCollisionEvaluator { get; set; }

		public ExplodingBullet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
