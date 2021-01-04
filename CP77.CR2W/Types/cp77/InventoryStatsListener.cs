using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryStatsListener : gameScriptStatsListener
	{
		[Ordinal(0)]  [RED("controller")] public wCHandle<InventoryStatsController> Controller { get; set; }
		[Ordinal(1)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }

		public InventoryStatsListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
