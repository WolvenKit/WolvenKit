using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameProgramController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("text")] public inkTextWidgetReference Text { get; set; }
		[Ordinal(2)] [RED("commandElementSlotsContainer")] public CArray<inkWidgetReference> CommandElementSlotsContainer { get; set; }
		[Ordinal(3)] [RED("elementLibraryName")] public CName ElementLibraryName { get; set; }
		[Ordinal(4)] [RED("completedMarker")] public inkWidgetReference CompletedMarker { get; set; }
		[Ordinal(5)] [RED("imageRef")] public inkImageWidgetReference ImageRef { get; set; }
		[Ordinal(6)] [RED("slotList")] public CArray<CArray<wCHandle<NetworkMinigameElementController>>> SlotList { get; set; }
		[Ordinal(7)] [RED("data")] public ProgramData Data { get; set; }
		[Ordinal(8)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }

		public NetworkMinigameProgramController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
