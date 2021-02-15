using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameBufferController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("bufferSlotsContainer")] public inkWidgetReference BufferSlotsContainer { get; set; }
		[Ordinal(2)] [RED("elementLibraryName")] public CName ElementLibraryName { get; set; }
		[Ordinal(3)] [RED("slotList")] public CArray<wCHandle<NetworkMinigameElementController>> SlotList { get; set; }
		[Ordinal(4)] [RED("blinker")] public inkWidgetReference Blinker { get; set; }
		[Ordinal(5)] [RED("count")] public CInt32 Count { get; set; }
		[Ordinal(6)] [RED("AnimProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(7)] [RED("AnimOptions")] public inkanimPlaybackOptions AnimOptions { get; set; }
		[Ordinal(8)] [RED("alpha_fadein")] public CHandle<inkanimDefinition> Alpha_fadein { get; set; }
		[Ordinal(9)] [RED("currentAlpha")] public CFloat CurrentAlpha { get; set; }
		[Ordinal(10)] [RED("nextAlpha")] public CFloat NextAlpha { get; set; }

		public NetworkMinigameBufferController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
