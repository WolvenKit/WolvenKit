using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CheckRemovedItemWithSlotActiveItem : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("itemID")] public gameItemID ItemID { get; set; }

		public CheckRemovedItemWithSlotActiveItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
