using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSpawnComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("projectileTemplates")] public CArray<CName> ProjectileTemplates { get; set; }
		[Ordinal(1)]  [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(2)]  [RED("spawnOffset")] public Vector3 SpawnOffset { get; set; }

		public gameprojectileSpawnComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
