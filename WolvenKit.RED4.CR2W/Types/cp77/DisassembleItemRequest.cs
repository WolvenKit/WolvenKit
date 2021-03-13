using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisassembleItemRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(2)] [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(3)] [RED("amount")] public CInt32 Amount { get; set; }

		public DisassembleItemRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
