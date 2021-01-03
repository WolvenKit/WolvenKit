using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CraftItemRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("amount")] public CInt32 Amount { get; set; }
		[Ordinal(1)]  [RED("itemRecord")] public CHandle<gamedataItem_Record> ItemRecord { get; set; }
		[Ordinal(2)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }

		public CraftItemRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
