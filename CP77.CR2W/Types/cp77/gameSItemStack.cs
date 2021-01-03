using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameSItemStack : CVariable
	{
		[Ordinal(0)]  [RED("isAvailable")] public CBool IsAvailable { get; set; }
		[Ordinal(1)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(2)]  [RED("powerLevel")] public CInt32 PowerLevel { get; set; }
		[Ordinal(3)]  [RED("quantity")] public CInt32 Quantity { get; set; }
		[Ordinal(4)]  [RED("requirement")] public gameSItemStackRequirementData Requirement { get; set; }
		[Ordinal(5)]  [RED("vendorItemID")] public TweakDBID VendorItemID { get; set; }

		public gameSItemStack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
