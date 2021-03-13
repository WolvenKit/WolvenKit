using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleBullet : BaseProjectile
	{
		[Ordinal(51)] [RED("meshComponent")] public CHandle<entIComponent> MeshComponent { get; set; }
		[Ordinal(52)] [RED("countTime")] public CFloat CountTime { get; set; }
		[Ordinal(53)] [RED("startVelocity")] public CFloat StartVelocity { get; set; }
		[Ordinal(54)] [RED("lifetime")] public CFloat Lifetime_456 { get; set; }
		[Ordinal(55)] [RED("BulletCollisionEvaluator")] public CHandle<BulletCollisionEvaluator> BulletCollisionEvaluator { get; set; }
		[Ordinal(56)] [RED("alive")] public CBool Alive { get; set; }

		public sampleBullet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
