using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BriefingScreen : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("bbAlignmentEventID")] public CUInt32 BbAlignmentEventID { get; set; }
		[Ordinal(1)]  [RED("bbOpenerEventID")] public CUInt32 BbOpenerEventID { get; set; }
		[Ordinal(2)]  [RED("bbSizeEventID")] public CUInt32 BbSizeEventID { get; set; }
		[Ordinal(3)]  [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(4)]  [RED("logicControllerRef")] public inkWidgetReference LogicControllerRef { get; set; }

		public BriefingScreen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
