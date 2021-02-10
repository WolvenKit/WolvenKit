using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StatProvider : IScriptable
	{
		[Ordinal(0)]  [RED("GameItemData")] public wCHandle<gameItemData> GameItemData { get; set; }
		[Ordinal(1)]  [RED("PartData")] public gameInnerItemData PartData { get; set; }
		[Ordinal(2)]  [RED("InventoryItemData")] public InventoryItemData InventoryItemData { get; set; }
		[Ordinal(3)]  [RED("dataSource")] public CEnum<gameEStatProviderDataSource> DataSource { get; set; }

		public StatProvider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
