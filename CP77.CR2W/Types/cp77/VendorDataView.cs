using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendorDataView : BackpackDataView
	{
		[Ordinal(0)]  [RED("itemSortMode")] public CEnum<ItemSortMode> ItemSortMode { get; set; }
		[Ordinal(1)]  [RED("attachmentsList")] public CArray<CEnum<gamedataItemType>> AttachmentsList { get; set; }
		[Ordinal(2)]  [RED("uiScriptableSystem")] public wCHandle<UIScriptableSystem> UiScriptableSystem { get; set; }
		[Ordinal(3)]  [RED("itemFilterType")] public CEnum<ItemFilterCategory> ItemFilterType { get; set; }
		[Ordinal(4)]  [RED("isVendorGrid")] public CBool IsVendorGrid { get; set; }
		[Ordinal(5)]  [RED("openTime")] public GameTime OpenTime { get; set; }

		public VendorDataView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
