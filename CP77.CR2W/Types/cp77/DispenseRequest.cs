using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DispenseRequest : MarketSystemRequest
	{
		[Ordinal(2)]  [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(3)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(4)]  [RED("shouldPay")] public CBool ShouldPay { get; set; }

		public DispenseRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
