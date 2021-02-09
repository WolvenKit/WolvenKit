using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BaseItemAction : BaseScriptableAction
	{
		[Ordinal(8)]  [RED("itemData")] public wCHandle<gameItemData> ItemData { get; set; }
		[Ordinal(9)]  [RED("removeAfterUse")] public CBool RemoveAfterUse { get; set; }
		[Ordinal(10)]  [RED("quantity")] public CInt32 Quantity { get; set; }

		public BaseItemAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
