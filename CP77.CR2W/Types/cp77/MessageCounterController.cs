using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MessageCounterController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("Blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(1)]  [RED("BlackboardDef")] public CHandle<UI_ComDeviceDef> BlackboardDef { get; set; }
		[Ordinal(2)]  [RED("CallInformationBBID")] public CUInt32 CallInformationBBID { get; set; }
		[Ordinal(3)]  [RED("Owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(4)]  [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(5)]  [RED("messageCounter")] public inkTextWidgetReference MessageCounter { get; set; }
		[Ordinal(6)]  [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }

		public MessageCounterController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
