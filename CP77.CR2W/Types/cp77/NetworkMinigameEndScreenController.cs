using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameEndScreenController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("outcomeText")] public inkTextWidgetReference OutcomeText { get; set; }
		[Ordinal(2)] [RED("finishBarContainer")] public wCHandle<NetworkMinigameProgramController> FinishBarContainer { get; set; }
		[Ordinal(3)] [RED("programsListContainer")] public inkWidgetReference ProgramsListContainer { get; set; }
		[Ordinal(4)] [RED("programLibraryName")] public CName ProgramLibraryName { get; set; }
		[Ordinal(5)] [RED("slotList")] public CArray<wCHandle<NetworkMinigameProgramController>> SlotList { get; set; }
		[Ordinal(6)] [RED("endData")] public EndScreenData EndData { get; set; }
		[Ordinal(7)] [RED("closeButton")] public inkWidgetReference CloseButton { get; set; }
		[Ordinal(8)] [RED("header_bg")] public inkWidgetReference Header_bg { get; set; }
		[Ordinal(9)] [RED("completionColor")] public CColor CompletionColor { get; set; }
		[Ordinal(10)] [RED("failureColor")] public CColor FailureColor { get; set; }

		public NetworkMinigameEndScreenController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
