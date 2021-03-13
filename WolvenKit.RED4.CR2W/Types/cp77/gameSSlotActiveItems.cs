using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSSlotActiveItems : CVariable
	{
		[Ordinal(0)] [RED("rightHandItem")] public gameItemID RightHandItem { get; set; }
		[Ordinal(1)] [RED("leftHandItem")] public gameItemID LeftHandItem { get; set; }

		public gameSSlotActiveItems(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
