using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AddItemToVendorRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("vendorID")] public TweakDBID VendorID { get; set; }
		[Ordinal(1)] [RED("itemToAddID")] public TweakDBID ItemToAddID { get; set; }
		[Ordinal(2)] [RED("quantity")] public CInt32 Quantity { get; set; }

		public AddItemToVendorRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
