using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEntitySpawnerComponent : gameComponent
	{
		[Ordinal(4)] [RED("slotDataArray")] public CArray<gameEntitySpawnerSlotData> SlotDataArray { get; set; }

		public gameEntitySpawnerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
