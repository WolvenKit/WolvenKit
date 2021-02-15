using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameGridCellController : inkButtonController
	{
		[Ordinal(10)] [RED("cellData")] public CellData CellData { get; set; }
		[Ordinal(11)] [RED("grid")] public wCHandle<NetworkMinigameGridController> Grid { get; set; }
		[Ordinal(12)] [RED("slotsContainer")] public inkWidgetReference SlotsContainer { get; set; }
		[Ordinal(13)] [RED("slotsContent")] public wCHandle<NetworkMinigameElementController> SlotsContent { get; set; }
		[Ordinal(14)] [RED("elementLibraryName")] public CName ElementLibraryName { get; set; }
		[Ordinal(15)] [RED("defaultColor")] public HDRColor DefaultColor { get; set; }

		public NetworkMinigameGridCellController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
