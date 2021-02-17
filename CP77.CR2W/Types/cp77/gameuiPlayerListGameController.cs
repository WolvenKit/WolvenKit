using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPlayerListGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("playerEntries")] public CArray<PlayerListEntryData> PlayerEntries { get; set; }
		[Ordinal(10)] [RED("container")] public inkCompoundWidgetReference Container { get; set; }

		public gameuiPlayerListGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
