using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEntitySpawnerSlotData : CVariable
	{
		[Ordinal(0)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(1)] [RED("spawnableObject")] public TweakDBID SpawnableObject { get; set; }

		public gameEntitySpawnerSlotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
