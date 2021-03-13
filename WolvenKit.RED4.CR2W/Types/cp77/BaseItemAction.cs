using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseItemAction : BaseScriptableAction
	{
		[Ordinal(11)] [RED("itemData")] public wCHandle<gameItemData> ItemData { get; set; }
		[Ordinal(12)] [RED("removeAfterUse")] public CBool RemoveAfterUse { get; set; }
		[Ordinal(13)] [RED("quantity")] public CInt32 Quantity { get; set; }

		public BaseItemAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
