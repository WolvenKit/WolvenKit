using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SpiderbotHeavyProjectile : BaseProjectile
	{
		[Ordinal(51)] [RED("meshComponent")] public CHandle<entIComponent> MeshComponent { get; set; }
		[Ordinal(52)] [RED("effect")] public gameEffectRef Effect { get; set; }
		[Ordinal(53)] [RED("startVelocity")] public CFloat StartVelocity { get; set; }
		[Ordinal(54)] [RED("lifetime")] public CFloat Lifetime_492 { get; set; }
		[Ordinal(55)] [RED("alive")] public CBool Alive { get; set; }
		[Ordinal(56)] [RED("hit")] public CBool Hit { get; set; }

		public SpiderbotHeavyProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
