using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TransactionRequest : MarketSystemRequest
	{
		[Ordinal(2)] [RED("items")] public CArray<TransactionRequestData> Items { get; set; }

		public TransactionRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
