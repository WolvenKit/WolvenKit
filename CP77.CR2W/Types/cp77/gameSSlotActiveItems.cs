using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameSSlotActiveItems : CVariable
	{
		[Ordinal(0)]  [RED("leftHandItem")] public gameItemID LeftHandItem { get; set; }
		[Ordinal(1)]  [RED("rightHandItem")] public gameItemID RightHandItem { get; set; }

		public gameSSlotActiveItems(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
