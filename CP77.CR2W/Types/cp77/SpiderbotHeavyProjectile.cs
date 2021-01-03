using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SpiderbotHeavyProjectile : BaseProjectile
	{
		[Ordinal(0)]  [RED("alive")] public CBool Alive { get; set; }
		[Ordinal(1)]  [RED("damage")] public CHandle<gameEffectInstance> Damage { get; set; }
		[Ordinal(2)]  [RED("effect")] public gameEffectRef Effect { get; set; }
		[Ordinal(3)]  [RED("hit")] public CBool Hit { get; set; }
		[Ordinal(4)]  [RED("lifetime")] public CFloat Lifetime { get; set; }
		[Ordinal(5)]  [RED("meshComponent")] public CHandle<entIComponent> MeshComponent { get; set; }
		[Ordinal(6)]  [RED("startVelocity")] public CFloat StartVelocity { get; set; }

		public SpiderbotHeavyProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
