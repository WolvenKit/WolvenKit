using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class sampleBulletGeneric : BaseProjectile
	{
		[Ordinal(41)]  [RED("meshComponent")] public CHandle<entIComponent> MeshComponent { get; set; }
		[Ordinal(42)]  [RED("damage")] public CHandle<gameEffectInstance> Damage { get; set; }
		[Ordinal(43)]  [RED("countTime")] public CFloat CountTime { get; set; }
		[Ordinal(44)]  [RED("startVelocity")] public CFloat StartVelocity { get; set; }
		[Ordinal(45)]  [RED("lifetime")] public CFloat Lifetime { get; set; }
		[Ordinal(46)]  [RED("alive")] public CBool Alive { get; set; }

		public sampleBulletGeneric(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
