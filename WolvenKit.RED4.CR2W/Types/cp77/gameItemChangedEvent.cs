using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameItemChangedEvent : redEvent
	{
		[Ordinal(0)] [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(1)] [RED("itemData")] public CHandle<gameItemData> ItemData { get; set; }
		[Ordinal(2)] [RED("difference")] public CInt32 Difference { get; set; }
		[Ordinal(3)] [RED("currentQuantity")] public CInt32 CurrentQuantity { get; set; }

		public gameItemChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
