using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MessageCounterController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("messageCounter")] public inkTextWidgetReference MessageCounter { get; set; }
		[Ordinal(3)] [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(4)] [RED("CallInformationBBID")] public CUInt32 CallInformationBBID { get; set; }
		[Ordinal(5)] [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(6)] [RED("Owner")] public wCHandle<gameObject> Owner { get; set; }

		public MessageCounterController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
