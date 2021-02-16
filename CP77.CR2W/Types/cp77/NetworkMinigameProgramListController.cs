using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameProgramListController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("programPlayerContainer")] public inkWidgetReference ProgramPlayerContainer { get; set; }
		[Ordinal(2)] [RED("programNetworkContainer")] public inkWidgetReference ProgramNetworkContainer { get; set; }
		[Ordinal(3)] [RED("programLibraryName")] public CName ProgramLibraryName { get; set; }
		[Ordinal(4)] [RED("slotList")] public CArray<wCHandle<NetworkMinigameProgramController>> SlotList { get; set; }
		[Ordinal(5)] [RED("animProxy_02")] public CHandle<inkanimProxy> AnimProxy_02 { get; set; }
		[Ordinal(6)] [RED("headerBG")] public inkWidgetReference HeaderBG { get; set; }

		public NetworkMinigameProgramListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
