using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendorGameItemData : IScriptable
	{
		[Ordinal(0)]  [RED("gameItemData")] public CHandle<gameItemData> GameItemData { get; set; }
		[Ordinal(1)]  [RED("itemStack")] public gameSItemStack ItemStack { get; set; }

		public VendorGameItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
