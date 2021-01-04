using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class sampleBulletGeneric : BaseProjectile
	{
		[Ordinal(0)]  [RED("alive")] public CBool Alive { get; set; }
		[Ordinal(1)]  [RED("countTime")] public CFloat CountTime { get; set; }
		[Ordinal(2)]  [RED("damage")] public CHandle<gameEffectInstance> Damage { get; set; }
		[Ordinal(3)]  [RED("lifetime")] public CFloat Lifetime { get; set; }
		[Ordinal(4)]  [RED("meshComponent")] public CHandle<entIComponent> MeshComponent { get; set; }
		[Ordinal(5)]  [RED("startVelocity")] public CFloat StartVelocity { get; set; }

		public sampleBulletGeneric(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
