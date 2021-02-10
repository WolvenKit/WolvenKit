using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameGridCellController : inkButtonController
	{
		[Ordinal(0)]  [RED("cellData")] public CellData CellData { get; set; }
		[Ordinal(1)]  [RED("grid")] public wCHandle<NetworkMinigameGridController> Grid { get; set; }
		[Ordinal(2)]  [RED("slotsContainer")] public inkWidgetReference SlotsContainer { get; set; }
		[Ordinal(3)]  [RED("slotsContent")] public wCHandle<NetworkMinigameElementController> SlotsContent { get; set; }
		[Ordinal(4)]  [RED("elementLibraryName")] public CName ElementLibraryName { get; set; }
		[Ordinal(5)]  [RED("defaultColor")] public HDRColor DefaultColor { get; set; }

		public NetworkMinigameGridCellController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
