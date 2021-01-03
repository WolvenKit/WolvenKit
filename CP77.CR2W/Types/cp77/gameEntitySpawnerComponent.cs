using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEntitySpawnerComponent : gameComponent
	{
		[Ordinal(0)]  [RED("slotDataArray")] public CArray<gameEntitySpawnerSlotData> SlotDataArray { get; set; }

		public gameEntitySpawnerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
