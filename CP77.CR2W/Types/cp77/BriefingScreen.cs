using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BriefingScreen : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("logicControllerRef")] public inkWidgetReference LogicControllerRef { get; set; }
		[Ordinal(10)] [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(11)] [RED("bbOpenerEventID")] public CUInt32 BbOpenerEventID { get; set; }
		[Ordinal(12)] [RED("bbSizeEventID")] public CUInt32 BbSizeEventID { get; set; }
		[Ordinal(13)] [RED("bbAlignmentEventID")] public CUInt32 BbAlignmentEventID { get; set; }

		public BriefingScreen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
