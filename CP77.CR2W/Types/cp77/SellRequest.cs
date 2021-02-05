using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SellRequest : TransactionRequest
	{
		[Ordinal(0)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(1)]  [RED("vendorID")] public TweakDBID VendorID { get; set; }
		[Ordinal(2)]  [RED("items")] public CArray<TransactionRequestData> Items { get; set; }

		public SellRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
