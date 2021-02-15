using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemCraftedDataTrackingRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("targetItem")] public gameItemID TargetItem { get; set; }

		public ItemCraftedDataTrackingRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
