using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CraftItemRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(1)]  [RED("itemRecord")] public CHandle<gamedataItem_Record> ItemRecord { get; set; }
		[Ordinal(2)]  [RED("amount")] public CInt32 Amount { get; set; }

		public CraftItemRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
