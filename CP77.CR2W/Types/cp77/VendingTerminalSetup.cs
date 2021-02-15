using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendingTerminalSetup : CVariable
	{
		[Ordinal(0)] [RED("vendorTweakID")] public TweakDBID VendorTweakID { get; set; }
		[Ordinal(1)] [RED("vendingBlacklist")] public CArray<CEnum<EVendorMode>> VendingBlacklist { get; set; }
		[Ordinal(2)] [RED("timeToCompletePurchase")] public CFloat TimeToCompletePurchase { get; set; }

		public VendingTerminalSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
