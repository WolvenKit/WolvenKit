using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScannerNPCBodyGameController : BaseChunkGameController
	{
		[Ordinal(0)]  [RED("dataBaseWidgetHolder")] public inkWidgetReference DataBaseWidgetHolder { get; set; }
		[Ordinal(1)]  [RED("factionCallbackID")] public CUInt32 FactionCallbackID { get; set; }
		[Ordinal(2)]  [RED("factionText")] public inkTextWidgetReference FactionText { get; set; }
		[Ordinal(3)]  [RED("isValidFaction")] public CBool IsValidFaction { get; set; }
		[Ordinal(4)]  [RED("rarityCallbackID")] public CUInt32 RarityCallbackID { get; set; }

		public ScannerNPCBodyGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
