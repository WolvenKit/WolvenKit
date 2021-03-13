using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInventorySlotInfo : CVariable
	{
		[Ordinal(0)] [RED("itemCategory")] public TweakDBID ItemCategory { get; set; }
		[Ordinal(1)] [RED("itemId")] public gameItemID ItemId { get; set; }
		[Ordinal(2)] [RED("quantity")] public CUInt32 Quantity { get; set; }

		public gameMuppetInventorySlotInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
