using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSItemStack : CVariable
	{
		[Ordinal(0)] [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(1)] [RED("quantity")] public CInt32 Quantity { get; set; }
		[Ordinal(2)] [RED("powerLevel")] public CInt32 PowerLevel { get; set; }
		[Ordinal(3)] [RED("vendorItemID")] public TweakDBID VendorItemID { get; set; }
		[Ordinal(4)] [RED("isAvailable")] public CBool IsAvailable { get; set; }
		[Ordinal(5)] [RED("requirement")] public gameSItemStackRequirementData Requirement { get; set; }

		public gameSItemStack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
