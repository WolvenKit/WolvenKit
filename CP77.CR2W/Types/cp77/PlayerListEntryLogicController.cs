using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerListEntryLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("playerNameLabel")] public inkWidgetReference PlayerNameLabel { get; set; }
		[Ordinal(2)] [RED("playerClassIcon")] public inkImageWidgetReference PlayerClassIcon { get; set; }

		public PlayerListEntryLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
