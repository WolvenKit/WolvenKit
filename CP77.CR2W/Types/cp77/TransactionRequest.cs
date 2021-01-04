using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TransactionRequest : MarketSystemRequest
	{
		[Ordinal(0)]  [RED("items")] public CArray<TransactionRequestData> Items { get; set; }

		public TransactionRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
