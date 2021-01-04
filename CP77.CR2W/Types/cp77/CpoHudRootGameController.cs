using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CpoHudRootGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("chatBox")] public CHandle<inkWidget> ChatBox { get; set; }
		[Ordinal(1)]  [RED("hitIndicator")] public CHandle<inkWidget> HitIndicator { get; set; }
		[Ordinal(2)]  [RED("inventory")] public CHandle<inkWidget> Inventory { get; set; }
		[Ordinal(3)]  [RED("loadouts")] public CHandle<inkWidget> Loadouts { get; set; }
		[Ordinal(4)]  [RED("narration_journal")] public CHandle<inkWidget> Narration_journal { get; set; }
		[Ordinal(5)]  [RED("narrative_plate")] public CHandle<inkWidget> Narrative_plate { get; set; }
		[Ordinal(6)]  [RED("playerList")] public CHandle<inkWidget> PlayerList { get; set; }

		public CpoHudRootGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
