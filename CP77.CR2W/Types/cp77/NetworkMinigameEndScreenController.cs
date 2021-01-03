using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameEndScreenController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("closeButton")] public inkWidgetReference CloseButton { get; set; }
		[Ordinal(1)]  [RED("completionColor")] public CColor CompletionColor { get; set; }
		[Ordinal(2)]  [RED("endData")] public EndScreenData EndData { get; set; }
		[Ordinal(3)]  [RED("failureColor")] public CColor FailureColor { get; set; }
		[Ordinal(4)]  [RED("finishBarContainer")] public wCHandle<NetworkMinigameProgramController> FinishBarContainer { get; set; }
		[Ordinal(5)]  [RED("header_bg")] public inkWidgetReference Header_bg { get; set; }
		[Ordinal(6)]  [RED("outcomeText")] public inkTextWidgetReference OutcomeText { get; set; }
		[Ordinal(7)]  [RED("programLibraryName")] public CName ProgramLibraryName { get; set; }
		[Ordinal(8)]  [RED("programsListContainer")] public inkWidgetReference ProgramsListContainer { get; set; }
		[Ordinal(9)]  [RED("slotList")] public CArray<wCHandle<NetworkMinigameProgramController>> SlotList { get; set; }

		public NetworkMinigameEndScreenController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
