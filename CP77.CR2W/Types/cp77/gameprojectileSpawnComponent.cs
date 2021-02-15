using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSpawnComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("spawnOffset")] public Vector3 SpawnOffset { get; set; }
		[Ordinal(6)] [RED("projectileTemplates")] public CArray<CName> ProjectileTemplates { get; set; }
		[Ordinal(7)] [RED("slotName")] public CName SlotName { get; set; }

		public gameprojectileSpawnComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
