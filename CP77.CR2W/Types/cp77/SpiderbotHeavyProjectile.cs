using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SpiderbotHeavyProjectile : BaseProjectile
	{
		[Ordinal(41)]  [RED("meshComponent")] public CHandle<entIComponent> MeshComponent { get; set; }
		[Ordinal(42)]  [RED("effect")] public gameEffectRef Effect { get; set; }
		[Ordinal(43)]  [RED("startVelocity")] public CFloat StartVelocity { get; set; }
		[Ordinal(44)]  [RED("lifetime")] public CFloat Lifetime { get; set; }
		[Ordinal(45)]  [RED("alive")] public CBool Alive { get; set; }
		[Ordinal(46)]  [RED("hit")] public CBool Hit { get; set; }

		public SpiderbotHeavyProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
