using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BaseBullet : BaseProjectile
	{
		[Ordinal(0)]  [RED("alive")] public CBool Alive { get; set; }
		[Ordinal(1)]  [RED("countTime")] public CFloat CountTime { get; set; }
		[Ordinal(2)]  [RED("damage")] public CHandle<gameEffectInstance> Damage { get; set; }
		[Ordinal(3)]  [RED("lifetime")] public CFloat Lifetime { get; set; }
		[Ordinal(4)]  [RED("meshComponent")] public CHandle<entIComponent> MeshComponent { get; set; }
		[Ordinal(5)]  [RED("startVelocity")] public CFloat StartVelocity { get; set; }

		public BaseBullet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
